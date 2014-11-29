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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMaxEssence = new System.Windows.Forms.Label();
            this.labelMinEssence = new System.Windows.Forms.Label();
            this.progressBarEssence = new System.Windows.Forms.ProgressBar();
            this.labelNoVolTitre = new System.Windows.Forms.Label();
            this.labelStatutTitre = new System.Windows.Forms.Label();
            this.labelNbPassagersTitre = new System.Windows.Forms.Label();
            this.labelTempsRestantTitre = new System.Windows.Forms.Label();
            this.labelEssence = new System.Windows.Forms.Label();
            this.labelNoVolValue = new System.Windows.Forms.Label();
            this.labelStatutValue = new System.Windows.Forms.Label();
            this.labelNbPassagers = new System.Windows.Forms.Label();
            this.labelTempsRestant = new System.Windows.Forms.Label();
            this.groupBoxPosteEssence = new System.Windows.Forms.GroupBox();
            this.buttonAjouterEssence = new System.Windows.Forms.Button();
            this.labelEssencePourcentage = new System.Windows.Forms.Label();
            this.groupBoxInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPosteEssence.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInformation.Controls.Add(this.labelEssencePourcentage);
            this.groupBoxInformation.Controls.Add(this.labelTempsRestant);
            this.groupBoxInformation.Controls.Add(this.labelNbPassagers);
            this.groupBoxInformation.Controls.Add(this.labelStatutValue);
            this.groupBoxInformation.Controls.Add(this.labelNoVolValue);
            this.groupBoxInformation.Controls.Add(this.labelEssence);
            this.groupBoxInformation.Controls.Add(this.labelTempsRestantTitre);
            this.groupBoxInformation.Controls.Add(this.labelNbPassagersTitre);
            this.groupBoxInformation.Controls.Add(this.labelStatutTitre);
            this.groupBoxInformation.Controls.Add(this.labelNoVolTitre);
            this.groupBoxInformation.Controls.Add(this.labelMinEssence);
            this.groupBoxInformation.Controls.Add(this.labelMaxEssence);
            this.groupBoxInformation.Controls.Add(this.progressBarEssence);
            this.groupBoxInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(241, 237);
            this.groupBoxInformation.TabIndex = 0;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBoxPosteEssence);
            this.groupBox1.Location = new System.Drawing.Point(259, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panneau contrôle";
            // 
            // labelMaxEssence
            // 
            this.labelMaxEssence.AutoSize = true;
            this.labelMaxEssence.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxEssence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxEssence.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMaxEssence.Location = new System.Drawing.Point(194, 218);
            this.labelMaxEssence.Name = "labelMaxEssence";
            this.labelMaxEssence.Size = new System.Drawing.Size(41, 16);
            this.labelMaxEssence.TabIndex = 0;
            this.labelMaxEssence.Text = "100%";
            // 
            // labelMinEssence
            // 
            this.labelMinEssence.AutoSize = true;
            this.labelMinEssence.BackColor = System.Drawing.Color.Transparent;
            this.labelMinEssence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMinEssence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinEssence.Location = new System.Drawing.Point(6, 215);
            this.labelMinEssence.Name = "labelMinEssence";
            this.labelMinEssence.Size = new System.Drawing.Size(27, 16);
            this.labelMinEssence.TabIndex = 1;
            this.labelMinEssence.Text = "0%";
            // 
            // progressBarEssence
            // 
            this.progressBarEssence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarEssence.Location = new System.Drawing.Point(6, 208);
            this.progressBarEssence.Name = "progressBarEssence";
            this.progressBarEssence.Size = new System.Drawing.Size(229, 23);
            this.progressBarEssence.TabIndex = 2;
            // 
            // labelNoVolTitre
            // 
            this.labelNoVolTitre.AutoSize = true;
            this.labelNoVolTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoVolTitre.Location = new System.Drawing.Point(6, 49);
            this.labelNoVolTitre.Name = "labelNoVolTitre";
            this.labelNoVolTitre.Size = new System.Drawing.Size(60, 20);
            this.labelNoVolTitre.TabIndex = 3;
            this.labelNoVolTitre.Text = "NoVol :";
            // 
            // labelStatutTitre
            // 
            this.labelStatutTitre.AutoSize = true;
            this.labelStatutTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatutTitre.Location = new System.Drawing.Point(6, 69);
            this.labelStatutTitre.Name = "labelStatutTitre";
            this.labelStatutTitre.Size = new System.Drawing.Size(61, 20);
            this.labelStatutTitre.TabIndex = 4;
            this.labelStatutTitre.Text = "Statut :";
            // 
            // labelNbPassagersTitre
            // 
            this.labelNbPassagersTitre.AutoSize = true;
            this.labelNbPassagersTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbPassagersTitre.Location = new System.Drawing.Point(6, 89);
            this.labelNbPassagersTitre.Name = "labelNbPassagersTitre";
            this.labelNbPassagersTitre.Size = new System.Drawing.Size(116, 20);
            this.labelNbPassagersTitre.TabIndex = 5;
            this.labelNbPassagersTitre.Text = "Nb Passagers :";
            // 
            // labelTempsRestantTitre
            // 
            this.labelTempsRestantTitre.AutoSize = true;
            this.labelTempsRestantTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempsRestantTitre.Location = new System.Drawing.Point(6, 131);
            this.labelTempsRestantTitre.Name = "labelTempsRestantTitre";
            this.labelTempsRestantTitre.Size = new System.Drawing.Size(127, 20);
            this.labelTempsRestantTitre.TabIndex = 6;
            this.labelTempsRestantTitre.Text = "Temps restants :";
            // 
            // labelEssence
            // 
            this.labelEssence.AutoSize = true;
            this.labelEssence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEssence.Location = new System.Drawing.Point(6, 185);
            this.labelEssence.Name = "labelEssence";
            this.labelEssence.Size = new System.Drawing.Size(79, 20);
            this.labelEssence.TabIndex = 7;
            this.labelEssence.Text = "Essence :";
            // 
            // labelNoVolValue
            // 
            this.labelNoVolValue.AutoSize = true;
            this.labelNoVolValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoVolValue.Location = new System.Drawing.Point(128, 49);
            this.labelNoVolValue.Name = "labelNoVolValue";
            this.labelNoVolValue.Size = new System.Drawing.Size(71, 20);
            this.labelNoVolValue.TabIndex = 8;
            this.labelNoVolValue.Text = "AA 2431";
            // 
            // labelStatutValue
            // 
            this.labelStatutValue.AutoSize = true;
            this.labelStatutValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatutValue.Location = new System.Drawing.Point(128, 69);
            this.labelStatutValue.Name = "labelStatutValue";
            this.labelStatutValue.Size = new System.Drawing.Size(64, 20);
            this.labelStatutValue.TabIndex = 9;
            this.labelStatutValue.Text = "Occupe";
            // 
            // labelNbPassagers
            // 
            this.labelNbPassagers.AutoSize = true;
            this.labelNbPassagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbPassagers.Location = new System.Drawing.Point(128, 89);
            this.labelNbPassagers.Name = "labelNbPassagers";
            this.labelNbPassagers.Size = new System.Drawing.Size(27, 20);
            this.labelNbPassagers.TabIndex = 10;
            this.labelNbPassagers.Text = "14";
            // 
            // labelTempsRestant
            // 
            this.labelTempsRestant.AutoSize = true;
            this.labelTempsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempsRestant.Location = new System.Drawing.Point(128, 131);
            this.labelTempsRestant.Name = "labelTempsRestant";
            this.labelTempsRestant.Size = new System.Drawing.Size(87, 20);
            this.labelTempsRestant.TabIndex = 11;
            this.labelTempsRestant.Text = "14 minutes";
            // 
            // groupBoxPosteEssence
            // 
            this.groupBoxPosteEssence.Controls.Add(this.buttonAjouterEssence);
            this.groupBoxPosteEssence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPosteEssence.Location = new System.Drawing.Point(6, 28);
            this.groupBoxPosteEssence.Name = "groupBoxPosteEssence";
            this.groupBoxPosteEssence.Size = new System.Drawing.Size(224, 100);
            this.groupBoxPosteEssence.TabIndex = 0;
            this.groupBoxPosteEssence.TabStop = false;
            this.groupBoxPosteEssence.Text = "Poste à Essence";
            // 
            // buttonAjouterEssence
            // 
            this.buttonAjouterEssence.Location = new System.Drawing.Point(6, 41);
            this.buttonAjouterEssence.Name = "buttonAjouterEssence";
            this.buttonAjouterEssence.Size = new System.Drawing.Size(212, 40);
            this.buttonAjouterEssence.TabIndex = 0;
            this.buttonAjouterEssence.Text = "Ajouter Essence";
            this.buttonAjouterEssence.UseVisualStyleBackColor = true;
            // 
            // labelEssencePourcentage
            // 
            this.labelEssencePourcentage.AutoSize = true;
            this.labelEssencePourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEssencePourcentage.Location = new System.Drawing.Point(128, 185);
            this.labelEssencePourcentage.Name = "labelEssencePourcentage";
            this.labelEssencePourcentage.Size = new System.Drawing.Size(45, 20);
            this.labelEssencePourcentage.TabIndex = 12;
            this.labelEssencePourcentage.Text = "49 %";
            // 
            // FormInfoObjVolants
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(507, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInformation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormInfoObjVolants";
            this.Text = "Détails Avions";
            this.Load += new System.EventHandler(this.FormInfoObjVolants_Load);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxPosteEssence.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label labelEssencePourcentage;
        private System.Windows.Forms.Label labelTempsRestant;
        private System.Windows.Forms.Label labelNbPassagers;
        private System.Windows.Forms.Label labelStatutValue;
        private System.Windows.Forms.Label labelNoVolValue;
        private System.Windows.Forms.Label labelEssence;
        private System.Windows.Forms.Label labelTempsRestantTitre;
        private System.Windows.Forms.Label labelNbPassagersTitre;
        private System.Windows.Forms.Label labelStatutTitre;
        private System.Windows.Forms.Label labelNoVolTitre;
        private System.Windows.Forms.Label labelMinEssence;
        private System.Windows.Forms.Label labelMaxEssence;
        private System.Windows.Forms.ProgressBar progressBarEssence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPosteEssence;
        private System.Windows.Forms.Button buttonAjouterEssence;
    }
}