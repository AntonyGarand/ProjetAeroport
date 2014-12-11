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
            this.listBoxEntenteAtterissage = new System.Windows.Forms.ListBox();
            this.listBoxAtterissage = new System.Windows.Forms.ListBox();
            this.splitContainerControls = new System.Windows.Forms.SplitContainer();
            this.listBoxEnteteDecollage = new System.Windows.Forms.ListBox();
            this.listBoxDecollage = new System.Windows.Forms.ListBox();
            this.groupBoxPistes = new System.Windows.Forms.GroupBox();
            this.comboBoxPisteSelectionne = new System.Windows.Forms.ComboBox();
            this.labelAvionValue = new System.Windows.Forms.Label();
            this.labelAvionTitre = new System.Windows.Forms.Label();
            this.labelStatutValue = new System.Windows.Forms.Label();
            this.labelStatutTitre = new System.Windows.Forms.Label();
            this.labelPisteSelectionneTitre = new System.Windows.Forms.Label();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.labelCodeValue = new System.Windows.Forms.Label();
            this.labelCodeTitre = new System.Windows.Forms.Label();
            this.labelVilleValue = new System.Windows.Forms.Label();
            this.labelVilleTitre = new System.Windows.Forms.Label();
            this.labelNomValue = new System.Windows.Forms.Label();
            this.labelNomTitre = new System.Windows.Forms.Label();
            this.groupBoxPanneauControle = new System.Windows.Forms.GroupBox();
            this.labelCapaciteValue = new System.Windows.Forms.Label();
            this.labelCapaciteTitre = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.labelTempsValeur = new System.Windows.Forms.Label();
            this.labelTempsLabel = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.backgroundWorkerGenerator = new System.ComponentModel.BackgroundWorker();
            this.timerGenerate = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerGetNews = new System.ComponentModel.BackgroundWorker();
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
            this.groupBoxPistes.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.groupBoxPanneauControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripControl
            // 
            this.menuStripControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageToolStripMenuItem});
            this.menuStripControl.Location = new System.Drawing.Point(0, 0);
            this.menuStripControl.Name = "menuStripControl";
            this.menuStripControl.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripControl.Size = new System.Drawing.Size(1194, 25);
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
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
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
            this.splitContainerVertical.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerVertical.IsSplitterFixed = true;
            this.splitContainerVertical.Location = new System.Drawing.Point(0, 25);
            this.splitContainerVertical.Margin = new System.Windows.Forms.Padding(5);
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
            this.splitContainerVertical.Size = new System.Drawing.Size(1194, 612);
            this.splitContainerVertical.SplitterDistance = 153;
            this.splitContainerVertical.SplitterWidth = 1;
            this.splitContainerVertical.TabIndex = 1;
            // 
            // listBoxNouvelles
            // 
            this.listBoxNouvelles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNouvelles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxNouvelles.FormattingEnabled = true;
            this.listBoxNouvelles.ItemHeight = 20;
            this.listBoxNouvelles.Location = new System.Drawing.Point(0, 0);
            this.listBoxNouvelles.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxNouvelles.Name = "listBoxNouvelles";
            this.listBoxNouvelles.Size = new System.Drawing.Size(1194, 153);
            this.listBoxNouvelles.TabIndex = 0;
            this.listBoxNouvelles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstBox_DrawItem);
            // 
            // splitContainerAeroport
            // 
            this.splitContainerAeroport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAeroport.IsSplitterFixed = true;
            this.splitContainerAeroport.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAeroport.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainerAeroport.Name = "splitContainerAeroport";
            // 
            // splitContainerAeroport.Panel1
            // 
            this.splitContainerAeroport.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerAeroport.Panel1.Controls.Add(this.listBoxEntenteAtterissage);
            this.splitContainerAeroport.Panel1.Controls.Add(this.listBoxAtterissage);
            // 
            // splitContainerAeroport.Panel2
            // 
            this.splitContainerAeroport.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerAeroport.Panel2.Controls.Add(this.splitContainerControls);
            this.splitContainerAeroport.Size = new System.Drawing.Size(1194, 458);
            this.splitContainerAeroport.SplitterDistance = 396;
            this.splitContainerAeroport.SplitterWidth = 1;
            this.splitContainerAeroport.TabIndex = 0;
            // 
            // listBoxEntenteAtterissage
            // 
            this.listBoxEntenteAtterissage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBoxEntenteAtterissage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBoxEntenteAtterissage.FormattingEnabled = true;
            this.listBoxEntenteAtterissage.ItemHeight = 20;
            this.listBoxEntenteAtterissage.Items.AddRange(new object[] {
            "NoVol\tTemps restants\tNbPassagers\t"});
            this.listBoxEntenteAtterissage.Location = new System.Drawing.Point(0, 7);
            this.listBoxEntenteAtterissage.MultiColumn = true;
            this.listBoxEntenteAtterissage.Name = "listBoxEntenteAtterissage";
            this.listBoxEntenteAtterissage.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxEntenteAtterissage.Size = new System.Drawing.Size(396, 24);
            this.listBoxEntenteAtterissage.TabIndex = 1;
            // 
            // listBoxAtterissage
            // 
            this.listBoxAtterissage.BackColor = System.Drawing.Color.White;
            this.listBoxAtterissage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxAtterissage.FormattingEnabled = true;
            this.listBoxAtterissage.ItemHeight = 20;
            this.listBoxAtterissage.Location = new System.Drawing.Point(0, 34);
            this.listBoxAtterissage.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxAtterissage.Name = "listBoxAtterissage";
            this.listBoxAtterissage.Size = new System.Drawing.Size(396, 424);
            this.listBoxAtterissage.TabIndex = 0;
            this.listBoxAtterissage.DoubleClick += new System.EventHandler(this.listBoxAtterissage_DoubleClick);
            // 
            // splitContainerControls
            // 
            this.splitContainerControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControls.IsSplitterFixed = true;
            this.splitContainerControls.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControls.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainerControls.Name = "splitContainerControls";
            // 
            // splitContainerControls.Panel1
            // 
            this.splitContainerControls.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerControls.Panel1.Controls.Add(this.listBoxEnteteDecollage);
            this.splitContainerControls.Panel1.Controls.Add(this.listBoxDecollage);
            // 
            // splitContainerControls.Panel2
            // 
            this.splitContainerControls.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerControls.Panel2.Controls.Add(this.groupBoxPistes);
            this.splitContainerControls.Panel2.Controls.Add(this.groupBoxInformation);
            this.splitContainerControls.Panel2.Controls.Add(this.groupBoxPanneauControle);
            this.splitContainerControls.Size = new System.Drawing.Size(797, 458);
            this.splitContainerControls.SplitterDistance = 411;
            this.splitContainerControls.SplitterWidth = 1;
            this.splitContainerControls.TabIndex = 0;
            // 
            // listBoxEnteteDecollage
            // 
            this.listBoxEnteteDecollage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBoxEnteteDecollage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBoxEnteteDecollage.FormattingEnabled = true;
            this.listBoxEnteteDecollage.ItemHeight = 20;
            this.listBoxEnteteDecollage.Items.AddRange(new object[] {
            "NoVol\tTemps restants\tNbPassagers\t"});
            this.listBoxEnteteDecollage.Location = new System.Drawing.Point(0, 7);
            this.listBoxEnteteDecollage.MultiColumn = true;
            this.listBoxEnteteDecollage.Name = "listBoxEnteteDecollage";
            this.listBoxEnteteDecollage.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxEnteteDecollage.Size = new System.Drawing.Size(408, 24);
            this.listBoxEnteteDecollage.TabIndex = 2;
            // 
            // listBoxDecollage
            // 
            this.listBoxDecollage.BackColor = System.Drawing.Color.White;
            this.listBoxDecollage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxDecollage.FormattingEnabled = true;
            this.listBoxDecollage.ItemHeight = 20;
            this.listBoxDecollage.Location = new System.Drawing.Point(0, 34);
            this.listBoxDecollage.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxDecollage.Name = "listBoxDecollage";
            this.listBoxDecollage.Size = new System.Drawing.Size(411, 424);
            this.listBoxDecollage.TabIndex = 0;

            // 
            // groupBoxPistes
            // 
            this.groupBoxPistes.BackColor = System.Drawing.Color.White;
            this.groupBoxPistes.Controls.Add(this.comboBoxPisteSelectionne);
            this.groupBoxPistes.Controls.Add(this.labelAvionValue);
            this.groupBoxPistes.Controls.Add(this.labelAvionTitre);
            this.groupBoxPistes.Controls.Add(this.labelStatutValue);
            this.groupBoxPistes.Controls.Add(this.labelStatutTitre);
            this.groupBoxPistes.Controls.Add(this.labelPisteSelectionneTitre);
            this.groupBoxPistes.Location = new System.Drawing.Point(6, 278);
            this.groupBoxPistes.Name = "groupBoxPistes";
            this.groupBoxPistes.Size = new System.Drawing.Size(368, 108);
            this.groupBoxPistes.TabIndex = 7;
            this.groupBoxPistes.TabStop = false;
            this.groupBoxPistes.Text = "Information Pistes";
            // 
            // comboBoxPisteSelectionne
            // 
            this.comboBoxPisteSelectionne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPisteSelectionne.FormattingEnabled = true;
            this.comboBoxPisteSelectionne.Location = new System.Drawing.Point(156, 19);
            this.comboBoxPisteSelectionne.Name = "comboBoxPisteSelectionne";
            this.comboBoxPisteSelectionne.Size = new System.Drawing.Size(203, 28);
            this.comboBoxPisteSelectionne.TabIndex = 9;
            this.comboBoxPisteSelectionne.SelectedIndexChanged += new System.EventHandler(this.comboBoxPisteSelectionne_SelectedIndexChanged);
            // 
            // labelAvionValue
            // 
            this.labelAvionValue.AutoSize = true;
            this.labelAvionValue.Location = new System.Drawing.Point(151, 79);
            this.labelAvionValue.Name = "labelAvionValue";
            this.labelAvionValue.Size = new System.Drawing.Size(0, 20);
            this.labelAvionValue.TabIndex = 8;
            // 
            // labelAvionTitre
            // 
            this.labelAvionTitre.AutoSize = true;
            this.labelAvionTitre.Location = new System.Drawing.Point(8, 79);
            this.labelAvionTitre.Name = "labelAvionTitre";
            this.labelAvionTitre.Size = new System.Drawing.Size(56, 20);
            this.labelAvionTitre.TabIndex = 7;
            this.labelAvionTitre.Text = "Avion :";
            // 
            // labelStatutValue
            // 
            this.labelStatutValue.AutoSize = true;
            this.labelStatutValue.Location = new System.Drawing.Point(151, 59);
            this.labelStatutValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStatutValue.Name = "labelStatutValue";
            this.labelStatutValue.Size = new System.Drawing.Size(0, 20);
            this.labelStatutValue.TabIndex = 6;
            // 
            // labelStatutTitre
            // 
            this.labelStatutTitre.AutoSize = true;
            this.labelStatutTitre.Location = new System.Drawing.Point(8, 59);
            this.labelStatutTitre.Name = "labelStatutTitre";
            this.labelStatutTitre.Size = new System.Drawing.Size(61, 20);
            this.labelStatutTitre.TabIndex = 5;
            this.labelStatutTitre.Text = "Statut :";
            // 
            // labelPisteSelectionneTitre
            // 
            this.labelPisteSelectionneTitre.AutoSize = true;
            this.labelPisteSelectionneTitre.Location = new System.Drawing.Point(8, 22);
            this.labelPisteSelectionneTitre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPisteSelectionneTitre.Name = "labelPisteSelectionneTitre";
            this.labelPisteSelectionneTitre.Size = new System.Drawing.Size(140, 20);
            this.labelPisteSelectionneTitre.TabIndex = 2;
            this.labelPisteSelectionneTitre.Text = "Piste Sélectionné :";
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.BackColor = System.Drawing.Color.White;
            this.groupBoxInformation.Controls.Add(this.labelCodeValue);
            this.groupBoxInformation.Controls.Add(this.labelCodeTitre);
            this.groupBoxInformation.Controls.Add(this.labelVilleValue);
            this.groupBoxInformation.Controls.Add(this.labelVilleTitre);
            this.groupBoxInformation.Controls.Add(this.labelNomValue);
            this.groupBoxInformation.Controls.Add(this.labelNomTitre);
            this.groupBoxInformation.Location = new System.Drawing.Point(6, 178);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(368, 94);
            this.groupBoxInformation.TabIndex = 6;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Statistiques Aeroport";
            // 
            // labelCodeValue
            // 
            this.labelCodeValue.AutoSize = true;
            this.labelCodeValue.Location = new System.Drawing.Point(151, 62);
            this.labelCodeValue.Name = "labelCodeValue";
            this.labelCodeValue.Size = new System.Drawing.Size(0, 20);
            this.labelCodeValue.TabIndex = 8;
            // 
            // labelCodeTitre
            // 
            this.labelCodeTitre.AutoSize = true;
            this.labelCodeTitre.Location = new System.Drawing.Point(8, 62);
            this.labelCodeTitre.Name = "labelCodeTitre";
            this.labelCodeTitre.Size = new System.Drawing.Size(55, 20);
            this.labelCodeTitre.TabIndex = 7;
            this.labelCodeTitre.Text = "Code :";
            // 
            // labelVilleValue
            // 
            this.labelVilleValue.AutoSize = true;
            this.labelVilleValue.Location = new System.Drawing.Point(151, 42);
            this.labelVilleValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVilleValue.Name = "labelVilleValue";
            this.labelVilleValue.Size = new System.Drawing.Size(0, 20);
            this.labelVilleValue.TabIndex = 6;
            // 
            // labelVilleTitre
            // 
            this.labelVilleTitre.AutoSize = true;
            this.labelVilleTitre.Location = new System.Drawing.Point(8, 42);
            this.labelVilleTitre.Name = "labelVilleTitre";
            this.labelVilleTitre.Size = new System.Drawing.Size(46, 20);
            this.labelVilleTitre.TabIndex = 5;
            this.labelVilleTitre.Text = "Ville :";
            // 
            // labelNomValue
            // 
            this.labelNomValue.AutoSize = true;
            this.labelNomValue.Location = new System.Drawing.Point(151, 22);
            this.labelNomValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNomValue.Name = "labelNomValue";
            this.labelNomValue.Size = new System.Drawing.Size(0, 20);
            this.labelNomValue.TabIndex = 3;
            // 
            // labelNomTitre
            // 
            this.labelNomTitre.AutoSize = true;
            this.labelNomTitre.Location = new System.Drawing.Point(8, 22);
            this.labelNomTitre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNomTitre.Name = "labelNomTitre";
            this.labelNomTitre.Size = new System.Drawing.Size(50, 20);
            this.labelNomTitre.TabIndex = 2;
            this.labelNomTitre.Text = "Nom :";
            // 
            // groupBoxPanneauControle
            // 
            this.groupBoxPanneauControle.BackColor = System.Drawing.Color.White;
            this.groupBoxPanneauControle.Controls.Add(this.labelCapaciteValue);
            this.groupBoxPanneauControle.Controls.Add(this.labelCapaciteTitre);
            this.groupBoxPanneauControle.Controls.Add(this.buttonPause);
            this.groupBoxPanneauControle.Controls.Add(this.labelTempsValeur);
            this.groupBoxPanneauControle.Controls.Add(this.labelTempsLabel);
            this.groupBoxPanneauControle.Controls.Add(this.buttonStart);
            this.groupBoxPanneauControle.Controls.Add(this.buttonStop);
            this.groupBoxPanneauControle.Location = new System.Drawing.Point(6, 3);
            this.groupBoxPanneauControle.Name = "groupBoxPanneauControle";
            this.groupBoxPanneauControle.Size = new System.Drawing.Size(368, 169);
            this.groupBoxPanneauControle.TabIndex = 5;
            this.groupBoxPanneauControle.TabStop = false;
            this.groupBoxPanneauControle.Text = "Panneau Contrôle";
            // 
            // labelCapaciteValue
            // 
            this.labelCapaciteValue.AutoSize = true;
            this.labelCapaciteValue.Location = new System.Drawing.Point(231, 85);
            this.labelCapaciteValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCapaciteValue.Name = "labelCapaciteValue";
            this.labelCapaciteValue.Size = new System.Drawing.Size(32, 20);
            this.labelCapaciteValue.TabIndex = 6;
            this.labelCapaciteValue.Text = "0%";
            // 
            // labelCapaciteTitre
            // 
            this.labelCapaciteTitre.AutoSize = true;
            this.labelCapaciteTitre.Location = new System.Drawing.Point(151, 85);
            this.labelCapaciteTitre.Name = "labelCapaciteTitre";
            this.labelCapaciteTitre.Size = new System.Drawing.Size(78, 20);
            this.labelCapaciteTitre.TabIndex = 5;
            this.labelCapaciteTitre.Text = "Utilisation";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(8, 78);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(133, 35);
            this.buttonPause.TabIndex = 4;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // labelTempsValeur
            // 
            this.labelTempsValeur.AutoSize = true;
            this.labelTempsValeur.Location = new System.Drawing.Point(223, 35);
            this.labelTempsValeur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTempsValeur.Name = "labelTempsValeur";
            this.labelTempsValeur.Size = new System.Drawing.Size(71, 20);
            this.labelTempsValeur.TabIndex = 3;
            this.labelTempsValeur.Text = "00:00:00";
            // 
            // labelTempsLabel
            // 
            this.labelTempsLabel.AutoSize = true;
            this.labelTempsLabel.Location = new System.Drawing.Point(151, 35);
            this.labelTempsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTempsLabel.Name = "labelTempsLabel";
            this.labelTempsLabel.Size = new System.Drawing.Size(61, 20);
            this.labelTempsLabel.TabIndex = 2;
            this.labelTempsLabel.Text = "Heure :";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(8, 28);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(133, 35);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Démarrer";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(8, 123);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(133, 35);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Arrêter";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // backgroundWorkerGenerator
            // 
            this.backgroundWorkerGenerator.WorkerReportsProgress = true;
            this.backgroundWorkerGenerator.WorkerSupportsCancellation = true;
            this.backgroundWorkerGenerator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGenerator_DoWork);
            this.backgroundWorkerGenerator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGenerator_RunWorkerCompleted);
            // 
            // timerGenerate
            // 
            this.timerGenerate.Interval = 1000;
            this.timerGenerate.Tick += new System.EventHandler(this.timerGenerate_Tick);
            // 
            // backgroundWorkerGetNews
            // 
            this.backgroundWorkerGetNews.WorkerReportsProgress = true;
            this.backgroundWorkerGetNews.WorkerSupportsCancellation = true;
            this.backgroundWorkerGetNews.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGetNews_DoWork);
            this.backgroundWorkerGetNews.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGetNews_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1194, 637);
            this.Controls.Add(this.splitContainerVertical);
            this.Controls.Add(this.menuStripControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripControl;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.Text = "Gestion d\'aéroport";
            this.Load += new System.EventHandler(this.FormMain_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControls)).EndInit();
            this.splitContainerControls.ResumeLayout(false);
            this.groupBoxPistes.ResumeLayout(false);
            this.groupBoxPistes.PerformLayout();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.groupBoxPanneauControle.ResumeLayout(false);
            this.groupBoxPanneauControle.PerformLayout();
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
        private System.Windows.Forms.ListBox listBoxDecollage;
        private System.Windows.Forms.Label labelTempsValeur;
        private System.Windows.Forms.Label labelTempsLabel;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGenerator;
        private System.Windows.Forms.Timer timerGenerate;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.ListBox listBoxAtterissage;
        private System.Windows.Forms.GroupBox groupBoxPanneauControle;
        private System.Windows.Forms.Label labelCapaciteValue;
        private System.Windows.Forms.Label labelCapaciteTitre;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label labelVilleValue;
        private System.Windows.Forms.Label labelVilleTitre;
        private System.Windows.Forms.Label labelNomValue;
        private System.Windows.Forms.Label labelNomTitre;
        private System.Windows.Forms.Label labelCodeValue;
        private System.Windows.Forms.Label labelCodeTitre;
        private System.Windows.Forms.GroupBox groupBoxPistes;
        private System.Windows.Forms.ComboBox comboBoxPisteSelectionne;
        private System.Windows.Forms.Label labelAvionValue;
        private System.Windows.Forms.Label labelAvionTitre;
        private System.Windows.Forms.Label labelStatutValue;
        private System.Windows.Forms.Label labelStatutTitre;
        private System.Windows.Forms.Label labelPisteSelectionneTitre;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGetNews;
        private System.Windows.Forms.ListBox listBoxEntenteAtterissage;
        private System.Windows.Forms.ListBox listBoxEnteteDecollage;


    }
}

