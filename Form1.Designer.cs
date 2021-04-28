
namespace HW7
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.MultiBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.ValLbl = new System.Windows.Forms.Label();
            this.CounterLbl = new System.Windows.Forms.Label();
            this.NeedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(139, 48);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(333, 182);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(502, 207);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Visible = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // MultiBtn
            // 
            this.MultiBtn.Location = new System.Drawing.Point(502, 100);
            this.MultiBtn.Name = "MultiBtn";
            this.MultiBtn.Size = new System.Drawing.Size(75, 23);
            this.MultiBtn.TabIndex = 2;
            this.MultiBtn.Text = "x2";
            this.MultiBtn.UseVisualStyleBackColor = true;
            this.MultiBtn.Visible = false;
            this.MultiBtn.Click += new System.EventHandler(this.MultiBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Location = new System.Drawing.Point(502, 48);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(75, 23);
            this.PlusBtn.TabIndex = 3;
            this.PlusBtn.Text = "+1";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Visible = false;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // ValLbl
            // 
            this.ValLbl.AutoSize = true;
            this.ValLbl.Location = new System.Drawing.Point(45, 32);
            this.ValLbl.Name = "ValLbl";
            this.ValLbl.Size = new System.Drawing.Size(70, 13);
            this.ValLbl.TabIndex = 4;
            this.ValLbl.Text = "Current value";
            this.ValLbl.Visible = false;
            // 
            // CounterLbl
            // 
            this.CounterLbl.AutoSize = true;
            this.CounterLbl.Location = new System.Drawing.Point(45, 281);
            this.CounterLbl.Name = "CounterLbl";
            this.CounterLbl.Size = new System.Drawing.Size(73, 13);
            this.CounterLbl.TabIndex = 5;
            this.CounterLbl.Text = "Actions Count";
            this.CounterLbl.Visible = false;
            // 
            // NeedLbl
            // 
            this.NeedLbl.AutoSize = true;
            this.NeedLbl.Location = new System.Drawing.Point(45, 133);
            this.NeedLbl.Name = "NeedLbl";
            this.NeedLbl.Size = new System.Drawing.Size(74, 13);
            this.NeedLbl.TabIndex = 6;
            this.NeedLbl.Text = "Needed value";
            this.NeedLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 339);
            this.Controls.Add(this.NeedLbl);
            this.Controls.Add(this.CounterLbl);
            this.Controls.Add(this.ValLbl);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.MultiBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button MultiBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Label ValLbl;
        private System.Windows.Forms.Label CounterLbl;
        private System.Windows.Forms.Label NeedLbl;
    }
}

