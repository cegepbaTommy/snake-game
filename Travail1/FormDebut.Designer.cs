namespace Travail1
{
    partial class FormDebut
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
            this.lblText = new System.Windows.Forms.Label();
            this.lblJoueure1 = new System.Windows.Forms.Label();
            this.lblJoueur2 = new System.Windows.Forms.Label();
            this.txtJoueur1 = new System.Windows.Forms.TextBox();
            this.txtJoueur2 = new System.Windows.Forms.TextBox();
            this.btnJouer = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(12, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(281, 21);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "veuillez entrer le nom des deux joueurs";
            // 
            // lblJoueure1
            // 
            this.lblJoueure1.AutoSize = true;
            this.lblJoueure1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoueure1.Location = new System.Drawing.Point(12, 57);
            this.lblJoueure1.Name = "lblJoueure1";
            this.lblJoueure1.Size = new System.Drawing.Size(91, 25);
            this.lblJoueure1.TabIndex = 1;
            this.lblJoueure1.Text = "joueur 1 :";
            // 
            // lblJoueur2
            // 
            this.lblJoueur2.AutoSize = true;
            this.lblJoueur2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur2.Location = new System.Drawing.Point(12, 86);
            this.lblJoueur2.Name = "lblJoueur2";
            this.lblJoueur2.Size = new System.Drawing.Size(91, 25);
            this.lblJoueur2.TabIndex = 2;
            this.lblJoueur2.Text = "joueur 2 :";
            // 
            // txtJoueur1
            // 
            this.txtJoueur1.Location = new System.Drawing.Point(124, 59);
            this.txtJoueur1.Name = "txtJoueur1";
            this.txtJoueur1.Size = new System.Drawing.Size(169, 23);
            this.txtJoueur1.TabIndex = 3;
            this.txtJoueur1.TextChanged += new System.EventHandler(this.txtJoueur_TextChanged);
            // 
            // txtJoueur2
            // 
            this.txtJoueur2.Location = new System.Drawing.Point(124, 88);
            this.txtJoueur2.Name = "txtJoueur2";
            this.txtJoueur2.Size = new System.Drawing.Size(169, 23);
            this.txtJoueur2.TabIndex = 4;
            this.txtJoueur2.TextChanged += new System.EventHandler(this.txtJoueur_TextChanged);
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(124, 117);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(169, 38);
            this.btnJouer.TabIndex = 5;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FormDebut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 178);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.txtJoueur2);
            this.Controls.Add(this.txtJoueur1);
            this.Controls.Add(this.lblJoueur2);
            this.Controls.Add(this.lblJoueure1);
            this.Controls.Add(this.lblText);
            this.Name = "FormDebut";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblText;
        private Label lblJoueure1;
        private Label lblJoueur2;
        private TextBox txtJoueur1;
        private TextBox txtJoueur2;
        private Button btnJouer;
        private ErrorProvider error;
    }
}