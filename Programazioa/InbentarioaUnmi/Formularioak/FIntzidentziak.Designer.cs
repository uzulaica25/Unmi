namespace InbentarioaUnmi.Formularioak
{
    partial class FIntzidentziak
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cbIrten = new Button();
            dgvIntzidentziak = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            gailuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GailuMota = new DataGridViewTextBoxColumn();
            mezuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            intzidentziakBindingSource2 = new BindingSource(components);
            intzidentziakBindingSource1 = new BindingSource(components);
            intzidentziakBindingSource = new BindingSource(components);
            panel1 = new Panel();
            cmbGailua = new ComboBox();
            cmbId = new ComboBox();
            lblGailua = new Label();
            dtpData = new DateTimePicker();
            lblData = new Label();
            txtMezua = new TextBox();
            lblId = new Label();
            lblMezua = new Label();
            cbGehitu = new Button();
            cbAldatu = new Button();
            cbEzabatu = new Button();
            inprimagailuakBindingSource = new BindingSource(components);
            cbAurkitu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIntzidentziak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intzidentziakBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intzidentziakBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intzidentziakBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inprimagailuakBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbIrten
            // 
            cbIrten.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbIrten.Cursor = Cursors.Hand;
            cbIrten.Font = new Font("Times New Roman", 12F);
            cbIrten.Location = new Point(1375, 868);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(119, 35);
            cbIrten.TabIndex = 4;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click;
            // 
            // dgvIntzidentziak
            // 
            dgvIntzidentziak.AllowUserToAddRows = false;
            dgvIntzidentziak.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvIntzidentziak.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvIntzidentziak.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIntzidentziak.AutoGenerateColumns = false;
            dgvIntzidentziak.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvIntzidentziak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIntzidentziak.Columns.AddRange(new DataGridViewColumn[] { Column1, gailuaDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, GailuMota, mezuaDataGridViewTextBoxColumn });
            dgvIntzidentziak.DataSource = intzidentziakBindingSource2;
            dgvIntzidentziak.Location = new Point(0, 0);
            dgvIntzidentziak.Name = "dgvIntzidentziak";
            dgvIntzidentziak.ReadOnly = true;
            dgvIntzidentziak.RowHeadersWidth = 51;
            dgvIntzidentziak.Size = new Size(1329, 848);
            dgvIntzidentziak.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 70;
            // 
            // gailuaDataGridViewTextBoxColumn
            // 
            gailuaDataGridViewTextBoxColumn.DataPropertyName = "IDGailua";
            gailuaDataGridViewTextBoxColumn.HeaderText = "Gailua";
            gailuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            gailuaDataGridViewTextBoxColumn.Name = "gailuaDataGridViewTextBoxColumn";
            gailuaDataGridViewTextBoxColumn.ReadOnly = true;
            gailuaDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.ReadOnly = true;
            dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // GailuMota
            // 
            GailuMota.DataPropertyName = "GailuMota";
            GailuMota.HeaderText = "GailuMota";
            GailuMota.MinimumWidth = 6;
            GailuMota.Name = "GailuMota";
            GailuMota.ReadOnly = true;
            GailuMota.Width = 125;
            // 
            // mezuaDataGridViewTextBoxColumn
            // 
            mezuaDataGridViewTextBoxColumn.DataPropertyName = "Mezua";
            mezuaDataGridViewTextBoxColumn.HeaderText = "Mezua";
            mezuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            mezuaDataGridViewTextBoxColumn.Name = "mezuaDataGridViewTextBoxColumn";
            mezuaDataGridViewTextBoxColumn.ReadOnly = true;
            mezuaDataGridViewTextBoxColumn.Width = 400;
            // 
            // intzidentziakBindingSource2
            // 
            intzidentziakBindingSource2.DataSource = typeof(DatuModeloak.Intzidentziak);
            // 
            // intzidentziakBindingSource1
            // 
            intzidentziakBindingSource1.DataSource = typeof(DatuModeloak.Intzidentziak);
            // 
            // intzidentziakBindingSource
            // 
            intzidentziakBindingSource.DataSource = typeof(DatuModeloak.Intzidentziak);
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cmbGailua);
            panel1.Controls.Add(cmbId);
            panel1.Controls.Add(lblGailua);
            panel1.Controls.Add(dtpData);
            panel1.Controls.Add(lblData);
            panel1.Controls.Add(txtMezua);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(lblMezua);
            panel1.Controls.Add(dgvIntzidentziak);
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1329, 848);
            panel1.TabIndex = 14;
            // 
            // cmbGailua
            // 
            cmbGailua.Anchor = AnchorStyles.None;
            cmbGailua.Font = new Font("Times New Roman", 12F);
            cmbGailua.FormattingEnabled = true;
            cmbGailua.Location = new Point(768, 234);
            cmbGailua.Name = "cmbGailua";
            cmbGailua.Size = new Size(119, 30);
            cmbGailua.TabIndex = 36;
            cmbGailua.UseWaitCursor = true;
            cmbGailua.Visible = false;
            // 
            // cmbId
            // 
            cmbId.Anchor = AnchorStyles.None;
            cmbId.Font = new Font("Times New Roman", 12F);
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(768, 186);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(119, 30);
            cmbId.TabIndex = 35;
            cmbId.UseWaitCursor = true;
            cmbId.Visible = false;
            cmbId.SelectedIndexChanged += cmbId_SelectedIndexChanged;
            cmbId.SelectedValueChanged += cmbId_SelectedValueChanged;
            cmbId.Leave += cmbId_Leave;
            // 
            // lblGailua
            // 
            lblGailua.Anchor = AnchorStyles.None;
            lblGailua.AutoSize = true;
            lblGailua.Font = new Font("Times New Roman", 12F);
            lblGailua.Location = new Point(672, 242);
            lblGailua.Name = "lblGailua";
            lblGailua.Size = new Size(69, 22);
            lblGailua.TabIndex = 37;
            lblGailua.Text = "Gailua:";
            lblGailua.Visible = false;
            // 
            // dtpData
            // 
            dtpData.Anchor = AnchorStyles.None;
            dtpData.CalendarFont = new Font("Times New Roman", 10.2F);
            dtpData.Font = new Font("Times New Roman", 12F);
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(768, 290);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(119, 30);
            dtpData.TabIndex = 37;
            dtpData.Value = new DateTime(2026, 4, 17, 19, 5, 51, 0);
            dtpData.Visible = false;
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.None;
            lblData.AutoSize = true;
            lblData.Font = new Font("Times New Roman", 12F);
            lblData.Location = new Point(672, 297);
            lblData.Name = "lblData";
            lblData.Size = new Size(53, 22);
            lblData.TabIndex = 34;
            lblData.Text = "Data:";
            lblData.Visible = false;
            // 
            // txtMezua
            // 
            txtMezua.Anchor = AnchorStyles.None;
            txtMezua.Cursor = Cursors.IBeam;
            txtMezua.Font = new Font("Times New Roman", 12F);
            txtMezua.Location = new Point(768, 343);
            txtMezua.Name = "txtMezua";
            txtMezua.Size = new Size(119, 30);
            txtMezua.TabIndex = 38;
            txtMezua.Visible = false;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 12F);
            lblId.Location = new Point(672, 194);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 22);
            lblId.TabIndex = 31;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // lblMezua
            // 
            lblMezua.Anchor = AnchorStyles.None;
            lblMezua.AutoSize = true;
            lblMezua.Font = new Font("Times New Roman", 12F);
            lblMezua.Location = new Point(672, 348);
            lblMezua.Name = "lblMezua";
            lblMezua.Size = new Size(68, 22);
            lblMezua.TabIndex = 33;
            lblMezua.Text = "Mezua:";
            lblMezua.Visible = false;
            // 
            // cbGehitu
            // 
            cbGehitu.Anchor = AnchorStyles.Right;
            cbGehitu.Cursor = Cursors.Hand;
            cbGehitu.Font = new Font("Times New Roman", 12F);
            cbGehitu.Location = new Point(1375, 55);
            cbGehitu.Name = "cbGehitu";
            cbGehitu.Size = new Size(119, 35);
            cbGehitu.TabIndex = 0;
            cbGehitu.Text = "Gehitu";
            cbGehitu.UseVisualStyleBackColor = true;
            cbGehitu.Click += cbGehitu_Click;
            // 
            // cbAldatu
            // 
            cbAldatu.Anchor = AnchorStyles.Right;
            cbAldatu.Cursor = Cursors.Hand;
            cbAldatu.Font = new Font("Times New Roman", 12F);
            cbAldatu.Location = new Point(1375, 103);
            cbAldatu.Name = "cbAldatu";
            cbAldatu.Size = new Size(119, 35);
            cbAldatu.TabIndex = 1;
            cbAldatu.Text = "Aldatu";
            cbAldatu.UseVisualStyleBackColor = true;
            cbAldatu.Click += cbAldatu_Click;
            // 
            // cbEzabatu
            // 
            cbEzabatu.Anchor = AnchorStyles.Right;
            cbEzabatu.Cursor = Cursors.Hand;
            cbEzabatu.Font = new Font("Times New Roman", 12F);
            cbEzabatu.Location = new Point(1375, 151);
            cbEzabatu.Name = "cbEzabatu";
            cbEzabatu.Size = new Size(119, 35);
            cbEzabatu.TabIndex = 2;
            cbEzabatu.Text = "Ezabatu";
            cbEzabatu.UseVisualStyleBackColor = true;
            cbEzabatu.Click += cbEzabatu_Click;
            // 
            // inprimagailuakBindingSource
            // 
            inprimagailuakBindingSource.DataSource = typeof(DatuModeloak.Inprimagailuak);
            // 
            // cbAurkitu
            // 
            cbAurkitu.Anchor = AnchorStyles.Right;
            cbAurkitu.Cursor = Cursors.Hand;
            cbAurkitu.Font = new Font("Times New Roman", 12F);
            cbAurkitu.Location = new Point(1375, 195);
            cbAurkitu.Name = "cbAurkitu";
            cbAurkitu.Size = new Size(119, 35);
            cbAurkitu.TabIndex = 3;
            cbAurkitu.Text = "Aurkitu";
            cbAurkitu.UseVisualStyleBackColor = true;
            cbAurkitu.Click += cbAurkitu_Click;
            // 
            // FIntzidentziak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1567, 947);
            Controls.Add(cbAurkitu);
            Controls.Add(panel1);
            Controls.Add(cbEzabatu);
            Controls.Add(cbAldatu);
            Controls.Add(cbGehitu);
            Controls.Add(cbIrten);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FIntzidentziak";
            Load += FIntzidentziak_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIntzidentziak).EndInit();
            ((System.ComponentModel.ISupportInitialize)intzidentziakBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)intzidentziakBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)intzidentziakBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inprimagailuakBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cbIrten;
        private DataGridView dgvIntzidentziak;
        private Panel panel1;
        private Button cbGehitu;
        private Button cbAldatu;
        private Button cbEzabatu;
        private BindingSource intzidentziakBindingSource;
        private BindingSource intzidentziakBindingSource1;
        private BindingSource inprimagailuakBindingSource;
        private ComboBox cmbId;
        private Label lblId;
        private Label lblMezua;
        private TextBox txtMezua;
        private Label lblData;
        private DateTimePicker dtpData;
        private Label lblGailua;
        private BindingSource intzidentziakBindingSource2;
        private ComboBox cmbGailua;
        private Button cbAurkitu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn gailuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn GailuMota;
        private DataGridViewTextBoxColumn mezuaDataGridViewTextBoxColumn;
    }
}