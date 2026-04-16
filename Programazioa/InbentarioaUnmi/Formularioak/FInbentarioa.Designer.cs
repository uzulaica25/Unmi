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
            lblId = new Label();
            txtId = new TextBox();
            txtMarka = new TextBox();
            lblMarka = new Label();
            txtKokalekua = new TextBox();
            lblKokalekua = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
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
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
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
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
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
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 10.2F);
            lblId.Location = new Point(40, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 19);
            lblId.TabIndex = 16;
            lblId.Text = "Id:";
            lblId.Visible = false;
            lblId.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Times New Roman", 10.2F);
            txtId.Location = new Point(90, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 17;
            txtId.Visible = false;
            // 
            // txtMarka
            // 
            txtMarka.Font = new Font("Times New Roman", 10.2F);
            txtMarka.Location = new Point(78, 17);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 19;
            txtMarka.Visible = false;
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Font = new Font("Times New Roman", 10.2F);
            lblMarka.Location = new Point(28, 20);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(57, 19);
            lblMarka.TabIndex = 18;
            lblMarka.Text = "Marka:";
            lblMarka.Visible = false;
            // 
            // txtKokalekua
            // 
            txtKokalekua.Font = new Font("Times New Roman", 10.2F);
            txtKokalekua.Location = new Point(78, 69);
            txtKokalekua.Name = "txtKokalekua";
            txtKokalekua.Size = new Size(125, 27);
            txtKokalekua.TabIndex = 21;
            txtKokalekua.Visible = false;
            // 
            // lblKokalekua
            // 
            lblKokalekua.AutoSize = true;
            lblKokalekua.Font = new Font("Times New Roman", 10.2F);
            lblKokalekua.Location = new Point(28, 72);
            lblKokalekua.Name = "lblKokalekua";
            lblKokalekua.Size = new Size(86, 19);
            lblKokalekua.TabIndex = 20;
            lblKokalekua.Text = "Kokalekua:";
            lblKokalekua.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 10.2F);
            textBox1.Location = new Point(78, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 23;
            textBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(28, 123);
            label1.Name = "label1";
            label1.Size = new Size(27, 19);
            label1.TabIndex = 22;
            label1.Text = "Id:";
            label1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 10.2F);
            textBox2.Location = new Point(78, -15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 19;
            textBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(28, -12);
            label2.Name = "label2";
            label2.Size = new Size(27, 19);
            label2.TabIndex = 18;
            label2.Text = "Id:";
            label2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 10.2F);
            textBox3.Location = new Point(434, 20);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 21;
            textBox3.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F);
            label3.Location = new Point(384, 23);
            label3.Name = "label3";
            label3.Size = new Size(27, 19);
            label3.TabIndex = 20;
            label3.Text = "Id:";
            label3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 10.2F);
            textBox4.Location = new Point(434, 65);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 23;
            textBox4.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F);
            label4.Location = new Point(384, 68);
            label4.Name = "label4";
            label4.Size = new Size(27, 19);
            label4.TabIndex = 22;
            label4.Text = "Id:";
            label4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 10.2F);
            textBox5.Location = new Point(446, 24);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 25;
            textBox5.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F);
            label5.Location = new Point(396, 27);
            label5.Name = "label5";
            label5.Size = new Size(27, 19);
            label5.TabIndex = 24;
            label5.Text = "Id:";
            label5.Visible = false;
            // 
            // FInbentarioa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(lblId);
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
        private TextBox txtId;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtKokalekua;
        private Label lblKokalekua;
        private TextBox txtMarka;
        private Label lblMarka;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox5;
        private Label label5;
    }
}