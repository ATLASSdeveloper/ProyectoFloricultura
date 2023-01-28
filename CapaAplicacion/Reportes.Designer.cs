namespace CapaAplicacion
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.los_invernaderos = new System.Windows.Forms.ComboBox();
            this.logOut = new System.Windows.Forms.Button();
            this.estadisticaVisual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.los_invernaderos);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.estadisticaVisual);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 747);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reportes";
            // 
            // los_invernaderos
            // 
            this.los_invernaderos.FormattingEnabled = true;
            this.los_invernaderos.Location = new System.Drawing.Point(530, 104);
            this.los_invernaderos.Name = "los_invernaderos";
            this.los_invernaderos.Size = new System.Drawing.Size(349, 28);
            this.los_invernaderos.TabIndex = 2;
            this.los_invernaderos.SelectedIndexChanged += new System.EventHandler(this.los_invernaderos_SelectedIndexChanged);
            this.los_invernaderos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.los_invernaderos_KeyPress);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.logOut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.Control;
            this.logOut.Location = new System.Drawing.Point(1205, 14);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(260, 40);
            this.logOut.TabIndex = 1;
            this.logOut.Text = "Cerrar Sesión";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // estadisticaVisual
            // 
            chartArea1.Name = "ChartArea1";
            this.estadisticaVisual.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.estadisticaVisual.Legends.Add(legend1);
            this.estadisticaVisual.Location = new System.Drawing.Point(325, 195);
            this.estadisticaVisual.Name = "estadisticaVisual";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Humedad";
            this.estadisticaVisual.Series.Add(series1);
            this.estadisticaVisual.Series.Add(series2);
            this.estadisticaVisual.Size = new System.Drawing.Size(835, 414);
            this.estadisticaVisual.TabIndex = 0;
            this.estadisticaVisual.Text = "chart1";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 745);
            this.Controls.Add(this.panel1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaVisual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart estadisticaVisual;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.ComboBox los_invernaderos;
        private System.Windows.Forms.Label label1;
    }
}