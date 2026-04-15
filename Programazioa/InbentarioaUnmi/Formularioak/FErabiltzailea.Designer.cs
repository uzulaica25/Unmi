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
            dgvErabiltzaileak = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            izenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pasahitzaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mintegiaIzenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            erabiltzaileakBindingSource = new BindingSource(components);
            cbEzabatu = new Button();
            cbAldatu = new Button();
            cbGehitu = new Button();
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
            panel1.Controls.Add(dgvErabiltzaileak);
            panel1.Location = new Point(12, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 351);
            panel1.TabIndex = 14;
            // 
            // dgvErabiltzaileak
            // 
            dgvErabiltzaileak.AllowUserToAddRows = false;
            dgvErabiltzaileak.AllowUserToDeleteRows = false;
            dgvErabiltzaileak.AutoGenerateColumns = false;
            dgvErabiltzaileak.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvErabiltzaileak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErabiltzaileak.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, izenaDataGridViewTextBoxColumn, pasahitzaDataGridViewTextBoxColumn, mintegiaIzenaDataGridViewTextBoxColumn, rolaDataGridViewTextBoxColumn });
            dgvErabiltzaileak.DataSource = erabiltzaileakBindingSource;
            dgvErabiltzaileak.Dock = DockStyle.Fill;
            dgvErabiltzaileak.Location = new Point(0, 0);
            dgvErabiltzaileak.Name = "dgvErabiltzaileak";
            dgvErabiltzaileak.ReadOnly = true;
            dgvErabiltzaileak.RowHeadersWidth = 51;
            dgvErabiltzaileak.Size = new Size(648, 351);
            dgvErabiltzaileak.TabIndex = 0;
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
            // pasahitzaDataGridViewTextBoxColumn
            // 
            pasahitzaDataGridViewTextBoxColumn.DataPropertyName = "Pasahitza";
            pasahitzaDataGridViewTextBoxColumn.HeaderText = "Pasahitza";
            pasahitzaDataGridViewTextBoxColumn.MinimumWidth = 6;
            pasahitzaDataGridViewTextBoxColumn.Name = "pasahitzaDataGridViewTextBoxColumn";
            pasahitzaDataGridViewTextBoxColumn.ReadOnly = true;
            pasahitzaDataGridViewTextBoxColumn.Width = 125;
            // 
            // mintegiaIzenaDataGridViewTextBoxColumn
            // 
            mintegiaIzenaDataGridViewTextBoxColumn.DataPropertyName = "MintegiaIzena";
            mintegiaIzenaDataGridViewTextBoxColumn.HeaderText = "MintegiaIzena";
            mintegiaIzenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            mintegiaIzenaDataGridViewTextBoxColumn.Name = "mintegiaIzenaDataGridViewTextBoxColumn";
            mintegiaIzenaDataGridViewTextBoxColumn.ReadOnly = true;
            mintegiaIzenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // rolaDataGridViewTextBoxColumn
            // 
            rolaDataGridViewTextBoxColumn.DataPropertyName = "Rola";
            rolaDataGridViewTextBoxColumn.HeaderText = "Rola";
            rolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            rolaDataGridViewTextBoxColumn.Name = "rolaDataGridViewTextBoxColumn";
            rolaDataGridViewTextBoxColumn.ReadOnly = true;
            rolaDataGridViewTextBoxColumn.Width = 125;
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn izenaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pasahitzaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mintegiaIzenaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolaDataGridViewTextBoxColumn;
    }
}