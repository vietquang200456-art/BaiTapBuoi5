namespace BT_Buoi4
{
    partial class FSoanVanBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSoanVanBan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuopen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sbtnNewFile = new System.Windows.Forms.ToolStripButton();
            this.sbtnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.tscbFont = new System.Windows.Forms.ToolStripComboBox();
            this.tscbSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.tslbDemChu = new System.Windows.Forms.ToolStripLabel();
            this.rtbSoanThao = new System.Windows.Forms.RichTextBox();
            this.tsbtnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuDinhDang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuopen,
            this.menuSave,
            this.menuExit});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(88, 24);
            this.menuHeThong.Text = "Hệ Thống";
            // 
            // menuNew
            // 
            this.menuNew.Image = ((System.Drawing.Image)(resources.GetObject("menuNew.Image")));
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(224, 26);
            this.menuNew.Text = "Tạo văn bản mới";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuopen
            // 
            this.menuopen.Image = ((System.Drawing.Image)(resources.GetObject("menuopen.Image")));
            this.menuopen.Name = "menuopen";
            this.menuopen.Size = new System.Drawing.Size(224, 26);
            this.menuopen.Text = "Mở văn bản";
            this.menuopen.Click += new System.EventHandler(this.menuopen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Image = ((System.Drawing.Image)(resources.GetObject("menuSave.Image")));
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(224, 26);
            this.menuSave.Text = "Lưu ";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click_1);
            // 
            // menuExit
            // 
            this.menuExit.Image = ((System.Drawing.Image)(resources.GetObject("menuExit.Image")));
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(224, 26);
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // menuDinhDang
            // 
            this.menuDinhDang.Name = "menuDinhDang";
            this.menuDinhDang.Size = new System.Drawing.Size(94, 24);
            this.menuDinhDang.Text = "Định Dạng";
            this.menuDinhDang.Click += new System.EventHandler(this.menuDinhDang_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbtnNewFile,
            this.sbtnSaveFile,
            this.tsbtnSaveAs,
            this.tscbFont,
            this.tscbSize,
            this.btnBold,
            this.btnItalic,
            this.btnUnderline,
            this.tslbDemChu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sbtnNewFile
            // 
            this.sbtnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbtnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("sbtnNewFile.Image")));
            this.sbtnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnNewFile.Name = "sbtnNewFile";
            this.sbtnNewFile.Size = new System.Drawing.Size(29, 25);
            this.sbtnNewFile.Text = "toolStripButton1";
            this.sbtnNewFile.Click += new System.EventHandler(this.sbtnNewFile_Click);
            // 
            // sbtnSaveFile
            // 
            this.sbtnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbtnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSaveFile.Image")));
            this.sbtnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnSaveFile.Name = "sbtnSaveFile";
            this.sbtnSaveFile.Size = new System.Drawing.Size(29, 25);
            this.sbtnSaveFile.Text = "toolStripButton2";
            this.sbtnSaveFile.Click += new System.EventHandler(this.sbtnSaveFile_Click);
            // 
            // tscbFont
            // 
            this.tscbFont.Name = "tscbFont";
            this.tscbFont.Size = new System.Drawing.Size(121, 28);
            this.tscbFont.SelectedIndexChanged += new System.EventHandler(this.tscbFont_SelectedIndexChanged);
            // 
            // tscbSize
            // 
            this.tscbSize.Name = "tscbSize";
            this.tscbSize.Size = new System.Drawing.Size(121, 28);
            this.tscbSize.SelectedIndexChanged += new System.EventHandler(this.tscbSize_SelectedIndexChanged);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.SystemColors.Control;
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(29, 25);
            this.btnBold.Text = "toolStripButton3";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(29, 25);
            this.btnItalic.Text = "toolStripButton4";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(29, 25);
            this.btnUnderline.Text = "toolStripButton5";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // tslbDemChu
            // 
            this.tslbDemChu.Name = "tslbDemChu";
            this.tslbDemChu.Size = new System.Drawing.Size(0, 25);
            // 
            // rtbSoanThao
            // 
            this.rtbSoanThao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSoanThao.Location = new System.Drawing.Point(0, 61);
            this.rtbSoanThao.Name = "rtbSoanThao";
            this.rtbSoanThao.Size = new System.Drawing.Size(800, 389);
            this.rtbSoanThao.TabIndex = 4;
            this.rtbSoanThao.Text = "";
            this.rtbSoanThao.TextChanged += new System.EventHandler(this.rtbSoanThao_TextChanged);
            // 
            // tsbtnSaveAs
            // 
            this.tsbtnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSaveAs.Image")));
            this.tsbtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSaveAs.Name = "tsbtnSaveAs";
            this.tsbtnSaveAs.Size = new System.Drawing.Size(29, 25);
            this.tsbtnSaveAs.Text = "toolStripButton1";
            this.tsbtnSaveAs.Click += new System.EventHandler(this.tsbtnSaveAs_Click);
            // 
            // FSoanVanBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSoanThao);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FSoanVanBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo văn bản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FSoanVanBan_FormClosing);
            this.Load += new System.EventHandler(this.FSoanVanBan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuopen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuDinhDang;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton sbtnNewFile;
        private System.Windows.Forms.ToolStripButton sbtnSaveFile;
        private System.Windows.Forms.ToolStripComboBox tscbFont;
        private System.Windows.Forms.ToolStripComboBox tscbSize;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.RichTextBox rtbSoanThao;
        private System.Windows.Forms.ToolStripLabel tslbDemChu;
        private System.Windows.Forms.ToolStripButton tsbtnSaveAs;
    }
}

