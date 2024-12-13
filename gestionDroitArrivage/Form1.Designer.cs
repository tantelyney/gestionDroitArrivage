namespace gestionDroitArrivage
{
    partial class Form1
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
            titre = new Label();
            panelNavigation = new Panel();
            menuAccueil = new Label();
            lblFermer = new Label();
            menuTransporteur = new Label();
            menuProprietaire = new Label();
            menuVehicule = new Label();
            menuPayement = new Label();
            menuDroit = new Label();
            menuArrivage = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panelContenu = new Panel();
            label3 = new Label();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenu.SuspendLayout();
            SuspendLayout();
            // 
            // titre
            // 
            titre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titre.BackColor = Color.Black;
            titre.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titre.ForeColor = Color.Goldenrod;
            titre.Location = new Point(-2, 0);
            titre.Name = "titre";
            titre.Size = new Size(1219, 57);
            titre.TabIndex = 2;
            titre.Text = "Gestion de droit d'arrivage";
            titre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelNavigation
            // 
            panelNavigation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelNavigation.BackColor = Color.White;
            panelNavigation.Controls.Add(menuAccueil);
            panelNavigation.Controls.Add(lblFermer);
            panelNavigation.Controls.Add(menuTransporteur);
            panelNavigation.Controls.Add(menuProprietaire);
            panelNavigation.Controls.Add(menuVehicule);
            panelNavigation.Controls.Add(menuPayement);
            panelNavigation.Controls.Add(menuDroit);
            panelNavigation.Controls.Add(menuArrivage);
            panelNavigation.Location = new Point(-2, 110);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(95, 582);
            panelNavigation.TabIndex = 19;
            // 
            // menuAccueil
            // 
            menuAccueil.BackColor = Color.White;
            menuAccueil.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            menuAccueil.Location = new Point(0, 8);
            menuAccueil.Name = "menuAccueil";
            menuAccueil.Size = new Size(95, 35);
            menuAccueil.TabIndex = 37;
            menuAccueil.Text = "Accueil";
            menuAccueil.TextAlign = ContentAlignment.MiddleCenter;
            menuAccueil.MouseClick += menuAccueil_MouseClick;
            menuAccueil.MouseEnter += menuAccueil_MouseEnter;
            menuAccueil.MouseLeave += menuAccueil_MouseLeave;
            // 
            // lblFermer
            // 
            lblFermer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFermer.BackColor = Color.White;
            lblFermer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblFermer.Location = new Point(0, 547);
            lblFermer.Name = "lblFermer";
            lblFermer.Size = new Size(95, 35);
            lblFermer.TabIndex = 36;
            lblFermer.Text = "Fermer";
            lblFermer.TextAlign = ContentAlignment.MiddleCenter;
            lblFermer.Click += lblFermer_Click;
            lblFermer.MouseClick += lblFermer_MouseClick;
            lblFermer.MouseEnter += lblFermer_MouseEnter;
            lblFermer.MouseLeave += lblFermer_MouseLeave;
            // 
            // menuTransporteur
            // 
            menuTransporteur.BackColor = Color.White;
            menuTransporteur.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            menuTransporteur.Location = new Point(0, 179);
            menuTransporteur.Name = "menuTransporteur";
            menuTransporteur.Size = new Size(95, 35);
            menuTransporteur.TabIndex = 5;
            menuTransporteur.Text = "Transporteur";
            menuTransporteur.TextAlign = ContentAlignment.MiddleCenter;
            menuTransporteur.MouseClick += menuTransporteur_MouseClick;
            menuTransporteur.MouseEnter += menuTransporteur_MouseEnter;
            menuTransporteur.MouseLeave += menuTransporteur_MouseLeave;
            menuTransporteur.MouseHover += menuTransporteur_MouseHover;
            // 
            // menuProprietaire
            // 
            menuProprietaire.BackColor = Color.White;
            menuProprietaire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            menuProprietaire.Location = new Point(0, 145);
            menuProprietaire.Name = "menuProprietaire";
            menuProprietaire.Size = new Size(95, 35);
            menuProprietaire.TabIndex = 4;
            menuProprietaire.Text = "Proprietaire";
            menuProprietaire.TextAlign = ContentAlignment.MiddleCenter;
            menuProprietaire.MouseClick += menuProprietaire_MouseClick;
            menuProprietaire.MouseEnter += menuProprietaire_MouseEnter;
            menuProprietaire.MouseLeave += menuProprietaire_MouseLeave;
            // 
            // menuVehicule
            // 
            menuVehicule.BackColor = Color.White;
            menuVehicule.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            menuVehicule.Location = new Point(0, 214);
            menuVehicule.Name = "menuVehicule";
            menuVehicule.Size = new Size(95, 35);
            menuVehicule.TabIndex = 3;
            menuVehicule.Text = "Véhicule";
            menuVehicule.TextAlign = ContentAlignment.MiddleCenter;
            menuVehicule.MouseClick += menuVehicule_MouseClick;
            menuVehicule.MouseEnter += menuVehicule_MouseEnter;
            menuVehicule.MouseLeave += menuVehicule_MouseLeave;
            // 
            // menuPayement
            // 
            menuPayement.BackColor = Color.White;
            menuPayement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            menuPayement.Location = new Point(0, 111);
            menuPayement.Name = "menuPayement";
            menuPayement.Size = new Size(95, 35);
            menuPayement.TabIndex = 2;
            menuPayement.Text = "Payement";
            menuPayement.TextAlign = ContentAlignment.MiddleCenter;
            menuPayement.MouseClick += menuPayement_MouseClick;
            menuPayement.MouseEnter += menuPayement_MouseEnter;
            menuPayement.MouseLeave += menuPayement_MouseLeave;
            // 
            // menuDroit
            // 
            menuDroit.BackColor = Color.White;
            menuDroit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            menuDroit.Location = new Point(0, 76);
            menuDroit.Name = "menuDroit";
            menuDroit.Size = new Size(95, 35);
            menuDroit.TabIndex = 1;
            menuDroit.Text = "Droit";
            menuDroit.TextAlign = ContentAlignment.MiddleCenter;
            menuDroit.MouseClick += menuDroit_MouseClick;
            menuDroit.MouseEnter += menuDroit_MouseEnter;
            menuDroit.MouseLeave += menuDroit_MouseLeave;
            // 
            // menuArrivage
            // 
            menuArrivage.BackColor = Color.White;
            menuArrivage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            menuArrivage.Location = new Point(0, 42);
            menuArrivage.Name = "menuArrivage";
            menuArrivage.Size = new Size(95, 35);
            menuArrivage.TabIndex = 0;
            menuArrivage.Text = "Arrivage";
            menuArrivage.TextAlign = ContentAlignment.MiddleCenter;
            menuArrivage.Enter += menuArrivage_Enter;
            menuArrivage.MouseClick += menuArrivage_MouseClick;
            menuArrivage.MouseEnter += menuArrivage_MouseEnter;
            menuArrivage.MouseLeave += menuArrivage_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoFianarantsoa;
            pictureBox1.Location = new Point(26, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(-2, 57);
            label1.Name = "label1";
            label1.Size = new Size(1219, 31);
            label1.TabIndex = 30;
            label1.Text = "Commune Urbaine de Fianarantsoa\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.DarkGray;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(-2, 88);
            label2.Name = "label2";
            label2.Size = new Size(1219, 31);
            label2.TabIndex = 31;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContenu
            // 
            panelContenu.BackgroundImageLayout = ImageLayout.Zoom;
            panelContenu.Controls.Add(label3);
            panelContenu.Controls.Add(plotView2);
            panelContenu.Controls.Add(plotView1);
            panelContenu.Location = new Point(110, 135);
            panelContenu.Name = "panelContenu";
            panelContenu.Size = new Size(1092, 547);
            panelContenu.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(670, 376);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 3;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plotView2
            // 
            plotView2.Location = new Point(550, 0);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(542, 351);
            plotView2.TabIndex = 1;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(0, 0);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(544, 351);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1214, 694);
            Controls.Add(panelContenu);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelNavigation);
            Controls.Add(titre);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de droit d'arrivage";
            Load += Form1_Load;
            panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenu.ResumeLayout(false);
            panelContenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label titre;
        private Panel panelNavigation;
        private Label menuArrivage;
        private Label menuTransporteur;
        private Label menuProprietaire;
        private Label menuVehicule;
        private Label menuPayement;
        private Label menuDroit;
        private Label label1;
        private Label label2;
        private Label lblFermer;
        private Panel panelContenu;
        private PictureBox pictureBox1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Label menuAccueil;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private Label label3;
    }
}
