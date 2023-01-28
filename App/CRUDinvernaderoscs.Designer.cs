namespace App
{
    partial class CRUDinvernaderoscs
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
            this.logOut = new System.Windows.Forms.Button();
            this.regresa = new System.Windows.Forms.Button();
            this.button_borrar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_crear = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.crear = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.inputCapacidad = new System.Windows.Forms.TextBox();
            this.flores = new System.Windows.Forms.ComboBox();
            this.jtxtcapacidad = new System.Windows.Forms.Label();
            this.jtxtflor = new System.Windows.Forms.Label();
            this.jtxtnombre = new System.Windows.Forms.Label();
            this.tablaInvernaderos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInvernaderos)).BeginInit();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(1275, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(182, 34);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "Cerrar Sesión";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // regresa
            // 
            this.regresa.Location = new System.Drawing.Point(26, 12);
            this.regresa.Name = "regresa";
            this.regresa.Size = new System.Drawing.Size(179, 34);
            this.regresa.TabIndex = 3;
            this.regresa.Text = "Regresar";
            this.regresa.UseVisualStyleBackColor = true;
            this.regresa.Click += new System.EventHandler(this.regresa_Click);
            // 
            // button_borrar
            // 
            this.button_borrar.Location = new System.Drawing.Point(871, 100);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(188, 34);
            this.button_borrar.TabIndex = 2;
            this.button_borrar.Text = "Borrar Invernadero";
            this.button_borrar.UseVisualStyleBackColor = true;
            this.button_borrar.Click += new System.EventHandler(this.button_borrar_Click);
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(633, 100);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(188, 34);
            this.button_editar.TabIndex = 1;
            this.button_editar.Text = "Editar Invernadero";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(392, 100);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(188, 34);
            this.button_crear.TabIndex = 0;
            this.button_crear.Text = "Crear Invernadero";
            this.button_crear.UseVisualStyleBackColor = true;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(633, 60);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(188, 34);
            this.editar.TabIndex = 2;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Visible = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(392, 60);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(188, 34);
            this.crear.TabIndex = 1;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Visible = false;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(1130, 246);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(185, 34);
            this.button_cancelar.TabIndex = 0;
            this.button_cancelar.Text = "Cancelar Operacion";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Visible = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(763, 468);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(182, 31);
            this.inputNombre.TabIndex = 5;
            this.inputNombre.Visible = false;
            this.inputNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearNombre);
            // 
            // inputCapacidad
            // 
            this.inputCapacidad.Location = new System.Drawing.Point(763, 534);
            this.inputCapacidad.Name = "inputCapacidad";
            this.inputCapacidad.Size = new System.Drawing.Size(182, 31);
            this.inputCapacidad.TabIndex = 4;
            this.inputCapacidad.Visible = false;
            this.inputCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearCapacidad);
            // 
            // flores
            // 
            this.flores.FormattingEnabled = true;
            this.flores.Location = new System.Drawing.Point(763, 615);
            this.flores.Name = "flores";
            this.flores.Size = new System.Drawing.Size(182, 33);
            this.flores.TabIndex = 3;
            this.flores.Visible = false;
            this.flores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearFlores);
            // 
            // jtxtcapacidad
            // 
            this.jtxtcapacidad.AutoSize = true;
            this.jtxtcapacidad.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jtxtcapacidad.Location = new System.Drawing.Point(525, 531);
            this.jtxtcapacidad.Name = "jtxtcapacidad";
            this.jtxtcapacidad.Size = new System.Drawing.Size(132, 32);
            this.jtxtcapacidad.TabIndex = 2;
            this.jtxtcapacidad.Text = "Capacidad";
            this.jtxtcapacidad.Visible = false;
            // 
            // jtxtflor
            // 
            this.jtxtflor.AutoSize = true;
            this.jtxtflor.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jtxtflor.Location = new System.Drawing.Point(598, 612);
            this.jtxtflor.Name = "jtxtflor";
            this.jtxtflor.Size = new System.Drawing.Size(59, 32);
            this.jtxtflor.TabIndex = 1;
            this.jtxtflor.Text = "Flor";
            this.jtxtflor.Visible = false;
            // 
            // jtxtnombre
            // 
            this.jtxtnombre.AutoSize = true;
            this.jtxtnombre.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jtxtnombre.Location = new System.Drawing.Point(548, 465);
            this.jtxtnombre.Name = "jtxtnombre";
            this.jtxtnombre.Size = new System.Drawing.Size(109, 32);
            this.jtxtnombre.TabIndex = 0;
            this.jtxtnombre.Text = "Nombre";
            this.jtxtnombre.Visible = false;
            this.jtxtnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // tablaInvernaderos
            // 
            this.tablaInvernaderos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInvernaderos.Location = new System.Drawing.Point(392, 169);
            this.tablaInvernaderos.Name = "tablaInvernaderos";
            this.tablaInvernaderos.RowHeadersWidth = 62;
            this.tablaInvernaderos.RowTemplate.Height = 33;
            this.tablaInvernaderos.Size = new System.Drawing.Size(692, 194);
            this.tablaInvernaderos.TabIndex = 4;
            this.tablaInvernaderos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaInvernaderos_CellClick);
            // 
            // CRUDinvernaderoscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1478, 784);
            this.Controls.Add(this.flores);
            this.Controls.Add(this.inputCapacidad);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.button_borrar);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.jtxtflor);
            this.Controls.Add(this.jtxtcapacidad);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.jtxtnombre);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.tablaInvernaderos);
            this.Controls.Add(this.button_crear);
            this.Controls.Add(this.regresa);
            this.MaximumSize = new System.Drawing.Size(1500, 840);
            this.MinimumSize = new System.Drawing.Size(1500, 840);
            this.Name = "CRUDinvernaderoscs";
            this.Text = "CRUDinvernaderoscs";
            ((System.ComponentModel.ISupportInitialize)(this.tablaInvernaderos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView tablaInvernaderos;
        private TextBox inputNombre;
        private TextBox inputCapacidad;
        private ComboBox flores;
        private Label jtxtcapacidad;
        private Label jtxtflor;
        private Label jtxtnombre;
        private Button button_borrar;
        private Button button_editar;
        private Button button_crear;
        private Button editar;
        private Button crear;
        private Button button_cancelar;
        private Button logOut;
        private Button regresa;
    }
}