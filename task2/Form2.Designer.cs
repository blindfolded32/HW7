﻿
namespace task2
{
    partial class Form2
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
            this.NumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumBox
            // 
            this.NumBox.Location = new System.Drawing.Point(80, 66);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(108, 20);
            this.NumBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input number";
            // 
            // ChkBtn
            // 
            this.ChkBtn.Location = new System.Drawing.Point(95, 104);
            this.ChkBtn.Name = "ChkBtn";
            this.ChkBtn.Size = new System.Drawing.Size(75, 23);
            this.ChkBtn.TabIndex = 2;
            this.ChkBtn.Text = "OK";
            this.ChkBtn.UseVisualStyleBackColor = true;
            this.ChkBtn.Click += new System.EventHandler(this.ChkBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 159);
            this.Controls.Add(this.ChkBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChkBtn;
    }
}