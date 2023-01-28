namespace App
{
    partial class crudPlantas
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
            this.LaTablaPlantas = new System.Windows.Forms.DataGridView();
            this.logOut = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_crear = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.crea = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.hum_minima = new System.Windows.Forms.TextBox();
            this.tem_min = new System.Windows.Forms.TextBox();
            this.hum_maxima = new System.Windows.Forms.TextBox();
            this.nom_planta = new System.Windows.Forms.TextBox();
            this.tem_maxima = new System.Windows.Forms.TextBox();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_hum2 = new System.Windows.Forms.Label();
            this.label_tem2 = new System.Windows.Forms.Label();
            this.label_hum1 = new System.Windows.Forms.Label();
            this.label_tem1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LaTablaPlantas)).BeginInit();
            this.SuspendLayout();
            // 
            // LaTablaPlantas
            // 
            this.LaTablaPlantas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LaTablaPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaTablaPlantas.Location = new System.Drawing.Point(202, 134);
            this.LaTablaPlantas.Name = "LaTablaPlantas";
            this.LaTablaPlantas.ReadOnly = true;
            this.LaTablaPlantas.RowHeadersWidth = 62;
            this.LaTablaPlantas.RowTemplate.Height = 33;
            this.LaTablaPlantas.Size = new System.Drawing.Size(1080, 266);
            this.LaTablaPlantas.TabIndex = 0;
            this.LaTablaPlantas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickTabla);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(1275, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(185, 34);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "Cerrar Sesión";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // regresar
            // 
            this.regresar.Location = new System.Drawing.Point(12, 12);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(185, 34);
            this.regresar.TabIndex = 3;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = true;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(731, 77);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(195, 34);
            this.button_eliminar.TabIndex = 2;
            this.button_eliminar.Text = "Eliminar Planta";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(461, 37);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(191, 34);
            this.button_editar.TabIndex = 1;
            this.button_editar.Text = "Editar Planta";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(203, 37);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(195, 34);
            this.button_crear.TabIndex = 0;
            this.button_crear.Text = "Crear Planta";
            this.button_crear.UseVisualStyleBackColor = true;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(460, 77);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(192, 34);
            this.editar.TabIndex = 2;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Visible = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // crea
            // 
            this.crea.Location = new System.Drawing.Point(205, 77);
            this.crea.Name = "crea";
            this.crea.Size = new System.Drawing.Size(192, 34);
            this.crea.TabIndex = 1;
            this.crea.Text = "Crear";
            this.crea.UseVisualStyleBackColor = true;
            this.crea.Visible = false;
            this.crea.Click += new System.EventHandler(this.crea_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(1045, 77);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(192, 34);
            this.button_cancelar.TabIndex = 0;
            this.button_cancelar.Text = "Cancelar Operación";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Visible = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // hum_minima
            // 
            this.hum_minima.Location = new System.Drawing.Point(1011, 671);
            this.hum_minima.MaxLength = 3;
            this.hum_minima.Name = "hum_minima";
            this.hum_minima.Size = new System.Drawing.Size(199, 31);
            this.hum_minima.TabIndex = 10;
            this.hum_minima.Visible = false;
            this.hum_minima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearHumMin);
            // 
            // tem_min
            // 
            this.tem_min.Location = new System.Drawing.Point(1011, 584);
            this.tem_min.MaxLength = 2;
            this.tem_min.Name = "tem_min";
            this.tem_min.Size = new System.Drawing.Size(199, 31);
            this.tem_min.TabIndex = 9;
            this.tem_min.Visible = false;
            this.tem_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearTempMin);
            // 
            // hum_maxima
            // 
            this.hum_maxima.Location = new System.Drawing.Point(460, 668);
            this.hum_maxima.MaxLength = 3;
            this.hum_maxima.Name = "hum_maxima";
            this.hum_maxima.Size = new System.Drawing.Size(198, 31);
            this.hum_maxima.TabIndex = 8;
            this.hum_maxima.Visible = false;
            this.hum_maxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearHumMax);
            // 
            // nom_planta
            // 
            this.nom_planta.Location = new System.Drawing.Point(460, 489);
            this.nom_planta.Name = "nom_planta";
            this.nom_planta.Size = new System.Drawing.Size(198, 31);
            this.nom_planta.TabIndex = 7;
            this.nom_planta.Visible = false;
            this.nom_planta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearNombre);
            // 
            // tem_maxima
            // 
            this.tem_maxima.Location = new System.Drawing.Point(460, 581);
            this.tem_maxima.MaxLength = 2;
            this.tem_maxima.Name = "tem_maxima";
            this.tem_maxima.Size = new System.Drawing.Size(198, 31);
            this.tem_maxima.TabIndex = 6;
            this.tem_maxima.Visible = false;
            this.tem_maxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teclaTemMax);
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_nom.Location = new System.Drawing.Point(202, 488);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(252, 32);
            this.label_nom.TabIndex = 5;
            this.label_nom.Text = "Nombre de la Planta";
            this.label_nom.Visible = false;
            // 
            // label_hum2
            // 
            this.label_hum2.AutoSize = true;
            this.label_hum2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_hum2.Location = new System.Drawing.Point(768, 668);
            this.label_hum2.Name = "label_hum2";
            this.label_hum2.Size = new System.Drawing.Size(223, 32);
            this.label_hum2.TabIndex = 4;
            this.label_hum2.Text = "Humedad Mínima";
            this.label_hum2.Visible = false;
            // 
            // label_tem2
            // 
            this.label_tem2.AutoSize = true;
            this.label_tem2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_tem2.Location = new System.Drawing.Point(731, 581);
            this.label_tem2.Name = "label_tem2";
            this.label_tem2.Size = new System.Drawing.Size(260, 32);
            this.label_tem2.TabIndex = 3;
            this.label_tem2.Text = "Temperatura Mínima";
            this.label_tem2.Visible = false;
            // 
            // label_hum1
            // 
            this.label_hum1.AutoSize = true;
            this.label_hum1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_hum1.Location = new System.Drawing.Point(225, 665);
            this.label_hum1.Name = "label_hum1";
            this.label_hum1.Size = new System.Drawing.Size(229, 32);
            this.label_hum1.TabIndex = 2;
            this.label_hum1.Text = "Humedad Máxima";
            this.label_hum1.Visible = false;
            // 
            // label_tem1
            // 
            this.label_tem1.AutoSize = true;
            this.label_tem1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_tem1.Location = new System.Drawing.Point(188, 578);
            this.label_tem1.Name = "label_tem1";
            this.label_tem1.Size = new System.Drawing.Size(266, 32);
            this.label_tem1.TabIndex = 1;
            this.label_tem1.Text = "Temperatura Máxima";
            this.label_tem1.Visible = false;
            // 
            // crudPlantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1478, 784);
            this.Controls.Add(this.label_hum2);
            this.Controls.Add(this.hum_minima);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.tem_min);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.hum_maxima);
            this.Controls.Add(this.label_tem2);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.tem_maxima);
            this.Controls.Add(this.nom_planta);
            this.Controls.Add(this.label_hum1);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.button_crear);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_tem1);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.crea);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.LaTablaPlantas);
            this.MaximumSize = new System.Drawing.Size(1500, 840);
            this.MinimumSize = new System.Drawing.Size(1500, 840);
            this.Name = "crudPlantas";
            this.Text = "Plantas";
            ((System.ComponentModel.ISupportInitialize)(this.LaTablaPlantas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView LaTablaPlantas;
        private Button button_eliminar;
        private Button button_editar;
        private Button button_crear;
        private Button button_cancelar;
        private Button editar;
        private Button crea;
        private Label label_hum2;
        private Label label_tem2;
        private Label label_hum1;
        private Label label_tem1;
        private Label label_nom;
        private TextBox hum_minima;
        private TextBox tem_min;
        private TextBox hum_maxima;
        private TextBox nom_planta;
        private TextBox tem_maxima;
        private Button logOut;
        private Button regresar;
    }
}