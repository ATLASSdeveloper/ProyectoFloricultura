namespace App
{
    partial class Invernaderos
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
            this.gestionarPlantas = new System.Windows.Forms.Button();
            this.gestionInvernaderos = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.los_invernaderos = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hum_pla = new System.Windows.Forms.Label();
            this.tem_pla = new System.Windows.Forms.Label();
            this.nom_pla = new System.Windows.Forms.Label();
            this.tablaTemperaturas = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTemperaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // gestionarPlantas
            // 
            this.gestionarPlantas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gestionarPlantas.AutoSize = true;
            this.gestionarPlantas.BackColor = System.Drawing.Color.White;
            this.gestionarPlantas.Location = new System.Drawing.Point(1150, 516);
            this.gestionarPlantas.Name = "gestionarPlantas";
            this.gestionarPlantas.Size = new System.Drawing.Size(205, 35);
            this.gestionarPlantas.TabIndex = 1;
            this.gestionarPlantas.Text = "Gestionar Plantas";
            this.gestionarPlantas.UseVisualStyleBackColor = false;
            this.gestionarPlantas.Click += new System.EventHandler(this.gestionarPlantas_Click);
            // 
            // gestionInvernaderos
            // 
            this.gestionInvernaderos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gestionInvernaderos.AutoSize = true;
            this.gestionInvernaderos.BackColor = System.Drawing.Color.White;
            this.gestionInvernaderos.Location = new System.Drawing.Point(1150, 326);
            this.gestionInvernaderos.Name = "gestionInvernaderos";
            this.gestionInvernaderos.Size = new System.Drawing.Size(205, 35);
            this.gestionInvernaderos.TabIndex = 0;
            this.gestionInvernaderos.Text = "Gestionar Invernaderos";
            this.gestionInvernaderos.UseVisualStyleBackColor = false;
            this.gestionInvernaderos.Click += new System.EventHandler(this.gestionInvernaderos_Click);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.White;
            this.regresar.Location = new System.Drawing.Point(12, 11);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(222, 34);
            this.regresar.TabIndex = 2;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Visible = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1234, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // los_invernaderos
            // 
            this.los_invernaderos.BackColor = System.Drawing.Color.White;
            this.los_invernaderos.FormattingEnabled = true;
            this.los_invernaderos.Location = new System.Drawing.Point(540, 27);
            this.los_invernaderos.Name = "los_invernaderos";
            this.los_invernaderos.Size = new System.Drawing.Size(182, 33);
            this.los_invernaderos.TabIndex = 0;
            this.los_invernaderos.SelectedIndexChanged += new System.EventHandler(this.los_invernaderos_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.gestionarPlantas);
            this.panel3.Controls.Add(this.regresar);
            this.panel3.Controls.Add(this.gestionInvernaderos);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.hum_pla);
            this.panel3.Controls.Add(this.tem_pla);
            this.panel3.Controls.Add(this.nom_pla);
            this.panel3.Controls.Add(this.tablaTemperaturas);
            this.panel3.Controls.Add(this.los_invernaderos);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1476, 771);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(790, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Humedad adecuada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(484, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Temperatura adecuada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de la planta";
            // 
            // hum_pla
            // 
            this.hum_pla.AutoSize = true;
            this.hum_pla.Location = new System.Drawing.Point(883, 199);
            this.hum_pla.Name = "hum_pla";
            this.hum_pla.Size = new System.Drawing.Size(0, 25);
            this.hum_pla.TabIndex = 5;
            // 
            // tem_pla
            // 
            this.tem_pla.AutoSize = true;
            this.tem_pla.Location = new System.Drawing.Point(579, 199);
            this.tem_pla.Name = "tem_pla";
            this.tem_pla.Size = new System.Drawing.Size(0, 25);
            this.tem_pla.TabIndex = 3;
            // 
            // nom_pla
            // 
            this.nom_pla.AutoSize = true;
            this.nom_pla.Location = new System.Drawing.Point(283, 199);
            this.nom_pla.Name = "nom_pla";
            this.nom_pla.Size = new System.Drawing.Size(0, 25);
            this.nom_pla.TabIndex = 2;
            // 
            // tablaTemperaturas
            // 
            this.tablaTemperaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTemperaturas.Location = new System.Drawing.Point(300, 326);
            this.tablaTemperaturas.Name = "tablaTemperaturas";
            this.tablaTemperaturas.RowHeadersWidth = 62;
            this.tablaTemperaturas.RowTemplate.Height = 33;
            this.tablaTemperaturas.Size = new System.Drawing.Size(671, 225);
            this.tablaTemperaturas.TabIndex = 1;
            this.tablaTemperaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Invernaderos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 784);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(1500, 840);
            this.MinimumSize = new System.Drawing.Size(1500, 840);
            this.Name = "Invernaderos";
            this.Text = "Invernaderos";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTemperaturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button gestionInvernaderos;
        private Button gestionarPlantas;
        private ComboBox los_invernaderos;
        private Button button1;
        private Panel panel3;
        private DataGridView tablaTemperaturas;
        private Label hum_pla;
        private Label tem_pla;
        private Label nom_pla;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button regresar;
    }
}