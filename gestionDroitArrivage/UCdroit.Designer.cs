namespace gestionDroitArrivage
{
    partial class UCdroit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnModif = new Button();
            comboBoxRefDroit = new ComboBox();
            btnSuppr = new Button();
            panel2 = new Panel();
            champRefDroit = new TextBox();
            champTarif = new TextBox();
            lblTarif = new Label();
            lblRefDroit = new Label();
            btnEnregistrer = new Button();
            lblRefMarchandise = new Label();
            champRefMarchandise = new TextBox();
            lblDroit = new Label();
            label4 = new Label();
            textBoxRecherche = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnAnnuler = new Button();
            btnAjout = new Button();
            panel1 = new Panel();
            champLibelle = new TextBox();
            lblLibelle = new Label();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnModif
            // 
            btnModif.BackColor = Color.White;
            btnModif.FlatAppearance.BorderColor = Color.SandyBrown;
            btnModif.FlatAppearance.CheckedBackColor = Color.PeachPuff;
            btnModif.FlatAppearance.MouseDownBackColor = Color.White;
            btnModif.FlatAppearance.MouseOverBackColor = Color.BlanchedAlmond;
            btnModif.FlatStyle = FlatStyle.Flat;
            btnModif.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnModif.ForeColor = Color.Black;
            btnModif.Location = new Point(209, 499);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(147, 33);
            btnModif.TabIndex = 55;
            btnModif.Text = "Modifier";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
            // 
            // comboBoxRefDroit
            // 
            comboBoxRefDroit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            comboBoxRefDroit.FormattingEnabled = true;
            comboBoxRefDroit.Location = new Point(53, 140);
            comboBoxRefDroit.Name = "comboBoxRefDroit";
            comboBoxRefDroit.Size = new Size(275, 25);
            comboBoxRefDroit.TabIndex = 24;
            comboBoxRefDroit.Leave += comboBoxRefDroit_Leave;
            // 
            // btnSuppr
            // 
            btnSuppr.BackColor = Color.White;
            btnSuppr.FlatAppearance.BorderColor = Color.SandyBrown;
            btnSuppr.FlatAppearance.CheckedBackColor = Color.PeachPuff;
            btnSuppr.FlatAppearance.MouseDownBackColor = Color.White;
            btnSuppr.FlatAppearance.MouseOverBackColor = Color.BlanchedAlmond;
            btnSuppr.FlatStyle = FlatStyle.Flat;
            btnSuppr.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSuppr.ForeColor = Color.Black;
            btnSuppr.Location = new Point(362, 499);
            btnSuppr.Name = "btnSuppr";
            btnSuppr.Size = new Size(152, 33);
            btnSuppr.TabIndex = 56;
            btnSuppr.Text = "Supprimer";
            btnSuppr.UseVisualStyleBackColor = false;
            btnSuppr.Click += btnSuppr_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(champRefDroit);
            panel2.Controls.Add(champTarif);
            panel2.Controls.Add(lblTarif);
            panel2.Controls.Add(lblRefDroit);
            panel2.Controls.Add(btnEnregistrer);
            panel2.Location = new Point(718, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 216);
            panel2.TabIndex = 58;
            // 
            // champRefDroit
            // 
            champRefDroit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champRefDroit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champRefDroit.Location = new Point(40, 55);
            champRefDroit.Name = "champRefDroit";
            champRefDroit.Size = new Size(269, 25);
            champRefDroit.TabIndex = 30;
            champRefDroit.TextChanged += champRefDroit_TextChanged;
            champRefDroit.KeyUp += champRefDroit_KeyUp;
            // 
            // champTarif
            // 
            champTarif.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champTarif.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champTarif.Location = new Point(40, 107);
            champTarif.Name = "champTarif";
            champTarif.Size = new Size(269, 25);
            champTarif.TabIndex = 9;
            champTarif.TextChanged += champTarif_TextChanged;
            champTarif.KeyUp += champTarif_KeyUp;
            // 
            // lblTarif
            // 
            lblTarif.AutoSize = true;
            lblTarif.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTarif.Location = new Point(43, 87);
            lblTarif.Name = "lblTarif";
            lblTarif.Size = new Size(40, 17);
            lblTarif.TabIndex = 8;
            lblTarif.Text = "Tarif :";
            // 
            // lblRefDroit
            // 
            lblRefDroit.AutoSize = true;
            lblRefDroit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblRefDroit.Location = new Point(43, 35);
            lblRefDroit.Name = "lblRefDroit";
            lblRefDroit.Size = new Size(107, 17);
            lblRefDroit.TabIndex = 10;
            lblRefDroit.Text = "Référence droit :";
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEnregistrer.BackColor = Color.BlanchedAlmond;
            btnEnregistrer.FlatAppearance.BorderColor = Color.BlanchedAlmond;
            btnEnregistrer.FlatAppearance.MouseDownBackColor = Color.BlanchedAlmond;
            btnEnregistrer.FlatAppearance.MouseOverBackColor = Color.PeachPuff;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEnregistrer.Location = new Point(40, 157);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(269, 33);
            btnEnregistrer.TabIndex = 25;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // lblRefMarchandise
            // 
            lblRefMarchandise.AutoSize = true;
            lblRefMarchandise.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblRefMarchandise.Location = new Point(53, 12);
            lblRefMarchandise.Name = "lblRefMarchandise";
            lblRefMarchandise.Size = new Size(155, 17);
            lblRefMarchandise.TabIndex = 15;
            lblRefMarchandise.Text = "Référence marchandise :";
            // 
            // champRefMarchandise
            // 
            champRefMarchandise.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champRefMarchandise.Location = new Point(53, 32);
            champRefMarchandise.Name = "champRefMarchandise";
            champRefMarchandise.Size = new Size(275, 25);
            champRefMarchandise.TabIndex = 22;
            champRefMarchandise.TextChanged += champRefMarchandise_TextChanged;
            // 
            // lblDroit
            // 
            lblDroit.AutoSize = true;
            lblDroit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDroit.Location = new Point(56, 120);
            lblDroit.Name = "lblDroit";
            lblDroit.Size = new Size(107, 17);
            lblDroit.TabIndex = 12;
            lblDroit.Text = "Référence droit :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Moccasin;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(718, 25);
            label4.Name = "label4";
            label4.Size = new Size(348, 37);
            label4.TabIndex = 61;
            label4.Text = "Formulaire droit d'arrivage";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.BackColor = Color.OldLace;
            textBoxRecherche.BorderStyle = BorderStyle.FixedSingle;
            textBoxRecherche.Cursor = Cursors.IBeam;
            textBoxRecherche.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            textBoxRecherche.ForeColor = Color.Black;
            textBoxRecherche.Location = new Point(104, 31);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.PlaceholderText = "libellé marchandise";
            textBoxRecherche.Size = new Size(175, 25);
            textBoxRecherche.TabIndex = 60;
            textBoxRecherche.KeyUp += textBoxRecherche_KeyUp;
            // 
            // label3
            // 
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 24);
            label3.Name = "label3";
            label3.Size = new Size(661, 37);
            label3.TabIndex = 59;
            label3.Text = "Recherche ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(661, 198);
            dataGridView1.TabIndex = 57;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.White;
            btnAnnuler.FlatAppearance.BorderColor = Color.SandyBrown;
            btnAnnuler.FlatAppearance.CheckedBackColor = Color.PeachPuff;
            btnAnnuler.FlatAppearance.MouseDownBackColor = Color.White;
            btnAnnuler.FlatAppearance.MouseOverBackColor = Color.BlanchedAlmond;
            btnAnnuler.FlatStyle = FlatStyle.Flat;
            btnAnnuler.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.Black;
            btnAnnuler.Location = new Point(520, 499);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(141, 33);
            btnAnnuler.TabIndex = 62;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnAjout
            // 
            btnAjout.BackColor = Color.White;
            btnAjout.FlatAppearance.BorderColor = Color.SandyBrown;
            btnAjout.FlatAppearance.CheckedBackColor = Color.PeachPuff;
            btnAjout.FlatAppearance.MouseDownBackColor = Color.White;
            btnAjout.FlatAppearance.MouseOverBackColor = Color.BlanchedAlmond;
            btnAjout.FlatStyle = FlatStyle.Flat;
            btnAjout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAjout.ForeColor = Color.Black;
            btnAjout.Location = new Point(55, 499);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(148, 33);
            btnAjout.TabIndex = 54;
            btnAjout.Text = "Ajouter";
            btnAjout.UseVisualStyleBackColor = false;
            btnAjout.Click += btnAjout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(champLibelle);
            panel1.Controls.Add(lblLibelle);
            panel1.Controls.Add(champRefMarchandise);
            panel1.Controls.Add(lblRefMarchandise);
            panel1.Controls.Add(comboBoxRefDroit);
            panel1.Controls.Add(lblDroit);
            panel1.Location = new Point(28, 298);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 183);
            panel1.TabIndex = 64;
            // 
            // champLibelle
            // 
            champLibelle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champLibelle.Location = new Point(53, 85);
            champLibelle.Name = "champLibelle";
            champLibelle.Size = new Size(275, 25);
            champLibelle.TabIndex = 24;
            champLibelle.TextChanged += champLibelle_TextChanged;
            // 
            // lblLibelle
            // 
            lblLibelle.AutoSize = true;
            lblLibelle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblLibelle.Location = new Point(53, 65);
            lblLibelle.Name = "lblLibelle";
            lblLibelle.Size = new Size(133, 17);
            lblLibelle.TabIndex = 23;
            lblLibelle.Text = "Libellé marchandise :";
            // 
            // label5
            // 
            label5.BackColor = Color.Moccasin;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 262);
            label5.Name = "label5";
            label5.Size = new Size(661, 37);
            label5.TabIndex = 65;
            label5.Text = "Formulaire marchandise";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(718, 283);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(348, 198);
            dataGridView2.TabIndex = 66;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Moccasin;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 485);
            label1.Name = "label1";
            label1.Size = new Size(1036, 58);
            label1.TabIndex = 87;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UCdroit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(btnModif);
            Controls.Add(btnSuppr);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(textBoxRecherche);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnAnnuler);
            Controls.Add(btnAjout);
            Controls.Add(label1);
            Name = "UCdroit";
            Size = new Size(1092, 547);
            Load += UserControlDroit_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModif;
        private ComboBox comboBoxRefDroit;
        private Button btnSuppr;
        private Panel panel2;
        private TextBox champTarif;
        private Button btnEnregistrer;
        private Label lblRefMarchandise;
        private TextBox champRefMarchandise;
        private DateTimePicker dateTimeArrivage;
        private Label lblDroit;
        private Label lblTarif;
        private Label lblRefDroit;
        private Label label4;
        private TextBox textBoxRecherche;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnAnnuler;
        private Button btnAjout;
        private TextBox champRefDroit;
        private Panel panel1;
        private Label label5;
        private TextBox champLibelle;
        private Label lblLibelle;
        private DataGridView dataGridView2;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}
