namespace gestionDroitArrivage
{
    partial class UCproprietaire
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
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnAnnuler = new Button();
            textBoxRecherche = new TextBox();
            label5 = new Label();
            champRefProprietaire = new TextBox();
            champNom = new TextBox();
            lblNom = new Label();
            lblRefProprietaire = new Label();
            btnModif = new Button();
            btnSuppr = new Button();
            panel2 = new Panel();
            btnEnregistrer = new Button();
            champTelephone = new TextBox();
            lblTelephone = new Label();
            champPrenoms = new TextBox();
            champAdresse = new TextBox();
            lblAdresse = new Label();
            lblPrenoms = new Label();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(29, 25);
            label3.Name = "label3";
            label3.Size = new Size(661, 37);
            label3.TabIndex = 72;
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
            dataGridView1.Location = new Point(29, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(661, 389);
            dataGridView1.TabIndex = 70;
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
            btnAnnuler.Location = new Point(450, 473);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(188, 33);
            btnAnnuler.TabIndex = 75;
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
            textBoxRecherche.Location = new Point(111, 32);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.PlaceholderText = "nom/prénoms du propriétaire";
            textBoxRecherche.Size = new Size(229, 25);
            textBoxRecherche.TabIndex = 73;
            textBoxRecherche.KeyUp += textBoxRecherche_KeyUp;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Moccasin;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(29, 456);
            label5.Name = "label5";
            label5.Size = new Size(1036, 67);
            label5.TabIndex = 77;
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // champRefProprietaire
            // 
            champRefProprietaire.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champRefProprietaire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champRefProprietaire.Location = new Point(69, 55);
            champRefProprietaire.Name = "champRefProprietaire";
            champRefProprietaire.Size = new Size(231, 25);
            champRefProprietaire.TabIndex = 30;
            champRefProprietaire.TextChanged += champRefProprietaire_TextChanged;
            // 
            // champNom
            // 
            champNom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champNom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champNom.Location = new Point(69, 107);
            champNom.Name = "champNom";
            champNom.Size = new Size(231, 25);
            champNom.TabIndex = 9;
            champNom.TextChanged += champNom_TextChanged;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNom.Location = new Point(72, 87);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(45, 17);
            lblNom.TabIndex = 8;
            lblNom.Text = "Nom :";
            // 
            // lblRefProprietaire
            // 
            lblRefProprietaire.AutoSize = true;
            lblRefProprietaire.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblRefProprietaire.Location = new Point(72, 35);
            lblRefProprietaire.Name = "lblRefProprietaire";
            lblRefProprietaire.Size = new Size(149, 17);
            lblRefProprietaire.TabIndex = 10;
            lblRefProprietaire.Text = "Référence propriétaire :";
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
            btnModif.Location = new Point(63, 473);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(173, 33);
            btnModif.TabIndex = 68;
            btnModif.Text = "Modifier";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
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
            btnSuppr.Location = new Point(256, 473);
            btnSuppr.Name = "btnSuppr";
            btnSuppr.Size = new Size(172, 33);
            btnSuppr.TabIndex = 69;
            btnSuppr.Text = "Supprimer";
            btnSuppr.UseVisualStyleBackColor = false;
            btnSuppr.Click += btnSuppr_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnEnregistrer);
            panel2.Controls.Add(champTelephone);
            panel2.Controls.Add(lblTelephone);
            panel2.Controls.Add(champPrenoms);
            panel2.Controls.Add(champAdresse);
            panel2.Controls.Add(lblAdresse);
            panel2.Controls.Add(lblPrenoms);
            panel2.Controls.Add(champRefProprietaire);
            panel2.Controls.Add(champNom);
            panel2.Controls.Add(lblNom);
            panel2.Controls.Add(lblRefProprietaire);
            panel2.Location = new Point(696, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 389);
            panel2.TabIndex = 71;
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
            btnEnregistrer.Location = new Point(69, 319);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(231, 33);
            btnEnregistrer.TabIndex = 37;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // champTelephone
            // 
            champTelephone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champTelephone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champTelephone.Location = new Point(69, 267);
            champTelephone.Name = "champTelephone";
            champTelephone.Size = new Size(231, 25);
            champTelephone.TabIndex = 36;
            champTelephone.TextChanged += champTelephone_TextChanged;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTelephone.Location = new Point(72, 247);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(77, 17);
            lblTelephone.TabIndex = 35;
            lblTelephone.Text = "Téléphone :";
            // 
            // champPrenoms
            // 
            champPrenoms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champPrenoms.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champPrenoms.Location = new Point(69, 162);
            champPrenoms.Name = "champPrenoms";
            champPrenoms.Size = new Size(231, 25);
            champPrenoms.TabIndex = 34;
            champPrenoms.TextChanged += champPrenoms_TextChanged;
            // 
            // champAdresse
            // 
            champAdresse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champAdresse.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champAdresse.Location = new Point(69, 214);
            champAdresse.Name = "champAdresse";
            champAdresse.Size = new Size(231, 25);
            champAdresse.TabIndex = 32;
            champAdresse.TextChanged += champAdresse_TextChanged;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblAdresse.Location = new Point(72, 194);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(63, 17);
            lblAdresse.TabIndex = 31;
            lblAdresse.Text = "Adresse :";
            // 
            // lblPrenoms
            // 
            lblPrenoms.AutoSize = true;
            lblPrenoms.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPrenoms.Location = new Point(72, 142);
            lblPrenoms.Name = "lblPrenoms";
            lblPrenoms.Size = new Size(69, 17);
            lblPrenoms.TabIndex = 33;
            lblPrenoms.Text = "Prénoms :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Moccasin;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(696, 26);
            label4.Name = "label4";
            label4.Size = new Size(369, 37);
            label4.TabIndex = 74;
            label4.Text = "Formulaire propriétaire";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UserControlPropri
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
            Name = "UserControlPropri";
            Size = new Size(1092, 547);
            Load += UserControlPropri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView dataGridView1;
        private Button btnAnnuler;
        private TextBox textBoxRecherche;
        private Label label5;
        private TextBox champRefProprietaire;
        private TextBox champNom;
        private Label lblNom;
        private Label lblRefProprietaire;
        private Button btnModif;
        private Button btnSuppr;
        private Panel panel2;
        private Label label4;
        private TextBox champPrenoms;
        private TextBox champAdresse;
        private Label lblAdresse;
        private Label lblPrenoms;
        private Button btnEnregistrer;
        private TextBox champTelephone;
        private Label lblTelephone;
        private ErrorProvider errorProvider1;
    }
}
