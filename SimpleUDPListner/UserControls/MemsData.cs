using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUDPListner
{
    public partial class MemsData : UserControl
    {
        Timer MEMsDataChartUpdateTimer;
        public MemsData()
        {
            InitializeComponent();

            ch_MEMsDataChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            ch_MEMsDataChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            ch_MEMsDataChart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            ch_MEMsDataChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            ch_MEMsDataChart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            ch_MEMsDataChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;

            MEMsDataChartUpdateTimer = new Timer();
            MEMsDataChartUpdateTimer.Interval = 100;
            MEMsDataChartUpdateTimer.Tick += MEMsDataChartUpdateTimer_Tick;

            this.acceTableAdapter.Fill(this.telemetryDataSet.Acce);

            //MEMsDataChartUpdateTimer.Start();
        }

        private void MEMsDataChartUpdateTimer_Tick(object sender, EventArgs e)
        {
            //DataRow dr = this.telemetryDataSet.Tables["Acce"].NewRow();
            //dr["Ax"] = j++;
            //dr["Ay"] = i;
            //dr["Az"] = 5;
            //this.telemetryDataSet.Tables[0].Rows.Add(dr);
            //this.telemetryDataSet.Tables[0].AcceptChanges();
            //this.acceTableAdapter.Adapter.Update(this.telemetryDataSet, "Acce");

            //dgv_AcceData.FirstDisplayedScrollingRowIndex = dgv_AcceData.RowCount - 1;

            //ch_MEMsDataChart.Series["Acce"].XValueMember = "Ax";
            //ch_MEMsDataChart.Series["Acce"].YValueMembers = "Ay";
            //ch_MEMsDataChart.DataSource = this.telemetryDataSet.Acce;
            //ch_MEMsDataChart.DataBind();
        }               
        public void InsertRecord(Telemetry.Modules.MEMs.Acce acce)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(delegate
                {
                    AddAcceData(acce);
                }));
            }
            else
            {
                AddAcceData(acce);
            }           
        }
        int xAxisCounter = 0;
        private void AddAcceData(Telemetry.Modules.MEMs.Acce acce)
        {
            //this.acceBindingSource.EndEdit();
            //this.acceTableAdapter.Adapter.Update(this.telemetryDataSet.Acce);

            DataRow dr = this.telemetryDataSet.Tables["Acce"].NewRow();
            dr["Id"] = xAxisCounter.ToString();
            xAxisCounter++;
            dr["Ax"] = acce.Ax.ToString();
            dr["Ay"] = acce.Ay.ToString();
            dr["Az"] = acce.Az.ToString();
            this.telemetryDataSet.Tables[0].Rows.Add(dr);
            this.telemetryDataSet.Tables[0].AcceptChanges();
            this.acceTableAdapter.Adapter.Update(this.telemetryDataSet, "Acce");

            dgv_AcceData.FirstDisplayedScrollingRowIndex = dgv_AcceData.RowCount - 1;

            ch_MEMsDataChart.Series["Ax"].XValueMember = "Id";
            ch_MEMsDataChart.Series["Ax"].YValueMembers = "Ax";
            ch_MEMsDataChart.Series["Ay"].XValueMember = "Id";
            ch_MEMsDataChart.Series["Ay"].YValueMembers = "Ay";
            ch_MEMsDataChart.Series["Az"].XValueMember = "Id";
            ch_MEMsDataChart.Series["Az"].YValueMembers = "Az";
            ch_MEMsDataChart.DataSource = this.telemetryDataSet.Acce;
            ch_MEMsDataChart.DataBind();
        }
        public void Clear()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(delegate
                {
                    ClearSeries();
                }));
            }
            else
            {
                ClearSeries();
            }
        }
        private void ClearSeries()
        {
            ch_MEMsDataChart.Series.Clear();
        }
    }
}
