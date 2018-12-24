using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMcMaster;
using System.Reflection;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;

namespace SimpleUDPListner
{
    public partial class AllData : UserControl
    {
        AutoControlBody ucontrolBody;
        Telemetry telemetry;

        public AllData()
        {
            InitializeComponent();
            telemetry = new Telemetry();
            InitControls();

            telemetry.Reset();
            this.ValidateChildren();
        }

        private void InitControls()
        {
            ucontrolBody = new AutoControlBody
            {
                Dock = DockStyle.Fill
            };
            ucontrolBody.InitFeaturedTableLayoutPanelForTelemetry(telemetry, Mtx_Validated);
            this.Controls.Add(ucontrolBody);

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
            Dictionary<PropertyInfo, object> instanceProps = telemetry.GetPropertyInfos(telemetry, null);
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
                else
                {
                    ((BunifuMaterialTextbox)sender).ForeColor = Color.Black;
                    ((BunifuMaterialTextbox)sender).Font = new Font(((BunifuMaterialTextbox)sender).Font, FontStyle.Regular);
                }
            }
        }
        public Telemetry Update(byte[] telemetryBytes)
        {
            telemetry.CopyByteArrayToThis(telemetryBytes);
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(delegate
                {
                    this.ValidateChildren();
                }));
            }
            else
            {
                this.ValidateChildren();
            }

            return telemetry;
        }
    }
}
