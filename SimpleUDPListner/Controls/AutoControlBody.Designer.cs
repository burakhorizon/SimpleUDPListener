namespace SimpleUDPListner
{
    partial class AutoControlBody
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
            this.flp_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_FlowLayoutPanel
            // 
            this.flp_FlowLayoutPanel.AutoSize = true;
            this.flp_FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flp_FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flp_FlowLayoutPanel.Name = "flp_FlowLayoutPanel";
            this.flp_FlowLayoutPanel.Size = new System.Drawing.Size(387, 540);
            this.flp_FlowLayoutPanel.TabIndex = 0;
            // 
            // AutoControlBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flp_FlowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AutoControlBody";
            this.Size = new System.Drawing.Size(387, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flp_FlowLayoutPanel;
    }
}
