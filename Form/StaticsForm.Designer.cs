
namespace QLSV
{
    partial class StaticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.genderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.totalStd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).BeginInit();
            this.SuspendLayout();
            // 
            // genderChart
            // 
            this.genderChart.BackColor = System.Drawing.Color.PaleTurquoise;
            this.genderChart.BorderlineColor = System.Drawing.Color.PowderBlue;
            chartArea6.Name = "ChartArea1";
            this.genderChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.genderChart.Legends.Add(legend6);
            this.genderChart.Location = new System.Drawing.Point(22, 87);
            this.genderChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderChart.Name = "genderChart";
            this.genderChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Gender";
            this.genderChart.Series.Add(series6);
            this.genderChart.Size = new System.Drawing.Size(510, 360);
            this.genderChart.TabIndex = 0;
            this.genderChart.Text = "genderChart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Student: ";
            // 
            // totalStd
            // 
            this.totalStd.AutoSize = true;
            this.totalStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStd.Location = new System.Drawing.Point(185, 40);
            this.totalStd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalStd.Name = "totalStd";
            this.totalStd.Size = new System.Drawing.Size(0, 25);
            this.totalStd.TabIndex = 2;
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(556, 458);
            this.Controls.Add(this.totalStd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderChart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart genderChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalStd;
    }
}