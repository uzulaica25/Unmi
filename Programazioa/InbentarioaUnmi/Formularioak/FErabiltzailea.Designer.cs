namespace InbentarioaUnmi.Formularioak
{
    partial class FErabiltzailea
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
            components = new System.ComponentModel.Container();
            cbIrten = new Button();
            panel1 = new Panel();
            cmbId = new ComboBox();
            cmbMintegia = new ComboBox();
            lblMintegia = new Label();
            lblRola = new Label();
            cmbRola = new ComboBox();
            lblId = new Label();
            txtPasahitza = new TextBox();
            lblPasahitza = new Label();
            txtErabiltzailea = new TextBox();
            lblErabiltzailea = new Label();
            dgvErabiltzaileak = new DataGridView();
            izenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pasahitzaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mintegiaIzenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            erabiltzaileakBindingSource = new BindingSource(components);
            cbEzabatu = new Button();
            cbAldatu = new Button();
            cbGehitu = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvErabiltzaileak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erabiltzaileakBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbIrten
            // 
            cbIrten.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbIrten.Font = new Font("Times New Roman", 12F);
            cbIrten.Location = new Point(1280, 877);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(119, 30);
            cbIrten.TabIndex = 3;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cmbId);
            panel1.Controls.Add(cmbMintegia);
            panel1.Controls.Add(lblMintegia);
            panel1.Controls.Add(lblRola);
            panel1.Controls.Add(cmbRola);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(txtPasahitza);
            panel1.Controls.Add(lblPasahitza);
            panel1.Controls.Add(txtErabiltzailea);
            panel1.Controls.Add(lblErabiltzailea);
            panel1.Controls.Add(dgvErabiltzaileak);
            panel1.Location = new Point(45, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 850);
            panel1.TabIndex = 14;
            // 
            // cmbId
            // 
            cmbId.Anchor = AnchorStyles.None;
            cmbId.Font = new Font("Times New Roman", 12F);
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(420, 182);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(119, 30);
            cmbId.TabIndex = 38;
            cmbId.UseWaitCursor = true;
            cmbId.Visible = false;
            cmbId.SelectedIndexChanged += cmbId_SelectedIndexChanged;
            cmbId.Leave += cmbId_Leave;
            // 
            // cmbMintegia
            // 
            cmbMintegia.Anchor = AnchorStyles.None;
            cmbMintegia.Font = new Font("Times New Roman", 12F);
            cmbMintegia.FormattingEnabled = true;
            cmbMintegia.Location = new Point(701, 230);
            cmbMintegia.Name = "cmbMintegia";
            cmbMintegia.Size = new Size(119, 30);
            cmbMintegia.TabIndex = 31;
            cmbMintegia.UseWaitCursor = true;
            cmbMintegia.Visible = false;
            cmbMintegia.SelectedIndexChanged += cmbMintegia_SelectedIndexChanged;
            cmbMintegia.Leave += cmbMintegia_Leave;
            // 
            // lblMintegia
            // 
            lblMintegia.Anchor = AnchorStyles.None;
            lblMintegia.AutoSize = true;
            lblMintegia.Font = new Font("Times New Roman", 12F);
            lblMintegia.Location = new Point(573, 231);
            lblMintegia.Name = "lblMintegia";
            lblMintegia.Size = new Size(86, 22);
            lblMintegia.TabIndex = 34;
            lblMintegia.Text = "Mintegia:";
            lblMintegia.Visible = false;
            // 
            // lblRola
            // 
            lblRola.Anchor = AnchorStyles.None;
            lblRola.AutoSize = true;
            lblRola.Font = new Font("Times New Roman", 12F);
            lblRola.Location = new Point(573, 185);
            lblRola.Name = "lblRola";
            lblRola.Size = new Size(54, 22);
            lblRola.TabIndex = 37;
            lblRola.Text = "Rola:";
            lblRola.Visible = false;
            // 
            // cmbRola
            // 
            cmbRola.Anchor = AnchorStyles.None;
            cmbRola.Font = new Font("Times New Roman", 12F);
            cmbRola.FormattingEnabled = true;
            cmbRola.Items.AddRange(new object[] { "Irakaslea", "MintegiBurua", "IKTArduraduna" });
            cmbRola.Location = new Point(701, 182);
            cmbRola.Name = "cmbRola";
            cmbRola.Size = new Size(119, 30);
            cmbRola.TabIndex = 32;
            cmbRola.UseWaitCursor = true;
            cmbRola.Visible = false;
            cmbRola.Leave += cmbRola_Leave;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 12F);
            lblId.Location = new Point(292, 189);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 22);
            lblId.TabIndex = 33;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // txtPasahitza
            // 
            txtPasahitza.Anchor = AnchorStyles.None;
            txtPasahitza.Font = new Font("Times New Roman", 12F);
            txtPasahitza.Location = new Point(420, 285);
            txtPasahitza.Name = "txtPasahitza";
            txtPasahitza.Size = new Size(119, 30);
            txtPasahitza.TabIndex = 30;
            txtPasahitza.Visible = false;
            txtPasahitza.Leave += txtPasahitza_Leave;
            // 
            // lblPasahitza
            // 
            lblPasahitza.Anchor = AnchorStyles.None;
            lblPasahitza.AutoSize = true;
            lblPasahitza.Font = new Font("Times New Roman", 12F);
            lblPasahitza.Location = new Point(292, 291);
            lblPasahitza.Name = "lblPasahitza";
            lblPasahitza.Size = new Size(90, 22);
            lblPasahitza.TabIndex = 36;
            lblPasahitza.Text = "Pasahitza:";
            lblPasahitza.Visible = false;
            // 
            // txtErabiltzailea
            // 
            txtErabiltzailea.Anchor = AnchorStyles.None;
            txtErabiltzailea.Font = new Font("Times New Roman", 12F);
            txtErabiltzailea.Location = new Point(420, 233);
            txtErabiltzailea.Name = "txtErabiltzailea";
            txtErabiltzailea.Size = new Size(119, 30);
            txtErabiltzailea.TabIndex = 29;
            txtErabiltzailea.Visible = false;
            txtErabiltzailea.Leave += txtErabiltzailea_Leave;
            // 
            // lblErabiltzailea
            // 
            lblErabiltzailea.Anchor = AnchorStyles.None;
            lblErabiltzailea.AutoSize = true;
            lblErabiltzailea.Font = new Font("Times New Roman", 12F);
            lblErabiltzailea.Location = new Point(292, 237);
            lblErabiltzailea.Name = "lblErabiltzailea";
            lblErabiltzailea.Size = new Size(118, 22);
            lblErabiltzailea.TabIndex = 35;
            lblErabiltzailea.Text = "Erabiltzailea:";
            lblErabiltzailea.Visible = false;
            // 
            // dgvErabiltzaileak
            // 
            dgvErabiltzaileak.AllowUserToAddRows = false;
            dgvErabiltzaileak.AllowUserToDeleteRows = false;
            dgvErabiltzaileak.AutoGenerateColumns = false;
            dgvErabiltzaileak.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvErabiltzaileak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErabiltzaileak.Columns.AddRange(new DataGridViewColumn[] { izenaDataGridViewTextBoxColumn, pasahitzaDataGridViewTextBoxColumn, mintegiaIzenaDataGridViewTextBoxColumn, rolaDataGridViewTextBoxColumn });
            dgvErabiltzaileak.DataSource = erabiltzaileakBindingSource;
            dgvErabiltzaileak.Dock = DockStyle.Fill;
            dgvErabiltzaileak.Location = new Point(0, 0);
            dgvErabiltzaileak.Name = "dgvErabiltzaileak";
            dgvErabiltzaileak.ReadOnly = true;
            dgvErabiltzaileak.RowHeadersWidth = 51;
            dgvErabiltzaileak.Size = new Size(1179, 850);
            dgvErabiltzaileak.TabIndex = 0;
            // 
            // izenaDataGridViewTextBoxColumn
            // 
            izenaDataGridViewTextBoxColumn.DataPropertyName = "Izena";
            izenaDataGridViewTextBoxColumn.HeaderText = "Izena";
            izenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            izenaDataGridViewTextBoxColumn.Name = "izenaDataGridViewTextBoxColumn";
            izenaDataGridViewTextBoxColumn.ReadOnly = true;
            izenaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            izenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pasahitzaDataGridViewTextBoxColumn
            // 
            pasahitzaDataGridViewTextBoxColumn.DataPropertyName = "Pasahitza";
            pasahitzaDataGridViewTextBoxColumn.HeaderText = "Pasahitza";
            pasahitzaDataGridViewTextBoxColumn.MinimumWidth = 6;
            pasahitzaDataGridViewTextBoxColumn.Name = "pasahitzaDataGridViewTextBoxColumn";
            pasahitzaDataGridViewTextBoxColumn.ReadOnly = true;
            pasahitzaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            pasahitzaDataGridViewTextBoxColumn.Width = 125;
            // 
            // mintegiaIzenaDataGridViewTextBoxColumn
            // 
            mintegiaIzenaDataGridViewTextBoxColumn.DataPropertyName = "MintegiaIzena";
            mintegiaIzenaDataGridViewTextBoxColumn.HeaderText = "MintegiaIzena";
            mintegiaIzenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            mintegiaIzenaDataGridViewTextBoxColumn.Name = "mintegiaIzenaDataGridViewTextBoxColumn";
            mintegiaIzenaDataGridViewTextBoxColumn.ReadOnly = true;
            mintegiaIzenaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            mintegiaIzenaDataGridViewTextBoxColumn.Width = 140;
            // 
            // rolaDataGridViewTextBoxColumn
            // 
            rolaDataGridViewTextBoxColumn.DataPropertyName = "Rola";
            rolaDataGridViewTextBoxColumn.HeaderText = "Rola";
            rolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            rolaDataGridViewTextBoxColumn.Name = "rolaDataGridViewTextBoxColumn";
            rolaDataGridViewTextBoxColumn.ReadOnly = true;
            rolaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            rolaDataGridViewTextBoxColumn.Width = 130;
            // 
            // erabiltzaileakBindingSource
            // 
            erabiltzaileakBindingSource.DataSource = typeof(DatuModeloak.Erabiltzaileak);
            // 
            // cbEzabatu
            // 
            cbEzabatu.Anchor = AnchorStyles.Right;
            cbEzabatu.Font = new Font("Times New Roman", 12F);
            cbEzabatu.Location = new Point(1280, 153);
            cbEzabatu.Name = "cbEzabatu";
            cbEzabatu.Size = new Size(119, 30);
            cbEzabatu.TabIndex = 2;
            cbEzabatu.Text = "Ezabatu";
            cbEzabatu.UseVisualStyleBackColor = true;
            cbEzabatu.Click += cbEzabatu_Click;
            // 
            // cbAldatu
            // 
            cbAldatu.Anchor = AnchorStyles.Right;
            cbAldatu.Font = new Font("Times New Roman", 12F);
            cbAldatu.Location = new Point(1280, 105);
            cbAldatu.Name = "cbAldatu";
            cbAldatu.Size = new Size(119, 30);
            cbAldatu.TabIndex = 1;
            cbAldatu.Text = "Aldatu";
            cbAldatu.UseVisualStyleBackColor = true;
            cbAldatu.Click += cbAldatu_Click;
            // 
            // cbGehitu
            // 
            cbGehitu.Anchor = AnchorStyles.Right;
            cbGehitu.Font = new Font("Times New Roman", 12F);
            cbGehitu.Location = new Point(1280, 57);
            cbGehitu.Name = "cbGehitu";
            cbGehitu.Size = new Size(119, 30);
            cbGehitu.TabIndex = 0;
            cbGehitu.Text = "Gehitu";
            cbGehitu.UseVisualStyleBackColor = true;
            cbGehitu.Click += cbGehitu_Click;
            // 
            // FErabiltzailea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1466, 956);
            Controls.Add(panel1);
            Controls.Add(cbEzabatu);
            Controls.Add(cbAldatu);
            Controls.Add(cbGehitu);
            Controls.Add(cbIrten);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FErabiltzailea";
            Text = "FErabiltzailea";
            Load += FErabiltzailea_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvErabiltzaileak).EndInit();
            ((System.ComponentModel.ISupportInitialize)erabiltzaileakBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cbIrten;
        private Panel panel1;
        private DataGridView dgvErabiltzaileak;
        private Button cbEzabatu;
        private Button cbAldatu;
        private Button cbGehitu;
        private BindingSource erabiltzaileakBindingSource;
        private ComboBox cmbId;
        private ComboBox cmbMintegia;
        private Label lblMintegia;
        private Label lblRola;
        private ComboBox cmbRola;
        private Label lblId;
        private TextBox txtPasahitza;
        private Label lblPasahitza;
        private TextBox txtErabiltzailea;
        private Label lblErabiltzailea;
        private DataGridViewTextBoxColumn izenaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pasahitzaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mintegiaIzenaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolaDataGridViewTextBoxColumn;
    }
}