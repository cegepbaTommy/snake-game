namespace Travail1.Controls
{
    partial class JoueursUi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTxtJoueur = new System.Windows.Forms.Label();
            this.lblTourJoueur = new System.Windows.Forms.Label();
            this.lblTxtJoueur1 = new System.Windows.Forms.Label();
            this.lblTxtJoueur2 = new System.Windows.Forms.Label();
            this.lblNomJoueur1 = new System.Windows.Forms.Label();
            this.lblNomJoueur2 = new System.Windows.Forms.Label();
            this.lblPointJoueur1 = new System.Windows.Forms.Label();
            this.lblPointJoueur2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTxtJoueur
            // 
            this.lblTxtJoueur.AutoSize = true;
            this.lblTxtJoueur.Location = new System.Drawing.Point(3, 0);
            this.lblTxtJoueur.Name = "lblTxtJoueur";
            this.lblTxtJoueur.Size = new System.Drawing.Size(116, 20);
            this.lblTxtJoueur.TabIndex = 0;
            this.lblTxtJoueur.Text = "Tour du joueur : ";
            // 
            // lblTourJoueur
            // 
            this.lblTourJoueur.AutoSize = true;
            this.lblTourJoueur.Location = new System.Drawing.Point(151, 0);
            this.lblTourJoueur.Name = "lblTourJoueur";
            this.lblTourJoueur.Size = new System.Drawing.Size(51, 20);
            this.lblTourJoueur.TabIndex = 1;
            this.lblTourJoueur.Text = "joueur";
            // 
            // lblTxtJoueur1
            // 
            this.lblTxtJoueur1.AutoSize = true;
            this.lblTxtJoueur1.Location = new System.Drawing.Point(4, 36);
            this.lblTxtJoueur1.Name = "lblTxtJoueur1";
            this.lblTxtJoueur1.Size = new System.Drawing.Size(115, 40);
            this.lblTxtJoueur1.TabIndex = 2;
            this.lblTxtJoueur1.Text = "Nom joueur 1  : \r\nPoint joueur 1  :";
            // 
            // lblTxtJoueur2
            // 
            this.lblTxtJoueur2.AutoSize = true;
            this.lblTxtJoueur2.Location = new System.Drawing.Point(4, 90);
            this.lblTxtJoueur2.Name = "lblTxtJoueur2";
            this.lblTxtJoueur2.Size = new System.Drawing.Size(115, 40);
            this.lblTxtJoueur2.TabIndex = 3;
            this.lblTxtJoueur2.Text = "Nom joueur 2  : \r\nPoint joueur 2  :";
            // 
            // lblNomJoueur1
            // 
            this.lblNomJoueur1.AutoSize = true;
            this.lblNomJoueur1.Location = new System.Drawing.Point(151, 36);
            this.lblNomJoueur1.Name = "lblNomJoueur1";
            this.lblNomJoueur1.Size = new System.Drawing.Size(59, 20);
            this.lblNomJoueur1.TabIndex = 4;
            this.lblNomJoueur1.Text = "joueur1";
            // 
            // lblNomJoueur2
            // 
            this.lblNomJoueur2.AutoSize = true;
            this.lblNomJoueur2.Location = new System.Drawing.Point(151, 90);
            this.lblNomJoueur2.Name = "lblNomJoueur2";
            this.lblNomJoueur2.Size = new System.Drawing.Size(59, 20);
            this.lblNomJoueur2.TabIndex = 5;
            this.lblNomJoueur2.Text = "joueur2";
            // 
            // lblPointJoueur1
            // 
            this.lblPointJoueur1.AutoSize = true;
            this.lblPointJoueur1.Location = new System.Drawing.Point(151, 56);
            this.lblPointJoueur1.Name = "lblPointJoueur1";
            this.lblPointJoueur1.Size = new System.Drawing.Size(102, 20);
            this.lblPointJoueur1.TabIndex = 6;
            this.lblPointJoueur1.Text = "point joueur 1";
            // 
            // lblPointJoueur2
            // 
            this.lblPointJoueur2.AutoSize = true;
            this.lblPointJoueur2.Location = new System.Drawing.Point(151, 110);
            this.lblPointJoueur2.Name = "lblPointJoueur2";
            this.lblPointJoueur2.Size = new System.Drawing.Size(102, 20);
            this.lblPointJoueur2.TabIndex = 7;
            this.lblPointJoueur2.Text = "point joueur 2";
            // 
            // JoueursUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPointJoueur2);
            this.Controls.Add(this.lblPointJoueur1);
            this.Controls.Add(this.lblNomJoueur2);
            this.Controls.Add(this.lblNomJoueur1);
            this.Controls.Add(this.lblTxtJoueur2);
            this.Controls.Add(this.lblTxtJoueur1);
            this.Controls.Add(this.lblTourJoueur);
            this.Controls.Add(this.lblTxtJoueur);
            this.Name = "JoueursUi";
            this.Size = new System.Drawing.Size(253, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTxtJoueur;
        private Label lblTourJoueur;
        private Label lblTxtJoueur1;
        private Label lblTxtJoueur2;
        private Label lblNomJoueur1;
        private Label lblNomJoueur2;
        private Label lblPointJoueur1;
        private Label lblPointJoueur2;
    }
}
