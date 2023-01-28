namespace Reportes
{
    partial class Repo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.estadistica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.estadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // estadistica
            // 
            chartArea1.Name = "ChartArea1";
            this.estadistica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.estadistica.Legends.Add(legend1);
            this.estadistica.Location = new System.Drawing.Point(223, 128);
            this.estadistica.Name = "estadistica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Humedad";
            this.estadistica.Series.Add(series1);
            this.estadistica.Series.Add(series2);
            this.estadistica.Size = new System.Drawing.Size(636, 404);
            this.estadistica.TabIndex = 0;
            this.estadistica.Text = "chart1";
            // 
            // Repo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 681);
            this.Controls.Add(this.estadistica);
            this.Name = "Repo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.estadistica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart estadistica;
    }
}

