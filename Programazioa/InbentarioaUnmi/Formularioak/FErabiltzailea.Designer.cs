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
            erabiltzaileakBindingSource = new BindingSource(components);
            cbEzabatu = new Button();
            cbAldatu = new Button();
            cbGehitu = new Button();
            izenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pasahitzaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mintegiaIzenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvErabiltzaileak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erabiltzaileakBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbIrten
            // 
            cbIrten.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIrten.Location = new Point(681, 378);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(94, 29);
            cbIrten.TabIndex = 3;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click;
            // 
            // panel1
            // 
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
            panel1.Location = new Point(12, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 351);
            panel1.TabIndex = 14;
            // 
            // cmbId
            // 
            cmbId.Font = new Font("Times New Roman", 10.2F);
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(131, 47);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(125, 27);
            cmbId.TabIndex = 38;
            cmbId.UseWaitCursor = true;
            cmbId.Visible = false;
            cmbId.SelectedIndexChanged += cmbId_SelectedIndexChanged;
            cmbId.Leave += cmbId_Leave;
            // 
            // cmbMintegia
            // 
            cmbMintegia.Font = new Font("Times New Roman", 10.2F);
            cmbMintegia.FormattingEnabled = true;
            cmbMintegia.Location = new Point(412, 95);
            cmbMintegia.Name = "cmbMintegia";
            cmbMintegia.Size = new Size(125, 27);
            cmbMintegia.TabIndex = 31;
            cmbMintegia.UseWaitCursor = true;
            cmbMintegia.Visible = false;
            cmbMintegia.SelectedIndexChanged += cmbMintegia_SelectedIndexChanged;
            cmbMintegia.Leave += cmbMintegia_Leave;
            // 
            // lblMintegia
            // 
            lblMintegia.AutoSize = true;
            lblMintegia.Font = new Font("Times New Roman", 10.2F);
            lblMintegia.Location = new Point(316, 97);
            lblMintegia.Name = "lblMintegia";
            lblMintegia.Size = new Size(75, 19);
            lblMintegia.TabIndex = 34;
            lblMintegia.Text = "Mintegia:";
            lblMintegia.Visible = false;
            // 
            // lblRola
            // 
            lblRola.AutoSize = true;
            lblRola.Font = new Font("Times New Roman", 10.2F);
            lblRola.Location = new Point(316, 51);
            lblRola.Name = "lblRola";
            lblRola.Size = new Size(46, 19);
            lblRola.TabIndex = 37;
            lblRola.Text = "Rola:";
            lblRola.Visible = false;
            // 
            // cmbRola
            // 
            cmbRola.Font = new Font("Times New Roman", 10.2F);
            cmbRola.FormattingEnabled = true;
            cmbRola.Items.AddRange(new object[] { "Irakaslea", "MintegiBurua", "IKTArduraduna" });
            cmbRola.Location = new Point(412, 47);
            cmbRola.Name = "cmbRola";
            cmbRola.Size = new Size(125, 27);
            cmbRola.TabIndex = 32;
            cmbRola.UseWaitCursor = true;
            cmbRola.Visible = false;
            cmbRola.Leave += cmbRola_Leave;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 10.2F);
            lblId.Location = new Point(35, 55);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 19);
            lblId.TabIndex = 33;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // txtPasahitza
            // 
            txtPasahitza.Font = new Font("Times New Roman", 10.2F);
            txtPasahitza.Location = new Point(131, 150);
            txtPasahitza.Name = "txtPasahitza";
            txtPasahitza.Size = new Size(125, 27);
            txtPasahitza.TabIndex = 30;
            txtPasahitza.Visible = false;
            txtPasahitza.Leave += txtPasahitza_Leave;
            // 
            // lblPasahitza
            // 
            lblPasahitza.AutoSize = true;
            lblPasahitza.Font = new Font("Times New Roman", 10.2F);
            lblPasahitza.Location = new Point(35, 157);
            lblPasahitza.Name = "lblPasahitza";
            lblPasahitza.Size = new Size(77, 19);
            lblPasahitza.TabIndex = 36;
            lblPasahitza.Text = "Pasahitza:";
            lblPasahitza.Visible = false;
            // 
            // txtErabiltzailea
            // 
            txtErabiltzailea.Font = new Font("Times New Roman", 10.2F);
            txtErabiltzailea.Location = new Point(131, 98);
            txtErabiltzailea.Name = "txtErabiltzailea";
            txtErabiltzailea.Size = new Size(125, 27);
            txtErabiltzailea.TabIndex = 29;
            txtErabiltzailea.Visible = false;
            txtErabiltzailea.Leave += txtErabiltzailea_Leave;
            // 
            // lblErabiltzailea
            // 
            lblErabiltzailea.AutoSize = true;
            lblErabiltzailea.Font = new Font("Times New Roman", 10.2F);
            lblErabiltzailea.Location = new Point(35, 103);
            lblErabiltzailea.Name = "lblErabiltzailea";
            lblErabiltzailea.Size = new Size(99, 19);
            lblErabiltzailea.TabIndex = 35;
            lblErabiltzailea.Text = "Erabiltzailea:";
            lblErabiltzailea.Visible = false;
            // 
            // dgvErabiltzaileak
            // 
            dgvErabiltzaileak.AllowUserToAddRows = false;
            dgvErabiltzaileak.AllowUserToDeleteRows = false;
            dgvErabiltzaileak.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvErabiltzaileak.AutoGenerateColumns = false;
            dgvErabiltzaileak.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvErabiltzaileak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErabiltzaileak.Columns.AddRange(new DataGridViewColumn[] { izenaDataGridViewTextBoxColumn, pasahitzaDataGridViewTextBoxColumn, mintegiaIzenaDataGridViewTextBoxColumn, rolaDataGridViewTextBoxColumn });
            dgvErabiltzaileak.DataSource = erabiltzaileakBindingSource;
            dgvErabiltzaileak.Location = new Point(0, 0);
            dgvErabiltzaileak.Name = "dgvErabiltzaileak";
            dgvErabiltzaileak.ReadOnly = true;
            dgvErabiltzaileak.RowHeadersWidth = 51;
            dgvErabiltzaileak.Size = new Size(648, 351);
            dgvErabiltzaileak.TabIndex = 0;
            // 
            // erabiltzaileakBindingSource
            // 
            erabiltzaileakBindingSource.DataSource = typeof(DatuModeloak.Erabiltzaileak);
            // 
            // cbEzabatu
            // 
            cbEzabatu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEzabatu.Location = new Point(681, 152);
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
            cbAldatu.Location = new Point(681, 104);
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
            cbGehitu.Location = new Point(681, 56);
            cbGehitu.Name = "cbGehitu";
            cbGehitu.Size = new Size(94, 29);
            cbGehitu.TabIndex = 0;
            cbGehitu.Text = "Gehitu";
            cbGehitu.UseVisualStyleBackColor = true;
            cbGehitu.Click += cbGehitu_Click;
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
            // FErabiltzailea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
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