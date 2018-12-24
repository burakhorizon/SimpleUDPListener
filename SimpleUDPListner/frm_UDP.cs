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
        Utils.FileWriter writer;
        string LogFile = @"UDPListener.log";
        Timer DataReceiveResolutionTimer = new Timer();
        UInt64 dataReadCounter, checksumErrorCounter;
        AllData allData;
        MemsData MEMsData;
        Telemetry telemetry;

        public Frm_UDP()
        {
            InitializeComponent();
            this.FormClosing += Frm_UDP_FormClosing;
            m_udpListener = new UDPListener(23);

            writer = new Utils.FileWriter
            {
                Filepath = LogFile
            };

            DataReceiveResolutionTimer.Interval = 1000;
            DataReceiveResolutionTimer.Tick += DataReceiveResolutionTimer_Tick;
            
            InitControls();
            DataReceiveResolutionTimer.Start();
        }

        private void InitControls()
        {
            allData = new AllData()
            {
                Dock = DockStyle.Fill,
                Visible = false
            };
            this.tlp_UDPListner.Controls.Add(allData);
            this.tlp_UDPListner.SetCellPosition(allData, new TableLayoutPanelCellPosition(0, 1));
            this.tlp_UDPListner.SetColumnSpan(allData, 2);
            allData.Visible = true;
            allData.BringToFront();

            MEMsData = new MemsData()
            {
                Dock = DockStyle.Fill,
                Visible = false
            };
            this.tlp_UDPListner.Controls.Add(MEMsData);
            this.tlp_UDPListner.SetCellPosition(MEMsData, new TableLayoutPanelCellPosition(0, 1));
            this.tlp_UDPListner.SetColumnSpan(MEMsData, 2);
            allData.BringToFront();
        }
        private void Frm_UDP_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_udpListener.StopListener();
            Application.DoEvents();          // allow processing of outstanding packets 
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
                //telemetry.Reset();
                //telemetry.GetAllInstancePropertyInfos();
                DataReceiveResolutionTimer.Start();

                dataReadCounter = 0;
                checksumErrorCounter = 0;
                lbl_ReadCounter.Text = dataReadCounter.ToString();
                lbl_ChecksumErrorCounter.Text = "Checksum Error Count : " + checksumErrorCounter.ToString();
                lbl_LastDataTime.Text = "Last Data Time : ";
                ((CheckBox)sender).Text = "Stop Listening";

                m_udpListener.StartListener(M_udpListener_NewMessageReceived);
            }
        }
        private void DataReceiveResolutionTimer_Tick(object sender, EventArgs e)
        {
            DataReceiveResolutionTimer.Stop();
            DataReceiveResolutionTimer.Enabled = false;



            if (this.InvokeRequired)
            {
                lbl_ReadCounter.ForeColor = Color.Black;
                lbl_ReadCounter.Font = new Font(lbl_ReadCounter.Font, FontStyle.Regular);

                //    this.Invoke((MethodInvoker)(delegate
                //    {
                //        foreach (BunifuMaterialTextbox ctl in Utils.Utils.GetAllControls(ucontrolBody.flp_FlowLayoutPanel, typeof(BunifuMaterialTextbox)))
                //        {
                //            ctl.ForeColor = System.Drawing.Color.Black;
                //            ctl.Font = new Font(ctl.Font, FontStyle.Regular);
                //        }

                //        this.ValidateChildren();
                //    }));
                //}
                //else
                //{
                //    lbl_ReadCounter.ForeColor = Color.Black;
                //    lbl_ReadCounter.Font = new Font(lbl_ReadCounter.Font, FontStyle.Regular);

                //    foreach (BunifuMaterialTextbox ctl in Utils.Utils.GetAllControls(ucontrolBody.flp_FlowLayoutPanel, typeof(BunifuMaterialTextbox)))
                //    {
                //        ctl.ForeColor = System.Drawing.Color.Black;
                //        ctl.Font = new Font(ctl.Font, FontStyle.Regular);
                //    }

                //    this.ValidateChildren();
            }
        }
        private void M_udpListener_NewMessageReceived(object sender, MyMessageArgs e)
        {
            //StringBuilder myString = new StringBuilder(BitConverter.ToString(e.data));
            //myString.Append("\r\n\r\n");
            //writer.WriteToFile(myString);

            dataReadCounter++;
            UInt16 headerSize = 2;
            UInt16 checksumLen = 4;
            UInt16 messageLen = BitConverter.ToUInt16(e.data, 2);
            if (e.data.Length >= messageLen + checksumLen)
            {
                byte[] message = e.data.Skip(headerSize).Take(messageLen).ToArray();
                byte[] chk = message.Skip(messageLen - checksumLen).Take(checksumLen).ToArray();
                UInt32 checksum = BitConverter.ToUInt32(chk, 0);

                if (Utils.Utils.Adler32(message, (UInt16)(messageLen - checksumLen)) == checksum)
                {
                    //telemetry.CopyByteArrayToThis(e.data.Skip(24).Take(BitConverter.ToUInt16(e.data, 22)).ToArray());
                    HighLigtLabel(lbl_ReadCounter, dataReadCounter.ToString());
                    telemetry = allData.Update(e.data.Skip(24).Take(BitConverter.ToUInt16(e.data, 22)).ToArray());
                    MEMsData.InsertRecord(telemetry.modules.mems.acce);
                }
                else
                {
                    checksumErrorCounter++;
                    //HighLigtLabel(lbl_ChecksumErrorCounter, "Checksum Error Count : " + checksumErrorCounter.ToString());
                }
            }
        }

        private void bbtn_AllData_Click(object sender, EventArgs e)
        {
            ShowUSerControl(allData);
        }
        private void ShowUSerControl(UserControl uc)
        {
            foreach(UserControl u in this.tlp_UDPListner.Controls.OfType<UserControl>())
            {
                u.Visible = false;
            }
            uc.Visible = true;
            uc.BringToFront();
        }
        private void bbtn_MEMsData_Click(object sender, EventArgs e)
        {
            ShowUSerControl(MEMsData);
        }
        private void HighLigtLabel(Label lbl, string v)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(delegate
                {
                    if (!DataReceiveResolutionTimer.Enabled)
                    {
                        lbl.ForeColor = Color.FromArgb(229, 126, 49);
                        lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                        lbl.Text = v;
                        lbl_LastDataTime.Text = "Last Data Time : " + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                        DataReceiveResolutionTimer.Enabled = true;
                        DataReceiveResolutionTimer.Start();
                    }
                }));
            }
            else
            {
                if (!DataReceiveResolutionTimer.Enabled)
                {
                    lbl.ForeColor = Color.FromArgb(229, 126, 49);
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                    lbl.Text = v;
                    lbl_LastDataTime.Text = "Last Data Time : " + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                    DataReceiveResolutionTimer.Enabled = true;
                    DataReceiveResolutionTimer.Start();
                }
            }
        }
    }
}
