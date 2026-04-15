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
            cbIrten = new Button();
            cbGehitu = new Button();
            cbAldatu = new Button();
            cbEzabatu = new Button();
            dgvMintegiak = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMintegiak).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbIrten
            // 
            cbIrten.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIrten.Location = new Point(579, 371);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(94, 29);
            cbIrten.TabIndex = 3;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click;
            // 
            // cbGehitu
            // 
            cbGehitu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGehitu.Location = new Point(579, 54);
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
            cbAldatu.Location = new Point(579, 102);
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
            cbEzabatu.Location = new Point(579, 150);
            cbEzabatu.Name = "cbEzabatu";
            cbEzabatu.Size = new Size(94, 29);
            cbEzabatu.TabIndex = 2;
            cbEzabatu.Text = "Ezabatu";
            cbEzabatu.UseVisualStyleBackColor = true;
            cbEzabatu.Click += cbEzabatu_Click_1;
            // 
            // dgvMintegiak
            // 
            dgvMintegiak.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvMintegiak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMintegiak.Dock = DockStyle.Fill;
            dgvMintegiak.Location = new Point(0, 0);
            dgvMintegiak.Name = "dgvMintegiak";
            dgvMintegiak.RowHeadersWidth = 51;
            dgvMintegiak.Size = new Size(497, 256);
            dgvMintegiak.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvMintegiak);
            panel1.Location = new Point(48, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 256);
            panel1.TabIndex = 9;
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
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button cbIrten;
        private Button cbGehitu;
        private Button cbAldatu;
        private Button cbEzabatu;
        private DataGridView dgvMintegiak;
        private Panel panel1;
    }
}