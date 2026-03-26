namespace InbentarioaUnmi
{
    partial class FLogina
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogina));
            cbIrten = new Button();
            cbSartu = new Button();
            lblErabiltzailea = new Label();
            txtErabiltzailea = new TextBox();
            txtPasahitza = new TextBox();
            lblPasahitza = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbIrten
            // 
            cbIrten.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIrten.Location = new Point(423, 246);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(94, 29);
            cbIrten.TabIndex = 4;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click;
            // 
            // cbSartu
            // 
            cbSartu.Enabled = false;
            cbSartu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSartu.Location = new Point(273, 246);
            cbSartu.Name = "cbSartu";
            cbSartu.Size = new Size(94, 29);
            cbSartu.TabIndex = 3;
            cbSartu.Text = "Sartu";
            cbSartu.UseVisualStyleBackColor = true;
            cbSartu.Click += cbSartu_Click;
            // 
            // lblErabiltzailea
            // 
            lblErabiltzailea.AutoSize = true;
            lblErabiltzailea.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErabiltzailea.Location = new Point(120, 102);
            lblErabiltzailea.Name = "lblErabiltzailea";
            lblErabiltzailea.Size = new Size(99, 19);
            lblErabiltzailea.TabIndex = 2;
            lblErabiltzailea.Text = "Erabiltzailea:";
            // 
            // txtErabiltzailea
            // 
            txtErabiltzailea.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtErabiltzailea.Location = new Point(273, 98);
            txtErabiltzailea.Name = "txtErabiltzailea";
            txtErabiltzailea.Size = new Size(244, 27);
            txtErabiltzailea.TabIndex = 0;
            txtErabiltzailea.Leave += txtErabiltzailea_Leave;
            // 
            // txtPasahitza
            // 
            txtPasahitza.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasahitza.Location = new Point(273, 153);
            txtPasahitza.Name = "txtPasahitza";
            txtPasahitza.Size = new Size(244, 27);
            txtPasahitza.TabIndex = 1;
            txtPasahitza.Leave += txtPasahitza_Leave;
            // 
            // lblPasahitza
            // 
            lblPasahitza.AutoSize = true;
            lblPasahitza.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasahitza.Location = new Point(120, 157);
            lblPasahitza.Name = "lblPasahitza";
            lblPasahitza.Size = new Size(77, 19);
            lblPasahitza.TabIndex = 4;
            lblPasahitza.Text = "Pasahitza:";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbSartu);
            panel1.Controls.Add(cbIrten);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 6;
            // 
            // FLogina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(txtPasahitza);
            Controls.Add(lblPasahitza);
            Controls.Add(txtErabiltzailea);
            Controls.Add(lblErabiltzailea);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FLogina";
            Text = "Inbentarioa";
            Load += FLogina_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cbIrten;
        private Button cbSartu;
        private Label lblErabiltzailea;
        private TextBox txtErabiltzailea;
        private TextBox txtPasahitza;
        private Label lblPasahitza;
        private Panel panel1;
    }
}
