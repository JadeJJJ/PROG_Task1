﻿
namespace PROG_Task1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Replace_btn = new System.Windows.Forms.Button();
            this.Identify_btn = new System.Windows.Forms.Button();
            this.callNum_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Replace_btn
            // 
            this.Replace_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Replace_btn.Image = ((System.Drawing.Image)(resources.GetObject("Replace_btn.Image")));
            this.Replace_btn.Location = new System.Drawing.Point(328, 55);
            this.Replace_btn.Name = "Replace_btn";
            this.Replace_btn.Size = new System.Drawing.Size(244, 185);
            this.Replace_btn.TabIndex = 0;
            this.Replace_btn.UseVisualStyleBackColor = false;
            this.Replace_btn.Click += new System.EventHandler(this.Replace_btn_Click);
            // 
            // Identify_btn
            // 
            this.Identify_btn.Image = ((System.Drawing.Image)(resources.GetObject("Identify_btn.Image")));
            this.Identify_btn.Location = new System.Drawing.Point(33, 271);
            this.Identify_btn.Name = "Identify_btn";
            this.Identify_btn.Size = new System.Drawing.Size(247, 216);
            this.Identify_btn.TabIndex = 1;
            this.Identify_btn.UseVisualStyleBackColor = true;
            this.Identify_btn.Click += new System.EventHandler(this.Identify_btn_Click);
            // 
            // callNum_btn
            // 
            this.callNum_btn.Location = new System.Drawing.Point(576, 298);
            this.callNum_btn.Name = "callNum_btn";
            this.callNum_btn.Size = new System.Drawing.Size(229, 113);
            this.callNum_btn.TabIndex = 2;
            this.callNum_btn.Text = "Finding Call Numbers";
            this.callNum_btn.UseVisualStyleBackColor = true;
            this.callNum_btn.Click += new System.EventHandler(this.callNum_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(932, 497);
            this.Controls.Add(this.callNum_btn);
            this.Controls.Add(this.Identify_btn);
            this.Controls.Add(this.Replace_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Replace_btn;
        private System.Windows.Forms.Button Identify_btn;
        private System.Windows.Forms.Button callNum_btn;
    }
}

