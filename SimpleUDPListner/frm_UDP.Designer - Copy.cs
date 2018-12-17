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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ReadCounter = new System.Windows.Forms.Label();
            this.lbl_LastDataTime = new System.Windows.Forms.Label();
            this.lbl_LabelReadCount = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tlp_UDPListner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_StartStopListening
            // 
            this.cb_StartStopListening.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_StartStopListening.AutoSize = true;
            this.cb_StartStopListening.Location = new System.Drawing.Point(4, 5);
            this.cb_StartStopListening.Margin = new System.Windows.Forms.Padding(4);
            this.cb_StartStopListening.Name = "cb_StartStopListening";
            this.cb_StartStopListening.Size = new System.Drawing.Size(109, 27);
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
            this.tlp_UDPListner.Margin = new System.Windows.Forms.Padding(4);
            this.tlp_UDPListner.Name = "tlp_UDPListner";
            this.tlp_UDPListner.RowCount = 2;
            this.tlp_UDPListner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp_UDPListner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_UDPListner.Size = new System.Drawing.Size(1067, 554);
            this.tlp_UDPListner.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.tlp_UDPListner.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_ReadCounter);
            this.panel1.Controls.Add(this.lbl_LastDataTime);
            this.panel1.Controls.Add(this.lbl_LabelReadCount);
            this.panel1.Controls.Add(this.cb_StartStopListening);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 36);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(694, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(594, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ReadCounter
            // 
            this.lbl_ReadCounter.AutoSize = true;
            this.lbl_ReadCounter.Location = new System.Drawing.Point(283, 11);
            this.lbl_ReadCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ReadCounter.Name = "lbl_ReadCounter";
            this.lbl_ReadCounter.Size = new System.Drawing.Size(0, 17);
            this.lbl_ReadCounter.TabIndex = 3;
            // 
            // lbl_LastDataTime
            // 
            this.lbl_LastDataTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_LastDataTime.AutoSize = true;
            this.lbl_LastDataTime.Location = new System.Drawing.Point(776, 11);
            this.lbl_LastDataTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LastDataTime.Name = "lbl_LastDataTime";
            this.lbl_LastDataTime.Size = new System.Drawing.Size(116, 17);
            this.lbl_LastDataTime.TabIndex = 3;
            this.lbl_LastDataTime.Text = "Last Data Time : ";
            // 
            // lbl_LabelReadCount
            // 
            this.lbl_LabelReadCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_LabelReadCount.AutoSize = true;
            this.lbl_LabelReadCount.Location = new System.Drawing.Point(148, 11);
            this.lbl_LabelReadCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LabelReadCount.Name = "lbl_LabelReadCount";
            this.lbl_LabelReadCount.Size = new System.Drawing.Size(138, 17);
            this.lbl_LabelReadCount.TabIndex = 2;
            this.lbl_LabelReadCount.Text = "DateRead Counter : ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(900, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frm_UDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tlp_UDPListner);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lbl_LastDataTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}

