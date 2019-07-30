using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace MultiClick
{
    
    public partial class Form1 : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WH_MOUSE_LL = 14;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_LBUTTONUP = 0x0202;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private LowLevelProc _proc;
        private IntPtr _keyHookID = IntPtr.Zero;
        private IntPtr _mouseHookID = IntPtr.Zero;
        private bool active = false;
        private int notUserClicks = 0;
        private int clicks = 0;
        private Point pos;
        private Thread th;

        private int trigger = WM_LBUTTONUP;
        private uint send = MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP;
        private int count = 2;
        private int delay = 0;

        public Form1()
        {
            InitializeComponent();
            HooksInit();
            FormClosing += new FormClosingEventHandler(OnFormClosing);
            th = new Thread(new ThreadStart(BackgroundWorker));
            th.Start();
        }

        private void BackgroundWorker()
        {
            while (true)
            {
                if (clicks == 0) { continue ; }
                Console.WriteLine("Clicks in queue " + clicks);
                clicks--;
                if (notUserClicks != 0) { notUserClicks--; Console.WriteLine("Not User Click nuc = "+notUserClicks); continue; }
                if (!active) { Console.WriteLine("Not Active"); continue; }
                //active = false;
                for (int i = 0; i < count-1; i++)
                {
                    notUserClicks++;
                    DoClick(pos);
                    Console.WriteLine("Clicked!");
                    Thread.Sleep(delay);
                }
                //Thread.Sleep(10);
            }
        }
        private void OnClick(Point _pos)
        {
            clicks++;
            pos = _pos;
            Console.WriteLine("Pos = [" + pos.X + ":" + pos.Y);
            
        }
        private void OnKeyDown(Keys k)
        {
            if(k == Keys.I) {
                active = true;
            } else if(k == Keys.O)
            {
                active = false;
            }
        }
        public void DoClick(Point pos)
        {
            uint X = (uint)pos.X;
            uint Y = (uint)pos.Y;
            mouse_event(send, X, Y, 0, 0);
        }
        private void OnFormClosing(object sender,FormClosingEventArgs e)
        {
            RemoveHooks();
            th.Abort();
        }
        public void HooksInit()
        {
            _proc = HookCallback;
            _keyHookID = SetKeyHook(_proc);
            _mouseHookID = SetMouseHook(_proc);
        }

        public void RemoveHooks()
        {
            UnhookWindowsHookEx(_keyHookID);
            UnhookWindowsHookEx(_mouseHookID);
        }

        private IntPtr SetKeyHook(LowLevelProc proc)
        {
            
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        private IntPtr SetMouseHook(LowLevelProc proc)
        {

            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                OnKeyDown((Keys)vkCode);
                return CallNextHookEx(_keyHookID, nCode, wParam, lParam);
            } else if(nCode >= 0 && wParam == (IntPtr)trigger)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                OnClick(new Point(hookStruct.pt.x, hookStruct.pt.y));
                return CallNextHookEx(_mouseHookID, nCode, wParam, lParam);
            }
            return IntPtr.Zero;
            
        }

        [StructLayout(LayoutKind.Sequential)]

        private struct POINT

        {

            public int x;

            public int y;

        }

        [StructLayout(LayoutKind.Sequential)]

        private struct MSLLHOOKSTRUCT

        {

            public POINT pt;

            public uint mouseData;

            public uint flags;

            public uint time;

            public IntPtr dwExtraInfo;

        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private void Send_Changed(object sender,EventArgs e)
        {
            if (send_up.Checked)
            {
                send = MOUSEEVENTF_LEFTUP;
            } else if (send_down.Checked)
            {
                send = MOUSEEVENTF_LEFTDOWN;
            } else
            {
                send = MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP;
            }
        }
        private void Trigger_Changed(object sender, EventArgs e)
        {
            if (trigger_up.Checked)
            {
                trigger = WM_LBUTTONUP;
            } else
            {
                trigger = WM_LBUTTONDOWN;
            }
        }
        private void Count_Changed(object sender,EventArgs e)
        {
            count = Decimal.ToInt32(click_count.Value);
        }
        private void Delay_Changed(object sender,EventArgs e)
        {
            delay = Decimal.ToInt32(click_delay.Value);
        }
    }
}
