namespace gestionDroitArrivage
{
    partial class UCvehicule
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
            dataGridView1 = new DataGridView();
            btnAnnuler = new Button();
            textBoxRecherche = new TextBox();
            btnModif = new Button();
            btnEnregistrer = new Button();
            lblNumTransporteur = new Label();
            btnSuppr = new Button();
            panel2 = new Panel();
            comboBoxNumTransporteur = new ComboBox();
            comboBoxRefProprietaire = new ComboBox();
            lblRefProprietaire = new Label();
            champMatricule = new TextBox();
            champTypeVehicule = new TextBox();
            lblType = new Label();
            lblMatricule = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Size = new Size(661, 389);
            dataGridView1.TabIndex = 80;
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
            btnAnnuler.Location = new Point(449, 472);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(188, 33);
            btnAnnuler.TabIndex = 85;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.BackColor = Color.OldLace;
            textBoxRecherche.BorderStyle = BorderStyle.FixedSingle;
            textBoxRecherche.Cursor = Cursors.IBeam;
            textBoxRecherche.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            textBoxRecherche.ForeColor = Color.Black;
            textBoxRecherche.Location = new Point(110, 31);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.PlaceholderText = "matricule du véhicule";
            textBoxRecherche.Size = new Size(229, 25);
            textBoxRecherche.TabIndex = 83;
            textBoxRecherche.KeyUp += textBoxRecherche_KeyUp;
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
            btnModif.Location = new Point(62, 472);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(173, 33);
            btnModif.TabIndex = 78;
            btnModif.Text = "Modifier";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
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
            btnEnregistrer.Location = new Point(67, 297);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(234, 33);
            btnEnregistrer.TabIndex = 37;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // lblNumTransporteur
            // 
            lblNumTransporteur.AutoSize = true;
            lblNumTransporteur.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNumTransporteur.Location = new Point(70, 216);
            lblNumTransporteur.Name = "lblNumTransporteur";
            lblNumTransporteur.Size = new Size(146, 17);
            lblNumTransporteur.TabIndex = 31;
            lblNumTransporteur.Text = "Numéro transporteur :";
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
            btnSuppr.Location = new Point(255, 472);
            btnSuppr.Name = "btnSuppr";
            btnSuppr.Size = new Size(172, 33);
            btnSuppr.TabIndex = 79;
            btnSuppr.Text = "Supprimer";
            btnSuppr.UseVisualStyleBackColor = false;
            btnSuppr.Click += btnSuppr_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBoxNumTransporteur);
            panel2.Controls.Add(comboBoxRefProprietaire);
            panel2.Controls.Add(btnEnregistrer);
            panel2.Controls.Add(lblNumTransporteur);
            panel2.Controls.Add(lblRefProprietaire);
            panel2.Controls.Add(champMatricule);
            panel2.Controls.Add(champTypeVehicule);
            panel2.Controls.Add(lblType);
            panel2.Controls.Add(lblMatricule);
            panel2.Location = new Point(695, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 389);
            panel2.TabIndex = 81;
            // 
            // comboBoxNumTransporteur
            // 
            comboBoxNumTransporteur.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            comboBoxNumTransporteur.FormattingEnabled = true;
            comboBoxNumTransporteur.Location = new Point(67, 236);
            comboBoxNumTransporteur.Name = "comboBoxNumTransporteur";
            comboBoxNumTransporteur.Size = new Size(234, 25);
            comboBoxNumTransporteur.TabIndex = 39;
            comboBoxNumTransporteur.Leave += comboBoxNumTransporteur_Leave;
            // 
            // comboBoxRefProprietaire
            // 
            comboBoxRefProprietaire.BackColor = SystemColors.Window;
            comboBoxRefProprietaire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            comboBoxRefProprietaire.FormattingEnabled = true;
            comboBoxRefProprietaire.Location = new Point(67, 177);
            comboBoxRefProprietaire.Name = "comboBoxRefProprietaire";
            comboBoxRefProprietaire.Size = new Size(234, 25);
            comboBoxRefProprietaire.TabIndex = 38;
            comboBoxRefProprietaire.Leave += comboBoxRefProprietaire_Leave;
            // 
            // lblRefProprietaire
            // 
            lblRefProprietaire.AutoSize = true;
            lblRefProprietaire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblRefProprietaire.Location = new Point(70, 157);
            lblRefProprietaire.Name = "lblRefProprietaire";
            lblRefProprietaire.Size = new Size(149, 17);
            lblRefProprietaire.TabIndex = 33;
            lblRefProprietaire.Text = "Référence propriétaire :";
            // 
            // champMatricule
            // 
            champMatricule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champMatricule.BackColor = SystemColors.Window;
            champMatricule.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champMatricule.Location = new Point(67, 55);
            champMatricule.Name = "champMatricule";
            champMatricule.Size = new Size(234, 25);
            champMatricule.TabIndex = 30;
            champMatricule.TextChanged += champMatricule_TextChanged;
            // 
            // champTypeVehicule
            // 
            champTypeVehicule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champTypeVehicule.BackColor = SystemColors.Window;
            champTypeVehicule.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champTypeVehicule.Location = new Point(67, 115);
            champTypeVehicule.Name = "champTypeVehicule";
            champTypeVehicule.Size = new Size(234, 25);
            champTypeVehicule.TabIndex = 9;
            champTypeVehicule.TextChanged += champTypeVehicule_TextChanged;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblType.Location = new Point(70, 95);
            lblType.Name = "lblType";
            lblType.Size = new Size(116, 17);
            lblType.TabIndex = 8;
            lblType.Text = "Type du véhicule :";
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblMatricule.Location = new Point(70, 35);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(144, 17);
            lblMatricule.TabIndex = 10;
            lblMatricule.Text = "Matricule du véhicule :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Moccasin;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(695, 25);
            label4.Name = "label4";
            label4.Size = new Size(369, 37);
            label4.TabIndex = 84;
            label4.Text = "Formulaire véhicule";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Moccasin;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 455);
            label5.Name = "label5";
            label5.Size = new Size(1036, 67);
            label5.TabIndex = 86;
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 24);
            label3.Name = "label3";
            label3.Size = new Size(661, 37);
            label3.TabIndex = 82;
            label3.Text = "Recherche ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UserControlVeh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dataGridView1);
            Controls.Add(btnAnnuler);
            Controls.Add(textBoxRecherche);
            Controls.Add(btnModif);
            Controls.Add(btnSuppr);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "UserControlVeh";
            Size = new Size(1092, 547);
            Load += UserControlVeh_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAnnuler;
        private TextBox textBoxRecherche;
        private Button btnModif;
        private Button btnEnregistrer;
        private Label lblNumTransporteur;
        private Button btnSuppr;
        private Panel panel2;
        private Label lblRefProprietaire;
        private TextBox champMatricule;
        private TextBox champTypeVehicule;
        private Label lblType;
        private Label lblMatricule;
        private Label label4;
        private Label label5;
        private Label label3;
        private ComboBox comboBoxNumTransporteur;
        private ComboBox comboBoxRefProprietaire;
        private ErrorProvider errorProvider1;
    }
}
