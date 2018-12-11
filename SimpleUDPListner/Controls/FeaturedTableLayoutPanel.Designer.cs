namespace SimpleUDPListner
{
    partial class FeaturedTableLayoutPanel
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
            this.tlp_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbl_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tlp_TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_TableLayoutPanel
            // 
            this.tlp_TableLayoutPanel.AccessibleName = "Monetary Values";
            this.tlp_TableLayoutPanel.AllowDrop = true;
            this.tlp_TableLayoutPanel.AutoSize = true;
            this.tlp_TableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_TableLayoutPanel.BackColor = System.Drawing.Color.DimGray;
            this.tlp_TableLayoutPanel.CausesValidation = false;
            this.tlp_TableLayoutPanel.ColumnCount = 2;
            this.tlp_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TableLayoutPanel.Controls.Add(this.bunifuSeparator1, 0, 1);
            this.tlp_TableLayoutPanel.Controls.Add(this.lbl_Title, 0, 0);
            this.tlp_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tlp_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(30, 32, 30, 16);
            this.tlp_TableLayoutPanel.Name = "tlp_TableLayoutPanel";
            this.tlp_TableLayoutPanel.RowCount = 3;
            this.tlp_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_TableLayoutPanel.Size = new System.Drawing.Size(60, 32);
            this.tlp_TableLayoutPanel.TabIndex = 65;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.tlp_TableLayoutPanel.SetColumnSpan(this.bunifuSeparator1, 2);
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 28);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(52, 1);
            this.bunifuSeparator1.TabIndex = 72;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.tlp_TableLayoutPanel.SetColumnSpan(this.lbl_Title, 2);
            this.lbl_Title.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lbl_Title.ForeColor = System.Drawing.Color.Black;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(60, 24);
            this.lbl_Title.TabIndex = 62;
            this.lbl_Title.Text = "Title";
            // 
            // FeaturedTableLayoutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlp_TableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.Name = "FeaturedTableLayoutPanel";
            this.Size = new System.Drawing.Size(60, 32);
            this.tlp_TableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.TableLayoutPanel tlp_TableLayoutPanel;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_Title;
    }
}
