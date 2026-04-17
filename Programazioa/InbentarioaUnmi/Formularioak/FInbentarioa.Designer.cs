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
            panel1 = new Panel();
            cmbId = new ComboBox();
            chbBai = new CheckBox();
            cmbMintegia = new ComboBox();
            lblMintegia = new Label();
            lblGailuMota = new Label();
            comboBox1 = new ComboBox();
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
            lblErosteData = new Label();
            cbEzabatu = new Button();
            cbAldatu = new Button();
            cbGehitu = new Button();
            cbIrten = new Button();
            inprimagailuakBindingSource = new BindingSource(components);
            panel2 = new Panel();
            dtpErosteData = new DateTimePicker();
            dgvInprimagailua = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Koloretakoa = new DataGridViewCheckBoxColumn();
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
            panel1.Controls.Add(cmbId);
            panel1.Controls.Add(chbBai);
            panel1.Controls.Add(cmbMintegia);
            panel1.Controls.Add(lblMintegia);
            panel1.Controls.Add(lblGailuMota);
            panel1.Controls.Add(comboBox1);
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
            panel1.Location = new Point(12, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 177);
            panel1.TabIndex = 14;
            // 
            // cmbId
            // 
            cmbId.Font = new Font("Times New Roman", 10.2F);
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(124, -3);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(125, 27);
            cmbId.TabIndex = 28;
            cmbId.UseWaitCursor = true;
            cmbId.Visible = false;
            cmbId.SelectedValueChanged += cmbId_SelectedValueChanged;
            // 
            // chbBai
            // 
            chbBai.AutoSize = true;
            chbBai.Font = new Font("Times New Roman", 10.2F);
            chbBai.Location = new Point(498, 6);
            chbBai.Name = "chbBai";
            chbBai.Size = new Size(54, 23);
            chbBai.TabIndex = 18;
            chbBai.Text = "Bai";
            chbBai.UseVisualStyleBackColor = true;
            chbBai.Visible = false;
            // 
            // cmbMintegia
            // 
            cmbMintegia.Font = new Font("Times New Roman", 10.2F);
            cmbMintegia.FormattingEnabled = true;
            cmbMintegia.Location = new Point(124, 146);
            cmbMintegia.Name = "cmbMintegia";
            cmbMintegia.Size = new Size(125, 27);
            cmbMintegia.TabIndex = 16;
            cmbMintegia.UseWaitCursor = true;
            cmbMintegia.Visible = false;
            // 
            // lblMintegia
            // 
            lblMintegia.AutoSize = true;
            lblMintegia.Font = new Font("Times New Roman", 10.2F);
            lblMintegia.Location = new Point(28, 150);
            lblMintegia.Name = "lblMintegia";
            lblMintegia.Size = new Size(75, 19);
            lblMintegia.TabIndex = 18;
            lblMintegia.Text = "Mintegia:";
            lblMintegia.Visible = false;
            // 
            // lblGailuMota
            // 
            lblGailuMota.AutoSize = true;
            lblGailuMota.Font = new Font("Times New Roman", 10.2F);
            lblGailuMota.Location = new Point(245, 128);
            lblGailuMota.Name = "lblGailuMota";
            lblGailuMota.Size = new Size(89, 19);
            lblGailuMota.TabIndex = 27;
            lblGailuMota.Text = "Gailu mota:";
            lblGailuMota.Visible = false;
            lblGailuMota.Leave += cmbGailuMota_Leave;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(637, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 26;
            // 
            // txtRam
            // 
            txtRam.Font = new Font("Times New Roman", 10.2F);
            txtRam.Location = new Point(498, 95);
            txtRam.Name = "txtRam";
            txtRam.Size = new Size(125, 27);
            txtRam.TabIndex = 20;
            txtRam.Visible = false;
            // 
            // cmbGailuMota
            // 
            cmbGailuMota.Font = new Font("Times New Roman", 10.2F);
            cmbGailuMota.FormattingEnabled = true;
            cmbGailuMota.Items.AddRange(new object[] { "Ordenagailua", "Inprimagailua" });
            cmbGailuMota.Location = new Point(341, 124);
            cmbGailuMota.Name = "cmbGailuMota";
            cmbGailuMota.Size = new Size(125, 27);
            cmbGailuMota.TabIndex = 16;
            cmbGailuMota.UseWaitCursor = true;
            cmbGailuMota.Visible = false;
            cmbGailuMota.SelectedIndexChanged += cmbGailuMota_SelectedIndexChanged;
            cmbGailuMota.Leave += cmbGailuMota_Leave;
            // 
            // lblKoloretakoa
            // 
            lblKoloretakoa.AutoSize = true;
            lblKoloretakoa.Font = new Font("Times New Roman", 10.2F);
            lblKoloretakoa.Location = new Point(384, 9);
            lblKoloretakoa.Name = "lblKoloretakoa";
            lblKoloretakoa.Size = new Size(99, 19);
            lblKoloretakoa.TabIndex = 24;
            lblKoloretakoa.Text = "Koloretakoa:";
            lblKoloretakoa.Visible = false;
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.Font = new Font("Times New Roman", 10.2F);
            lblRam.Location = new Point(384, 102);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(51, 19);
            lblRam.TabIndex = 22;
            lblRam.Text = "RAM:";
            lblRam.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 10.2F);
            lblId.Location = new Point(28, 6);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 19);
            lblId.TabIndex = 16;
            lblId.Text = "Id:";
            lblId.Visible = false;
            lblId.Click += label1_Click;
            // 
            // txtCpu
            // 
            txtCpu.Font = new Font("Times New Roman", 10.2F);
            txtCpu.Location = new Point(498, 50);
            txtCpu.Name = "txtCpu";
            txtCpu.Size = new Size(125, 27);
            txtCpu.TabIndex = 19;
            txtCpu.Visible = false;
            // 
            // lblCpu
            // 
            lblCpu.AutoSize = true;
            lblCpu.Font = new Font("Times New Roman", 10.2F);
            lblCpu.Location = new Point(384, 57);
            lblCpu.Name = "lblCpu";
            lblCpu.Size = new Size(47, 19);
            lblCpu.TabIndex = 20;
            lblCpu.Text = "CPU:";
            lblCpu.Visible = false;
            // 
            // txtKokalekua
            // 
            txtKokalekua.Font = new Font("Times New Roman", 10.2F);
            txtKokalekua.Location = new Point(124, 100);
            txtKokalekua.Name = "txtKokalekua";
            txtKokalekua.Size = new Size(125, 27);
            txtKokalekua.TabIndex = 15;
            txtKokalekua.Visible = false;
            // 
            // lblKokalekua
            // 
            lblKokalekua.AutoSize = true;
            lblKokalekua.Font = new Font("Times New Roman", 10.2F);
            lblKokalekua.Location = new Point(28, 106);
            lblKokalekua.Name = "lblKokalekua";
            lblKokalekua.Size = new Size(86, 19);
            lblKokalekua.TabIndex = 20;
            lblKokalekua.Text = "Kokalekua:";
            lblKokalekua.Visible = false;
            // 
            // txtMarka
            // 
            txtMarka.Font = new Font("Times New Roman", 10.2F);
            txtMarka.Location = new Point(124, 48);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 14;
            txtMarka.Visible = false;
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Font = new Font("Times New Roman", 10.2F);
            lblMarka.Location = new Point(28, 54);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(57, 19);
            lblMarka.TabIndex = 18;
            lblMarka.Text = "Marka:";
            lblMarka.Visible = false;
            // 
            // dgvOrdenagailua
            // 
            dgvOrdenagailua.AllowUserToAddRows = false;
            dgvOrdenagailua.AllowUserToDeleteRows = false;
            dgvOrdenagailua.AutoGenerateColumns = false;
            dgvOrdenagailua.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvOrdenagailua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenagailua.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, markaDataGridViewTextBoxColumn, kokalekuaDataGridViewTextBoxColumn, erosteDataDataGridViewTextBoxColumn, MintegiaIzena, Cpu, Ram });
            dgvOrdenagailua.DataSource = ordenagailuakBindingSource;
            dgvOrdenagailua.Dock = DockStyle.Fill;
            dgvOrdenagailua.Location = new Point(0, 0);
            dgvOrdenagailua.Name = "dgvOrdenagailua";
            dgvOrdenagailua.RowHeadersWidth = 51;
            dgvOrdenagailua.Size = new Size(676, 177);
            dgvOrdenagailua.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kokalekuaDataGridViewTextBoxColumn
            // 
            kokalekuaDataGridViewTextBoxColumn.DataPropertyName = "Kokalekua";
            kokalekuaDataGridViewTextBoxColumn.HeaderText = "Kokalekua";
            kokalekuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            kokalekuaDataGridViewTextBoxColumn.Name = "kokalekuaDataGridViewTextBoxColumn";
            kokalekuaDataGridViewTextBoxColumn.Width = 125;
            // 
            // erosteDataDataGridViewTextBoxColumn
            // 
            erosteDataDataGridViewTextBoxColumn.DataPropertyName = "ErosteData";
            erosteDataDataGridViewTextBoxColumn.HeaderText = "ErosteData";
            erosteDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            erosteDataDataGridViewTextBoxColumn.Name = "erosteDataDataGridViewTextBoxColumn";
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
            Cpu.Width = 125;
            // 
            // Ram
            // 
            Ram.DataPropertyName = "Ram";
            Ram.HeaderText = "Ram";
            Ram.MinimumWidth = 6;
            Ram.Name = "Ram";
            Ram.Width = 125;
            // 
            // ordenagailuakBindingSource
            // 
            ordenagailuakBindingSource.DataSource = typeof(DatuModeloak.Ordenagailuak);
            // 
            // lblErosteData
            // 
            lblErosteData.AutoSize = true;
            lblErosteData.Font = new Font("Times New Roman", 10.2F);
            lblErosteData.Location = new Point(28, 20);
            lblErosteData.Name = "lblErosteData";
            lblErosteData.Size = new Size(90, 19);
            lblErosteData.TabIndex = 22;
            lblErosteData.Text = "ErosteData:";
            lblErosteData.Visible = false;
            lblErosteData.Click += label1_Click_1;
            // 
            // cbEzabatu
            // 
            cbEzabatu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEzabatu.Location = new Point(694, 152);
            cbEzabatu.Name = "cbEzabatu";
            cbEzabatu.Size = new Size(94, 29);
            cbEzabatu.TabIndex = 2;
            cbEzabatu.Text = "Ezabatu";
            cbEzabatu.UseVisualStyleBackColor = true;
            cbEzabatu.Click += cbEzabatu_Click;
            // 
            // cbAldatu
            // 
            cbAldatu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAldatu.Location = new Point(694, 104);
            cbAldatu.Name = "cbAldatu";
            cbAldatu.Size = new Size(94, 29);
            cbAldatu.TabIndex = 1;
            cbAldatu.Text = "Aldatu";
            cbAldatu.UseVisualStyleBackColor = true;
            cbAldatu.Click += cbAldatu_Click;
            // 
            // cbGehitu
            // 
            cbGehitu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGehitu.Location = new Point(694, 56);
            cbGehitu.Name = "cbGehitu";
            cbGehitu.Size = new Size(94, 29);
            cbGehitu.TabIndex = 0;
            cbGehitu.Text = "Gehitu";
            cbGehitu.UseVisualStyleBackColor = true;
            cbGehitu.Click += cbGehitu_Click;
            // 
            // cbIrten
            // 
            cbIrten.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIrten.Location = new Point(694, 368);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(94, 29);
            cbIrten.TabIndex = 3;
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
            panel2.Controls.Add(dtpErosteData);
            panel2.Controls.Add(lblErosteData);
            panel2.Controls.Add(dgvInprimagailua);
            panel2.Location = new Point(12, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(676, 158);
            panel2.TabIndex = 15;
            // 
            // dtpErosteData
            // 
            dtpErosteData.CalendarFont = new Font("Times New Roman", 10.2F);
            dtpErosteData.Font = new Font("Times New Roman", 10.2F);
            dtpErosteData.Format = DateTimePickerFormat.Short;
            dtpErosteData.Location = new Point(124, 14);
            dtpErosteData.Name = "dtpErosteData";
            dtpErosteData.Size = new Size(125, 27);
            dtpErosteData.TabIndex = 17;
            dtpErosteData.Visible = false;
            dtpErosteData.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dgvInprimagailua
            // 
            dgvInprimagailua.AllowUserToAddRows = false;
            dgvInprimagailua.AllowUserToDeleteRows = false;
            dgvInprimagailua.AutoGenerateColumns = false;
            dgvInprimagailua.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvInprimagailua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInprimagailua.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Koloretakoa });
            dgvInprimagailua.DataSource = inprimagailuakBindingSource;
            dgvInprimagailua.Dock = DockStyle.Fill;
            dgvInprimagailua.Location = new Point(0, 0);
            dgvInprimagailua.Name = "dgvInprimagailua";
            dgvInprimagailua.RowHeadersWidth = 51;
            dgvInprimagailua.Size = new Size(676, 158);
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
            // FInbentarioa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
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
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInprimagailua).EndInit();
            ResumeLayout(false);
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
        private ComboBox comboBox1;
        private ComboBox cmbGailuMota;
        private Label lblGailuMota;
        private ComboBox cmbMintegia;
        private CheckBox chbBai;
        private DateTimePicker dtpErosteData;
        private ComboBox cmbId;
    }
}