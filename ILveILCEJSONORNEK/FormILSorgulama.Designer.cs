
namespace ILveILCEJSONORNEK
{
    partial class FormILSorgulama
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxILSecimi = new System.Windows.Forms.ComboBox();
            this.btnsec = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxIL = new System.Windows.Forms.GroupBox();
            this.richTextBoxIL = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxIL.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İL ADI : ";
            // 
            // comboBoxILSecimi
            // 
            this.comboBoxILSecimi.FormattingEnabled = true;
            this.comboBoxILSecimi.Location = new System.Drawing.Point(114, 72);
            this.comboBoxILSecimi.Name = "comboBoxILSecimi";
            this.comboBoxILSecimi.Size = new System.Drawing.Size(434, 28);
            this.comboBoxILSecimi.TabIndex = 2;
            // 
            // btnsec
            // 
            this.btnsec.Location = new System.Drawing.Point(571, 72);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(83, 29);
            this.btnsec.TabIndex = 3;
            this.btnsec.Text = "SEÇ";
            this.btnsec.UseVisualStyleBackColor = true;
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 171);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(849, 446);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefon";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fax";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "EPosta";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "WebSitesi";
            this.columnHeader5.Width = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "İl Hakkında Bilgiler";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBoxIL
            // 
            this.groupBoxIL.Controls.Add(this.richTextBoxIL);
            this.groupBoxIL.Controls.Add(this.label2);
            this.groupBoxIL.Location = new System.Drawing.Point(902, 171);
            this.groupBoxIL.Name = "groupBoxIL";
            this.groupBoxIL.Size = new System.Drawing.Size(382, 446);
            this.groupBoxIL.TabIndex = 7;
            this.groupBoxIL.TabStop = false;
            this.groupBoxIL.Text = "groupBox1";
            // 
            // richTextBoxIL
            // 
            this.richTextBoxIL.Location = new System.Drawing.Point(15, 64);
            this.richTextBoxIL.Name = "richTextBoxIL";
            this.richTextBoxIL.ReadOnly = true;
            this.richTextBoxIL.Size = new System.Drawing.Size(361, 376);
            this.richTextBoxIL.TabIndex = 6;
            this.richTextBoxIL.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayGosterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 28);
            // 
            // detayGosterToolStripMenuItem
            // 
            this.detayGosterToolStripMenuItem.Name = "detayGosterToolStripMenuItem";
            this.detayGosterToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.detayGosterToolStripMenuItem.Text = "Detay Göster";
            this.detayGosterToolStripMenuItem.Click += new System.EventHandler(this.detayGosterToolStripMenuItem_Click);
            // 
            // FormILSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 652);
            this.Controls.Add(this.groupBoxIL);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.comboBoxILSecimi);
            this.Controls.Add(this.label1);
            this.Name = "FormILSorgulama";
            this.Text = "FormILSorgulama";
            this.Load += new System.EventHandler(this.FormILSorgulama_Load);
            this.groupBoxIL.ResumeLayout(false);
            this.groupBoxIL.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxILSecimi;
        private System.Windows.Forms.Button btnsec;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxIL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayGosterToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxIL;
    }
}