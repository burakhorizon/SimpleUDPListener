using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using SMcMaster;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace SimpleUDPListner
{
    public partial class Frm_UDP : Form
    {
        UDPListener m_udpListener;
        Writer writer;
        string LogFile = @"UDPListener.log";
        AutoControlBody ucontrolBody;
        Telemetry telemetry;
        System.Windows.Forms.Timer DataReceiveResolutionTimer = new System.Windows.Forms.Timer();
        UInt64 dataReadCounter;

        public Frm_UDP()
        {
            InitializeComponent();
            this.FormClosing += Frm_UDP_FormClosing;
            m_udpListener = new UDPListener(23);

            writer = new Writer
            {
                Filepath = LogFile
            };

            DataReceiveResolutionTimer.Interval = 1000;
            DataReceiveResolutionTimer.Tick += DataReceiveResolutionTimer_Tick;

            telemetry = new Telemetry();
            InitControls();
            telemetry.Reset();
        }

        

        private void InitControls()
        {
            ucontrolBody = new AutoControlBody
            {
                Dock = DockStyle.Fill
            };
            ucontrolBody.InitFeaturedTableLayoutPanelForTelemetry(telemetry, Mtx_Validated);
            this.tlp_UDPListner.Controls.Add(ucontrolBody);
            this.tlp_UDPListner.SetCellPosition(ucontrolBody, new TableLayoutPanelCellPosition(0, 1));
            this.tlp_UDPListner.SetColumnSpan(ucontrolBody, 2);

            (new TabOrderManager(ucontrolBody.flp_FlowLayoutPanel)).SetTabOrder(TabOrderManager.TabScheme.AcrossFirst);
            DisableTabStop(this);
            InitializeDataBindings();
        }
        private void DisableTabStop(Control control)
        {
            foreach (Control ctl in control.Controls)
            {
                if (!(ctl.GetType() == typeof(BunifuMaterialTextbox) || ctl.GetType() == typeof(BunifuCheckBox)))
                {
                    ((Control)ctl).TabStop = false;
                    DisableTabStop(ctl);
                }
            }
        }
        private void InitializeDataBindings()
        {
            Dictionary<PropertyInfo, object> instanceProps = telemetry.GetPropertyInfos(telemetry,  null);
            foreach (KeyValuePair<PropertyInfo, object> entry in instanceProps)
            {
                BunifuMaterialTextbox mtx = (BunifuMaterialTextbox)Utils.Utils.GetControlByName(ucontrolBody.flp_FlowLayoutPanel, "mtx_" + ((PropertyInfo)entry.Key).Name);
                mtx.AccessibleDescription = ((PropertyInfo)entry.Key).PropertyType.Name.ToString();
                mtx.AccessibleName = ((PropertyInfo)entry.Key).Name.ToString();
                Binding binding = new Binding(mtx.AccessibleDescription == "bool" ? "Checked" : "Text", entry.Value, mtx.AccessibleName)
                {
                    DataSourceUpdateMode = DataSourceUpdateMode.Never,
                    ControlUpdateMode = ControlUpdateMode.Never
                };
                bool ret = Utils.DataBindingHandlers.Delegator(mtx, binding);
                mtx.DataBindings.Add(binding);
            }
        }
        private void Mtx_Validated(object sender, EventArgs e)
        {
            if (((BunifuMaterialTextbox)sender).DataBindings.Cast<Binding>().Any(binding => binding.PropertyName == "Text"))
            {
                string textBuffer = ((BunifuMaterialTextbox)sender).Text;
                ((BunifuMaterialTextbox)sender).DataBindings["Text"].ReadValue();
                ((BunifuMaterialTextbox)sender).DataBindings["Text"].WriteValue();
                if (textBuffer != ((BunifuMaterialTextbox)sender).Text)
                {
                    ((BunifuMaterialTextbox)sender).ForeColor = Color.FromArgb(229, 126, 49);
                    ((BunifuMaterialTextbox)sender).Font = new Font(((BunifuMaterialTextbox)sender).Font, FontStyle.Bold);
                }
            }
        }
        private void Frm_UDP_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_udpListener.StopListener();
            Application.DoEvents();          // allow processing of outstanding packets 
        }
        private void DataReceiveResolutionTimer_Tick(object sender, EventArgs e)
        {
            DataReceiveResolutionTimer.Stop();

            if (this.InvokeRequired)
            {
                lbl_ReadCounter.ForeColor = Color.Black;
                lbl_ReadCounter.Font = new Font(lbl_ReadCounter.Font, FontStyle.Regular);

                this.Invoke((MethodInvoker)(delegate
                {
                    foreach (BunifuMaterialTextbox ctl in Utils.Utils.GetAllControls(ucontrolBody.flp_FlowLayoutPanel, typeof(BunifuMaterialTextbox)))
                    {
                        ctl.ForeColor = System.Drawing.Color.Black;
                        ctl.Font = new Font(ctl.Font, FontStyle.Regular);
                    }

                    this.ValidateChildren();
                }));
            }
            else
            {
                lbl_ReadCounter.ForeColor = Color.Black;
                lbl_ReadCounter.Font = new Font(lbl_ReadCounter.Font, FontStyle.Regular);

                foreach (BunifuMaterialTextbox ctl in Utils.Utils.GetAllControls(ucontrolBody.flp_FlowLayoutPanel, typeof(BunifuMaterialTextbox)))
                {
                    ctl.ForeColor = System.Drawing.Color.Black;
                    ctl.Font = new Font(ctl.Font, FontStyle.Regular);
                }

                this.ValidateChildren();
            }
        }
        private void M_udpListener_NewMessageReceived(object sender, MyMessageArgs e)
        {
            //StringBuilder myString = new StringBuilder(BitConverter.ToString(e.data));
            //myString.Append("\r\n\r\n");
            //writer.WriteToFile(myString);

            dataReadCounter++;
            telemetry.CopyByteArrayToThis(e.data);

            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(delegate
                {
                    if (!DataReceiveResolutionTimer.Enabled)
                    {
                        lbl_ReadCounter.ForeColor = Color.FromArgb(229, 126, 49);
                        lbl_ReadCounter.Font = new Font(lbl_ReadCounter.Font, FontStyle.Bold);
                        lbl_ReadCounter.Text = dataReadCounter.ToString();
                        lbl_LastDataTime.Text = "Last Data Time : " + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                        DataReceiveResolutionTimer.Start();
                    }
                }));
            }
            else
            {
                if (!DataReceiveResolutionTimer.Enabled)
                {
                    lbl_ReadCounter.ForeColor = Color.FromArgb(229, 126, 49);
                    lbl_ReadCounter.Font = new Font(lbl_ReadCounter.Font, FontStyle.Bold);
                    lbl_ReadCounter.Text = dataReadCounter.ToString();
                    lbl_LastDataTime.Text = "Last Data Time : " + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                    DataReceiveResolutionTimer.Start();
                }
            }
        }
        private void Cb_StartStopListening_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == false)
            {
                ((CheckBox)sender).Text = "Start Listening";
                m_udpListener.StopListener();
            }
            else if (((CheckBox)sender).Checked == true)
            {
                telemetry.Reset();
                //telemetry.GetAllInstancePropertyInfos();
                DataReceiveResolutionTimer.Start();

                dataReadCounter = 0;
                lbl_ReadCounter.Text = dataReadCounter.ToString();
                ((CheckBox)sender).Text = "Stop Listening";

                m_udpListener.StartListener(M_udpListener_NewMessageReceived);
            }
        }

        public class Writer
        {
            public string Filepath { get; set; }
            private static readonly object locker = new Object();

            public void WriteToFile(StringBuilder text)
            {
                lock (locker)
                {
                    using (FileStream file = new FileStream(Filepath, FileMode.Append, FileAccess.Write, FileShare.Read))
                    using (StreamWriter writer = new StreamWriter(file, Encoding.ASCII))
                    {
                        writer.Write(DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss.ff") + " : " + text.ToString());
                    }
                }

            }
        }
    }
}
