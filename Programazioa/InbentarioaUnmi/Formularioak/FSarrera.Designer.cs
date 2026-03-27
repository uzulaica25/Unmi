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
            txtIzena.TabIndex = 1;
            // 
            // cbIrten
            // 
            cbIrten.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIrten.Location = new Point(305, 336);
            cbIrten.Name = "cbIrten";
            cbIrten.Size = new Size(94, 29);
            cbIrten.TabIndex = 6;
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
            txtMintegia.TabIndex = 7;
            // 
            // lblIrakaslea
            // 
            lblIrakaslea.AutoSize = true;
            lblIrakaslea.Font = new Font("Times New Roman", 10.2F);
            lblIrakaslea.Location = new Point(142, 52);
            lblIrakaslea.Name = "lblIrakaslea";
            lblIrakaslea.Size = new Size(74, 19);
            lblIrakaslea.TabIndex = 8;
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
            lblMintegia.TabIndex = 9;
            lblMintegia.Text = "Mintegia:";
            // 
            // FSarrera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
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
    }
}