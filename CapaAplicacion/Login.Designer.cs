namespace CapaAplicacion
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.boton_inicio_sesion = new System.Windows.Forms.Button();
            this.claveTEXT = new System.Windows.Forms.TextBox();
            this.correoTEXT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.boton_inicio_sesion);
            this.panel1.Controls.Add(this.claveTEXT);
            this.panel1.Controls.Add(this.correoTEXT);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.MaximumSize = new System.Drawing.Size(1500, 840);
            this.panel1.MinimumSize = new System.Drawing.Size(1500, 840);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 840);
            this.panel1.TabIndex = 0;
            // 
            // boton_inicio_sesion
            // 
            this.boton_inicio_sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(100)))));
            this.boton_inicio_sesion.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.boton_inicio_sesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_inicio_sesion.Location = new System.Drawing.Point(172, 510);
            this.boton_inicio_sesion.Name = "boton_inicio_sesion";
            this.boton_inicio_sesion.Size = new System.Drawing.Size(284, 60);
            this.boton_inicio_sesion.TabIndex = 6;
            this.boton_inicio_sesion.Text = "INICIAR SESIÓN";
            this.boton_inicio_sesion.UseVisualStyleBackColor = false;
            this.boton_inicio_sesion.Click += new System.EventHandler(this.boton_inicio_sesion_Click);
            // 
            // claveTEXT
            // 
            this.claveTEXT.Location = new System.Drawing.Point(172, 385);
            this.claveTEXT.Name = "claveTEXT";
            this.claveTEXT.Size = new System.Drawing.Size(284, 26);
            this.claveTEXT.TabIndex = 5;
            // 
            // correoTEXT
            // 
            this.correoTEXT.Location = new System.Drawing.Point(172, 253);
            this.correoTEXT.Name = "correoTEXT";
            this.correoTEXT.Size = new System.Drawing.Size(284, 26);
            this.correoTEXT.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(636, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(841, 780);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "CORREO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDOS";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 784);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox claveTEXT;
        private System.Windows.Forms.TextBox correoTEXT;
        private System.Windows.Forms.Button boton_inicio_sesion;
    }
}

