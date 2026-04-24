namespace InbentarioaUnmi.Formularioak
{
    partial class FMintegia
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
            cbGehitu = new Button();
            cbAldatu = new Button();
            cbEzabatu = new Button();
            dgvMintegiak = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            izenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mintegiakBindingSource = new BindingSource(components);
            panel1 = new Panel();
            cmbId = new ComboBox();
            lblId = new Label();
            txtIzena = new TextBox();
            lblIzena = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMintegiak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mintegiakBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbIrten
            // 
            cbIrten.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbIrten.Font = new Font("Times New Roman", 12F);
            cbIrten.Location = new Point(1241, 799);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(119, 30);
            cbIrten.TabIndex = 3;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click;
            cbIrten.MouseMove += cbIrten_MouseMove;
            // 
            // cbGehitu
            // 
            cbGehitu.Anchor = AnchorStyles.Right;
            cbGehitu.Font = new Font("Times New Roman", 12F);
            cbGehitu.Location = new Point(1241, 54);
            cbGehitu.Name = "cbGehitu";
            cbGehitu.Size = new Size(119, 30);
            cbGehitu.TabIndex = 0;
            cbGehitu.Text = "Gehitu";
            cbGehitu.UseVisualStyleBackColor = true;
            cbGehitu.Click += cbGehitu_Click;
            // 
            // cbAldatu
            // 
            cbAldatu.Anchor = AnchorStyles.Right;
            cbAldatu.Font = new Font("Times New Roman", 12F);
            cbAldatu.Location = new Point(1241, 102);
            cbAldatu.Name = "cbAldatu";
            cbAldatu.Size = new Size(119, 30);
            cbAldatu.TabIndex = 1;
            cbAldatu.Text = "Aldatu";
            cbAldatu.UseVisualStyleBackColor = true;
            cbAldatu.Click += cbAldatu_Click_1;
            // 
            // cbEzabatu
            // 
            cbEzabatu.Anchor = AnchorStyles.Right;
            cbEzabatu.Font = new Font("Times New Roman", 12F);
            cbEzabatu.Location = new Point(1241, 150);
            cbEzabatu.Name = "cbEzabatu";
            cbEzabatu.Size = new Size(119, 30);
            cbEzabatu.TabIndex = 2;
            cbEzabatu.Text = "Ezabatu";
            cbEzabatu.UseVisualStyleBackColor = true;
            cbEzabatu.Click += cbEzabatu_Click_1;
            // 
            // dgvMintegiak
            // 
            dgvMintegiak.AllowUserToAddRows = false;
            dgvMintegiak.AllowUserToDeleteRows = false;
            dgvMintegiak.AutoGenerateColumns = false;
            dgvMintegiak.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvMintegiak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMintegiak.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, izenaDataGridViewTextBoxColumn });
            dgvMintegiak.DataSource = mintegiakBindingSource;
            dgvMintegiak.Dock = DockStyle.Fill;
            dgvMintegiak.Location = new Point(0, 0);
            dgvMintegiak.Name = "dgvMintegiak";
            dgvMintegiak.ReadOnly = true;
            dgvMintegiak.RowHeadersWidth = 51;
            dgvMintegiak.Size = new Size(1174, 775);
            dgvMintegiak.TabIndex = 0;
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
            // izenaDataGridViewTextBoxColumn
            // 
            izenaDataGridViewTextBoxColumn.DataPropertyName = "Izena";
            izenaDataGridViewTextBoxColumn.HeaderText = "Izena";
            izenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            izenaDataGridViewTextBoxColumn.Name = "izenaDataGridViewTextBoxColumn";
            izenaDataGridViewTextBoxColumn.ReadOnly = true;
            izenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // mintegiakBindingSource
            // 
            mintegiakBindingSource.DataSource = typeof(DatuModeloak.Mintegiak);
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cmbId);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(txtIzena);
            panel1.Controls.Add(lblIzena);
            panel1.Controls.Add(dgvMintegiak);
            panel1.Location = new Point(43, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 775);
            panel1.TabIndex = 9;
            // 
            // cmbId
            // 
            cmbId.Anchor = AnchorStyles.None;
            cmbId.Font = new Font("Times New Roman", 12F);
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(550, 230);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(119, 30);
            cmbId.TabIndex = 42;
            cmbId.UseWaitCursor = true;
            cmbId.Visible = false;
            cmbId.SelectedIndexChanged += cmbId_SelectedIndexChanged;
            cmbId.Leave += cmbId_Leave;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 12F);
            lblId.Location = new Point(454, 238);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 22);
            lblId.TabIndex = 40;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // txtIzena
            // 
            txtIzena.Anchor = AnchorStyles.None;
            txtIzena.Cursor = Cursors.IBeam;
            txtIzena.Font = new Font("Times New Roman", 12F);
            txtIzena.Location = new Point(550, 281);
            txtIzena.Name = "txtIzena";
            txtIzena.Size = new Size(119, 30);
            txtIzena.TabIndex = 39;
            txtIzena.Visible = false;
            txtIzena.Leave += txtIzena_Leave;
            // 
            // lblIzena
            // 
            lblIzena.Anchor = AnchorStyles.None;
            lblIzena.AutoSize = true;
            lblIzena.Font = new Font("Times New Roman", 12F);
            lblIzena.Location = new Point(454, 286);
            lblIzena.Name = "lblIzena";
            lblIzena.Size = new Size(57, 22);
            lblIzena.TabIndex = 41;
            lblIzena.Text = "Izena:";
            lblIzena.Visible = false;
            // 
            // FMintegia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1406, 858);
            Controls.Add(panel1);
            Controls.Add(cbEzabatu);
            Controls.Add(cbAldatu);
            Controls.Add(cbGehitu);
            Controls.Add(cbIrten);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FMintegia";
            Text = "FMintegia";
            Load += FMintegia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMintegiak).EndInit();
            ((System.ComponentModel.ISupportInitialize)mintegiakBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cbIrten;
        private Button cbGehitu;
        private Button cbAldatu;
        private Button cbEzabatu;
        private DataGridView dgvMintegiak;
        private Panel panel1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn izenaDataGridViewTextBoxColumn;
        private BindingSource mintegiakBindingSource;
        private ComboBox cmbId;
        private Label lblId;
        private TextBox txtIzena;
        private Label lblIzena;
    }
}