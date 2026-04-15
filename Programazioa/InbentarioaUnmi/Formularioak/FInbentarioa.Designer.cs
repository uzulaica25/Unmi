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
            dgvOrdenagailua = new DataGridView();
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
            IdMintegia = new DataGridViewTextBoxColumn();
            Koloretakoa = new DataGridViewCheckBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            markaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kokalekuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            erosteDataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Cpu = new DataGridViewTextBoxColumn();
            Ram = new DataGridViewTextBoxColumn();
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
            panel1.Controls.Add(dgvOrdenagailua);
            panel1.Location = new Point(12, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 177);
            panel1.TabIndex = 14;
            // 
            // dgvOrdenagailua
            // 
            dgvOrdenagailua.AllowUserToAddRows = false;
            dgvOrdenagailua.AllowUserToDeleteRows = false;
            dgvOrdenagailua.AutoGenerateColumns = false;
            dgvOrdenagailua.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvOrdenagailua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenagailua.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, markaDataGridViewTextBoxColumn, kokalekuaDataGridViewTextBoxColumn, erosteDataDataGridViewTextBoxColumn, dataGridViewTextBoxColumn5, Cpu, Ram });
            dgvOrdenagailua.DataSource = ordenagailuakBindingSource;
            dgvOrdenagailua.Dock = DockStyle.Fill;
            dgvOrdenagailua.Location = new Point(0, 0);
            dgvOrdenagailua.Name = "dgvOrdenagailua";
            dgvOrdenagailua.RowHeadersWidth = 51;
            dgvOrdenagailua.Size = new Size(676, 177);
            dgvOrdenagailua.TabIndex = 0;
            // 
            // ordenagailuakBindingSource
            // 
            ordenagailuakBindingSource.DataSource = typeof(DatuModeloak.Ordenagailuak);
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
            panel2.Controls.Add(dgvInprimagailua);
            panel2.Location = new Point(12, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(676, 158);
            panel2.TabIndex = 15;
            // 
            // dgvInprimagailua
            // 
            dgvInprimagailua.AllowUserToAddRows = false;
            dgvInprimagailua.AllowUserToDeleteRows = false;
            dgvInprimagailua.AutoGenerateColumns = false;
            dgvInprimagailua.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvInprimagailua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInprimagailua.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, IdMintegia, Koloretakoa });
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
            // IdMintegia
            // 
            IdMintegia.DataPropertyName = "IdMintegia";
            IdMintegia.HeaderText = "IdMintegia";
            IdMintegia.MinimumWidth = 6;
            IdMintegia.Name = "IdMintegia";
            IdMintegia.ReadOnly = true;
            IdMintegia.Width = 125;
            // 
            // Koloretakoa
            // 
            Koloretakoa.DataPropertyName = "Koloretakoa";
            Koloretakoa.HeaderText = "Koloretakoa";
            Koloretakoa.MinimumWidth = 6;
            Koloretakoa.Name = "Koloretakoa";
            Koloretakoa.Width = 125;
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
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "IdMintegia";
            dataGridViewTextBoxColumn5.HeaderText = "IdMintegia";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)dgvOrdenagailua).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordenagailuakBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inprimagailuakBindingSource).EndInit();
            panel2.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn IdMintegia;
        private DataGridViewCheckBoxColumn Koloretakoa;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kokalekuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn erosteDataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Cpu;
        private DataGridViewTextBoxColumn Ram;
    }
}