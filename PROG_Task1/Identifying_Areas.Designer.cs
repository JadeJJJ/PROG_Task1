
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBTN = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.third = new System.Windows.Forms.Label();
            this.fourth = new System.Windows.Forms.Label();
            this.descripBox = new System.Windows.Forms.ListBox();
            this.CHECK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuBTN);
            this.panel1.Controls.Add(this.resetBTN);
            this.panel1.Controls.Add(this.startBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 763);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1505, 75);
            this.panel1.TabIndex = 0;
            // 
            // menuBTN
            // 
            this.menuBTN.Location = new System.Drawing.Point(304, 28);
            this.menuBTN.Margin = new System.Windows.Forms.Padding(4);
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
            this.resetBTN.Margin = new System.Windows.Forms.Padding(4);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(100, 28);
            this.resetBTN.TabIndex = 1;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = true;
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(17, 30);
            this.startBTN.Margin = new System.Windows.Forms.Padding(4);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(100, 28);
            this.startBTN.TabIndex = 0;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.Location = new System.Drawing.Point(41, 66);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(339, 54);
            this.first.TabIndex = 1;
            this.first.Text = "label1";
            // 
            // second
            // 
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.Location = new System.Drawing.Point(41, 148);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(339, 58);
            this.second.TabIndex = 2;
            this.second.Text = "label1";
            // 
            // third
            // 
            this.third.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.third.Location = new System.Drawing.Point(41, 273);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(339, 58);
            this.third.TabIndex = 3;
            this.third.Text = "label1";
            // 
            // fourth
            // 
            this.fourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourth.Location = new System.Drawing.Point(41, 400);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(339, 58);
            this.fourth.TabIndex = 4;
            this.fourth.Text = "label1";
            // 
            // descripBox
            // 
            this.descripBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripBox.FormattingEnabled = true;
            this.descripBox.ItemHeight = 31;
            this.descripBox.Location = new System.Drawing.Point(573, 52);
            this.descripBox.Name = "descripBox";
            this.descripBox.Size = new System.Drawing.Size(878, 593);
            this.descripBox.TabIndex = 5;
            // 
            // CHECK
            // 
            this.CHECK.Location = new System.Drawing.Point(426, 699);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(117, 44);
            this.CHECK.TabIndex = 6;
            this.CHECK.Text = "CHECK";
            this.CHECK.UseVisualStyleBackColor = true;
            this.CHECK.Click += new System.EventHandler(this.CHECK_Click);
            // 
            // Identifying_Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 838);
            this.Controls.Add(this.CHECK);
            this.Controls.Add(this.descripBox);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Identifying_Areas";
            this.Text = "Identifying_Areas";
            this.Load += new System.EventHandler(this.Identifying_Areas_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox descripBox;
        private System.Windows.Forms.Button CHECK;
    }
}