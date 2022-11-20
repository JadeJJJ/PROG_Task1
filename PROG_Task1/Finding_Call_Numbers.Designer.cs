
namespace PROG_Task1
{
    partial class Finding_Call_Numbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finding_Call_Numbers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Question = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.o2 = new System.Windows.Forms.Label();
            this.o3 = new System.Windows.Forms.Label();
            this.o4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.reset_btn);
            this.panel1.Controls.Add(this.start_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 64);
            this.panel1.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(12, 18);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(95, 34);
            this.start_btn.TabIndex = 3;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(134, 18);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(95, 33);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(650, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 46);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(763, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "00:00:00.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Timer:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(80, 110);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(100, 23);
            this.Question.TabIndex = 1;
            this.Question.Text = "label3";
            // 
            // o1
            // 
            this.o1.Location = new System.Drawing.Point(625, 85);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(296, 47);
            this.o1.TabIndex = 2;
            this.o1.Text = "label3";
            this.o1.Click += new System.EventHandler(this.o1_Click);
            // 
            // o2
            // 
            this.o2.Location = new System.Drawing.Point(625, 156);
            this.o2.Name = "o2";
            this.o2.Size = new System.Drawing.Size(296, 45);
            this.o2.TabIndex = 3;
            this.o2.Text = "label4";
            this.o2.Click += new System.EventHandler(this.o2_Click);
            // 
            // o3
            // 
            this.o3.Location = new System.Drawing.Point(625, 222);
            this.o3.Name = "o3";
            this.o3.Size = new System.Drawing.Size(296, 45);
            this.o3.TabIndex = 4;
            this.o3.Text = "label5";
            this.o3.Click += new System.EventHandler(this.o3_Click);
            // 
            // o4
            // 
            this.o4.Location = new System.Drawing.Point(625, 304);
            this.o4.Name = "o4";
            this.o4.Size = new System.Drawing.Size(296, 45);
            this.o4.TabIndex = 5;
            this.o4.Text = "label6";
            this.o4.Click += new System.EventHandler(this.o4_Click);
            // 
            // Finding_Call_Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 542);
            this.Controls.Add(this.o4);
            this.Controls.Add(this.o3);
            this.Controls.Add(this.o2);
            this.Controls.Add(this.o1);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Finding_Call_Numbers";
            this.Text = "Finding_Call_Numbers";
            this.Load += new System.EventHandler(this.Finding_Call_Numbers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label o1;
        private System.Windows.Forms.Label o2;
        private System.Windows.Forms.Label o3;
        private System.Windows.Forms.Label o4;
    }
}