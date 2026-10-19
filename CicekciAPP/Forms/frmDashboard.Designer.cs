using System.ComponentModel;

namespace CicekciAPP.Forms
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartSatisTrendi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartKritikStok = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartEnCokSatanlar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartKategoriDagilimi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartSatisTrendi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartKritikStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartEnCokSatanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartKategoriDagilimi).BeginInit();
            SuspendLayout();
            // 
            // chartSatisTrendi
            // 
            chartArea5.Name = "ChartArea1";
            chartSatisTrendi.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chartSatisTrendi.Legends.Add(legend5);
            chartSatisTrendi.Location = new Point(12, 41);
            chartSatisTrendi.Name = "chartSatisTrendi";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chartSatisTrendi.Series.Add(series5);
            chartSatisTrendi.Size = new Size(380, 200);
            chartSatisTrendi.TabIndex = 0;
            chartSatisTrendi.Text = "chart1";
            // 
            // chartKritikStok
            // 
            chartArea6.Name = "ChartArea1";
            chartKritikStok.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chartKritikStok.Legends.Add(legend6);
            chartKritikStok.Location = new Point(12, 247);
            chartKritikStok.Name = "chartKritikStok";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chartKritikStok.Series.Add(series6);
            chartKritikStok.Size = new Size(380, 200);
            chartKritikStok.TabIndex = 1;
            chartKritikStok.Text = "chart2";
            // 
            // chartEnCokSatanlar
            // 
            chartArea7.Name = "ChartArea1";
            chartEnCokSatanlar.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            chartEnCokSatanlar.Legends.Add(legend7);
            chartEnCokSatanlar.Location = new Point(398, 247);
            chartEnCokSatanlar.Name = "chartEnCokSatanlar";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            chartEnCokSatanlar.Series.Add(series7);
            chartEnCokSatanlar.Size = new Size(380, 200);
            chartEnCokSatanlar.TabIndex = 2;
            chartEnCokSatanlar.Text = "chart3";
            // 
            // chartKategoriDagilimi
            // 
            chartArea8.Name = "ChartArea1";
            chartKategoriDagilimi.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            chartKategoriDagilimi.Legends.Add(legend8);
            chartKategoriDagilimi.Location = new Point(398, 41);
            chartKategoriDagilimi.Name = "chartKategoriDagilimi";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            chartKategoriDagilimi.Series.Add(series8);
            chartKategoriDagilimi.Size = new Size(380, 200);
            chartKategoriDagilimi.TabIndex = 3;
            chartKategoriDagilimi.Text = "chart4";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 510);
            Controls.Add(chartKategoriDagilimi);
            Controls.Add(chartEnCokSatanlar);
            Controls.Add(chartKritikStok);
            Controls.Add(chartSatisTrendi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            Text = "frmDashboard";
            Load += frmDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)chartSatisTrendi).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartKritikStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartEnCokSatanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartKategoriDagilimi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSatisTrendi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKritikStok;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEnCokSatanlar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKategoriDagilimi;

    }
}