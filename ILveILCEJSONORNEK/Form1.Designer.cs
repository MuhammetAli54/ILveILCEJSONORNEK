
namespace ILveILCEJSONORNEK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iLCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iLSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iLCESorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iLToolStripMenuItem,
            this.iLCEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iLToolStripMenuItem
            // 
            this.iLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iLSorgulamaToolStripMenuItem});
            this.iLToolStripMenuItem.Name = "iLToolStripMenuItem";
            this.iLToolStripMenuItem.Size = new System.Drawing.Size(34, 24);
            this.iLToolStripMenuItem.Text = "IL";
            // 
            // iLCEToolStripMenuItem
            // 
            this.iLCEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iLCESorgulamaToolStripMenuItem});
            this.iLCEToolStripMenuItem.Name = "iLCEToolStripMenuItem";
            this.iLCEToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.iLCEToolStripMenuItem.Text = "ILCE";
            // 
            // iLSorgulamaToolStripMenuItem
            // 
            this.iLSorgulamaToolStripMenuItem.Name = "iLSorgulamaToolStripMenuItem";
            this.iLSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iLSorgulamaToolStripMenuItem.Text = "ILSorgulama";
            this.iLSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.iLSorgulamaToolStripMenuItem_Click);
            // 
            // iLCESorgulamaToolStripMenuItem
            // 
            this.iLCESorgulamaToolStripMenuItem.Name = "iLCESorgulamaToolStripMenuItem";
            this.iLCESorgulamaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iLCESorgulamaToolStripMenuItem.Text = "ILCE Sorgulama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 606);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iLSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iLCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iLCESorgulamaToolStripMenuItem;
    }
}

