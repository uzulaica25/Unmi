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
            cbIrten = new Button();
            dgvIntzidentziak = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            gailuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mezuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            intzidentziakBindingSource2 = new BindingSource(components);
            intzidentziakBindingSource1 = new BindingSource(components);
            intzidentziakBindingSource = new BindingSource(components);
            panel1 = new Panel();
            cmbGailua = new ComboBox();
            lblGailua = new Label();
            cmbId = new ComboBox();
            lblId = new Label();
            lblMezua = new Label();
            txtMezua = new TextBox();
            lblData = new Label();
            dtpData = new DateTimePicker();
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
            cbIrten.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIrten.Location = new Point(682, 365);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(94, 29);
            cbIrten.TabIndex = 4;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click;
            // 
            // dgvIntzidentziak
            // 
            dgvIntzidentziak.AllowUserToAddRows = false;
            dgvIntzidentziak.AllowUserToDeleteRows = false;
            dgvIntzidentziak.AutoGenerateColumns = false;
            dgvIntzidentziak.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvIntzidentziak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIntzidentziak.Columns.AddRange(new DataGridViewColumn[] { Column1, gailuaDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, mezuaDataGridViewTextBoxColumn });
            dgvIntzidentziak.DataSource = intzidentziakBindingSource2;
            dgvIntzidentziak.Dock = DockStyle.Fill;
            dgvIntzidentziak.Location = new Point(0, 0);
            dgvIntzidentziak.Name = "dgvIntzidentziak";
            dgvIntzidentziak.ReadOnly = true;
            dgvIntzidentziak.RowHeadersWidth = 51;
            dgvIntzidentziak.Size = new Size(653, 339);
            dgvIntzidentziak.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // gailuaDataGridViewTextBoxColumn
            // 
            gailuaDataGridViewTextBoxColumn.DataPropertyName = "IDGailua";
            gailuaDataGridViewTextBoxColumn.HeaderText = "Gailua";
            gailuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            gailuaDataGridViewTextBoxColumn.Name = "gailuaDataGridViewTextBoxColumn";
            gailuaDataGridViewTextBoxColumn.ReadOnly = true;
            gailuaDataGridViewTextBoxColumn.Width = 125;
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
            // mezuaDataGridViewTextBoxColumn
            // 
            mezuaDataGridViewTextBoxColumn.DataPropertyName = "Mezua";
            mezuaDataGridViewTextBoxColumn.HeaderText = "Mezua";
            mezuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            mezuaDataGridViewTextBoxColumn.Name = "mezuaDataGridViewTextBoxColumn";
            mezuaDataGridViewTextBoxColumn.ReadOnly = true;
            mezuaDataGridViewTextBoxColumn.Width = 125;
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
            panel1.Controls.Add(cmbGailua);
            panel1.Controls.Add(lblGailua);
            panel1.Controls.Add(cmbId);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(lblMezua);
            panel1.Controls.Add(txtMezua);
            panel1.Controls.Add(lblData);
            panel1.Controls.Add(dtpData);
            panel1.Controls.Add(dgvIntzidentziak);
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 339);
            panel1.TabIndex = 14;
            // 
            // cmbGailua
            // 
            cmbGailua.Font = new Font("Times New Roman", 10.2F);
            cmbGailua.FormattingEnabled = true;
            cmbGailua.Location = new Point(201, 109);
            cmbGailua.Name = "cmbGailua";
            cmbGailua.Size = new Size(125, 27);
            cmbGailua.TabIndex = 36;
            cmbGailua.UseWaitCursor = true;
            cmbGailua.Visible = false;
            // 
            // lblGailua
            // 
            lblGailua.AutoSize = true;
            lblGailua.Font = new Font("Times New Roman", 10.2F);
            lblGailua.Location = new Point(105, 117);
            lblGailua.Name = "lblGailua";
            lblGailua.Size = new Size(58, 19);
            lblGailua.TabIndex = 37;
            lblGailua.Text = "Gailua:";
            lblGailua.Visible = false;
            // 
            // cmbId
            // 
            cmbId.Font = new Font("Times New Roman", 10.2F);
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(201, 61);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(125, 27);
            cmbId.TabIndex = 35;
            cmbId.UseWaitCursor = true;
            cmbId.Visible = false;
            cmbId.SelectedIndexChanged += cmbId_SelectedIndexChanged;
            cmbId.SelectedValueChanged += cmbId_SelectedValueChanged;
            cmbId.Leave += cmbId_Leave;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 10.2F);
            lblId.Location = new Point(105, 69);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 19);
            lblId.TabIndex = 31;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // lblMezua
            // 
            lblMezua.AutoSize = true;
            lblMezua.Font = new Font("Times New Roman", 10.2F);
            lblMezua.Location = new Point(105, 223);
            lblMezua.Name = "lblMezua";
            lblMezua.Size = new Size(59, 19);
            lblMezua.TabIndex = 33;
            lblMezua.Text = "Mezua:";
            lblMezua.Visible = false;
            // 
            // txtMezua
            // 
            txtMezua.Font = new Font("Times New Roman", 10.2F);
            txtMezua.Location = new Point(201, 218);
            txtMezua.Name = "txtMezua";
            txtMezua.Size = new Size(125, 27);
            txtMezua.TabIndex = 38;
            txtMezua.Visible = false;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Times New Roman", 10.2F);
            lblData.Location = new Point(105, 172);
            lblData.Name = "lblData";
            lblData.Size = new Size(45, 19);
            lblData.TabIndex = 34;
            lblData.Text = "Data:";
            lblData.Visible = false;
            // 
            // dtpData
            // 
            dtpData.CalendarFont = new Font("Times New Roman", 10.2F);
            dtpData.Font = new Font("Times New Roman", 10.2F);
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(201, 165);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(125, 27);
            dtpData.TabIndex = 37;
            dtpData.Value = new DateTime(2026, 4, 17, 19, 5, 51, 0);
            dtpData.Visible = false;
            // 
            // cbGehitu
            // 
            cbGehitu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGehitu.Location = new Point(682, 55);
            cbGehitu.Name = "cbGehitu";
            cbGehitu.Size = new Size(94, 29);
            cbGehitu.TabIndex = 0;
            cbGehitu.Text = "Gehitu";
            cbGehitu.UseVisualStyleBackColor = true;
            cbGehitu.Click += cbGehitu_Click;
            // 
            // cbAldatu
            // 
            cbAldatu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAldatu.Location = new Point(682, 103);
            cbAldatu.Name = "cbAldatu";
            cbAldatu.Size = new Size(94, 29);
            cbAldatu.TabIndex = 1;
            cbAldatu.Text = "Aldatu";
            cbAldatu.UseVisualStyleBackColor = true;
            cbAldatu.Click += cbAldatu_Click;
            // 
            // cbEzabatu
            // 
            cbEzabatu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEzabatu.Location = new Point(682, 151);
            cbEzabatu.Name = "cbEzabatu";
            cbEzabatu.Size = new Size(94, 29);
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
            cbAurkitu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAurkitu.Location = new Point(682, 195);
            cbAurkitu.Name = "cbAurkitu";
            cbAurkitu.Size = new Size(94, 29);
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
            ClientSize = new Size(800, 450);
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
        private DataGridViewTextBoxColumn mezuaDataGridViewTextBoxColumn;
    }
}