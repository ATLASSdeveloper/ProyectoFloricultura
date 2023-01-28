namespace CapaAplicacion
{
    partial class CRUDInvernaderos
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_borrar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.crear = new System.Windows.Forms.Button();
            this.button_crear = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.regresa = new System.Windows.Forms.Button();
            this.flores = new System.Windows.Forms.ComboBox();
            this.inputCapacidad = new System.Windows.Forms.TextBox();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.jtxtflor = new System.Windows.Forms.Label();
            this.jtxtcapacidad = new System.Windows.Forms.Label();
            this.jtxtnombre = new System.Windows.Forms.Label();
            this.tablaInvernaderos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInvernaderos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_cancelar);
            this.panel1.Controls.Add(this.button_borrar);
            this.panel1.Controls.Add(this.button_editar);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.crear);
            this.panel1.Controls.Add(this.button_crear);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.regresa);
            this.panel1.Controls.Add(this.flores);
            this.panel1.Controls.Add(this.inputCapacidad);
            this.panel1.Controls.Add(this.inputNombre);
            this.panel1.Controls.Add(this.jtxtflor);
            this.panel1.Controls.Add(this.jtxtcapacidad);
            this.panel1.Controls.Add(this.jtxtnombre);
            this.panel1.Controls.Add(this.tablaInvernaderos);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1470, 780);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gestión Invernaderos";
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.button_cancelar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(896, 123);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(237, 41);
            this.button_cancelar.TabIndex = 14;
            this.button_cancelar.Text = "Cancelar Operación";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Visible = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_borrar
            // 
            this.button_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.button_borrar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar.Location = new System.Drawing.Point(896, 123);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(237, 41);
            this.button_borrar.TabIndex = 13;
            this.button_borrar.Text = "Borrar Invernadero";
            this.button_borrar.UseVisualStyleBackColor = false;
            this.button_borrar.Click += new System.EventHandler(this.button_borrar_Click);
            // 
            // button_editar
            // 
            this.button_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.button_editar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.Location = new System.Drawing.Point(626, 123);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(230, 41);
            this.button_editar.TabIndex = 12;
            this.button_editar.Text = "Editar Invernadero";
            this.button_editar.UseVisualStyleBackColor = false;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.editar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.Location = new System.Drawing.Point(626, 123);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(230, 41);
            this.editar.TabIndex = 11;
            this.editar.Text = "Guardar Cambios";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Visible = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // crear
            // 
            this.crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.crear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.Location = new System.Drawing.Point(356, 123);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(230, 41);
            this.crear.TabIndex = 10;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = false;
            this.crear.Visible = false;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // button_crear
            // 
            this.button_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.button_crear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_crear.Location = new System.Drawing.Point(356, 123);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(230, 41);
            this.button_crear.TabIndex = 9;
            this.button_crear.Text = "Crear Invernadero";
            this.button_crear.UseVisualStyleBackColor = false;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.logOut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.Control;
            this.logOut.Location = new System.Drawing.Point(1232, 11);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(230, 41);
            this.logOut.TabIndex = 8;
            this.logOut.Text = "Cerrar Sesión";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // regresa
            // 
            this.regresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.regresa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresa.ForeColor = System.Drawing.SystemColors.Control;
            this.regresa.Location = new System.Drawing.Point(9, 11);
            this.regresa.Name = "regresa";
            this.regresa.Size = new System.Drawing.Size(230, 41);
            this.regresa.TabIndex = 7;
            this.regresa.Text = "Regresar";
            this.regresa.UseVisualStyleBackColor = false;
            this.regresa.Click += new System.EventHandler(this.regresa_Click);
            // 
            // flores
            // 
            this.flores.FormattingEnabled = true;
            this.flores.Location = new System.Drawing.Point(634, 651);
            this.flores.Name = "flores";
            this.flores.Size = new System.Drawing.Size(222, 28);
            this.flores.TabIndex = 6;
            this.flores.Visible = false;
            this.flores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearFlores);
            // 
            // inputCapacidad
            // 
            this.inputCapacidad.Location = new System.Drawing.Point(634, 549);
            this.inputCapacidad.Name = "inputCapacidad";
            this.inputCapacidad.Size = new System.Drawing.Size(222, 26);
            this.inputCapacidad.TabIndex = 5;
            this.inputCapacidad.Visible = false;
            this.inputCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearCapacidad);
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(634, 454);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(222, 26);
            this.inputNombre.TabIndex = 4;
            this.inputNombre.Visible = false;
            this.inputNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclearNombre);
            // 
            // jtxtflor
            // 
            this.jtxtflor.AutoSize = true;
            this.jtxtflor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jtxtflor.Location = new System.Drawing.Point(594, 600);
            this.jtxtflor.Name = "jtxtflor";
            this.jtxtflor.Size = new System.Drawing.Size(55, 28);
            this.jtxtflor.TabIndex = 3;
            this.jtxtflor.Text = "Flor";
            this.jtxtflor.Visible = false;
            // 
            // jtxtcapacidad
            // 
            this.jtxtcapacidad.AutoSize = true;
            this.jtxtcapacidad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jtxtcapacidad.Location = new System.Drawing.Point(549, 501);
            this.jtxtcapacidad.Name = "jtxtcapacidad";
            this.jtxtcapacidad.Size = new System.Drawing.Size(119, 28);
            this.jtxtcapacidad.TabIndex = 2;
            this.jtxtcapacidad.Text = "Capacidad";
            this.jtxtcapacidad.Visible = false;
            // 
            // jtxtnombre
            // 
            this.jtxtnombre.AutoSize = true;
            this.jtxtnombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jtxtnombre.Location = new System.Drawing.Point(572, 408);
            this.jtxtnombre.Name = "jtxtnombre";
            this.jtxtnombre.Size = new System.Drawing.Size(96, 28);
            this.jtxtnombre.TabIndex = 1;
            this.jtxtnombre.Text = "Nombre";
            this.jtxtnombre.Visible = false;
            // 
            // tablaInvernaderos
            // 
            this.tablaInvernaderos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInvernaderos.Location = new System.Drawing.Point(356, 172);
            this.tablaInvernaderos.Name = "tablaInvernaderos";
            this.tablaInvernaderos.RowHeadersWidth = 62;
            this.tablaInvernaderos.RowTemplate.Height = 28;
            this.tablaInvernaderos.Size = new System.Drawing.Size(777, 194);
            this.tablaInvernaderos.TabIndex = 0;
            this.tablaInvernaderos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaInvernaderos_CellClick);
            // 
            // CRUDInvernaderos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 784);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDInvernaderos";
            this.Text = "CRUDInvernaderos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInvernaderos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaInvernaderos;
        private System.Windows.Forms.Label jtxtflor;
        private System.Windows.Forms.Label jtxtcapacidad;
        private System.Windows.Forms.Label jtxtnombre;
        private System.Windows.Forms.ComboBox flores;
        private System.Windows.Forms.TextBox inputCapacidad;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button regresa;
        private System.Windows.Forms.Label label1;
    }
}