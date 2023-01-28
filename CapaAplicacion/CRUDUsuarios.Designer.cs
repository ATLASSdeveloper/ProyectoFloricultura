namespace CapaAplicacion
{
    partial class CRUDUsuarios
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
            this.apellido = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.nombres = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.car = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.ComboBox();
            this.pass = new System.Windows.Forms.Label();
            this.cor = new System.Windows.Forms.Label();
            this.ape = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.ced = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.actualizacion = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.crear = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.losusuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.losusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.apellido);
            this.panel1.Controls.Add(this.clave);
            this.panel1.Controls.Add(this.correo);
            this.panel1.Controls.Add(this.nombres);
            this.panel1.Controls.Add(this.cedula);
            this.panel1.Controls.Add(this.car);
            this.panel1.Controls.Add(this.cargo);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.cor);
            this.panel1.Controls.Add(this.ape);
            this.panel1.Controls.Add(this.nom);
            this.panel1.Controls.Add(this.ced);
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Controls.Add(this.Eliminar);
            this.panel1.Controls.Add(this.actualizacion);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.Guardar);
            this.panel1.Controls.Add(this.crear);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.regresar);
            this.panel1.Controls.Add(this.losusuarios);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1470, 781);
            this.panel1.TabIndex = 0;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(701, 624);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(263, 26);
            this.apellido.TabIndex = 20;
            this.apellido.Visible = false;
            this.apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellido_KeyPress);
            // 
            // clave
            // 
            this.clave.Location = new System.Drawing.Point(701, 718);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(263, 26);
            this.clave.TabIndex = 19;
            this.clave.Visible = false;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(292, 718);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(263, 26);
            this.correo.TabIndex = 18;
            this.correo.Visible = false;
            // 
            // nombres
            // 
            this.nombres.Location = new System.Drawing.Point(292, 624);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(263, 26);
            this.nombres.TabIndex = 17;
            this.nombres.Visible = false;
            this.nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombres_KeyPress);
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(292, 539);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(263, 26);
            this.cedula.TabIndex = 16;
            this.cedula.Visible = false;
            this.cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedula_KeyPress);
            // 
            // car
            // 
            this.car.AutoSize = true;
            this.car.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car.Location = new System.Drawing.Point(1019, 583);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(73, 28);
            this.car.TabIndex = 15;
            this.car.Text = "Cargo";
            this.car.Visible = false;
            // 
            // cargo
            // 
            this.cargo.FormattingEnabled = true;
            this.cargo.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Analista",
            "Floricultor"});
            this.cargo.Location = new System.Drawing.Point(1060, 622);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(221, 28);
            this.cargo.TabIndex = 14;
            this.cargo.Visible = false;
            this.cargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cargo_KeyPress);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(659, 666);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(129, 28);
            this.pass.TabIndex = 13;
            this.pass.Text = "Contraseña";
            this.pass.Visible = false;
            // 
            // cor
            // 
            this.cor.AutoSize = true;
            this.cor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cor.Location = new System.Drawing.Point(239, 670);
            this.cor.Name = "cor";
            this.cor.Size = new System.Drawing.Size(208, 28);
            this.cor.TabIndex = 12;
            this.cor.Text = "Correo Electrónico";
            this.cor.Visible = false;
            // 
            // ape
            // 
            this.ape.AutoSize = true;
            this.ape.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ape.Location = new System.Drawing.Point(659, 583);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(109, 28);
            this.ape.TabIndex = 11;
            this.ape.Text = "Apellidos";
            this.ape.Visible = false;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(239, 583);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(106, 28);
            this.nom.TabIndex = 10;
            this.nom.Text = "Nombres";
            this.nom.Visible = false;
            // 
            // ced
            // 
            this.ced.AutoSize = true;
            this.ced.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ced.Location = new System.Drawing.Point(239, 499);
            this.ced.Name = "ced";
            this.ced.Size = new System.Drawing.Size(83, 28);
            this.ced.TabIndex = 9;
            this.ced.Text = "Cédula";
            this.ced.Visible = false;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.Cancelar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(1096, 86);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(250, 41);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar Operación";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Visible = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.Eliminar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(755, 86);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(250, 41);
            this.Eliminar.TabIndex = 7;
            this.Eliminar.Text = "Eliminar Usuario";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // actualizacion
            // 
            this.actualizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.actualizacion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizacion.Location = new System.Drawing.Point(458, 86);
            this.actualizacion.Name = "actualizacion";
            this.actualizacion.Size = new System.Drawing.Size(230, 41);
            this.actualizacion.TabIndex = 6;
            this.actualizacion.Text = "Guardar Cambios";
            this.actualizacion.UseVisualStyleBackColor = false;
            this.actualizacion.Visible = false;
            this.actualizacion.Click += new System.EventHandler(this.actualizacion_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.actualizar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.Location = new System.Drawing.Point(458, 86);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(230, 41);
            this.actualizar.TabIndex = 5;
            this.actualizar.Text = "Editar Usuario";
            this.actualizar.UseVisualStyleBackColor = false;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.Guardar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(128, 86);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(230, 41);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Crear";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Visible = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // crear
            // 
            this.crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.crear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.Location = new System.Drawing.Point(128, 86);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(230, 41);
            this.crear.TabIndex = 3;
            this.crear.Text = "Crear Usuario";
            this.crear.UseVisualStyleBackColor = false;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.logOut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.Control;
            this.logOut.Location = new System.Drawing.Point(1237, 9);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(230, 41);
            this.logOut.TabIndex = 2;
            this.logOut.Text = "Cerrar Sesión";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.regresar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ForeColor = System.Drawing.SystemColors.Control;
            this.regresar.Location = new System.Drawing.Point(8, 9);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(230, 41);
            this.regresar.TabIndex = 1;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // losusuarios
            // 
            this.losusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.losusuarios.Location = new System.Drawing.Point(128, 133);
            this.losusuarios.Name = "losusuarios";
            this.losusuarios.RowHeadersWidth = 62;
            this.losusuarios.RowTemplate.Height = 28;
            this.losusuarios.Size = new System.Drawing.Size(1218, 363);
            this.losusuarios.TabIndex = 0;
            this.losusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.losusuarios_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(618, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 47);
            this.label1.TabIndex = 21;
            this.label1.Text = "Empleados";
            // 
            // CRUDUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 785);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDUsuarios";
            this.Text = "CRUDUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.losusuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView losusuarios;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button actualizacion;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label cor;
        private System.Windows.Forms.Label ape;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label ced;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox clave;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox nombres;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.Label car;
        private System.Windows.Forms.ComboBox cargo;
        private System.Windows.Forms.Label label1;
    }
}