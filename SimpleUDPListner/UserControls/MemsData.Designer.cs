namespace SimpleUDPListner
{
    partial class MemsData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ch_MEMsDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_AcceData = new System.Windows.Forms.DataGridView();
            this.axDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.azDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telemetryDataSet = new SimpleUDPListner.Data.TelemetryDataSet();
            this.acceTableAdapter = new SimpleUDPListner.Data.TelemetryDataSetTableAdapters.AcceTableAdapter();
            this.tlp_MEMsData = new System.Windows.Forms.TableLayoutPanel();
            this.acceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ch_MEMsDataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AcceData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telemetryDataSet)).BeginInit();
            this.tlp_MEMsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_MEMsDataChart
            // 
            this.ch_MEMsDataChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.BorderColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "cha_MEMs";
            chartArea1.ShadowOffset = 15;
            this.ch_MEMsDataChart.ChartAreas.Add(chartArea1);
            this.ch_MEMsDataChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.DockedToChartArea = "cha_MEMs";
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 15F;
            legend1.Position.Width = 7.683073F;
            legend1.Position.X = 88F;
            legend1.Position.Y = 7F;
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.ch_MEMsDataChart.Legends.Add(legend1);
            this.ch_MEMsDataChart.Location = new System.Drawing.Point(0, 230);
            this.ch_MEMsDataChart.Margin = new System.Windows.Forms.Padding(0, 30, 30, 30);
            this.ch_MEMsDataChart.Name = "ch_MEMsDataChart";
            series1.ChartArea = "cha_MEMs";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Ax";
            series2.ChartArea = "cha_MEMs";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Ay";
            series3.ChartArea = "cha_MEMs";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Az";
            this.ch_MEMsDataChart.Series.Add(series1);
            this.ch_MEMsDataChart.Series.Add(series2);
            this.ch_MEMsDataChart.Series.Add(series3);
            this.ch_MEMsDataChart.Size = new System.Drawing.Size(804, 334);
            this.ch_MEMsDataChart.TabIndex = 0;
            this.ch_MEMsDataChart.Text = "chart1";
            // 
            // dgv_AcceData
            // 
            this.dgv_AcceData.AutoGenerateColumns = false;
            this.dgv_AcceData.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_AcceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AcceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.axDataGridViewTextBoxColumn,
            this.ayDataGridViewTextBoxColumn,
            this.azDataGridViewTextBoxColumn});
            this.dgv_AcceData.DataSource = this.acceBindingSource;
            this.dgv_AcceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AcceData.Location = new System.Drawing.Point(76, 3);
            this.dgv_AcceData.Margin = new System.Windows.Forms.Padding(76, 3, 60, 3);
            this.dgv_AcceData.Name = "dgv_AcceData";
            this.dgv_AcceData.Size = new System.Drawing.Size(698, 194);
            this.dgv_AcceData.TabIndex = 1;
            // 
            // axDataGridViewTextBoxColumn
            // 
            this.axDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.axDataGridViewTextBoxColumn.DataPropertyName = "Ax";
            this.axDataGridViewTextBoxColumn.HeaderText = "Ax";
            this.axDataGridViewTextBoxColumn.Name = "axDataGridViewTextBoxColumn";
            // 
            // ayDataGridViewTextBoxColumn
            // 
            this.ayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ayDataGridViewTextBoxColumn.DataPropertyName = "Ay";
            this.ayDataGridViewTextBoxColumn.HeaderText = "Ay";
            this.ayDataGridViewTextBoxColumn.Name = "ayDataGridViewTextBoxColumn";
            // 
            // azDataGridViewTextBoxColumn
            // 
            this.azDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.azDataGridViewTextBoxColumn.DataPropertyName = "Az";
            this.azDataGridViewTextBoxColumn.HeaderText = "Az";
            this.azDataGridViewTextBoxColumn.Name = "azDataGridViewTextBoxColumn";
            // 
            // acceBindingSource
            // 
            this.acceBindingSource.DataMember = "Acce";
            this.acceBindingSource.DataSource = this.telemetryDataSet;
            // 
            // telemetryDataSet
            // 
            this.telemetryDataSet.DataSetName = "TelemetryDataSet";
            this.telemetryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acceTableAdapter
            // 
            this.acceTableAdapter.ClearBeforeFill = true;
            // 
            // tlp_MEMsData
            // 
            this.tlp_MEMsData.ColumnCount = 1;
            this.tlp_MEMsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_MEMsData.Controls.Add(this.dgv_AcceData, 0, 0);
            this.tlp_MEMsData.Controls.Add(this.ch_MEMsDataChart, 0, 1);
            this.tlp_MEMsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_MEMsData.Location = new System.Drawing.Point(0, 0);
            this.tlp_MEMsData.Name = "tlp_MEMsData";
            this.tlp_MEMsData.RowCount = 2;
            this.tlp_MEMsData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_MEMsData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_MEMsData.Size = new System.Drawing.Size(834, 540);
            this.tlp_MEMsData.TabIndex = 3;
            // 
            // acceBindingSource1
            // 
            this.acceBindingSource1.DataMember = "Acce";
            this.acceBindingSource1.DataSource = this.telemetryDataSet;
            // 
            // MemsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_MEMsData);
            this.Name = "MemsData";
            this.Size = new System.Drawing.Size(834, 540);
            ((System.ComponentModel.ISupportInitialize)(this.ch_MEMsDataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AcceData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telemetryDataSet)).EndInit();
            this.tlp_MEMsData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acceBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_MEMsDataChart;
        private System.Windows.Forms.DataGridView dgv_AcceData;
        private System.Windows.Forms.BindingSource acceBindingSource;
        private Data.TelemetryDataSet telemetryDataSet;
        private Data.TelemetryDataSetTableAdapters.AcceTableAdapter acceTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tlp_MEMsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn axDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn azDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource acceBindingSource1;
    }
}
