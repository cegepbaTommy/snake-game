﻿namespace Travail1
{
    partial class FormJeu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPlancheJeu = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlancheJeu)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlancheJeu
            // 
            this.picPlancheJeu.BackColor = System.Drawing.SystemColors.Control;
            this.picPlancheJeu.Location = new System.Drawing.Point(525, 15);
            this.picPlancheJeu.Margin = new System.Windows.Forms.Padding(6);
            this.picPlancheJeu.Name = "picPlancheJeu";
            this.picPlancheJeu.Size = new System.Drawing.Size(801, 801);
            this.picPlancheJeu.TabIndex = 0;
            this.picPlancheJeu.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 836);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picPlancheJeu);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormJeu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPlancheJeu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picPlancheJeu;
        private Button button1;
    }
}