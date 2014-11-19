namespace ProjetAeroport
{
    partial class FormMain
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
            this.menuStripControl = new System.Windows.Forms.MenuStrip();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attérissagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.décollagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrôlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerVertical = new System.Windows.Forms.SplitContainer();
            this.listBoxNouvelles = new System.Windows.Forms.ListBox();
            this.splitContainerAeroport = new System.Windows.Forms.SplitContainer();
            this.listBoxAtterissage = new System.Windows.Forms.ListBox();
            this.splitContainerControls = new System.Windows.Forms.SplitContainer();
            this.listBoxDecollage = new System.Windows.Forms.ListBox();
            this.labelTempsValeur = new System.Windows.Forms.Label();
            this.labelTempsLabel = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.backgroundWorkerGenerator = new System.ComponentModel.BackgroundWorker();
            this.timerGenerate = new System.Windows.Forms.Timer(this.components);
            this.menuStripControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).BeginInit();
            this.splitContainerVertical.Panel1.SuspendLayout();
            this.splitContainerVertical.Panel2.SuspendLayout();
            this.splitContainerVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAeroport)).BeginInit();
            this.splitContainerAeroport.Panel1.SuspendLayout();
            this.splitContainerAeroport.Panel2.SuspendLayout();
            this.splitContainerAeroport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControls)).BeginInit();
            this.splitContainerControls.Panel1.SuspendLayout();
            this.splitContainerControls.Panel2.SuspendLayout();
            this.splitContainerControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripControl
            // 
            this.menuStripControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageToolStripMenuItem});
            this.menuStripControl.Location = new System.Drawing.Point(0, 0);
            this.menuStripControl.Name = "menuStripControl";
            this.menuStripControl.Size = new System.Drawing.Size(796, 24);
            this.menuStripControl.TabIndex = 0;
            this.menuStripControl.Text = "menuStripControl";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellesToolStripMenuItem,
            this.attérissagesToolStripMenuItem,
            this.décollagesToolStripMenuItem,
            this.contrôlesToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // nouvellesToolStripMenuItem
            // 
            this.nouvellesToolStripMenuItem.Name = "nouvellesToolStripMenuItem";
            this.nouvellesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.nouvellesToolStripMenuItem.Text = "Nouvelles";
            this.nouvellesToolStripMenuItem.Click += new System.EventHandler(this.nouvellesToolStripMenuItem_Click);
            // 
            // attérissagesToolStripMenuItem
            // 
            this.attérissagesToolStripMenuItem.Name = "attérissagesToolStripMenuItem";
            this.attérissagesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.attérissagesToolStripMenuItem.Text = "Atterissages";
            this.attérissagesToolStripMenuItem.Click += new System.EventHandler(this.atterissagesToolStripMenuItem_Click);
            // 
            // décollagesToolStripMenuItem
            // 
            this.décollagesToolStripMenuItem.Name = "décollagesToolStripMenuItem";
            this.décollagesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.décollagesToolStripMenuItem.Text = "Décollages";
            this.décollagesToolStripMenuItem.Click += new System.EventHandler(this.décollagesToolStripMenuItem_Click);
            // 
            // contrôlesToolStripMenuItem
            // 
            this.contrôlesToolStripMenuItem.Name = "contrôlesToolStripMenuItem";
            this.contrôlesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.contrôlesToolStripMenuItem.Text = "Contrôles";
            this.contrôlesToolStripMenuItem.Click += new System.EventHandler(this.contrôlesToolStripMenuItem_Click);
            // 
            // splitContainerVertical
            // 
            this.splitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVertical.Location = new System.Drawing.Point(0, 24);
            this.splitContainerVertical.Name = "splitContainerVertical";
            this.splitContainerVertical.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerVertical.Panel1
            // 
            this.splitContainerVertical.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerVertical.Panel1.Controls.Add(this.listBoxNouvelles);
            // 
            // splitContainerVertical.Panel2
            // 
            this.splitContainerVertical.Panel2.Controls.Add(this.splitContainerAeroport);
            this.splitContainerVertical.Size = new System.Drawing.Size(796, 390);
            this.splitContainerVertical.SplitterDistance = 98;
            this.splitContainerVertical.TabIndex = 1;
            // 
            // listBoxNouvelles
            // 
            this.listBoxNouvelles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNouvelles.FormattingEnabled = true;
            this.listBoxNouvelles.Location = new System.Drawing.Point(0, 0);
            this.listBoxNouvelles.Name = "listBoxNouvelles";
            this.listBoxNouvelles.Size = new System.Drawing.Size(796, 98);
            this.listBoxNouvelles.TabIndex = 0;
            // 
            // splitContainerAeroport
            // 
            this.splitContainerAeroport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAeroport.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAeroport.Name = "splitContainerAeroport";
            // 
            // splitContainerAeroport.Panel1
            // 
            this.splitContainerAeroport.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerAeroport.Panel1.Controls.Add(this.listBoxAtterissage);
            // 
            // splitContainerAeroport.Panel2
            // 
            this.splitContainerAeroport.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerAeroport.Panel2.Controls.Add(this.splitContainerControls);
            this.splitContainerAeroport.Size = new System.Drawing.Size(796, 288);
            this.splitContainerAeroport.SplitterDistance = 264;
            this.splitContainerAeroport.TabIndex = 0;
            // 
            // listBoxAtterissage
            // 
            this.listBoxAtterissage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAtterissage.FormattingEnabled = true;
            this.listBoxAtterissage.Location = new System.Drawing.Point(0, 0);
            this.listBoxAtterissage.Name = "listBoxAtterissage";
            this.listBoxAtterissage.Size = new System.Drawing.Size(264, 288);
            this.listBoxAtterissage.TabIndex = 0;
            // 
            // splitContainerControls
            // 
            this.splitContainerControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControls.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControls.Name = "splitContainerControls";
            // 
            // splitContainerControls.Panel1
            // 
            this.splitContainerControls.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerControls.Panel1.Controls.Add(this.listBoxDecollage);
            // 
            // splitContainerControls.Panel2
            // 
            this.splitContainerControls.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerControls.Panel2.Controls.Add(this.labelTempsValeur);
            this.splitContainerControls.Panel2.Controls.Add(this.labelTempsLabel);
            this.splitContainerControls.Panel2.Controls.Add(this.buttonStop);
            this.splitContainerControls.Panel2.Controls.Add(this.buttonStart);
            this.splitContainerControls.Size = new System.Drawing.Size(528, 288);
            this.splitContainerControls.SplitterDistance = 273;
            this.splitContainerControls.TabIndex = 0;
            // 
            // listBoxDecollage
            // 
            this.listBoxDecollage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDecollage.FormattingEnabled = true;
            this.listBoxDecollage.Location = new System.Drawing.Point(0, 0);
            this.listBoxDecollage.Name = "listBoxDecollage";
            this.listBoxDecollage.Size = new System.Drawing.Size(273, 288);
            this.listBoxDecollage.TabIndex = 0;
            // 
            // labelTempsValeur
            // 
            this.labelTempsValeur.AutoSize = true;
            this.labelTempsValeur.Location = new System.Drawing.Point(163, 29);
            this.labelTempsValeur.Name = "labelTempsValeur";
            this.labelTempsValeur.Size = new System.Drawing.Size(49, 13);
            this.labelTempsValeur.TabIndex = 3;
            this.labelTempsValeur.Text = "00:00:00";
            // 
            // labelTempsLabel
            // 
            this.labelTempsLabel.AutoSize = true;
            this.labelTempsLabel.Location = new System.Drawing.Point(115, 29);
            this.labelTempsLabel.Name = "labelTempsLabel";
            this.labelTempsLabel.Size = new System.Drawing.Size(42, 13);
            this.labelTempsLabel.TabIndex = 2;
            this.labelTempsLabel.Text = "Temps:";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(20, 54);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Arrêter";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(20, 24);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Démarrer";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // backgroundWorkerGenerator
            // 
            this.backgroundWorkerGenerator.WorkerReportsProgress = true;
            this.backgroundWorkerGenerator.WorkerSupportsCancellation = true;
            this.backgroundWorkerGenerator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGenerator_DoWork);
            // 
            // timerGenerate
            // 
            this.timerGenerate.Interval = 1000;
            this.timerGenerate.Tick += new System.EventHandler(this.timerGenerate_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 414);
            this.Controls.Add(this.splitContainerVertical);
            this.Controls.Add(this.menuStripControl);
            this.MainMenuStrip = this.menuStripControl;
            this.Name = "FormMain";
            this.Text = "Gestion d\'aéroport";
            this.menuStripControl.ResumeLayout(false);
            this.menuStripControl.PerformLayout();
            this.splitContainerVertical.Panel1.ResumeLayout(false);
            this.splitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).EndInit();
            this.splitContainerVertical.ResumeLayout(false);
            this.splitContainerAeroport.Panel1.ResumeLayout(false);
            this.splitContainerAeroport.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAeroport)).EndInit();
            this.splitContainerAeroport.ResumeLayout(false);
            this.splitContainerControls.Panel1.ResumeLayout(false);
            this.splitContainerControls.Panel2.ResumeLayout(false);
            this.splitContainerControls.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControls)).EndInit();
            this.splitContainerControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripControl;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvellesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attérissagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem décollagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrôlesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerVertical;
        private System.Windows.Forms.SplitContainer splitContainerAeroport;
        private System.Windows.Forms.SplitContainer splitContainerControls;
        private System.Windows.Forms.ListBox listBoxNouvelles;
        private System.Windows.Forms.ListBox listBoxAtterissage;
        private System.Windows.Forms.ListBox listBoxDecollage;
        private System.Windows.Forms.Label labelTempsValeur;
        private System.Windows.Forms.Label labelTempsLabel;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGenerator;
        private System.Windows.Forms.Timer timerGenerate;


    }
}

