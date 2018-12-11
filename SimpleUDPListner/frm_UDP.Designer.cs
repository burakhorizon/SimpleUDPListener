namespace SimpleUDPListner
{
    partial class frm_UDP
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
            this.cb_StartStopListening = new System.Windows.Forms.CheckBox();
            this.tlp_UDPListner = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ReadCounter = new System.Windows.Forms.Label();
            this.lbl_LabelReadCount = new System.Windows.Forms.Label();
            this.tlp_UDPListner.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.cb_StartStopListening.CheckedChanged += new System.EventHandler(this.cb_StartStopListening_CheckedChanged);
            // 
            // tlp_UDPListner
            // 
            this.tlp_UDPListner.AutoScroll = true;
            this.tlp_UDPListner.ColumnCount = 2;
            this.tlp_UDPListner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.875F));
            this.tlp_UDPListner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.125F));
            this.tlp_UDPListner.Controls.Add(this.panel1, 0, 0);
            this.tlp_UDPListner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UDPListner.Location = new System.Drawing.Point(0, 0);
            this.tlp_UDPListner.Name = "tlp_UDPListner";
            this.tlp_UDPListner.RowCount = 2;
            this.tlp_UDPListner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_UDPListner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_UDPListner.Size = new System.Drawing.Size(800, 450);
            this.tlp_UDPListner.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.tlp_UDPListner.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lbl_ReadCounter);
            this.panel1.Controls.Add(this.lbl_LabelReadCount);
            this.panel1.Controls.Add(this.cb_StartStopListening);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 30);
            this.panel1.TabIndex = 2;
            // 
            // lbl_ReadCounter
            // 
            this.lbl_ReadCounter.AutoSize = true;
            this.lbl_ReadCounter.Location = new System.Drawing.Point(212, 9);
            this.lbl_ReadCounter.Name = "lbl_ReadCounter";
            this.lbl_ReadCounter.Size = new System.Drawing.Size(0, 13);
            this.lbl_ReadCounter.TabIndex = 3;
            // 
            // lbl_LabelReadCount
            // 
            this.lbl_LabelReadCount.AutoSize = true;
            this.lbl_LabelReadCount.Location = new System.Drawing.Point(111, 9);
            this.lbl_LabelReadCount.Name = "lbl_LabelReadCount";
            this.lbl_LabelReadCount.Size = new System.Drawing.Size(105, 13);
            this.lbl_LabelReadCount.TabIndex = 2;
            this.lbl_LabelReadCount.Text = "DateRead Counter : ";
            // 
            // frm_UDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_UDPListner);
            this.Name = "frm_UDP";
            this.Text = "UDP Listener";
            this.tlp_UDPListner.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cb_StartStopListening;
        private System.Windows.Forms.TableLayoutPanel tlp_UDPListner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ReadCounter;
        private System.Windows.Forms.Label lbl_LabelReadCount;
    }
}

