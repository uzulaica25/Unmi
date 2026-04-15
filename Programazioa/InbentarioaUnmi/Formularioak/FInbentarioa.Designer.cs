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
            panel1 = new Panel();
            dgvInbentarioa = new DataGridView();
            cbEzabatu = new Button();
            cbAldatu = new Button();
            cbGehitu = new Button();
            cbIrten = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInbentarioa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvInbentarioa);
            panel1.Location = new Point(84, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 256);
            panel1.TabIndex = 14;
            // 
            // dgvInbentarioa
            // 
            dgvInbentarioa.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvInbentarioa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInbentarioa.Dock = DockStyle.Fill;
            dgvInbentarioa.Location = new Point(0, 0);
            dgvInbentarioa.Name = "dgvInbentarioa";
            dgvInbentarioa.RowHeadersWidth = 51;
            dgvInbentarioa.Size = new Size(497, 256);
            dgvInbentarioa.TabIndex = 0;
            // 
            // cbEzabatu
            // 
            cbEzabatu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEzabatu.Location = new Point(615, 152);
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
            cbAldatu.Location = new Point(615, 104);
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
            cbGehitu.Location = new Point(615, 56);
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
            cbIrten.Location = new Point(615, 373);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(94, 29);
            cbIrten.TabIndex = 3;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click_1;
            // 
            // FInbentarioa
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
            Name = "FInbentarioa";
            Text = "FInbentarioa";
            Load += FInbentarioa_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInbentarioa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cbIrten;
        private Panel panel1;
        private DataGridView dgvInbentarioa;
        private Button cbEzabatu;
        private Button cbAldatu;
        private Button cbGehitu;
    }
}