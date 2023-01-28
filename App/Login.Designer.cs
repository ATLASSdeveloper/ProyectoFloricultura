namespace App
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.correoTEXT = new System.Windows.Forms.TextBox();
            this.claveTEXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // correoTEXT
            // 
            this.correoTEXT.Location = new System.Drawing.Point(172, 255);
            this.correoTEXT.Name = "correoTEXT";
            this.correoTEXT.Size = new System.Drawing.Size(272, 31);
            this.correoTEXT.TabIndex = 0;
            // 
            // claveTEXT
            // 
            this.claveTEXT.Location = new System.Drawing.Point(172, 402);
            this.claveTEXT.Name = "claveTEXT";
            this.claveTEXT.Size = new System.Drawing.Size(272, 31);
            this.claveTEXT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(160, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(160, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(172, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.claveTEXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.correoTEXT);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1463, 782);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(637, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 779);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(224, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bienvenido ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1478, 784);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1500, 840);
            this.MinimumSize = new System.Drawing.Size(1500, 840);
            this.Name = "Login";
            this.Text = "Inicio de Sesion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox correoTEXT;
        private TextBox claveTEXT;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}