
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
            this.startBTN = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.menuBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuBTN);
            this.panel1.Controls.Add(this.resetBTN);
            this.panel1.Controls.Add(this.startBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 61);
            this.panel1.TabIndex = 0;
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(13, 24);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(75, 23);
            this.startBTN.TabIndex = 0;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            // 
            // resetBTN
            // 
            this.resetBTN.Location = new System.Drawing.Point(116, 24);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(75, 23);
            this.resetBTN.TabIndex = 1;
            this.resetBTN.Text = "reset";
            this.resetBTN.UseVisualStyleBackColor = true;
            // 
            // menuBTN
            // 
            this.menuBTN.Location = new System.Drawing.Point(228, 23);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(75, 23);
            this.menuBTN.TabIndex = 2;
            this.menuBTN.Text = "Menu";
            this.menuBTN.UseVisualStyleBackColor = true;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // Identifying_Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 603);
            this.Controls.Add(this.panel1);
            this.Name = "Identifying_Areas";
            this.Text = "Identifying_Areas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button menuBTN;
        private System.Windows.Forms.Button resetBTN;
    }
}