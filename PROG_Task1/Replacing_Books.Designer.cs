﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replacing_Books));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
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
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.start_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.reset_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 627);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 56);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Timer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 170);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.Color.OrangeRed;
            this.textbox1.Location = new System.Drawing.Point(0, 348);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(46, 133);
            this.textbox1.TabIndex = 9;
            this.textbox1.Text = "Book1";
            this.textbox1.UseVisualStyleBackColor = false;
            // 
            // textbox2
            // 
            this.textbox2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textbox2.Location = new System.Drawing.Point(0, 488);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(46, 133);
            this.textbox2.TabIndex = 10;
            this.textbox2.Text = "Book 2";
            this.textbox2.UseVisualStyleBackColor = false;
            // 
            // textbox3
            // 
            this.textbox3.BackColor = System.Drawing.Color.Plum;
            this.textbox3.Location = new System.Drawing.Point(52, 348);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(46, 133);
            this.textbox3.TabIndex = 11;
            this.textbox3.Text = "Book 3";
            this.textbox3.UseVisualStyleBackColor = false;
            // 
            // textbox4
            // 
            this.textbox4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.textbox4.Location = new System.Drawing.Point(52, 488);
            this.textbox4.Name = "textbox4";
            this.textbox4.Size = new System.Drawing.Size(46, 133);
            this.textbox4.TabIndex = 12;
            this.textbox4.Text = "Book 4";
            this.textbox4.UseVisualStyleBackColor = false;
            // 
            // textbox5
            // 
            this.textbox5.BackColor = System.Drawing.Color.SteelBlue;
            this.textbox5.Location = new System.Drawing.Point(112, 348);
            this.textbox5.Name = "textbox5";
            this.textbox5.Size = new System.Drawing.Size(46, 133);
            this.textbox5.TabIndex = 13;
            this.textbox5.Text = "Book 5";
            this.textbox5.UseVisualStyleBackColor = false;
            // 
            // textbox6
            // 
            this.textbox6.BackColor = System.Drawing.Color.HotPink;
            this.textbox6.Location = new System.Drawing.Point(112, 488);
            this.textbox6.Name = "textbox6";
            this.textbox6.Size = new System.Drawing.Size(46, 133);
            this.textbox6.TabIndex = 14;
            this.textbox6.Text = "Book 6";
            this.textbox6.UseVisualStyleBackColor = false;
            // 
            // textbox7
            // 
            this.textbox7.BackColor = System.Drawing.Color.Salmon;
            this.textbox7.Location = new System.Drawing.Point(174, 348);
            this.textbox7.Name = "textbox7";
            this.textbox7.Size = new System.Drawing.Size(46, 133);
            this.textbox7.TabIndex = 15;
            this.textbox7.Text = "Book 7";
            this.textbox7.UseVisualStyleBackColor = false;
            // 
            // textbox8
            // 
            this.textbox8.BackColor = System.Drawing.Color.Gold;
            this.textbox8.Location = new System.Drawing.Point(174, 488);
            this.textbox8.Name = "textbox8";
            this.textbox8.Size = new System.Drawing.Size(46, 133);
            this.textbox8.TabIndex = 16;
            this.textbox8.Text = "Book 8";
            this.textbox8.UseVisualStyleBackColor = false;
            // 
            // textbox9
            // 
            this.textbox9.BackColor = System.Drawing.Color.Chartreuse;
            this.textbox9.Location = new System.Drawing.Point(236, 348);
            this.textbox9.Name = "textbox9";
            this.textbox9.Size = new System.Drawing.Size(46, 133);
            this.textbox9.TabIndex = 17;
            this.textbox9.Text = "Book 9";
            this.textbox9.UseVisualStyleBackColor = false;
            // 
            // textbox10
            // 
            this.textbox10.BackColor = System.Drawing.Color.LightBlue;
            this.textbox10.Location = new System.Drawing.Point(236, 488);
            this.textbox10.Name = "textbox10";
            this.textbox10.Size = new System.Drawing.Size(46, 133);
            this.textbox10.TabIndex = 18;
            this.textbox10.Text = "Book 10";
            this.textbox10.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Unsorted Books";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sorted Books";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(24, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 46);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox11.Location = new System.Drawing.Point(0, 246);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(665, 14);
            this.textBox11.TabIndex = 22;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox12.Location = new System.Drawing.Point(0, 71);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(665, 14);
            this.textBox12.TabIndex = 23;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox13.Location = new System.Drawing.Point(0, 478);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(282, 14);
            this.textBox13.TabIndex = 24;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox14.Location = new System.Drawing.Point(662, 71);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(10, 189);
            this.textBox14.TabIndex = 25;
            // 
            // Replacing_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(980, 683);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.panel1);
            this.Name = "Replacing_Books";
            this.Text = "Replacing_Books";
            this.Load += new System.EventHandler(this.Replacing_Books_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
    }
}