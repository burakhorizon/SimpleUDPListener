namespace SimpleUDPListner
{
    partial class Frm_UDP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UDP));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.cb_StartStopListening = new System.Windows.Forms.CheckBox();
            this.tlp_UDPListner = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ChecksumErrorCounter = new System.Windows.Forms.Label();
            this.lbl_ReadCounter = new System.Windows.Forms.Label();
            this.lbl_LastDataTime = new System.Windows.Forms.Label();
            this.lbl_LabelReadCount = new System.Windows.Forms.Label();
            this.tlp_MenuButtons = new System.Windows.Forms.TableLayoutPanel();
            this.bbtn_AllData = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bbtn_MEMsData = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tlp_UDPListner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlp_MenuButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_StartStopListening
            // 
            this.cb_StartStopListening.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_StartStopListening.AutoSize = true;
            this.cb_StartStopListening.Location = new System.Drawing.Point(3, 4);
            this.cb_StartStopListening.Name = "cb_StartStopListening";
            this.cb_StartStopListening.Size = new System.Drawing.Size(84, 23);
            this.cb_StartStopListening.TabIndex = 1;
            this.cb_StartStopListening.Text = "Start Listening";
            this.cb_StartStopListening.UseVisualStyleBackColor = true;
            this.cb_StartStopListening.CheckedChanged += new System.EventHandler(this.Cb_StartStopListening_CheckedChanged);
            // 
            // tlp_UDPListner
            // 
            this.tlp_UDPListner.AutoScroll = true;
            this.tlp_UDPListner.ColumnCount = 2;
            this.tlp_UDPListner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.875F));
            this.tlp_UDPListner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.125F));
            this.tlp_UDPListner.Controls.Add(this.panel1, 0, 0);
            this.tlp_UDPListner.Controls.Add(this.tlp_MenuButtons, 0, 1);
            this.tlp_UDPListner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UDPListner.Location = new System.Drawing.Point(0, 0);
            this.tlp_UDPListner.Name = "tlp_UDPListner";
            this.tlp_UDPListner.RowCount = 3;
            this.tlp_UDPListner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_UDPListner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_UDPListner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_UDPListner.Size = new System.Drawing.Size(800, 450);
            this.tlp_UDPListner.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.tlp_UDPListner.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lbl_ChecksumErrorCounter);
            this.panel1.Controls.Add(this.lbl_ReadCounter);
            this.panel1.Controls.Add(this.lbl_LastDataTime);
            this.panel1.Controls.Add(this.lbl_LabelReadCount);
            this.panel1.Controls.Add(this.cb_StartStopListening);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 30);
            this.panel1.TabIndex = 2;
            // 
            // lbl_ChecksumErrorCounter
            // 
            this.lbl_ChecksumErrorCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ChecksumErrorCounter.AutoSize = true;
            this.lbl_ChecksumErrorCounter.Location = new System.Drawing.Point(304, 9);
            this.lbl_ChecksumErrorCounter.Name = "lbl_ChecksumErrorCounter";
            this.lbl_ChecksumErrorCounter.Size = new System.Drawing.Size(122, 13);
            this.lbl_ChecksumErrorCounter.TabIndex = 4;
            this.lbl_ChecksumErrorCounter.Text = "Checksum Error Count : ";
            // 
            // lbl_ReadCounter
            // 
            this.lbl_ReadCounter.AutoSize = true;
            this.lbl_ReadCounter.Location = new System.Drawing.Point(212, 9);
            this.lbl_ReadCounter.Name = "lbl_ReadCounter";
            this.lbl_ReadCounter.Size = new System.Drawing.Size(0, 13);
            this.lbl_ReadCounter.TabIndex = 3;
            // 
            // lbl_LastDataTime
            // 
            this.lbl_LastDataTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_LastDataTime.AutoSize = true;
            this.lbl_LastDataTime.Location = new System.Drawing.Point(582, 9);
            this.lbl_LastDataTime.Name = "lbl_LastDataTime";
            this.lbl_LastDataTime.Size = new System.Drawing.Size(88, 13);
            this.lbl_LastDataTime.TabIndex = 3;
            this.lbl_LastDataTime.Text = "Last Data Time : ";
            // 
            // lbl_LabelReadCount
            // 
            this.lbl_LabelReadCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_LabelReadCount.AutoSize = true;
            this.lbl_LabelReadCount.Location = new System.Drawing.Point(111, 9);
            this.lbl_LabelReadCount.Name = "lbl_LabelReadCount";
            this.lbl_LabelReadCount.Size = new System.Drawing.Size(105, 13);
            this.lbl_LabelReadCount.TabIndex = 2;
            this.lbl_LabelReadCount.Text = "DateRead Counter : ";
            // 
            // tlp_MenuButtons
            // 
            this.tlp_MenuButtons.ColumnCount = 6;
            this.tlp_UDPListner.SetColumnSpan(this.tlp_MenuButtons, 2);
            this.tlp_MenuButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_MenuButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_MenuButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_MenuButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_MenuButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_MenuButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_MenuButtons.Controls.Add(this.bbtn_AllData, 0, 0);
            this.tlp_MenuButtons.Controls.Add(this.bbtn_MEMsData, 1, 0);
            this.tlp_MenuButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_MenuButtons.Location = new System.Drawing.Point(3, 39);
            this.tlp_MenuButtons.Name = "tlp_MenuButtons";
            this.tlp_MenuButtons.RowCount = 1;
            this.tlp_MenuButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_MenuButtons.Size = new System.Drawing.Size(794, 30);
            this.tlp_MenuButtons.TabIndex = 3;
            // 
            // bbtn_AllData
            // 
            this.bbtn_AllData.BackColor = System.Drawing.Color.Transparent;
            this.bbtn_AllData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bbtn_AllData.BackgroundImage")));
            this.bbtn_AllData.ButtonText = "All Data";
            this.bbtn_AllData.ButtonTextMarginLeft = 0;
            this.bbtn_AllData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bbtn_AllData.DisabledFillColor = System.Drawing.Color.Gray;
            this.bbtn_AllData.DisabledForecolor = System.Drawing.Color.White;
            this.bbtn_AllData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbtn_AllData.ForeColor = System.Drawing.Color.White;
            this.bbtn_AllData.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bbtn_AllData.IconPadding = 10;
            this.bbtn_AllData.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bbtn_AllData.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bbtn_AllData.IdleBorderRadius = 1;
            this.bbtn_AllData.IdleBorderThickness = 0;
            this.bbtn_AllData.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bbtn_AllData.IdleIconLeftImage = null;
            this.bbtn_AllData.IdleIconRightImage = null;
            this.bbtn_AllData.Location = new System.Drawing.Point(3, 3);
            this.bbtn_AllData.Name = "bbtn_AllData";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bbtn_AllData.onHoverState = stateProperties1;
            this.bbtn_AllData.Size = new System.Drawing.Size(126, 27);
            this.bbtn_AllData.TabIndex = 1;
            this.bbtn_AllData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bbtn_AllData.Click += new System.EventHandler(this.bbtn_AllData_Click);
            // 
            // bbtn_MEMsData
            // 
            this.bbtn_MEMsData.BackColor = System.Drawing.Color.Transparent;
            this.bbtn_MEMsData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bbtn_MEMsData.BackgroundImage")));
            this.bbtn_MEMsData.ButtonText = "MEMs Data";
            this.bbtn_MEMsData.ButtonTextMarginLeft = 0;
            this.bbtn_MEMsData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bbtn_MEMsData.DisabledFillColor = System.Drawing.Color.Gray;
            this.bbtn_MEMsData.DisabledForecolor = System.Drawing.Color.White;
            this.bbtn_MEMsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbtn_MEMsData.ForeColor = System.Drawing.Color.White;
            this.bbtn_MEMsData.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bbtn_MEMsData.IconPadding = 10;
            this.bbtn_MEMsData.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bbtn_MEMsData.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bbtn_MEMsData.IdleBorderRadius = 1;
            this.bbtn_MEMsData.IdleBorderThickness = 0;
            this.bbtn_MEMsData.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bbtn_MEMsData.IdleIconLeftImage = null;
            this.bbtn_MEMsData.IdleIconRightImage = null;
            this.bbtn_MEMsData.Location = new System.Drawing.Point(135, 3);
            this.bbtn_MEMsData.Name = "bbtn_MEMsData";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bbtn_MEMsData.onHoverState = stateProperties2;
            this.bbtn_MEMsData.Size = new System.Drawing.Size(126, 27);
            this.bbtn_MEMsData.TabIndex = 2;
            this.bbtn_MEMsData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bbtn_MEMsData.Click += new System.EventHandler(this.bbtn_MEMsData_Click);
            // 
            // Frm_UDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_UDPListner);
            this.Name = "Frm_UDP";
            this.Text = "UDP Listener";
            this.tlp_UDPListner.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlp_MenuButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cb_StartStopListening;
        private System.Windows.Forms.TableLayoutPanel tlp_UDPListner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ReadCounter;
        private System.Windows.Forms.Label lbl_LabelReadCount;
        private System.Windows.Forms.Label lbl_LastDataTime;
        private System.Windows.Forms.Label lbl_ChecksumErrorCounter;
        private System.Windows.Forms.TableLayoutPanel tlp_MenuButtons;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bbtn_AllData;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bbtn_MEMsData;
    }
}

