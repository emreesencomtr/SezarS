﻿
namespace SezarS
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtVeri = new System.Windows.Forms.TextBox();
            this.BtnSifrele = new System.Windows.Forms.Button();
            this.TxtSifreliVeri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSifreCoz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veri:";
            // 
            // TxtVeri
            // 
            this.TxtVeri.Location = new System.Drawing.Point(100, 38);
            this.TxtVeri.Name = "TxtVeri";
            this.TxtVeri.Size = new System.Drawing.Size(199, 26);
            this.TxtVeri.TabIndex = 1;
            // 
            // BtnSifrele
            // 
            this.BtnSifrele.Location = new System.Drawing.Point(100, 110);
            this.BtnSifrele.Name = "BtnSifrele";
            this.BtnSifrele.Size = new System.Drawing.Size(92, 28);
            this.BtnSifrele.TabIndex = 2;
            this.BtnSifrele.Text = "Şifrele";
            this.BtnSifrele.UseVisualStyleBackColor = true;
            this.BtnSifrele.Click += new System.EventHandler(this.BtnSifrele_Click);
            // 
            // TxtSifreliVeri
            // 
            this.TxtSifreliVeri.Location = new System.Drawing.Point(100, 78);
            this.TxtSifreliVeri.Name = "TxtSifreliVeri";
            this.TxtSifreliVeri.Size = new System.Drawing.Size(199, 26);
            this.TxtSifreliVeri.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifreli Veri:";
            // 
            // BtnSifreCoz
            // 
            this.BtnSifreCoz.Location = new System.Drawing.Point(208, 110);
            this.BtnSifreCoz.Name = "BtnSifreCoz";
            this.BtnSifreCoz.Size = new System.Drawing.Size(91, 28);
            this.BtnSifreCoz.TabIndex = 5;
            this.BtnSifreCoz.Text = "Şifre Çöz";
            this.BtnSifreCoz.UseVisualStyleBackColor = true;
            this.BtnSifreCoz.Click += new System.EventHandler(this.BtnSifreCoz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 167);
            this.Controls.Add(this.BtnSifreCoz);
            this.Controls.Add(this.TxtSifreliVeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSifrele);
            this.Controls.Add(this.TxtVeri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtVeri;
        private System.Windows.Forms.Button BtnSifrele;
        private System.Windows.Forms.TextBox TxtSifreliVeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSifreCoz;
    }
}

