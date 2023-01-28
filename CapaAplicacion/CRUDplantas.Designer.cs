namespace CapaAplicacion
{
    partial class CRUDplantas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.button_crear = new System.Windows.Forms.Button();
            this.crea = new System.Windows.Forms.Button();
            this.hum_minima = new System.Windows.Forms.TextBox();
            this.tem_min = new System.Windows.Forms.TextBox();
            this.hum_maxima = new System.Windows.Forms.TextBox();
            this.tem_maxima = new System.Windows.Forms.TextBox();
            this.nom_planta = new System.Windows.Forms.TextBox();
            this.label_hum2 = new System.Windows.Forms.Label();
            this.label_tem2 = new System.Windows.Forms.Label();
            this.label_hum1 = new System.Windows.Forms.Label();
            this.label_tem1 = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.LaTablaPlantas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaTablaPlantas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button_cancelar);
            this.panel1.Controls.Add(this.button_eliminar);
            this.panel1.Controls.Add(this.button_editar);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.button_crear);
            this.panel1.Controls.Add(this.crea);
            this.panel1.Controls.Add(this.hum_minima);
            this.panel1.Controls.Add(this.tem_min);
            this.panel1.Controls.Add(this.hum_maxima);
            this.panel1.Controls.Add(this.tem_maxima);
            this.panel1.Controls.Add(this.nom_planta);
            this.panel1.Controls.Add(this.label_hum2);
            this.panel1.Controls.Add(this.label_tem2);
            this.panel1.Controls.Add(this.label_hum1);
            this.panel1.Controls.Add(this.label_tem1);
            this.panel1.Controls.Add(this.label_nom);
            this.panel1.Controls.Add(this.LaTablaPlantas);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 779);
            this.panel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.button8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(9, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(230, 41);
            this.button8.TabIndex = 18;
            this.button8.Text = "Regresar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.regresar_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.button7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(1233, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(230, 41);
            this.button7.TabIndex = 17;
            this.button7.Text = "Cerrar Sesión";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.logOut_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.button_cancelar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(1026, 94);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(242, 41);
            this.button_cancelar.TabIndex = 16;
            this.button_cancelar.Text = "Cancelar Operación";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Visible = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.button_eliminar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.Location = new System.Drawing.Point(755, 94);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(230, 41);
            this.button_eliminar.TabIndex = 15;
            this.button_eliminar.Text = "Eliminar Flor";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_editar
            // 
            this.button_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.button_editar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.Location = new System.Drawing.Point(473, 94);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(230, 41);
            this.button_editar.TabIndex = 14;
            this.button_editar.Text = "Editar Flor";
            this.button_editar.UseVisualStyleBackColor = false;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.editar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.Location = new System.Drawing.Point(473, 94);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(230, 41);
            this.editar.TabIndex = 13;
            this.editar.Text = "Guardar Cambios";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Visible = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // button_crear
            // 
            this.button_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.button_crear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_crear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_crear.Location = new System.Drawing.Point(188, 94);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(230, 41);
            this.button_crear.TabIndex = 12;
            this.button_crear.Text = "Crear Flor";
            this.button_crear.UseVisualStyleBackColor = false;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // crea
            // 
            this.crea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.crea.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crea.Location = new System.Drawing.Point(188, 94);
            this.crea.Name = "crea";
            this.crea.Size = new System.Drawing.Size(230, 41);
            this.crea.TabIndex = 11;
            this.crea.Text = "Crear";
            this.crea.UseVisualStyleBackColor = false;
            this.crea.Visible = false;
            this.crea.Click += new System.EventHandler(this.crea_Click);
            // 
            // hum_minima
            // 
            this.hum_minima.Location = new System.Drawing.Point(850, 639);
            this.hum_minima.Name = "hum_minima";
            this.hum_minima.Size = new System.Drawing.Size(258, 26);
            this.hum_minima.TabIndex = 10;
            this.hum_minima.Visible = false;
            this.hum_minima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearHumMin);
            // 
            // tem_min
            // 
            this.tem_min.Location = new System.Drawing.Point(850, 549);
            this.tem_min.Name = "tem_min";
            this.tem_min.Size = new System.Drawing.Size(258, 26);
            this.tem_min.TabIndex = 9;
            this.tem_min.Visible = false;
            this.tem_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearTempMin);
            // 
            // hum_maxima
            // 
            this.hum_maxima.Location = new System.Drawing.Point(386, 639);
            this.hum_maxima.Name = "hum_maxima";
            this.hum_maxima.Size = new System.Drawing.Size(258, 26);
            this.hum_maxima.TabIndex = 8;
            this.hum_maxima.Visible = false;
            this.hum_maxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearHumMax);
            // 
            // tem_maxima
            // 
            this.tem_maxima.Location = new System.Drawing.Point(386, 549);
            this.tem_maxima.Name = "tem_maxima";
            this.tem_maxima.Size = new System.Drawing.Size(258, 26);
            this.tem_maxima.TabIndex = 7;
            this.tem_maxima.Visible = false;
            this.tem_maxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teclaTemMax);
            // 
            // nom_planta
            // 
            this.nom_planta.Location = new System.Drawing.Point(386, 466);
            this.nom_planta.Name = "nom_planta";
            this.nom_planta.Size = new System.Drawing.Size(258, 26);
            this.nom_planta.TabIndex = 6;
            this.nom_planta.Visible = false;
            this.nom_planta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearNombre);
            // 
            // label_hum2
            // 
            this.label_hum2.AutoSize = true;
            this.label_hum2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hum2.Location = new System.Drawing.Point(800, 594);
            this.label_hum2.Name = "label_hum2";
            this.label_hum2.Size = new System.Drawing.Size(195, 28);
            this.label_hum2.TabIndex = 5;
            this.label_hum2.Text = "Humedad Mínima";
            this.label_hum2.Visible = false;
            // 
            // label_tem2
            // 
            this.label_tem2.AutoSize = true;
            this.label_tem2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tem2.Location = new System.Drawing.Point(800, 505);
            this.label_tem2.Name = "label_tem2";
            this.label_tem2.Size = new System.Drawing.Size(230, 28);
            this.label_tem2.TabIndex = 4;
            this.label_tem2.Text = "Temperatura Mínima";
            this.label_tem2.Visible = false;
            // 
            // label_hum1
            // 
            this.label_hum1.AutoSize = true;
            this.label_hum1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hum1.Location = new System.Drawing.Point(336, 594);
            this.label_hum1.Name = "label_hum1";
            this.label_hum1.Size = new System.Drawing.Size(199, 28);
            this.label_hum1.TabIndex = 3;
            this.label_hum1.Text = "Humedad Máxima";
            this.label_hum1.Visible = false;
            // 
            // label_tem1
            // 
            this.label_tem1.AutoSize = true;
            this.label_tem1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tem1.Location = new System.Drawing.Point(336, 505);
            this.label_tem1.Name = "label_tem1";
            this.label_tem1.Size = new System.Drawing.Size(234, 28);
            this.label_tem1.TabIndex = 2;
            this.label_tem1.Text = "Temperatura Máxima";
            this.label_tem1.Visible = false;
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(336, 424);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(96, 28);
            this.label_nom.TabIndex = 1;
            this.label_nom.Text = "Nombre";
            this.label_nom.Visible = false;
            // 
            // LaTablaPlantas
            // 
            this.LaTablaPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaTablaPlantas.Location = new System.Drawing.Point(188, 145);
            this.LaTablaPlantas.Name = "LaTablaPlantas";
            this.LaTablaPlantas.RowHeadersWidth = 62;
            this.LaTablaPlantas.RowTemplate.Height = 28;
            this.LaTablaPlantas.Size = new System.Drawing.Size(1080, 266);
            this.LaTablaPlantas.TabIndex = 0;
            this.LaTablaPlantas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickTabla);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gestión Flores";
            // 
            // CRUDplantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 784);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDplantas";
            this.Text = "CRUDplantas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaTablaPlantas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_tem1;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.DataGridView LaTablaPlantas;
        private System.Windows.Forms.TextBox hum_minima;
        private System.Windows.Forms.TextBox tem_min;
        private System.Windows.Forms.TextBox hum_maxima;
        private System.Windows.Forms.TextBox tem_maxima;
        private System.Windows.Forms.TextBox nom_planta;
        private System.Windows.Forms.Label label_hum2;
        private System.Windows.Forms.Label label_tem2;
        private System.Windows.Forms.Label label_hum1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.Button crea;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
    }
}