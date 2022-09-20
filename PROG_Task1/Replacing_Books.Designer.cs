
namespace PROG_Task1
{
    partial class Replacing_Books
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textbox1 = new System.Windows.Forms.Button();
            this.textbox2 = new System.Windows.Forms.Button();
            this.textbox3 = new System.Windows.Forms.Button();
            this.textbox4 = new System.Windows.Forms.Button();
            this.textbox5 = new System.Windows.Forms.Button();
            this.textbox6 = new System.Windows.Forms.Button();
            this.textbox7 = new System.Windows.Forms.Button();
            this.textbox8 = new System.Windows.Forms.Button();
            this.textbox9 = new System.Windows.Forms.Button();
            this.textbox10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00:00.00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(3, 31);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(96, 31);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 4;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.start_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.reset_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 82);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Timer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(890, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 565);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 170);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(10, 398);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(46, 133);
            this.textbox1.TabIndex = 9;
            this.textbox1.Text = "Book1";
            this.textbox1.UseVisualStyleBackColor = true;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(66, 398);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(46, 133);
            this.textbox2.TabIndex = 10;
            this.textbox2.Text = "Book 2";
            this.textbox2.UseVisualStyleBackColor = true;
            // 
            // textbox3
            // 
            this.textbox3.Location = new System.Drawing.Point(124, 398);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(46, 133);
            this.textbox3.TabIndex = 11;
            this.textbox3.Text = "Book 3";
            this.textbox3.UseVisualStyleBackColor = true;
            // 
            // textbox4
            // 
            this.textbox4.Location = new System.Drawing.Point(175, 398);
            this.textbox4.Name = "textbox4";
            this.textbox4.Size = new System.Drawing.Size(46, 133);
            this.textbox4.TabIndex = 12;
            this.textbox4.Text = "Book 4";
            this.textbox4.UseVisualStyleBackColor = true;
            // 
            // textbox5
            // 
            this.textbox5.Location = new System.Drawing.Point(224, 398);
            this.textbox5.Name = "textbox5";
            this.textbox5.Size = new System.Drawing.Size(46, 133);
            this.textbox5.TabIndex = 13;
            this.textbox5.Text = "Book 5";
            this.textbox5.UseVisualStyleBackColor = true;
            // 
            // textbox6
            // 
            this.textbox6.Location = new System.Drawing.Point(276, 398);
            this.textbox6.Name = "textbox6";
            this.textbox6.Size = new System.Drawing.Size(46, 133);
            this.textbox6.TabIndex = 14;
            this.textbox6.Text = "Book 6";
            this.textbox6.UseVisualStyleBackColor = true;
            // 
            // textbox7
            // 
            this.textbox7.Location = new System.Drawing.Point(328, 398);
            this.textbox7.Name = "textbox7";
            this.textbox7.Size = new System.Drawing.Size(46, 133);
            this.textbox7.TabIndex = 15;
            this.textbox7.Text = "Book 7";
            this.textbox7.UseVisualStyleBackColor = true;
            // 
            // textbox8
            // 
            this.textbox8.Location = new System.Drawing.Point(381, 398);
            this.textbox8.Name = "textbox8";
            this.textbox8.Size = new System.Drawing.Size(46, 133);
            this.textbox8.TabIndex = 16;
            this.textbox8.Text = "Book 8";
            this.textbox8.UseVisualStyleBackColor = true;
            // 
            // textbox9
            // 
            this.textbox9.Location = new System.Drawing.Point(434, 398);
            this.textbox9.Name = "textbox9";
            this.textbox9.Size = new System.Drawing.Size(46, 133);
            this.textbox9.TabIndex = 17;
            this.textbox9.Text = "Book 9";
            this.textbox9.UseVisualStyleBackColor = true;
            // 
            // textbox10
            // 
            this.textbox10.Location = new System.Drawing.Point(486, 398);
            this.textbox10.Name = "textbox10";
            this.textbox10.Size = new System.Drawing.Size(46, 133);
            this.textbox10.TabIndex = 18;
            this.textbox10.Text = "Book 10";
            this.textbox10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Unsorted Books";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sorted Books";
            // 
            // Replacing_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(980, 647);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox10);
            this.Controls.Add(this.textbox9);
            this.Controls.Add(this.textbox8);
            this.Controls.Add(this.textbox7);
            this.Controls.Add(this.textbox6);
            this.Controls.Add(this.textbox5);
            this.Controls.Add(this.textbox4);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Replacing_Books";
            this.Text = "Replacing_Books";
            this.Load += new System.EventHandler(this.Replacing_Books_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button textbox1;
        private System.Windows.Forms.Button textbox2;
        private System.Windows.Forms.Button textbox3;
        private System.Windows.Forms.Button textbox4;
        private System.Windows.Forms.Button textbox5;
        private System.Windows.Forms.Button textbox6;
        private System.Windows.Forms.Button textbox7;
        private System.Windows.Forms.Button textbox8;
        private System.Windows.Forms.Button textbox9;
        private System.Windows.Forms.Button textbox10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}