namespace MultiClick
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.click_count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.click_delay = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.send_both = new System.Windows.Forms.RadioButton();
            this.send_down = new System.Windows.Forms.RadioButton();
            this.send_up = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trigger_down = new System.Windows.Forms.RadioButton();
            this.trigger_up = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.click_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.click_delay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // click_count
            // 
            this.click_count.Location = new System.Drawing.Point(87, 3);
            this.click_count.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.click_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.click_count.Name = "click_count";
            this.click_count.Size = new System.Drawing.Size(120, 22);
            this.click_count.TabIndex = 0;
            this.click_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.click_count.ValueChanged += new System.EventHandler(this.Count_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delay";
            // 
            // click_delay
            // 
            this.click_delay.Location = new System.Drawing.Point(87, 31);
            this.click_delay.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.click_delay.Name = "click_delay";
            this.click_delay.Size = new System.Drawing.Size(120, 22);
            this.click_delay.TabIndex = 3;
            this.click_delay.ValueChanged += new System.EventHandler(this.Delay_Changed);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.send_both, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.send_down, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.send_up, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 83);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // send_both
            // 
            this.send_both.AutoSize = true;
            this.send_both.Checked = true;
            this.send_both.Location = new System.Drawing.Point(3, 57);
            this.send_both.Name = "send_both";
            this.send_both.Size = new System.Drawing.Size(115, 21);
            this.send_both.TabIndex = 5;
            this.send_both.TabStop = true;
            this.send_both.Text = "Both (default)";
            this.send_both.UseVisualStyleBackColor = true;
            this.send_both.CheckedChanged += new System.EventHandler(this.Send_Changed);
            // 
            // send_down
            // 
            this.send_down.AutoSize = true;
            this.send_down.Location = new System.Drawing.Point(3, 3);
            this.send_down.Name = "send_down";
            this.send_down.Size = new System.Drawing.Size(110, 21);
            this.send_down.TabIndex = 0;
            this.send_down.TabStop = true;
            this.send_down.Text = "Mouse Down";
            this.send_down.UseVisualStyleBackColor = true;
            this.send_down.CheckedChanged += new System.EventHandler(this.Send_Changed);
            // 
            // send_up
            // 
            this.send_up.AutoSize = true;
            this.send_up.Location = new System.Drawing.Point(3, 30);
            this.send_up.Name = "send_up";
            this.send_up.Size = new System.Drawing.Size(93, 21);
            this.send_up.TabIndex = 1;
            this.send_up.TabStop = true;
            this.send_up.Text = "Mouse Up";
            this.send_up.UseVisualStyleBackColor = true;
            this.send_up.CheckedChanged += new System.EventHandler(this.Send_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Send";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.click_count);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.click_delay);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 120);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ms";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 120);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(512, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 120);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trigger on";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.trigger_down, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.trigger_up, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 58);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // trigger_down
            // 
            this.trigger_down.AutoSize = true;
            this.trigger_down.Location = new System.Drawing.Point(3, 3);
            this.trigger_down.Name = "trigger_down";
            this.trigger_down.Size = new System.Drawing.Size(110, 21);
            this.trigger_down.TabIndex = 0;
            this.trigger_down.TabStop = true;
            this.trigger_down.Text = "Mouse Down";
            this.trigger_down.UseVisualStyleBackColor = true;
            this.trigger_down.CheckedChanged += new System.EventHandler(this.Trigger_Changed);
            // 
            // trigger_up
            // 
            this.trigger_up.AutoSize = true;
            this.trigger_up.Checked = true;
            this.trigger_up.Location = new System.Drawing.Point(3, 30);
            this.trigger_up.Name = "trigger_up";
            this.trigger_up.Size = new System.Drawing.Size(150, 21);
            this.trigger_up.TabIndex = 1;
            this.trigger_up.TabStop = true;
            this.trigger_up.Text = "Mouse Up (default)";
            this.trigger_up.UseVisualStyleBackColor = true;
            this.trigger_up.CheckedChanged += new System.EventHandler(this.Trigger_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Press I to turn on, O to turn off";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(488, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "MIT License Copyright (c) 2019 Ondřej Lukeš";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 152);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "MultiClick";
            ((System.ComponentModel.ISupportInitialize)(this.click_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.click_delay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown click_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown click_delay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton send_both;
        private System.Windows.Forms.RadioButton send_down;
        private System.Windows.Forms.RadioButton send_up;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton trigger_down;
        private System.Windows.Forms.RadioButton trigger_up;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

