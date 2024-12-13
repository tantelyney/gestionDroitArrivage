namespace gestionDroitArrivage
{
    partial class UCtransporteur
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
            champTelephone = new TextBox();
            lblTelephone = new Label();
            champPrenoms = new TextBox();
            champAdresse = new TextBox();
            lblAdresse = new Label();
            btnSuppr = new Button();
            panel2 = new Panel();
            champCin = new TextBox();
            lblCin = new Label();
            lblPrenoms = new Label();
            champNumTransporteur = new TextBox();
            champNom = new TextBox();
            lblNom = new Label();
            lblNumTransp = new Label();
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
            dataGridView1.Size = new Size(661, 409);
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
            btnAnnuler.Location = new Point(449, 490);
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
            textBoxRecherche.PlaceholderText = "nom/prénoms du transporteur";
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
            btnModif.Location = new Point(62, 490);
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
            btnEnregistrer.Location = new Point(67, 350);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(233, 33);
            btnEnregistrer.TabIndex = 37;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // champTelephone
            // 
            champTelephone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champTelephone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champTelephone.Location = new Point(67, 306);
            champTelephone.Name = "champTelephone";
            champTelephone.Size = new Size(233, 25);
            champTelephone.TabIndex = 36;
            champTelephone.TextChanged += champTelephone_TextChanged;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTelephone.Location = new Point(70, 286);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(77, 17);
            lblTelephone.TabIndex = 35;
            lblTelephone.Text = "Téléphone :";
            // 
            // champPrenoms
            // 
            champPrenoms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champPrenoms.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champPrenoms.Location = new Point(67, 145);
            champPrenoms.Name = "champPrenoms";
            champPrenoms.Size = new Size(233, 25);
            champPrenoms.TabIndex = 34;
            champPrenoms.TextChanged += champPrenoms_TextChanged;
            // 
            // champAdresse
            // 
            champAdresse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champAdresse.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champAdresse.Location = new Point(67, 252);
            champAdresse.Name = "champAdresse";
            champAdresse.Size = new Size(233, 25);
            champAdresse.TabIndex = 32;
            champAdresse.TextChanged += champAdresse_TextChanged;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblAdresse.Location = new Point(70, 232);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(63, 17);
            lblAdresse.TabIndex = 31;
            lblAdresse.Text = "Adresse :";
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
            btnSuppr.Location = new Point(255, 490);
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
            panel2.Controls.Add(champCin);
            panel2.Controls.Add(lblCin);
            panel2.Controls.Add(btnEnregistrer);
            panel2.Controls.Add(champTelephone);
            panel2.Controls.Add(lblTelephone);
            panel2.Controls.Add(champPrenoms);
            panel2.Controls.Add(champAdresse);
            panel2.Controls.Add(lblAdresse);
            panel2.Controls.Add(lblPrenoms);
            panel2.Controls.Add(champNumTransporteur);
            panel2.Controls.Add(champNom);
            panel2.Controls.Add(lblNom);
            panel2.Controls.Add(lblNumTransp);
            panel2.Location = new Point(695, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 409);
            panel2.TabIndex = 81;
            // 
            // champCin
            // 
            champCin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champCin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champCin.Location = new Point(67, 197);
            champCin.Name = "champCin";
            champCin.Size = new Size(233, 25);
            champCin.TabIndex = 39;
            champCin.TextChanged += champCin_TextChanged;
            // 
            // lblCin
            // 
            lblCin.AutoSize = true;
            lblCin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCin.Location = new Point(70, 177);
            lblCin.Name = "lblCin";
            lblCin.Size = new Size(91, 17);
            lblCin.TabIndex = 38;
            lblCin.Text = "Numéro CIN :";
            // 
            // lblPrenoms
            // 
            lblPrenoms.AutoSize = true;
            lblPrenoms.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPrenoms.Location = new Point(70, 125);
            lblPrenoms.Name = "lblPrenoms";
            lblPrenoms.Size = new Size(69, 17);
            lblPrenoms.TabIndex = 33;
            lblPrenoms.Text = "Prénoms :";
            // 
            // champNumTransporteur
            // 
            champNumTransporteur.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champNumTransporteur.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champNumTransporteur.Location = new Point(67, 38);
            champNumTransporteur.Name = "champNumTransporteur";
            champNumTransporteur.Size = new Size(233, 25);
            champNumTransporteur.TabIndex = 30;
            champNumTransporteur.TextChanged += champNumTransporteur_TextChanged;
            // 
            // champNom
            // 
            champNom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champNom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champNom.Location = new Point(67, 90);
            champNom.Name = "champNom";
            champNom.Size = new Size(233, 25);
            champNom.TabIndex = 9;
            champNom.TextChanged += champNom_TextChanged;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNom.Location = new Point(70, 70);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(45, 17);
            lblNom.TabIndex = 8;
            lblNom.Text = "Nom :";
            // 
            // lblNumTransp
            // 
            lblNumTransp.AutoSize = true;
            lblNumTransp.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNumTransp.Location = new Point(70, 18);
            lblNumTransp.Name = "lblNumTransp";
            lblNumTransp.Size = new Size(146, 17);
            lblNumTransp.TabIndex = 10;
            lblNumTransp.Text = "Numéro transporteur :";
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
            label4.Text = "Formulaire transporteur";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Moccasin;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 473);
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
            // UserControlTransp
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
            Name = "UserControlTransp";
            Size = new Size(1092, 547);
            Load += UserControlTransp_Load;
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
        private TextBox champTelephone;
        private Label lblTelephone;
        private TextBox champPrenoms;
        private TextBox champAdresse;
        private Label lblAdresse;
        private Button btnSuppr;
        private Panel panel2;
        private TextBox champCin;
        private Label lblCin;
        private Label lblPrenoms;
        private TextBox champNumTransporteur;
        private TextBox champNom;
        private Label lblNom;
        private Label lblNumTransp;
        private Label label4;
        private Label label5;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}
