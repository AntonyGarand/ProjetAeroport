namespace ProjetAeroport
{
    partial class FormInfoObjVolants
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
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.labelTempsRestant = new System.Windows.Forms.Label();
            this.labelNbPassagers = new System.Windows.Forms.Label();
            this.labelStatutValue = new System.Windows.Forms.Label();
            this.labelNoVolValue = new System.Windows.Forms.Label();
            this.labelEssence = new System.Windows.Forms.Label();
            this.labelTempsRestantTitre = new System.Windows.Forms.Label();
            this.labelNbPassagersTitre = new System.Windows.Forms.Label();
            this.labelStatutTitre = new System.Windows.Forms.Label();
            this.labelNoVolTitre = new System.Windows.Forms.Label();
            this.progressBarEssence = new ProjetAeroport.CustomProgressBar();
            this.groupBoxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInformation.Controls.Add(this.labelTempsRestant);
            this.groupBoxInformation.Controls.Add(this.labelNbPassagers);
            this.groupBoxInformation.Controls.Add(this.labelStatutValue);
            this.groupBoxInformation.Controls.Add(this.labelNoVolValue);
            this.groupBoxInformation.Controls.Add(this.labelEssence);
            this.groupBoxInformation.Controls.Add(this.labelTempsRestantTitre);
            this.groupBoxInformation.Controls.Add(this.labelNbPassagersTitre);
            this.groupBoxInformation.Controls.Add(this.labelStatutTitre);
            this.groupBoxInformation.Controls.Add(this.labelNoVolTitre);
            this.groupBoxInformation.Controls.Add(this.progressBarEssence);
            this.groupBoxInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(241, 237);
            this.groupBoxInformation.TabIndex = 0;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // labelTempsRestant
            // 
            this.labelTempsRestant.AutoSize = true;
            this.labelTempsRestant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempsRestant.Location = new System.Drawing.Point(128, 131);
            this.labelTempsRestant.Name = "labelTempsRestant";
            this.labelTempsRestant.Size = new System.Drawing.Size(88, 21);
            this.labelTempsRestant.TabIndex = 11;
            this.labelTempsRestant.Text = "14 minutes";
            // 
            // labelNbPassagers
            // 
            this.labelNbPassagers.AutoSize = true;
            this.labelNbPassagers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbPassagers.Location = new System.Drawing.Point(128, 89);
            this.labelNbPassagers.Name = "labelNbPassagers";
            this.labelNbPassagers.Size = new System.Drawing.Size(28, 21);
            this.labelNbPassagers.TabIndex = 10;
            this.labelNbPassagers.Text = "14";
            // 
            // labelStatutValue
            // 
            this.labelStatutValue.AutoSize = true;
            this.labelStatutValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatutValue.Location = new System.Drawing.Point(128, 69);
            this.labelStatutValue.Name = "labelStatutValue";
            this.labelStatutValue.Size = new System.Drawing.Size(62, 21);
            this.labelStatutValue.TabIndex = 9;
            this.labelStatutValue.Text = "Occupe";
            // 
            // labelNoVolValue
            // 
            this.labelNoVolValue.AutoSize = true;
            this.labelNoVolValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoVolValue.Location = new System.Drawing.Point(128, 49);
            this.labelNoVolValue.Name = "labelNoVolValue";
            this.labelNoVolValue.Size = new System.Drawing.Size(70, 21);
            this.labelNoVolValue.TabIndex = 8;
            this.labelNoVolValue.Text = "AA 2431";
            // 
            // labelEssence
            // 
            this.labelEssence.AutoSize = true;
            this.labelEssence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEssence.Location = new System.Drawing.Point(6, 184);
            this.labelEssence.Name = "labelEssence";
            this.labelEssence.Size = new System.Drawing.Size(124, 21);
            this.labelEssence.TabIndex = 7;
            this.labelEssence.Text = "Niveau essence :";
            // 
            // labelTempsRestantTitre
            // 
            this.labelTempsRestantTitre.AutoSize = true;
            this.labelTempsRestantTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempsRestantTitre.Location = new System.Drawing.Point(6, 131);
            this.labelTempsRestantTitre.Name = "labelTempsRestantTitre";
            this.labelTempsRestantTitre.Size = new System.Drawing.Size(122, 21);
            this.labelTempsRestantTitre.TabIndex = 6;
            this.labelTempsRestantTitre.Text = "Temps restants :";
            // 
            // labelNbPassagersTitre
            // 
            this.labelNbPassagersTitre.AutoSize = true;
            this.labelNbPassagersTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbPassagersTitre.Location = new System.Drawing.Point(6, 89);
            this.labelNbPassagersTitre.Name = "labelNbPassagersTitre";
            this.labelNbPassagersTitre.Size = new System.Drawing.Size(111, 21);
            this.labelNbPassagersTitre.TabIndex = 5;
            this.labelNbPassagersTitre.Text = "Nb Passagers :";
            // 
            // labelStatutTitre
            // 
            this.labelStatutTitre.AutoSize = true;
            this.labelStatutTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatutTitre.Location = new System.Drawing.Point(6, 69);
            this.labelStatutTitre.Name = "labelStatutTitre";
            this.labelStatutTitre.Size = new System.Drawing.Size(58, 21);
            this.labelStatutTitre.TabIndex = 4;
            this.labelStatutTitre.Text = "Statut :";
            // 
            // labelNoVolTitre
            // 
            this.labelNoVolTitre.AutoSize = true;
            this.labelNoVolTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoVolTitre.Location = new System.Drawing.Point(6, 49);
            this.labelNoVolTitre.Name = "labelNoVolTitre";
            this.labelNoVolTitre.Size = new System.Drawing.Size(61, 21);
            this.labelNoVolTitre.TabIndex = 3;
            this.labelNoVolTitre.Text = "NoVol :";
            // 
            // progressBarEssence
            // 
            this.progressBarEssence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarEssence.CustomText = null;
            this.progressBarEssence.DisplayStyle = ProjetAeroport.CustomProgressBar.ProgressBarDisplayText.Percentage;
            this.progressBarEssence.Location = new System.Drawing.Point(6, 208);
            this.progressBarEssence.Name = "progressBarEssence";
            this.progressBarEssence.Size = new System.Drawing.Size(229, 23);
            this.progressBarEssence.TabIndex = 2;
            // 
            // FormInfoObjVolants
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(263, 261);
            this.Controls.Add(this.groupBoxInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormInfoObjVolants";
            this.Text = "Détails Avions";
            this.Load += new System.EventHandler(this.FormInfoObjVolants_Load);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label labelTempsRestant;
        private System.Windows.Forms.Label labelNbPassagers;
        private System.Windows.Forms.Label labelStatutValue;
        private System.Windows.Forms.Label labelNoVolValue;
        private System.Windows.Forms.Label labelEssence;
        private System.Windows.Forms.Label labelTempsRestantTitre;
        private System.Windows.Forms.Label labelNbPassagersTitre;
        private System.Windows.Forms.Label labelStatutTitre;
        private System.Windows.Forms.Label labelNoVolTitre;
        private CustomProgressBar progressBarEssence;
    }
}