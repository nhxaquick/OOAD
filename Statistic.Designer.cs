namespace Student_Management
{
    partial class Statistic
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
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnExport = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // chart
            // 
            chart.BackColor = SystemColors.Window;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chart.Legends.Add(legend1);
            chart.Location = new Point(12, 12);
            chart.Name = "chart";
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(683, 649);
            chart.TabIndex = 0;
            chart.Text = "chart";
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.Location = new Point(1139, 620);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(111, 41);
            btnExport.TabIndex = 1;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(1005, 620);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 41);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Statistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnBack);
            Controls.Add(btnExport);
            Controls.Add(chart);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Statistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistic";
            Load += Statistic_Load_1;
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Button btnExport;
        private Button btnBack;
    }
}