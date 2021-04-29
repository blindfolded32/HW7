
namespace task2
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
            this.MLLbl = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.InputBtn = new System.Windows.Forms.Button();
            this.CounterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MLLbl
            // 
            this.MLLbl.AutoSize = true;
            this.MLLbl.Location = new System.Drawing.Point(209, 35);
            this.MLLbl.Name = "MLLbl";
            this.MLLbl.Size = new System.Drawing.Size(92, 13);
            this.MLLbl.TabIndex = 0;
            this.MLLbl.Text = "Больше/Меньше";
            this.MLLbl.Visible = false;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(79, 86);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(347, 150);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // InputBtn
            // 
            this.InputBtn.Location = new System.Drawing.Point(187, 254);
            this.InputBtn.Name = "InputBtn";
            this.InputBtn.Size = new System.Drawing.Size(135, 29);
            this.InputBtn.TabIndex = 2;
            this.InputBtn.Text = "Input Number";
            this.InputBtn.UseVisualStyleBackColor = true;
            this.InputBtn.Visible = false;
            this.InputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // CounterLbl
            // 
            this.CounterLbl.AutoSize = true;
            this.CounterLbl.Location = new System.Drawing.Point(12, 270);
            this.CounterLbl.Name = "CounterLbl";
            this.CounterLbl.Size = new System.Drawing.Size(92, 13);
            this.CounterLbl.TabIndex = 3;
            this.CounterLbl.Text = "Больше/Меньше";
            this.CounterLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CounterLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 307);
            this.Controls.Add(this.CounterLbl);
            this.Controls.Add(this.InputBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.MLLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MLLbl;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button InputBtn;
        private System.Windows.Forms.Label CounterLbl;
    }
}

