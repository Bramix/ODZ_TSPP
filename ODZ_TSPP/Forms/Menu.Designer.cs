namespace ODZ_TSPP.Forms
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(35, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add a user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.create_user);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(35, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Word manager";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClickWordButton);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(35, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Excel manager";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClickExcelButton);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(35, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search by criteria";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.FilterByFields);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(35, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Configuration";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ClickCongigure);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 31);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(35, 212);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ClickCancel);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 270);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 270);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 13);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(3, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(226, 13);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 13);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel7.Location = new System.Drawing.Point(5, 257);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 13);
            this.panel7.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 270);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(231, 270);
            this.MinimumSize = new System.Drawing.Size(231, 270);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}