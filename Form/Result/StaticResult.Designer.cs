
namespace QLSV
{
    partial class StaticResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExcellentLabel = new System.Windows.Forms.Label();
            this.GoodLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.FailLabel = new System.Windows.Forms.Label();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("hooge 05_53", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Static By Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("hooge 05_53", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Static By Result";
            // 
            // ExcellentLabel
            // 
            this.ExcellentLabel.AutoSize = true;
            this.ExcellentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcellentLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ExcellentLabel.Location = new System.Drawing.Point(450, 80);
            this.ExcellentLabel.Name = "ExcellentLabel";
            this.ExcellentLabel.Size = new System.Drawing.Size(109, 24);
            this.ExcellentLabel.TabIndex = 7;
            this.ExcellentLabel.Text = "Excellent: ";
            // 
            // GoodLabel
            // 
            this.GoodLabel.AutoSize = true;
            this.GoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodLabel.ForeColor = System.Drawing.Color.Yellow;
            this.GoodLabel.Location = new System.Drawing.Point(450, 130);
            this.GoodLabel.Name = "GoodLabel";
            this.GoodLabel.Size = new System.Drawing.Size(73, 24);
            this.GoodLabel.TabIndex = 8;
            this.GoodLabel.Text = "Good: ";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageLabel.ForeColor = System.Drawing.Color.Yellow;
            this.AverageLabel.Location = new System.Drawing.Point(450, 180);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(100, 24);
            this.AverageLabel.TabIndex = 9;
            this.AverageLabel.Text = "Average: ";
            // 
            // FailLabel
            // 
            this.FailLabel.AutoSize = true;
            this.FailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailLabel.ForeColor = System.Drawing.Color.Yellow;
            this.FailLabel.Location = new System.Drawing.Point(450, 230);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(56, 24);
            this.FailLabel.TabIndex = 10;
            this.FailLabel.Text = "Fail: ";
            // 
            // ResultChart
            // 
            this.ResultChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea2.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ResultChart.Legends.Add(legend2);
            this.ResultChart.Location = new System.Drawing.Point(370, 272);
            this.ResultChart.Name = "ResultChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Result";
            this.ResultChart.Series.Add(series2);
            this.ResultChart.Size = new System.Drawing.Size(320, 280);
            this.ResultChart.TabIndex = 11;
            // 
            // StaticResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(712, 562);
            this.Controls.Add(this.ResultChart);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.GoodLabel);
            this.Controls.Add(this.ExcellentLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "StaticResult";
            this.Text = "StaticResult";
            this.Load += new System.EventHandler(this.StaticResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label ExcellentLabel;
        public System.Windows.Forms.Label GoodLabel;
        public System.Windows.Forms.Label AverageLabel;
        public System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultChart;
    }
}