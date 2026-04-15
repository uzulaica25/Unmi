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
            dgvintzidentziak = new DataGridView();
            gailuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mezuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            intzidentziakBindingSource1 = new BindingSource(components);
            intzidentziakBindingSource = new BindingSource(components);
            panel1 = new Panel();
            cbGehitu = new Button();
            cbAldatu = new Button();
            cbEzabatu = new Button();
            inprimagailuakBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvintzidentziak).BeginInit();
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
            cbIrten.TabIndex = 3;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click;
            // 
            // dgvintzidentziak
            // 
            dgvintzidentziak.AllowUserToAddRows = false;
            dgvintzidentziak.AllowUserToDeleteRows = false;
            dgvintzidentziak.AutoGenerateColumns = false;
            dgvintzidentziak.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvintzidentziak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvintzidentziak.Columns.AddRange(new DataGridViewColumn[] { gailuaDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, mezuaDataGridViewTextBoxColumn });
            dgvintzidentziak.DataSource = intzidentziakBindingSource1;
            dgvintzidentziak.Dock = DockStyle.Fill;
            dgvintzidentziak.Location = new Point(0, 0);
            dgvintzidentziak.Name = "dgvintzidentziak";
            dgvintzidentziak.ReadOnly = true;
            dgvintzidentziak.RowHeadersWidth = 51;
            dgvintzidentziak.Size = new Size(653, 339);
            dgvintzidentziak.TabIndex = 0;
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
            panel1.Controls.Add(dgvintzidentziak);
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 339);
            panel1.TabIndex = 14;
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
            // FIntzidentziak
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
            Name = "FIntzidentziak";
            Load += FIntzidentziak_Load;
            ((System.ComponentModel.ISupportInitialize)dgvintzidentziak).EndInit();
            ((System.ComponentModel.ISupportInitialize)intzidentziakBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)intzidentziakBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inprimagailuakBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cbIrten;
        private DataGridView dgvintzidentziak;
        private Panel panel1;
        private Button cbGehitu;
        private Button cbAldatu;
        private Button cbEzabatu;
        private BindingSource intzidentziakBindingSource;
        private BindingSource intzidentziakBindingSource1;
        private BindingSource inprimagailuakBindingSource;
        private DataGridViewTextBoxColumn gailuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mezuaDataGridViewTextBoxColumn;
    }
}