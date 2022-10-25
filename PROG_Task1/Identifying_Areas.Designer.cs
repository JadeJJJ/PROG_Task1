
namespace PROG_Task1
{
    partial class Identifying_Areas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Identifying_Areas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuBTN = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.third = new System.Windows.Forms.Label();
            this.fourth = new System.Windows.Forms.Label();
            this.CHECK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.descripBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.menuBTN);
            this.panel1.Controls.Add(this.resetBTN);
            this.panel1.Controls.Add(this.startBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 762);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1861, 75);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1210, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "00:00:00.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1148, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Timer:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1093, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 57);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // menuBTN
            // 
            this.menuBTN.Location = new System.Drawing.Point(304, 28);
            this.menuBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(100, 28);
            this.menuBTN.TabIndex = 2;
            this.menuBTN.Text = "Menu";
            this.menuBTN.UseVisualStyleBackColor = true;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.Location = new System.Drawing.Point(155, 30);
            this.resetBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(100, 28);
            this.resetBTN.TabIndex = 1;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = true;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(17, 30);
            this.startBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(100, 28);
            this.startBTN.TabIndex = 0;
            this.startBTN.Text = "START";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.Color.DarkOrchid;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.Location = new System.Drawing.Point(11, 166);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(339, 54);
            this.first.TabIndex = 1;
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.Location = new System.Drawing.Point(11, 290);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(339, 58);
            this.second.TabIndex = 2;
            // 
            // third
            // 
            this.third.BackColor = System.Drawing.Color.CornflowerBlue;
            this.third.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.third.Location = new System.Drawing.Point(11, 437);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(339, 58);
            this.third.TabIndex = 3;
            // 
            // fourth
            // 
            this.fourth.BackColor = System.Drawing.Color.Crimson;
            this.fourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourth.Location = new System.Drawing.Point(12, 587);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(339, 58);
            this.fourth.TabIndex = 4;
            // 
            // CHECK
            // 
            this.CHECK.Location = new System.Drawing.Point(662, 719);
            this.CHECK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(117, 44);
            this.CHECK.TabIndex = 6;
            this.CHECK.Text = "CHECK";
            this.CHECK.UseVisualStyleBackColor = true;
            this.CHECK.Visible = false;
            this.CHECK.Click += new System.EventHandler(this.CHECK_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(373, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 46);
            this.label1.TabIndex = 7;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(373, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 46);
            this.label2.TabIndex = 8;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(373, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 46);
            this.label3.TabIndex = 9;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(373, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 46);
            this.label4.TabIndex = 10;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(445, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 46);
            this.label5.TabIndex = 11;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(445, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 46);
            this.label6.TabIndex = 12;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(445, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 46);
            this.label7.TabIndex = 13;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(445, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 46);
            this.label8.TabIndex = 14;
            this.label8.Visible = false;
            // 
            // descripBox
            // 
            this.descripBox.BackColor = System.Drawing.Color.Tomato;
            this.descripBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripBox.FormattingEnabled = true;
            this.descripBox.ItemHeight = 25;
            this.descripBox.Location = new System.Drawing.Point(867, 91);
            this.descripBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descripBox.Name = "descripBox";
            this.descripBox.Size = new System.Drawing.Size(916, 554);
            this.descripBox.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 38);
            this.label11.TabIndex = 15;
            this.label11.Text = "Column A";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1134, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(234, 38);
            this.label12.TabIndex = 16;
            this.label12.Text = "Column B";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(710, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 754);
            this.label13.TabIndex = 17;
            this.label13.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // Identifying_Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1861, 837);
            this.Controls.Add(this.CHECK);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripBox);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Identifying_Areas";
            this.Text = "Identifying_Areas";
            this.Load += new System.EventHandler(this.Identifying_Areas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button menuBTN;
        private System.Windows.Forms.Button resetBTN;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label third;
        private System.Windows.Forms.Label fourth;
        private System.Windows.Forms.Button CHECK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox descripBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}