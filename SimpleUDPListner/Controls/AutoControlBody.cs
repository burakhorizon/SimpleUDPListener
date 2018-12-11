using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SimpleUDPListner
{
    public partial class AutoControlBody : UserControl
    {
        FeaturedTableLayoutPanel featuredTableLayoutPanel;
        
        public AutoControlBody()
        {
            InitializeComponent();
        }

        public void InitFeaturedTableLayoutPanelForTelemetry(Telemetry telemetry, EventHandler validatedEventHandler)
        {
            //Dictionary<PropertyInfo, bool> pis = Utils.Utils.GetAllNestedProps(typeof(Telemetry));
            //Dictionary<PropertyInfo, object> pis = Utils.Utils.GetPropertInfos(telemetry, null);

            List<Type> types = Utils.Utils.GetAllNestedTypes(typeof(Telemetry));

            foreach (Type t in types)
            {
                if (t.IsNested && Utils.Utils.GetPropertInfos(t, null).Keys.Count == 0)
                {
                    FeaturedFlowLayoutPanel fFlp = new FeaturedFlowLayoutPanel();
                    fFlp.lbl_Title.Text = t.Name;
                    fFlp.Name = "fFlp_" + t.Name;
                    if (t.ReflectedType == typeof(Telemetry))
                    {
                        flp_FlowLayoutPanel.Controls.Add(fFlp);
                    }
                    else
                    {
                        FeaturedFlowLayoutPanel parentFflp = (FeaturedFlowLayoutPanel)Utils.Utils.GetControlByName(flp_FlowLayoutPanel, "fFlp_" + t.ReflectedType.Name);
                        parentFflp.flp_Fflp.Controls.Add(fFlp);
                    }
                }
                else if (t.IsNested && Utils.Utils.GetPropertInfos(t, null).Keys.Count != 0)
                {
                    FeaturedTableLayoutPanel fTlp = new FeaturedTableLayoutPanel();
                    fTlp.lbl_Title.Text = t.Name;
                    fTlp.Name = "fTlp_" + t.Name;
                    if (t.ReflectedType == typeof(Telemetry))
                    {
                        flp_FlowLayoutPanel.Controls.Add(fTlp);
                    }
                    else
                    {
                        FeaturedFlowLayoutPanel parentFflp = (FeaturedFlowLayoutPanel)Utils.Utils.GetControlByName(flp_FlowLayoutPanel, "fFlp_" + t.ReflectedType.Name);
                        parentFflp.flp_Fflp.Controls.Add(fTlp);
                    }
                }
            }

            foreach (Type t in types)
            {
                foreach (PropertyInfo pi in Utils.Utils.GetPropertInfos(t, null).Keys)
                {
                    ModelTypeDef mtd = new ModelTypeDef(pi);
                    Label label = CreateLabel(pi.Name);
                    Control dedicatedControl = CreateDedicatedControl(mtd, null, validatedEventHandler);
                    FeaturedTableLayoutPanel parentFtp = (FeaturedTableLayoutPanel)Utils.Utils.GetControlByName(flp_FlowLayoutPanel, "fTlp_" + pi.ReflectedType.Name);
                    AddRow(parentFtp, label, dedicatedControl);
                    AddTableRow(parentFtp, 10F);
                }
            }
        }

        private Control CreateDedicatedControl(ModelTypeDef mtd, KeyEventHandler keyUpEventHandler, EventHandler validatedEventHandler)
        {
            Control control = null;

            if (mtd.dataType == "Int32" || mtd.dataType == "UInt64" || mtd.dataType == "UInt16" ||
                mtd.dataType == "Int16" || mtd.dataType == "Int64" || mtd.dataType == "Single" ||
                mtd.dataType == "UInt32" || mtd.dataType == "Byte" || mtd.dataType == "Char" || mtd.dataType == "String")
            {
                control = new BunifuMaterialTextbox();
                ((BunifuMaterialTextbox)control).Name = "mtx_" + mtd.propertyName;
                ((BunifuMaterialTextbox)control).HintText = "0";
                //((BunifuMaterialTextbox)control).MaxLength = mtd.maxLength;
                //((BunifuMaterialTextbox)control).MaximumSize = new System.Drawing.Size(mtd.maxLength * 8, 37);
                ((BunifuMaterialTextbox)control).MinimumSize = new System.Drawing.Size(mtd.maxLength * 8, 20);
                ((BunifuMaterialTextbox)control).Size = new System.Drawing.Size(20, 20);
                ((BunifuMaterialTextbox)control).Dock = DockStyle.Fill;
            }
            else if (mtd.dataType == "string")
            {
                control = new BunifuMaterialTextbox();
                ((BunifuMaterialTextbox)control).Name = "mtx_" + mtd.propertyName;
                ((BunifuMaterialTextbox)control).HintText = "";
                //((BunifuMaterialTextbox)control).MaxLength = mtd.maxLength;
                //((BunifuMaterialTextbox)control).MaximumSize = new System.Drawing.Size(mtd.maxLength * 8, 37);
                //((BunifuMaterialTextbox)control).MinimumSize = new System.Drawing.Size(mtd.maxLength * 8, 37);
                //((BunifuMaterialTextbox)control).Size = new System.Drawing.Size(mtd.maxLength * 8, 37);
                ((BunifuMaterialTextbox)control).Dock = DockStyle.Fill;
            }
            else if (mtd.dataType == "telephoneString")
            {
                control = new BunifuMaterialTextbox();
                ((BunifuMaterialTextbox)control).Name = "mtx_" + mtd.propertyName;
                ((BunifuMaterialTextbox)control).HintText = "00 XX XXX XX XX";
                //((BunifuMaterialTextbox)control).MaxLength = mtd.maxLength;
                //((BunifuMaterialTextbox)control).MaximumSize = new System.Drawing.Size(mtd.maxLength * 8, 37);
                //((BunifuMaterialTextbox)control).MinimumSize = new System.Drawing.Size(mtd.maxLength * 8, 37);
                //((BunifuMaterialTextbox)control).Size = new System.Drawing.Size(mtd.maxLength * 8, 37);
                ((BunifuMaterialTextbox)control).Dock = DockStyle.Fill;
            }
            else if (mtd.dataType == "eMailString")
            {
                control = new BunifuMaterialTextbox();
                ((BunifuMaterialTextbox)control).Name = "mtx_" + mtd.propertyName;
                ((BunifuMaterialTextbox)control).HintText = "name@example.com";
                //((BunifuMaterialTextbox)control).MaxLength = mtd.maxLength;
                //((BunifuMaterialTextbox)control).MaximumSize = new System.Drawing.Size(mtd.maxLength * 8, 37);
                //((BunifuMaterialTextbox)control).MinimumSize = new System.Drawing.Size(mtd.maxLength * 8, 37);
                //((BunifuMaterialTextbox)control).Size = new System.Drawing.Size(mtd.maxLength * 8, 37);
                ((BunifuMaterialTextbox)control).Dock = DockStyle.Fill;
            }
            else if (mtd.dataType == "doubleCurrency")
            {
                control = new BunifuMaterialTextbox();
                ((BunifuMaterialTextbox)control).Name = "mtx_" + mtd.propertyName;
                ((BunifuMaterialTextbox)control).HintText = "€ 000.0000";
                //((BunifuMaterialTextbox)control).MaxLength = mtd.maxLength;
                //((BunifuMaterialTextbox)control).MaximumSize = new System.Drawing.Size(mtd.maxLength * 8, 37);
                //((BunifuMaterialTextbox)control).MinimumSize = new System.Drawing.Size(mtd.maxLength * 8, 37);
                //((BunifuMaterialTextbox)control).Size = new System.Drawing.Size(mtd.maxLength * 8, 37);
                ((BunifuMaterialTextbox)control).Dock = DockStyle.Fill;
            }

            control.AccessibleName = mtd.propertyName;
            control.AccessibleDescription = mtd.dataType;

            if (control.GetType() == typeof(BunifuMaterialTextbox))
            {
                //((BunifuMaterialTextbox)control).Anchor = AnchorStyles.Left;
                ((BunifuMaterialTextbox)control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
                ((BunifuMaterialTextbox)control).AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
                //((BunifuMaterialTextbox)control).AutoSize = true;
                ((BunifuMaterialTextbox)control).AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
                ((BunifuMaterialTextbox)control).characterCasing = System.Windows.Forms.CharacterCasing.Normal;
                ((BunifuMaterialTextbox)control).Cursor = System.Windows.Forms.Cursors.IBeam;
                ((BunifuMaterialTextbox)control).Font = new System.Drawing.Font("Century Gothic", 9F);
                ((BunifuMaterialTextbox)control).ForeColor = System.Drawing.Color.Black;
                ((BunifuMaterialTextbox)control).HintForeColor = System.Drawing.Color.DarkGray;
                ((BunifuMaterialTextbox)control).isPassword = false;
                ((BunifuMaterialTextbox)control).LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(165)))), ((int)(((byte)(44)))));
                ((BunifuMaterialTextbox)control).LineIdleColor = System.Drawing.Color.Black;
                ((BunifuMaterialTextbox)control).LineMouseHoverColor = System.Drawing.Color.Teal;
                ((BunifuMaterialTextbox)control).LineThickness = 1;
                ((BunifuMaterialTextbox)control).Location = new System.Drawing.Point(208, 80);
                ((BunifuMaterialTextbox)control).Margin = new System.Windows.Forms.Padding(0);
                ((BunifuMaterialTextbox)control).TabIndex = 2;
                ((BunifuMaterialTextbox)control).TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                ((BunifuMaterialTextbox)control).KeyUp += keyUpEventHandler;
                ((BunifuMaterialTextbox)control).Validated += validatedEventHandler;
            }

            if (control.GetType() == typeof(BunifuDropdown))
            {
                //((BunifuDropdown)control).BackColor = System.Drawing.Color.DimGray;
                ((BunifuDropdown)control).BorderRadius = 0;
                ((BunifuDropdown)control).DisabledColor = System.Drawing.Color.Gray;
                ((BunifuDropdown)control).Font = new System.Drawing.Font("Century Gothic", 11F);
                ((BunifuDropdown)control).ForeColor = System.Drawing.Color.Black;
                ((BunifuDropdown)control).BackColor = System.Drawing.Color.Transparent;
                ((BunifuDropdown)control).NomalColor = Color.Transparent;
                ((BunifuDropdown)control).onHoverColor = Color.Transparent;
                ((BunifuDropdown)control).Margin = new System.Windows.Forms.Padding(0);
                //((BunifuDropdown)control).Sorted = true;
                ((BunifuDropdown)control).TabIndex = 27;
                ((BunifuDropdown)control).Text = null;
            }

            return control;
        }
        private BunifuCustomLabel CreateLabel(string propertyName)
        {
            BunifuCustomLabel lbl = new BunifuCustomLabel();
            lbl.Name = "lbl_" + propertyName;
            lbl.Text = propertyName.Replace("_", " ");

            lbl.AutoSize = true;
            lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            lbl.Font = new System.Drawing.Font("Century Gothic", 9F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            lbl.Location = new System.Drawing.Point(0, 57);
            lbl.Margin = new System.Windows.Forms.Padding(0);
            lbl.Size = new System.Drawing.Size(208, 20);
            lbl.TabIndex = 0;
            lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

            return lbl;
        }
        private void AddRow(FeaturedTableLayoutPanel ftlp, Control label, Control value)
        {
            int rowIndex = AddTableRow(ftlp, 20F);
            ftlp.tlp_TableLayoutPanel.Controls.Add(label, 0, rowIndex);
            if (value != null)
            {
                ftlp.tlp_TableLayoutPanel.Controls.Add(value, 1, rowIndex);
            }
        }
        private int AddTableRow(FeaturedTableLayoutPanel ftlp, float height)
        {
            int index = ftlp.tlp_TableLayoutPanel.RowCount++;
            RowStyle rowStyle = new RowStyle(SizeType.Absolute, height);
            ftlp.tlp_TableLayoutPanel.RowStyles.Add(rowStyle);
            ftlp.tlp_TableLayoutPanel.Height += (int)height;
            return index;
        }
    }
}
