namespace App
{
    partial class Reportes
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
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.cerrarSesion.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cerrarSesion.Location = new System.Drawing.Point(1518, 12);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(206, 34);
            this.cerrarSesion.TabIndex = 0;
            this.cerrarSesion.Text = "Cerrar Sesión";
            this.cerrarSesion.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(756, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1736, 744);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cerrarSesion);
            this.MaximumSize = new System.Drawing.Size(1758, 800);
            this.MinimumSize = new System.Drawing.Size(1758, 800);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private Button cerrarSesion;
        private ComboBox comboBox1;
    }
}