namespace InbentarioaUnmi.Formularioak
{
    partial class FSarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSarrera));
            pictureBox1 = new PictureBox();
            txtIzena = new TextBox();
            cbIrten = new Button();
            txtMintegia = new TextBox();
            lblIrakaslea = new Label();
            lblMintegia = new Label();
            cbInbentarioa = new Button();
            cbMintegia = new Button();
            cbIntzidentziak = new Button();
            cbErabiltzailea = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtIzena
            // 
            txtIzena.Font = new Font("Times New Roman", 10.2F);
            txtIzena.Location = new Point(142, 74);
            txtIzena.Name = "txtIzena";
            txtIzena.Size = new Size(125, 27);
            txtIzena.TabIndex = 10;
            // 
            // cbIrten
            // 
            cbIrten.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIrten.Location = new Point(305, 336);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(94, 29);
            cbIrten.TabIndex = 4;
            cbIrten.Text = "Irten";
            cbIrten.UseVisualStyleBackColor = true;
            cbIrten.Click += cbIrten_Click;
            // 
            // txtMintegia
            // 
            txtMintegia.Font = new Font("Times New Roman", 10.2F);
            txtMintegia.Location = new Point(142, 133);
            txtMintegia.Name = "txtMintegia";
            txtMintegia.Size = new Size(125, 27);
            txtMintegia.TabIndex = 13;
            // 
            // lblIrakaslea
            // 
            lblIrakaslea.AutoSize = true;
            lblIrakaslea.Font = new Font("Times New Roman", 10.2F);
            lblIrakaslea.Location = new Point(142, 52);
            lblIrakaslea.Name = "lblIrakaslea";
            lblIrakaslea.Size = new Size(74, 19);
            lblIrakaslea.TabIndex = 11;
            lblIrakaslea.Text = "Irakaslea:";
            lblIrakaslea.Click += label1_Click;
            // 
            // lblMintegia
            // 
            lblMintegia.AutoSize = true;
            lblMintegia.Font = new Font("Times New Roman", 10.2F);
            lblMintegia.Location = new Point(142, 111);
            lblMintegia.Name = "lblMintegia";
            lblMintegia.Size = new Size(75, 19);
            lblMintegia.TabIndex = 12;
            lblMintegia.Text = "Mintegia:";
            // 
            // cbInbentarioa
            // 
            cbInbentarioa.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbInbentarioa.Location = new Point(614, 28);
            cbInbentarioa.Name = "cbInbentarioa";
            cbInbentarioa.Size = new Size(105, 29);
            cbInbentarioa.TabIndex = 0;
            cbInbentarioa.Text = "Inbentarioa";
            cbInbentarioa.UseVisualStyleBackColor = true;
            cbInbentarioa.Click += cbInbentarioa_Click;
            // 
            // cbMintegia
            // 
            cbMintegia.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMintegia.Location = new Point(614, 155);
            cbMintegia.Name = "cbMintegia";
            cbMintegia.Size = new Size(105, 29);
            cbMintegia.TabIndex = 3;
            cbMintegia.Text = "Mintegia";
            cbMintegia.UseVisualStyleBackColor = true;
            cbMintegia.Click += cbMintegia_Click;
            // 
            // cbIntzidentziak
            // 
            cbIntzidentziak.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIntzidentziak.Location = new Point(614, 74);
            cbIntzidentziak.Name = "cbIntzidentziak";
            cbIntzidentziak.Size = new Size(105, 29);
            cbIntzidentziak.TabIndex = 1;
            cbIntzidentziak.Text = "Intzidentzia";
            cbIntzidentziak.UseVisualStyleBackColor = true;
            cbIntzidentziak.Click += cbIntzidentziak_Click;
            // 
            // cbErabiltzailea
            // 
            cbErabiltzailea.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbErabiltzailea.Location = new Point(614, 115);
            cbErabiltzailea.Name = "cbErabiltzailea";
            cbErabiltzailea.Size = new Size(105, 29);
            cbErabiltzailea.TabIndex = 2;
            cbErabiltzailea.Text = "Erabiltzailea";
            cbErabiltzailea.UseVisualStyleBackColor = true;
            cbErabiltzailea.Click += cbErabiltzailea_Click;
            // 
            // FSarrera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(cbErabiltzailea);
            Controls.Add(cbIntzidentziak);
            Controls.Add(cbMintegia);
            Controls.Add(cbInbentarioa);
            Controls.Add(lblMintegia);
            Controls.Add(lblIrakaslea);
            Controls.Add(txtMintegia);
            Controls.Add(cbIrten);
            Controls.Add(txtIzena);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FSarrera";
            Text = "Form2";
            Load += FSarrera_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtIzena;
        private Button cbIrten;
        private TextBox txtMintegia;
        private Label lblIrakaslea;
        private Label lblMintegia;
        private Button cbInbentarioa;
        private Button cbMintegia;
        private Button cbIntzidentziak;
        private Button cbErabiltzailea;
    }
}