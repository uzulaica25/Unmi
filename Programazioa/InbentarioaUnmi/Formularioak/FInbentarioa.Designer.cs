namespace InbentarioaUnmi.Formularioak
{
    partial class FInbentarioa
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
            panel1 = new Panel();
            dtpErosteData = new DateTimePicker();
            lblErosteData = new Label();
            cmbId = new ComboBox();
            chbBai = new CheckBox();
            cmbMintegia = new ComboBox();
            lblMintegia = new Label();
            lblGailuMota = new Label();
            txtRam = new TextBox();
            cmbGailuMota = new ComboBox();
            lblKoloretakoa = new Label();
            lblRam = new Label();
            lblId = new Label();
            txtCpu = new TextBox();
            lblCpu = new Label();
            txtKokalekua = new TextBox();
            lblKokalekua = new Label();
            txtMarka = new TextBox();
            lblMarka = new Label();
            dgvOrdenagailua = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            markaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kokalekuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            erosteDataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MintegiaIzena = new DataGridViewTextBoxColumn();
            Cpu = new DataGridViewTextBoxColumn();
            Ram = new DataGridViewTextBoxColumn();
            ordenagailuakBindingSource = new BindingSource(components);
            cbEzabatu = new Button();
            cbAldatu = new Button();
            cbGehitu = new Button();
            cbIrten = new Button();
            inprimagailuakBindingSource = new BindingSource(components);
            panel2 = new Panel();
            dgvInprimagailua = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Koloretakoa = new DataGridViewCheckBoxColumn();
            lblOrdenagailua = new Label();
            lblInprimagailua = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenagailua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordenagailuakBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inprimagailuakBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInprimagailua).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dtpErosteData);
            panel1.Controls.Add(lblErosteData);
            panel1.Controls.Add(cmbId);
            panel1.Controls.Add(chbBai);
            panel1.Controls.Add(cmbMintegia);
            panel1.Controls.Add(lblMintegia);
            panel1.Controls.Add(lblGailuMota);
            panel1.Controls.Add(txtRam);
            panel1.Controls.Add(cmbGailuMota);
            panel1.Controls.Add(lblKoloretakoa);
            panel1.Controls.Add(lblRam);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(txtCpu);
            panel1.Controls.Add(lblCpu);
            panel1.Controls.Add(txtKokalekua);
            panel1.Controls.Add(lblKokalekua);
            panel1.Controls.Add(txtMarka);
            panel1.Controls.Add(lblMarka);
            panel1.Controls.Add(dgvOrdenagailua);
            panel1.Location = new Point(11, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 374);
            panel1.TabIndex = 14;
            // 
            // dtpErosteData
            // 
            dtpErosteData.Anchor = AnchorStyles.None;
            dtpErosteData.CalendarFont = new Font("Times New Roman", 10.2F);
            dtpErosteData.Font = new Font("Times New Roman", 12F);
            dtpErosteData.Format = DateTimePickerFormat.Short;
            dtpErosteData.Location = new Point(606, 356);
            dtpErosteData.Name = "dtpErosteData";
            dtpErosteData.Size = new Size(119, 30);
            dtpErosteData.TabIndex = 17;
            dtpErosteData.Value = new DateTime(2026, 4, 17, 19, 5, 51, 0);
            dtpErosteData.Visible = false;
            dtpErosteData.Leave += dtpErosteData_Leave;
            // 
            // lblErosteData
            // 
            lblErosteData.Anchor = AnchorStyles.None;
            lblErosteData.AutoSize = true;
            lblErosteData.Font = new Font("Times New Roman", 12F);
            lblErosteData.Location = new Point(500, 362);
            lblErosteData.Name = "lblErosteData";
            lblErosteData.Size = new Size(104, 22);
            lblErosteData.TabIndex = 22;
            lblErosteData.Text = "ErosteData:";
            lblErosteData.Visible = false;
            // 
            // cmbId
            // 
            cmbId.Anchor = AnchorStyles.None;
            cmbId.Font = new Font("Times New Roman", 12F);
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(606, 136);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(119, 30);
            cmbId.TabIndex = 28;
            cmbId.UseWaitCursor = true;
            cmbId.Visible = false;
            cmbId.SelectedValueChanged += cmbId_SelectedValueChanged;
            cmbId.Leave += cmbId_Leave;
            // 
            // chbBai
            // 
            chbBai.Anchor = AnchorStyles.None;
            chbBai.AutoSize = true;
            chbBai.Font = new Font("Times New Roman", 12F);
            chbBai.Location = new Point(990, 129);
            chbBai.Name = "chbBai";
            chbBai.Size = new Size(60, 26);
            chbBai.TabIndex = 18;
            chbBai.Text = "Bai";
            chbBai.UseVisualStyleBackColor = true;
            chbBai.Visible = false;
            chbBai.Leave += chbBai_Leave;
            // 
            // cmbMintegia
            // 
            cmbMintegia.Anchor = AnchorStyles.None;
            cmbMintegia.Font = new Font("Times New Roman", 12F);
            cmbMintegia.FormattingEnabled = true;
            cmbMintegia.Location = new Point(606, 306);
            cmbMintegia.Name = "cmbMintegia";
            cmbMintegia.Size = new Size(119, 30);
            cmbMintegia.TabIndex = 16;
            cmbMintegia.UseWaitCursor = true;
            cmbMintegia.Visible = false;
            cmbMintegia.Leave += cmbMintegia_Leave;
            // 
            // lblMintegia
            // 
            lblMintegia.Anchor = AnchorStyles.None;
            lblMintegia.AutoSize = true;
            lblMintegia.Font = new Font("Times New Roman", 12F);
            lblMintegia.Location = new Point(500, 307);
            lblMintegia.Name = "lblMintegia";
            lblMintegia.Size = new Size(86, 22);
            lblMintegia.TabIndex = 18;
            lblMintegia.Text = "Mintegia:";
            lblMintegia.Visible = false;
            // 
            // lblGailuMota
            // 
            lblGailuMota.Anchor = AnchorStyles.None;
            lblGailuMota.AutoSize = true;
            lblGailuMota.Font = new Font("Times New Roman", 12F);
            lblGailuMota.Location = new Point(622, 281);
            lblGailuMota.Name = "lblGailuMota";
            lblGailuMota.Size = new Size(103, 22);
            lblGailuMota.TabIndex = 27;
            lblGailuMota.Text = "Gailu mota:";
            lblGailuMota.Visible = false;
            // 
            // txtRam
            // 
            txtRam.Anchor = AnchorStyles.None;
            txtRam.Cursor = Cursors.IBeam;
            txtRam.Font = new Font("Times New Roman", 12F);
            txtRam.Location = new Point(976, 222);
            txtRam.Name = "txtRam";
            txtRam.Size = new Size(119, 30);
            txtRam.TabIndex = 20;
            txtRam.Visible = false;
            txtRam.Leave += txtRam_Leave;
            // 
            // cmbGailuMota
            // 
            cmbGailuMota.Anchor = AnchorStyles.None;
            cmbGailuMota.Font = new Font("Times New Roman", 12F);
            cmbGailuMota.FormattingEnabled = true;
            cmbGailuMota.Items.AddRange(new object[] { "Ordenagailua", "Inprimagailua" });
            cmbGailuMota.Location = new Point(742, 278);
            cmbGailuMota.Name = "cmbGailuMota";
            cmbGailuMota.Size = new Size(119, 30);
            cmbGailuMota.TabIndex = 16;
            cmbGailuMota.UseWaitCursor = true;
            cmbGailuMota.Visible = false;
            cmbGailuMota.SelectedValueChanged += cmbGailuMota_SelectedValueChanged;
            // 
            // lblKoloretakoa
            // 
            lblKoloretakoa.Anchor = AnchorStyles.None;
            lblKoloretakoa.AutoSize = true;
            lblKoloretakoa.Font = new Font("Times New Roman", 12F);
            lblKoloretakoa.Location = new Point(870, 133);
            lblKoloretakoa.Name = "lblKoloretakoa";
            lblKoloretakoa.Size = new Size(114, 22);
            lblKoloretakoa.TabIndex = 24;
            lblKoloretakoa.Text = "Koloretakoa:";
            lblKoloretakoa.Visible = false;
            // 
            // lblRam
            // 
            lblRam.Anchor = AnchorStyles.None;
            lblRam.AutoSize = true;
            lblRam.Font = new Font("Times New Roman", 12F);
            lblRam.Location = new Point(870, 225);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(60, 22);
            lblRam.TabIndex = 22;
            lblRam.Text = "RAM:";
            lblRam.Visible = false;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 12F);
            lblId.Location = new Point(500, 144);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 22);
            lblId.TabIndex = 16;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // txtCpu
            // 
            txtCpu.Anchor = AnchorStyles.None;
            txtCpu.Cursor = Cursors.IBeam;
            txtCpu.Font = new Font("Times New Roman", 12F);
            txtCpu.Location = new Point(976, 176);
            txtCpu.Name = "txtCpu";
            txtCpu.Size = new Size(119, 30);
            txtCpu.TabIndex = 19;
            txtCpu.Visible = false;
            txtCpu.Leave += txtCpu_Leave;
            // 
            // lblCpu
            // 
            lblCpu.Anchor = AnchorStyles.None;
            lblCpu.AutoSize = true;
            lblCpu.Font = new Font("Times New Roman", 12F);
            lblCpu.Location = new Point(870, 182);
            lblCpu.Name = "lblCpu";
            lblCpu.Size = new Size(53, 22);
            lblCpu.TabIndex = 20;
            lblCpu.Text = "CPU:";
            lblCpu.Visible = false;
            // 
            // txtKokalekua
            // 
            txtKokalekua.Anchor = AnchorStyles.None;
            txtKokalekua.Cursor = Cursors.IBeam;
            txtKokalekua.Font = new Font("Times New Roman", 12F);
            txtKokalekua.Location = new Point(606, 253);
            txtKokalekua.Name = "txtKokalekua";
            txtKokalekua.Size = new Size(119, 30);
            txtKokalekua.TabIndex = 15;
            txtKokalekua.Visible = false;
            txtKokalekua.Leave += txtKokalekua_Leave;
            // 
            // lblKokalekua
            // 
            lblKokalekua.Anchor = AnchorStyles.None;
            lblKokalekua.AutoSize = true;
            lblKokalekua.Font = new Font("Times New Roman", 12F);
            lblKokalekua.Location = new Point(500, 256);
            lblKokalekua.Name = "lblKokalekua";
            lblKokalekua.Size = new Size(100, 22);
            lblKokalekua.TabIndex = 20;
            lblKokalekua.Text = "Kokalekua:";
            lblKokalekua.Visible = false;
            // 
            // txtMarka
            // 
            txtMarka.Anchor = AnchorStyles.None;
            txtMarka.Cursor = Cursors.IBeam;
            txtMarka.Font = new Font("Times New Roman", 12F);
            txtMarka.Location = new Point(606, 201);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(119, 30);
            txtMarka.TabIndex = 14;
            txtMarka.Visible = false;
            txtMarka.Leave += txtMarka_Leave;
            // 
            // lblMarka
            // 
            lblMarka.Anchor = AnchorStyles.None;
            lblMarka.AutoSize = true;
            lblMarka.Font = new Font("Times New Roman", 12F);
            lblMarka.Location = new Point(500, 206);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(67, 22);
            lblMarka.TabIndex = 18;
            lblMarka.Text = "Marka:";
            lblMarka.Visible = false;
            // 
            // dgvOrdenagailua
            // 
            dgvOrdenagailua.AllowUserToAddRows = false;
            dgvOrdenagailua.AllowUserToDeleteRows = false;
            dgvOrdenagailua.AllowUserToResizeColumns = false;
            dgvOrdenagailua.AllowUserToResizeRows = false;
            dgvOrdenagailua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrdenagailua.AutoGenerateColumns = false;
            dgvOrdenagailua.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrdenagailua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrdenagailua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenagailua.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, markaDataGridViewTextBoxColumn, kokalekuaDataGridViewTextBoxColumn, erosteDataDataGridViewTextBoxColumn, MintegiaIzena, Cpu, Ram });
            dgvOrdenagailua.DataSource = ordenagailuakBindingSource;
            dgvOrdenagailua.Location = new Point(0, 0);
            dgvOrdenagailua.Name = "dgvOrdenagailua";
            dgvOrdenagailua.ReadOnly = true;
            dgvOrdenagailua.RowHeadersWidth = 51;
            dgvOrdenagailua.Size = new Size(1400, 374);
            dgvOrdenagailua.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            markaDataGridViewTextBoxColumn.ReadOnly = true;
            markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kokalekuaDataGridViewTextBoxColumn
            // 
            kokalekuaDataGridViewTextBoxColumn.DataPropertyName = "Kokalekua";
            kokalekuaDataGridViewTextBoxColumn.HeaderText = "Kokalekua";
            kokalekuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            kokalekuaDataGridViewTextBoxColumn.Name = "kokalekuaDataGridViewTextBoxColumn";
            kokalekuaDataGridViewTextBoxColumn.ReadOnly = true;
            kokalekuaDataGridViewTextBoxColumn.Width = 125;
            // 
            // erosteDataDataGridViewTextBoxColumn
            // 
            erosteDataDataGridViewTextBoxColumn.DataPropertyName = "ErosteData";
            erosteDataDataGridViewTextBoxColumn.HeaderText = "ErosteData";
            erosteDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            erosteDataDataGridViewTextBoxColumn.Name = "erosteDataDataGridViewTextBoxColumn";
            erosteDataDataGridViewTextBoxColumn.ReadOnly = true;
            erosteDataDataGridViewTextBoxColumn.Width = 125;
            // 
            // MintegiaIzena
            // 
            MintegiaIzena.DataPropertyName = "MintegiaIzena";
            MintegiaIzena.HeaderText = "MintegiaIzena";
            MintegiaIzena.MinimumWidth = 6;
            MintegiaIzena.Name = "MintegiaIzena";
            MintegiaIzena.ReadOnly = true;
            MintegiaIzena.Width = 125;
            // 
            // Cpu
            // 
            Cpu.DataPropertyName = "Cpu";
            Cpu.HeaderText = "Cpu";
            Cpu.MinimumWidth = 6;
            Cpu.Name = "Cpu";
            Cpu.ReadOnly = true;
            Cpu.Width = 125;
            // 
            // Ram
            // 
            Ram.DataPropertyName = "Ram";
            Ram.HeaderText = "Ram";
            Ram.MinimumWidth = 6;
            Ram.Name = "Ram";
            Ram.ReadOnly = true;
            Ram.Width = 125;
            // 
            // ordenagailuakBindingSource
            // 
            ordenagailuakBindingSource.DataSource = typeof(DatuModeloak.Ordenagailuak);
            // 
            // cbEzabatu
            // 
            cbEzabatu.Anchor = AnchorStyles.Right;
            cbEzabatu.Cursor = Cursors.Hand;
            cbEzabatu.Font = new Font("Times New Roman", 12F);
            cbEzabatu.Location = new Point(1450, 155);
            cbEzabatu.Name = "cbEzabatu";
            cbEzabatu.Size = new Size(119, 35);
            cbEzabatu.TabIndex = 23;
            cbEzabatu.Text = "Ezabatu";
            cbEzabatu.UseVisualStyleBackColor = true;
            cbEzabatu.Click += cbEzabatu_Click;
            // 
            // cbAldatu
            // 
            cbAldatu.Anchor = AnchorStyles.Right;
            cbAldatu.Cursor = Cursors.Hand;
            cbAldatu.Font = new Font("Times New Roman", 12F);
            cbAldatu.Location = new Point(1450, 106);
            cbAldatu.Name = "cbAldatu";
            cbAldatu.Size = new Size(119, 35);
            cbAldatu.TabIndex = 22;
            cbAldatu.Text = "Aldatu";
            cbAldatu.UseVisualStyleBackColor = true;
            cbAldatu.Click += cbAldatu_Click;
            // 
            // cbGehitu
            // 
            cbGehitu.Anchor = AnchorStyles.Right;
            cbGehitu.Cursor = Cursors.Hand;
            cbGehitu.Font = new Font("Times New Roman", 12F);
            cbGehitu.Location = new Point(1450, 56);
            cbGehitu.Name = "cbGehitu";
            cbGehitu.Size = new Size(119, 35);
            cbGehitu.TabIndex = 21;
            cbGehitu.Text = "Gehitu";
            cbGehitu.UseVisualStyleBackColor = true;
            cbGehitu.Click += cbGehitu_Click;
            // 
            // cbIrten
            // 
            cbIrten.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbIrten.Cursor = Cursors.Hand;
            cbIrten.Font = new Font("Times New Roman", 12F);
            cbIrten.Location = new Point(1450, 794);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(119, 35);
            cbIrten.TabIndex = 50;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click_1;
            // 
            // inprimagailuakBindingSource
            // 
            inprimagailuakBindingSource.DataSource = typeof(DatuModeloak.Inprimagailuak);
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dgvInprimagailua);
            panel2.Location = new Point(12, 511);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 318);
            panel2.TabIndex = 15;
            // 
            // dgvInprimagailua
            // 
            dgvInprimagailua.AllowUserToAddRows = false;
            dgvInprimagailua.AllowUserToDeleteRows = false;
            dgvInprimagailua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInprimagailua.AutoGenerateColumns = false;
            dgvInprimagailua.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvInprimagailua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInprimagailua.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Koloretakoa });
            dgvInprimagailua.DataSource = inprimagailuakBindingSource;
            dgvInprimagailua.Location = new Point(0, 0);
            dgvInprimagailua.Name = "dgvInprimagailua";
            dgvInprimagailua.RowHeadersWidth = 51;
            dgvInprimagailua.Size = new Size(1400, 318);
            dgvInprimagailua.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Marka";
            dataGridViewTextBoxColumn2.HeaderText = "Marka";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Kokalekua";
            dataGridViewTextBoxColumn3.HeaderText = "Kokalekua";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "ErosteData";
            dataGridViewTextBoxColumn4.HeaderText = "ErosteData";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "MintegiaIzena";
            dataGridViewTextBoxColumn5.HeaderText = "MintegiaIzena";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Koloretakoa
            // 
            Koloretakoa.DataPropertyName = "Koloretakoa";
            Koloretakoa.HeaderText = "Koloretakoa";
            Koloretakoa.MinimumWidth = 6;
            Koloretakoa.Name = "Koloretakoa";
            Koloretakoa.Width = 125;
            // 
            // lblOrdenagailua
            // 
            lblOrdenagailua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOrdenagailua.AutoSize = true;
            lblOrdenagailua.Font = new Font("Times New Roman", 12F);
            lblOrdenagailua.Location = new Point(12, 34);
            lblOrdenagailua.Name = "lblOrdenagailua";
            lblOrdenagailua.Size = new Size(122, 22);
            lblOrdenagailua.TabIndex = 29;
            lblOrdenagailua.Text = "Ordenagailua:";
            // 
            // lblInprimagailua
            // 
            lblInprimagailua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblInprimagailua.AutoSize = true;
            lblInprimagailua.Font = new Font("Times New Roman", 12F);
            lblInprimagailua.Location = new Point(12, 486);
            lblInprimagailua.Name = "lblInprimagailua";
            lblInprimagailua.Size = new Size(125, 22);
            lblInprimagailua.TabIndex = 23;
            lblInprimagailua.Text = "Inprimagailua:";
            // 
            // FInbentarioa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1652, 885);
            Controls.Add(lblInprimagailua);
            Controls.Add(lblOrdenagailua);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cbEzabatu);
            Controls.Add(cbAldatu);
            Controls.Add(cbGehitu);
            Controls.Add(cbIrten);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FInbentarioa";
            Text = "FInbentarioa";
            Load += FInbentarioa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenagailua).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordenagailuakBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inprimagailuakBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInprimagailua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cbIrten;
        private Panel panel1;
        private DataGridView dgvOrdenagailua;
        private Button cbEzabatu;
        private Button cbAldatu;
        private Button cbGehitu;
        private BindingSource ordenagailuakBindingSource;
        private DataGridViewTextBoxColumn mintegiaDataGridViewTextBoxColumn;
        private BindingSource inprimagailuakBindingSource;
        private Panel panel2;
        private DataGridView dgvInprimagailua;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kokalekuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn erosteDataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn MintegiaIzena;
        private DataGridViewTextBoxColumn Cpu;
        private DataGridViewTextBoxColumn Ram;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn Koloretakoa;
        private Label lblId;
        private Label lblErosteData;
        private TextBox txtKokalekua;
        private Label lblKokalekua;
        private TextBox txtMarka;
        private Label lblMarka;
        private TextBox txtRam;
        private Label lblRam;
        private TextBox txtCpu;
        private Label lblCpu;
        private Label lblMintegia;
        private Label lblKoloretakoa;
        private ComboBox cmbGailuMota;
        private Label lblGailuMota;
        private ComboBox cmbMintegia;
        private CheckBox chbBai;
        private DateTimePicker dtpErosteData;
        private ComboBox cmbId;
        private Label lblOrdenagailua;
        private Label lblInprimagailua;
    }
}