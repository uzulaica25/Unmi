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
            cbIrten.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIrten.Location = new Point(660, 371);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(94, 29);
            cbIrten.TabIndex = 3;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click;
            cbIrten.MouseMove += cbIrten_MouseMove;
            // 
            // cbGehitu
            // 
            cbGehitu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGehitu.Location = new Point(660, 54);
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
            cbAldatu.Location = new Point(660, 102);
            cbAldatu.Name = "cbAldatu";
            cbAldatu.Size = new Size(94, 29);
            cbAldatu.TabIndex = 1;
            cbAldatu.Text = "Aldatu";
            cbAldatu.UseVisualStyleBackColor = true;
            cbAldatu.Click += cbAldatu_Click_1;
            // 
            // cbEzabatu
            // 
            cbEzabatu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEzabatu.Location = new Point(660, 150);
            cbEzabatu.Name = "cbEzabatu";
            cbEzabatu.Size = new Size(94, 29);
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
            dgvMintegiak.Size = new Size(629, 346);
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
            panel1.Controls.Add(cmbId);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(txtIzena);
            panel1.Controls.Add(lblIzena);
            panel1.Controls.Add(dgvMintegiak);
            panel1.Location = new Point(12, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 346);
            panel1.TabIndex = 9;
            // 
            // cmbId
            // 
            cmbId.Font = new Font("Times New Roman", 10.2F);
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(294, 50);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(125, 27);
            cmbId.TabIndex = 42;
            cmbId.UseWaitCursor = true;
            cmbId.Visible = false;
            cmbId.SelectedIndexChanged += cmbId_SelectedIndexChanged;
            cmbId.Leave += cmbId_Leave;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 10.2F);
            lblId.Location = new Point(198, 58);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 19);
            lblId.TabIndex = 40;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // txtIzena
            // 
            txtIzena.Cursor = Cursors.IBeam;
            txtIzena.Font = new Font("Times New Roman", 10.2F);
            txtIzena.Location = new Point(294, 101);
            txtIzena.Name = "txtIzena";
            txtIzena.Size = new Size(125, 27);
            txtIzena.TabIndex = 39;
            txtIzena.Visible = false;
            txtIzena.Leave += txtIzena_Leave;
            // 
            // lblIzena
            // 
            lblIzena.AutoSize = true;
            lblIzena.Font = new Font("Times New Roman", 10.2F);
            lblIzena.Location = new Point(198, 106);
            lblIzena.Name = "lblIzena";
            lblIzena.Size = new Size(49, 19);
            lblIzena.TabIndex = 41;
            lblIzena.Text = "Izena:";
            lblIzena.Visible = false;
            // 
            // FMintegia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(766, 433);
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