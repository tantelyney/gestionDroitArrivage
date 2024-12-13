namespace gestionDroitArrivage
{
    partial class UCarrivage
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
            btnQuittance = new Button();
            label4 = new Label();
            textBoxRecherche = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnAjoutArrivage = new Button();
            btnSupprArrivage = new Button();
            panel2 = new Panel();
            comboBoxMarchandise = new ComboBox();
            comboBoxMatricule = new ComboBox();
            listBoxMarchandise = new ListBox();
            champPointDepart = new TextBox();
            btnConfirmer = new Button();
            lblQte = new Label();
            btnAnnuler = new Button();
            listBoxQte = new ListBox();
            champQte = new TextBox();
            dateTimeArrivage = new DateTimePicker();
            lblMarchandises = new Label();
            lblMatricule = new Label();
            lblPointDepart = new Label();
            lblDateArrivage = new Label();
            btnModifArrivage = new Button();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnQuittance
            // 
            btnQuittance.BackColor = Color.White;
            btnQuittance.FlatAppearance.BorderColor = Color.SandyBrown;
            btnQuittance.FlatAppearance.CheckedBackColor = Color.PeachPuff;
            btnQuittance.FlatAppearance.MouseDownBackColor = Color.White;
            btnQuittance.FlatAppearance.MouseOverBackColor = Color.BlanchedAlmond;
            btnQuittance.FlatStyle = FlatStyle.Flat;
            btnQuittance.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnQuittance.ForeColor = Color.Black;
            btnQuittance.Location = new Point(504, 487);
            btnQuittance.Name = "btnQuittance";
            btnQuittance.Size = new Size(141, 36);
            btnQuittance.TabIndex = 53;
            btnQuittance.Text = "Elaborer quittance";
            btnQuittance.UseVisualStyleBackColor = false;
            btnQuittance.Click += btnQuitance_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Moccasin;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(665, 27);
            label4.Name = "label4";
            label4.Size = new Size(380, 37);
            label4.TabIndex = 52;
            label4.Text = "Formulaire arrivage";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.BackColor = Color.OldLace;
            textBoxRecherche.BorderStyle = BorderStyle.FixedSingle;
            textBoxRecherche.Cursor = Cursors.IBeam;
            textBoxRecherche.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            textBoxRecherche.ForeColor = Color.Black;
            textBoxRecherche.Location = new Point(193, 32);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.PlaceholderText = "yyyy-mm-dd";
            textBoxRecherche.Size = new Size(166, 25);
            textBoxRecherche.TabIndex = 51;
            textBoxRecherche.KeyUp += textBoxRecherche_KeyUp;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 26);
            label3.Name = "label3";
            label3.Size = new Size(631, 37);
            label3.TabIndex = 50;
            label3.Text = "Recherche date arrivage";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(631, 406);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnAjoutArrivage
            // 
            btnAjoutArrivage.BackColor = Color.White;
            btnAjoutArrivage.FlatAppearance.BorderColor = Color.SandyBrown;
            btnAjoutArrivage.FlatAppearance.CheckedBackColor = Color.PeachPuff;
            btnAjoutArrivage.FlatAppearance.MouseDownBackColor = Color.White;
            btnAjoutArrivage.FlatAppearance.MouseOverBackColor = Color.BlanchedAlmond;
            btnAjoutArrivage.FlatStyle = FlatStyle.Flat;
            btnAjoutArrivage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAjoutArrivage.ForeColor = Color.Black;
            btnAjoutArrivage.Location = new Point(39, 487);
            btnAjoutArrivage.Name = "btnAjoutArrivage";
            btnAjoutArrivage.Size = new Size(148, 36);
            btnAjoutArrivage.TabIndex = 45;
            btnAjoutArrivage.Text = "Ajouter";
            btnAjoutArrivage.UseVisualStyleBackColor = false;
            btnAjoutArrivage.Click += btnAjoutArrivage_Click;
            // 
            // btnSupprArrivage
            // 
            btnSupprArrivage.BackColor = Color.White;
            btnSupprArrivage.FlatAppearance.BorderColor = Color.SandyBrown;
            btnSupprArrivage.FlatAppearance.CheckedBackColor = Color.PeachPuff;
            btnSupprArrivage.FlatAppearance.MouseDownBackColor = Color.White;
            btnSupprArrivage.FlatAppearance.MouseOverBackColor = Color.BlanchedAlmond;
            btnSupprArrivage.FlatStyle = FlatStyle.Flat;
            btnSupprArrivage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSupprArrivage.ForeColor = Color.Black;
            btnSupprArrivage.Location = new Point(346, 487);
            btnSupprArrivage.Name = "btnSupprArrivage";
            btnSupprArrivage.Size = new Size(152, 36);
            btnSupprArrivage.TabIndex = 47;
            btnSupprArrivage.Text = "Supprimer";
            btnSupprArrivage.UseVisualStyleBackColor = false;
            btnSupprArrivage.Click += btnSupprArrivage_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBoxMarchandise);
            panel2.Controls.Add(comboBoxMatricule);
            panel2.Controls.Add(listBoxMarchandise);
            panel2.Controls.Add(champPointDepart);
            panel2.Controls.Add(btnConfirmer);
            panel2.Controls.Add(lblQte);
            panel2.Controls.Add(btnAnnuler);
            panel2.Controls.Add(listBoxQte);
            panel2.Controls.Add(champQte);
            panel2.Controls.Add(dateTimeArrivage);
            panel2.Controls.Add(lblMarchandises);
            panel2.Controls.Add(lblMatricule);
            panel2.Controls.Add(lblPointDepart);
            panel2.Controls.Add(lblDateArrivage);
            panel2.Location = new Point(665, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 476);
            panel2.TabIndex = 49;
            panel2.Paint += panel2_Paint;
            // 
            // comboBoxMarchandise
            // 
            comboBoxMarchandise.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            comboBoxMarchandise.FormattingEnabled = true;
            comboBoxMarchandise.Location = new Point(59, 213);
            comboBoxMarchandise.Name = "comboBoxMarchandise";
            comboBoxMarchandise.Size = new Size(125, 25);
            comboBoxMarchandise.TabIndex = 29;
            comboBoxMarchandise.Leave += comboBoxMarchandise_Leave;
            // 
            // comboBoxMatricule
            // 
            comboBoxMatricule.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            comboBoxMatricule.FormattingEnabled = true;
            comboBoxMatricule.Location = new Point(59, 151);
            comboBoxMatricule.Name = "comboBoxMatricule";
            comboBoxMatricule.Size = new Size(262, 25);
            comboBoxMatricule.TabIndex = 24;
            comboBoxMatricule.Leave += comboBoxMatricule_Leave;
            // 
            // listBoxMarchandise
            // 
            listBoxMarchandise.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            listBoxMarchandise.FormattingEnabled = true;
            listBoxMarchandise.ItemHeight = 17;
            listBoxMarchandise.Location = new Point(59, 238);
            listBoxMarchandise.Name = "listBoxMarchandise";
            listBoxMarchandise.Size = new Size(125, 72);
            listBoxMarchandise.TabIndex = 26;
            listBoxMarchandise.SelectedIndexChanged += listBoxMarchandise_SelectedIndexChanged;
            // 
            // champPointDepart
            // 
            champPointDepart.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champPointDepart.Location = new Point(59, 94);
            champPointDepart.Name = "champPointDepart";
            champPointDepart.Size = new Size(262, 25);
            champPointDepart.TabIndex = 9;
            champPointDepart.TextChanged += champPointDepart_TextChanged;
            // 
            // btnConfirmer
            // 
            btnConfirmer.BackColor = Color.BlanchedAlmond;
            btnConfirmer.FlatAppearance.BorderColor = Color.BlanchedAlmond;
            btnConfirmer.FlatAppearance.MouseDownBackColor = Color.BlanchedAlmond;
            btnConfirmer.FlatAppearance.MouseOverBackColor = Color.PeachPuff;
            btnConfirmer.FlatStyle = FlatStyle.Flat;
            btnConfirmer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnConfirmer.Location = new Point(59, 339);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(262, 33);
            btnConfirmer.TabIndex = 25;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.UseVisualStyleBackColor = false;
            btnConfirmer.Click += btnConfirmer_Click;
            // 
            // lblQte
            // 
            lblQte.AutoSize = true;
            lblQte.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblQte.Location = new Point(202, 195);
            lblQte.Name = "lblQte";
            lblQte.Size = new Size(74, 17);
            lblQte.TabIndex = 15;
            lblQte.Text = "Quantités :";
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.White;
            btnAnnuler.FlatAppearance.BorderColor = Color.PeachPuff;
            btnAnnuler.FlatAppearance.MouseDownBackColor = Color.White;
            btnAnnuler.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnAnnuler.FlatStyle = FlatStyle.Flat;
            btnAnnuler.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.Black;
            btnAnnuler.Location = new Point(59, 399);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(262, 34);
            btnAnnuler.TabIndex = 28;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // listBoxQte
            // 
            listBoxQte.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            listBoxQte.FormattingEnabled = true;
            listBoxQte.ItemHeight = 17;
            listBoxQte.Location = new Point(199, 238);
            listBoxQte.Name = "listBoxQte";
            listBoxQte.Size = new Size(122, 72);
            listBoxQte.TabIndex = 27;
            // 
            // champQte
            // 
            champQte.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            champQte.Location = new Point(199, 213);
            champQte.Name = "champQte";
            champQte.Size = new Size(122, 25);
            champQte.TabIndex = 22;
            champQte.TextChanged += champQte_TextChanged;
            // 
            // dateTimeArrivage
            // 
            dateTimeArrivage.CustomFormat = "";
            dateTimeArrivage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimeArrivage.Location = new Point(59, 37);
            dateTimeArrivage.Name = "dateTimeArrivage";
            dateTimeArrivage.Size = new Size(262, 25);
            dateTimeArrivage.TabIndex = 11;
            // 
            // lblMarchandises
            // 
            lblMarchandises.AutoSize = true;
            lblMarchandises.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblMarchandises.Location = new Point(62, 195);
            lblMarchandises.Name = "lblMarchandises";
            lblMarchandises.Size = new Size(98, 17);
            lblMarchandises.TabIndex = 14;
            lblMarchandises.Text = "Marchandises :";
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblMatricule.Location = new Point(62, 131);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(144, 17);
            lblMatricule.TabIndex = 12;
            lblMatricule.Text = "Matricule du véhicule :";
            // 
            // lblPointDepart
            // 
            lblPointDepart.AutoSize = true;
            lblPointDepart.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPointDepart.Location = new Point(62, 74);
            lblPointDepart.Name = "lblPointDepart";
            lblPointDepart.Size = new Size(110, 17);
            lblPointDepart.TabIndex = 8;
            lblPointDepart.Text = "Point de départ :";
            // 
            // lblDateArrivage
            // 
            lblDateArrivage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateArrivage.AutoSize = true;
            lblDateArrivage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDateArrivage.Location = new Point(62, 17);
            lblDateArrivage.Name = "lblDateArrivage";
            lblDateArrivage.Size = new Size(107, 17);
            lblDateArrivage.TabIndex = 10;
            lblDateArrivage.Text = "Date d'arrivage :";
            // 
            // btnModifArrivage
            // 
            btnModifArrivage.BackColor = Color.White;
            btnModifArrivage.FlatAppearance.BorderColor = Color.SandyBrown;
            btnModifArrivage.FlatAppearance.CheckedBackColor = Color.PeachPuff;
            btnModifArrivage.FlatAppearance.MouseDownBackColor = Color.White;
            btnModifArrivage.FlatAppearance.MouseOverBackColor = Color.BlanchedAlmond;
            btnModifArrivage.FlatStyle = FlatStyle.Flat;
            btnModifArrivage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnModifArrivage.ForeColor = Color.Black;
            btnModifArrivage.Location = new Point(193, 487);
            btnModifArrivage.Name = "btnModifArrivage";
            btnModifArrivage.Size = new Size(147, 36);
            btnModifArrivage.TabIndex = 46;
            btnModifArrivage.Text = "Modifier";
            btnModifArrivage.UseVisualStyleBackColor = false;
            btnModifArrivage.Click += btnModifArrivage_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Moccasin;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 472);
            label5.Name = "label5";
            label5.Size = new Size(631, 67);
            label5.TabIndex = 87;
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UCarrivage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnQuittance);
            Controls.Add(label4);
            Controls.Add(textBoxRecherche);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnAjoutArrivage);
            Controls.Add(btnSupprArrivage);
            Controls.Add(panel2);
            Controls.Add(btnModifArrivage);
            Controls.Add(label5);
            Name = "UCarrivage";
            Size = new Size(1092, 547);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuittance;
        private Label label4;
        private TextBox textBoxRecherche;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnAjoutArrivage;
        private Button btnSupprArrivage;
        private Panel panel2;
        private ComboBox comboBoxMarchandise;
        private ComboBox comboBoxMatricule;
        private ListBox listBoxMarchandise;
        private TextBox champPointDepart;
        private Button btnConfirmer;
        private Label lblQte;
        private Button btnAnnuler;
        private ListBox listBoxQte;
        private TextBox champQte;
        private DateTimePicker dateTimeArrivage;
        private Label lblMarchandises;
        private Label lblMatricule;
        private Label lblPointDepart;
        private Label lblDateArrivage;
        private Button btnModifArrivage;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}
