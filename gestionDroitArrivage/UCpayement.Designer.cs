namespace gestionDroitArrivage
{
    partial class UCpayement
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
            label4 = new Label();
            btnEnregistrer = new Button();
            lblDatePayement = new Label();
            lblMontant = new Label();
            champMontant = new TextBox();
            panel2 = new Panel();
            dateArrivage = new DateTimePicker();
            btnAnnuler = new Button();
            lblDateArrivage = new Label();
            datePayement = new DateTimePicker();
            comboBoxMatricule = new ComboBox();
            lblMatricule = new Label();
            btnSuppr = new Button();
            btnModif = new Button();
            textBoxRecherche = new TextBox();
            btnRecu = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            textBoxMatricule = new TextBox();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Moccasin;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(693, 26);
            label4.Name = "label4";
            label4.Size = new Size(354, 37);
            label4.TabIndex = 74;
            label4.Text = "Formulaire payement";
            label4.TextAlign = ContentAlignment.MiddleLeft;
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
            btnEnregistrer.Location = new Point(63, 284);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(228, 33);
            btnEnregistrer.TabIndex = 25;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // lblDatePayement
            // 
            lblDatePayement.AutoSize = true;
            lblDatePayement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDatePayement.Location = new Point(66, 27);
            lblDatePayement.Name = "lblDatePayement";
            lblDatePayement.Size = new Size(108, 17);
            lblDatePayement.TabIndex = 10;
            lblDatePayement.Text = "Date payement :";
            // 
            // lblMontant
            // 
            lblMontant.AutoSize = true;
            lblMontant.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblMontant.Location = new Point(66, 86);
            lblMontant.Name = "lblMontant";
            lblMontant.Size = new Size(68, 17);
            lblMontant.TabIndex = 8;
            lblMontant.Text = "Montant :";
            // 
            // champMontant
            // 
            champMontant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champMontant.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champMontant.Location = new Point(63, 106);
            champMontant.Name = "champMontant";
            champMontant.Size = new Size(228, 25);
            champMontant.TabIndex = 9;
            champMontant.TextChanged += champMontant_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dateArrivage);
            panel2.Controls.Add(btnAnnuler);
            panel2.Controls.Add(lblDateArrivage);
            panel2.Controls.Add(datePayement);
            panel2.Controls.Add(champMontant);
            panel2.Controls.Add(lblMontant);
            panel2.Controls.Add(lblDatePayement);
            panel2.Controls.Add(comboBoxMatricule);
            panel2.Controls.Add(btnEnregistrer);
            panel2.Controls.Add(lblMatricule);
            panel2.Location = new Point(693, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 402);
            panel2.TabIndex = 71;
            // 
            // dateArrivage
            // 
            dateArrivage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateArrivage.CustomFormat = "";
            dateArrivage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateArrivage.Location = new Point(63, 228);
            dateArrivage.Name = "dateArrivage";
            dateArrivage.Size = new Size(228, 25);
            dateArrivage.TabIndex = 30;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAnnuler.BackColor = Color.White;
            btnAnnuler.FlatAppearance.BorderColor = Color.PeachPuff;
            btnAnnuler.FlatAppearance.MouseDownBackColor = Color.White;
            btnAnnuler.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnAnnuler.FlatStyle = FlatStyle.Flat;
            btnAnnuler.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.Black;
            btnAnnuler.Location = new Point(62, 337);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(229, 34);
            btnAnnuler.TabIndex = 29;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // lblDateArrivage
            // 
            lblDateArrivage.AutoSize = true;
            lblDateArrivage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDateArrivage.Location = new Point(66, 208);
            lblDateArrivage.Name = "lblDateArrivage";
            lblDateArrivage.Size = new Size(96, 17);
            lblDateArrivage.TabIndex = 27;
            lblDateArrivage.Text = "Date arrivage :";
            // 
            // datePayement
            // 
            datePayement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datePayement.CustomFormat = "";
            datePayement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datePayement.Location = new Point(63, 47);
            datePayement.Name = "datePayement";
            datePayement.Size = new Size(228, 25);
            datePayement.TabIndex = 26;
            // 
            // comboBoxMatricule
            // 
            comboBoxMatricule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMatricule.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            comboBoxMatricule.FormattingEnabled = true;
            comboBoxMatricule.Location = new Point(63, 168);
            comboBoxMatricule.Name = "comboBoxMatricule";
            comboBoxMatricule.Size = new Size(228, 25);
            comboBoxMatricule.TabIndex = 24;
            comboBoxMatricule.Leave += comboBoxMatricule_Leave;
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblMatricule.Location = new Point(66, 148);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(144, 17);
            lblMatricule.TabIndex = 12;
            lblMatricule.Text = "Matricule du véhicule :";
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
            btnSuppr.Location = new Point(463, 489);
            btnSuppr.Name = "btnSuppr";
            btnSuppr.Size = new Size(191, 34);
            btnSuppr.TabIndex = 69;
            btnSuppr.Text = "Supprimer";
            btnSuppr.UseVisualStyleBackColor = false;
            btnSuppr.Click += btnSuppr_Click;
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
            btnModif.Location = new Point(264, 489);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(184, 34);
            btnModif.TabIndex = 68;
            btnModif.Text = "Modifier";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.BackColor = Color.OldLace;
            textBoxRecherche.BorderStyle = BorderStyle.FixedSingle;
            textBoxRecherche.Cursor = Cursors.IBeam;
            textBoxRecherche.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            textBoxRecherche.ForeColor = Color.Black;
            textBoxRecherche.Location = new Point(123, 32);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.PlaceholderText = "numéro/date de payement";
            textBoxRecherche.Size = new Size(225, 25);
            textBoxRecherche.TabIndex = 73;
            textBoxRecherche.TextChanged += textBoxRecherche_TextChanged;
            textBoxRecherche.KeyUp += textBoxRecherche_KeyUp;
            // 
            // btnRecu
            // 
            btnRecu.BackColor = Color.White;
            btnRecu.FlatAppearance.BorderColor = Color.SandyBrown;
            btnRecu.FlatAppearance.CheckedBackColor = Color.PeachPuff;
            btnRecu.FlatAppearance.MouseDownBackColor = Color.White;
            btnRecu.FlatAppearance.MouseOverBackColor = Color.BlanchedAlmond;
            btnRecu.FlatStyle = FlatStyle.Flat;
            btnRecu.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRecu.ForeColor = Color.Black;
            btnRecu.Location = new Point(62, 489);
            btnRecu.Name = "btnRecu";
            btnRecu.Size = new Size(185, 34);
            btnRecu.TabIndex = 67;
            btnRecu.Text = "Elaborer reçu";
            btnRecu.UseVisualStyleBackColor = false;
            btnRecu.Click += btnRecu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(631, 225);
            dataGridView1.TabIndex = 70;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label3
            // 
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 24);
            label3.Name = "label3";
            label3.Size = new Size(631, 39);
            label3.TabIndex = 72;
            label3.Text = "Recherche ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(40, 333);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(631, 132);
            dataGridView2.TabIndex = 75;
            // 
            // label1
            // 
            label1.BackColor = Color.Moccasin;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(40, 294);
            label1.Name = "label1";
            label1.Size = new Size(631, 39);
            label1.TabIndex = 76;
            label1.Text = "Recherche ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxMatricule
            // 
            textBoxMatricule.BackColor = Color.OldLace;
            textBoxMatricule.BorderStyle = BorderStyle.FixedSingle;
            textBoxMatricule.Cursor = Cursors.IBeam;
            textBoxMatricule.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            textBoxMatricule.ForeColor = Color.Black;
            textBoxMatricule.Location = new Point(123, 302);
            textBoxMatricule.Name = "textBoxMatricule";
            textBoxMatricule.PlaceholderText = "matricule véhicule";
            textBoxMatricule.Size = new Size(225, 25);
            textBoxMatricule.TabIndex = 77;
            textBoxMatricule.KeyUp += textBoxMatricule_KeyUp;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Moccasin;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 471);
            label5.Name = "label5";
            label5.Size = new Size(1036, 67);
            label5.TabIndex = 87;
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UCpayement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(textBoxMatricule);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnRecu);
            Controls.Add(textBoxRecherche);
            Controls.Add(btnModif);
            Controls.Add(btnSuppr);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Name = "UCpayement";
            Size = new Size(1092, 547);
            Load += UserControlPayem_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnEnregistrer;
        private Label lblDatePayement;
        private Label lblMontant;
        private TextBox champMontant;
        private Panel panel2;
        private Button btnSuppr;
        private Button btnModif;
        private TextBox textBoxRecherche;
        private Button btnRecu;
        private DataGridView dataGridView1;
        private Label label3;
        private Label lblMatricule;
        private ComboBox comboBoxMatricule;
        private DateTimePicker datePayement;
        private Label lblDateArrivage;
        private Button btnAnnuler;
        private DataGridView dataGridView2;
        private Label label1;
        private TextBox textBoxMatricule;
        private DateTimePicker dateArrivage;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}
