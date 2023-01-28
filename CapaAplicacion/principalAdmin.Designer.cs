namespace CapaAplicacion
{
    partial class principalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principalAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boton_usuarios = new System.Windows.Forms.Button();
            this.boton_invernaderos = new System.Windows.Forms.Button();
            this.boton_reportes = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO ADMINISTRADOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // boton_usuarios
            // 
            this.boton_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.boton_usuarios.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_usuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.boton_usuarios.Location = new System.Drawing.Point(810, 225);
            this.boton_usuarios.Name = "boton_usuarios";
            this.boton_usuarios.Size = new System.Drawing.Size(634, 113);
            this.boton_usuarios.TabIndex = 2;
            this.boton_usuarios.Text = "USUARIOS";
            this.boton_usuarios.UseVisualStyleBackColor = false;
            this.boton_usuarios.Click += new System.EventHandler(this.boton_usuarios_Click);
            // 
            // boton_invernaderos
            // 
            this.boton_invernaderos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.boton_invernaderos.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_invernaderos.ForeColor = System.Drawing.SystemColors.Control;
            this.boton_invernaderos.Location = new System.Drawing.Point(810, 532);
            this.boton_invernaderos.Name = "boton_invernaderos";
            this.boton_invernaderos.Size = new System.Drawing.Size(634, 113);
            this.boton_invernaderos.TabIndex = 3;
            this.boton_invernaderos.Text = "INVERNADEROS";
            this.boton_invernaderos.UseVisualStyleBackColor = false;
            this.boton_invernaderos.Click += new System.EventHandler(this.boton_invernaderos_Click);
            // 
            // boton_reportes
            // 
            this.boton_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.boton_reportes.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_reportes.ForeColor = System.Drawing.SystemColors.Control;
            this.boton_reportes.Location = new System.Drawing.Point(810, 378);
            this.boton_reportes.Name = "boton_reportes";
            this.boton_reportes.Size = new System.Drawing.Size(634, 113);
            this.boton_reportes.TabIndex = 4;
            this.boton_reportes.Text = "REPORTES";
            this.boton_reportes.UseVisualStyleBackColor = false;
            this.boton_reportes.Click += new System.EventHandler(this.boton_reportes_Click);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.logOut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOut.Location = new System.Drawing.Point(1207, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(260, 40);
            this.logOut.TabIndex = 5;
            this.logOut.Text = "Cerrar Sesión";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.boton_reportes);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.boton_invernaderos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.boton_usuarios);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 782);
            this.panel1.TabIndex = 6;
            // 
            // principalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 784);
            this.Controls.Add(this.panel1);
            this.Name = "principalAdmin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boton_usuarios;
        private System.Windows.Forms.Button boton_invernaderos;
        private System.Windows.Forms.Button boton_reportes;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Panel panel1;
    }
}