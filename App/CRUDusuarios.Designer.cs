namespace App
{
    partial class CRUDusuarios
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ced = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.ape = new System.Windows.Forms.Label();
            this.cor = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.car = new System.Windows.Forms.Label();
            this.nombres = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.ComboBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.losusuarios = new System.Windows.Forms.DataGridView();
            this.regresar = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.crear = new System.Windows.Forms.Button();
            this.actualizacion = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.losusuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ced
            // 
            this.ced.AutoSize = true;
            this.ced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ced.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ced.Location = new System.Drawing.Point(208, 545);
            this.ced.Name = "ced";
            this.ced.Size = new System.Drawing.Size(92, 32);
            this.ced.TabIndex = 5;
            this.ced.Text = "Cedula";
            this.ced.Visible = false;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.nom.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nom.Location = new System.Drawing.Point(179, 613);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(121, 32);
            this.nom.TabIndex = 6;
            this.nom.Text = "Nombres";
            this.nom.Visible = false;
            // 
            // ape
            // 
            this.ape.AutoSize = true;
            this.ape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ape.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ape.Location = new System.Drawing.Point(715, 613);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(123, 32);
            this.ape.TabIndex = 7;
            this.ape.Text = "Apellidos";
            this.ape.Visible = false;
            // 
            // cor
            // 
            this.cor.AutoSize = true;
            this.cor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.cor.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cor.Location = new System.Drawing.Point(208, 682);
            this.cor.Name = "cor";
            this.cor.Size = new System.Drawing.Size(92, 32);
            this.cor.TabIndex = 8;
            this.cor.Text = "Correo";
            this.cor.Visible = false;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.pass.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pass.Location = new System.Drawing.Point(693, 682);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(145, 32);
            this.pass.TabIndex = 9;
            this.pass.Text = "Contraseña";
            this.pass.Visible = false;
            // 
            // car
            // 
            this.car.AutoSize = true;
            this.car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.car.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.car.Location = new System.Drawing.Point(218, 743);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(82, 32);
            this.car.TabIndex = 10;
            this.car.Text = "Cargo";
            this.car.Visible = false;
            // 
            // nombres
            // 
            this.nombres.Location = new System.Drawing.Point(330, 610);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(237, 31);
            this.nombres.TabIndex = 12;
            this.nombres.Visible = false;
            this.nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombres_KeyPress);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(872, 610);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(237, 31);
            this.apellido.TabIndex = 13;
            this.apellido.Visible = false;
            this.apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellido_KeyPress);
            // 
            // clave
            // 
            this.clave.Location = new System.Drawing.Point(875, 676);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(234, 31);
            this.clave.TabIndex = 14;
            this.clave.Visible = false;
            this.clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clave_KeyPress);
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(330, 679);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(237, 31);
            this.correo.TabIndex = 15;
            this.correo.Visible = false;
            this.correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correo_KeyPress);
            // 
            // cargo
            // 
            this.cargo.FormattingEnabled = true;
            this.cargo.Items.AddRange(new object[] {
            "Administrador",
            "Analista",
            "Floricultor"});
            this.cargo.Location = new System.Drawing.Point(330, 739);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(237, 33);
            this.cargo.TabIndex = 16;
            this.cargo.Visible = false;
            this.cargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cargo_KeyPress);
            // 
            // cedula
            // 
            this.cedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cedula.Location = new System.Drawing.Point(330, 549);
            this.cedula.MaxLength = 10;
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(237, 31);
            this.cedula.TabIndex = 11;
            this.cedula.Visible = false;
            this.cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedula_KeyPress);
            // 
            // losusuarios
            // 
            this.losusuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.losusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.losusuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.losusuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.losusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.losusuarios.Location = new System.Drawing.Point(136, 150);
            this.losusuarios.Name = "losusuarios";
            this.losusuarios.ReadOnly = true;
            this.losusuarios.RowHeadersWidth = 62;
            this.losusuarios.RowTemplate.Height = 33;
            this.losusuarios.Size = new System.Drawing.Size(1218, 363);
            this.losusuarios.TabIndex = 0;
            this.losusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.losusuarios_CellClick);
            // 
            // regresar
            // 
            this.regresar.Location = new System.Drawing.Point(12, 12);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(112, 34);
            this.regresar.TabIndex = 19;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = true;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(1303, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(152, 34);
            this.logOut.TabIndex = 20;
            this.logOut.Text = "Cerrar Sesión";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Controls.Add(this.Guardar);
            this.panel1.Controls.Add(this.Eliminar);
            this.panel1.Controls.Add(this.apellido);
            this.panel1.Controls.Add(this.crear);
            this.panel1.Controls.Add(this.actualizacion);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.actualizar);
            this.panel1.Controls.Add(this.regresar);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.car);
            this.panel1.Controls.Add(this.ape);
            this.panel1.Controls.Add(this.losusuarios);
            this.panel1.Controls.Add(this.cor);
            this.panel1.Controls.Add(this.nom);
            this.panel1.Controls.Add(this.cedula);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 784);
            this.panel1.TabIndex = 19;
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancelar.AutoSize = true;
            this.Cancelar.Location = new System.Drawing.Point(1101, 93);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(197, 35);
            this.Cancelar.TabIndex = 4;
            this.Cancelar.Text = "Cancelar Operación";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Visible = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(153, 54);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(197, 34);
            this.Guardar.TabIndex = 17;
            this.Guardar.Text = "Guardar Usuario";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Visible = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eliminar.AutoSize = true;
            this.Eliminar.Location = new System.Drawing.Point(681, 93);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(197, 35);
            this.Eliminar.TabIndex = 3;
            this.Eliminar.Text = "Eliminar Usuario";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // crear
            // 
            this.crear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crear.AutoSize = true;
            this.crear.Location = new System.Drawing.Point(153, 94);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(197, 35);
            this.crear.TabIndex = 1;
            this.crear.Text = "Crear Usuario";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // actualizacion
            // 
            this.actualizacion.Location = new System.Drawing.Point(405, 54);
            this.actualizacion.Name = "actualizacion";
            this.actualizacion.Size = new System.Drawing.Size(193, 34);
            this.actualizacion.TabIndex = 18;
            this.actualizacion.Text = "Actualizar Usuario";
            this.actualizacion.UseVisualStyleBackColor = true;
            this.actualizacion.Visible = false;
            this.actualizacion.Click += new System.EventHandler(this.actualizacion_Click);
            // 
            // actualizar
            // 
            this.actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actualizar.AutoSize = true;
            this.actualizar.Location = new System.Drawing.Point(405, 96);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(197, 35);
            this.actualizar.TabIndex = 2;
            this.actualizar.Text = "Editar Usuario";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // CRUDusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 784);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.nombres);
            this.Controls.Add(this.ced);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1500, 840);
            this.MinimumSize = new System.Drawing.Size(1500, 840);
            this.Name = "CRUDusuarios";
            this.Text = "CRUDusuarios";
            ((System.ComponentModel.ISupportInitialize)(this.losusuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label ced;
        private Label nom;
        private Label ape;
        private Label cor;
        private Label pass;
        private Label car;
        private TextBox nombres;
        private TextBox apellido;
        private TextBox clave;
        private TextBox correo;
        private ComboBox cargo;
        private TextBox cedula;
        private DataGridView losusuarios;
        private Button regresar;
        private Button logOut;
        private Panel panel1;
        private Button Cancelar;
        private Button Guardar;
        private Button Eliminar;
        private Button crear;
        private Button actualizacion;
        private Button actualizar;
    }
}