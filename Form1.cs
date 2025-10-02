using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi4
{
    public partial class FSoanVanBan : Form
    {
        public FSoanVanBan()
        {
            InitializeComponent();
        }
        private string CurrentFilePath = string.Empty;
        private bool isModified = false;
        private bool CheckSave()
        {
            if (isModified)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn lưu lại không?", "Lưu",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    SaveFile();
                    return true;
                }
                else if (r == DialogResult.No)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return true;
        }
        private void SaveFile()
        {
            if (!string.IsNullOrEmpty(CurrentFilePath))
            {
                if (CurrentFilePath.EndsWith(".rtf"))
                {
                    rtbSoanThao.SaveFile(CurrentFilePath);
                }
                else
                {
                    rtbSoanThao.SaveFile(CurrentFilePath, RichTextBoxStreamType.PlainText);
                }
                isModified = false;
            }
            else
            {
                SaveFileAs();
            }
        }
        private void SaveFileAs()
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Rich Text Format|*.rtf|Text Files|*.txt|All Files|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = sfd.FileName;
                if (CurrentFilePath.EndsWith(".rtf"))
                {
                    rtbSoanThao.SaveFile(CurrentFilePath);   
                }
                else
                {
                    rtbSoanThao.SaveFile(CurrentFilePath, RichTextBoxStreamType.PlainText);
                }
                isModified = false;
            }
        }
        private void rtbSoanThao_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
            string[] strings = rtbSoanThao.Text.Split(new char[] { ' ', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);
            tslbDemChu.Text = "Tổng số chữ : " + strings.Length;

        }
        private void FSoanVanBan_Load(object sender, EventArgs e)
        {
            tscbFont.Text = "Tahoma";
            tscbSize.Text = "14";

            foreach (FontFamily font in FontFamily.Families)
            {
                tscbFont.Items.Add(font.Name);
            }
            for (int i = 8; i < 72; i += 2)
            {
                tscbSize.Items.Add(i);
            }

            rtbSoanThao.Font = new Font("Tahoma", 14);
            tslbDemChu.Text = "Tổng số chữ : 0";
        }

        private void FSoanVanBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CheckSave())
            {
                e.Cancel = true;
            }
    
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            if (CheckSave())
            {
                rtbSoanThao.Clear();
                CurrentFilePath = string.Empty;
                rtbSoanThao.Font = new Font("Tahoma", 14);
                tscbFont.Text = "Tahoma";
                tscbSize.Text = "14";
                isModified = false;
            }
        }

        private void menuopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rich Text Format|*.rtf|Text Files|*.txt|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = ofd.FileName;
                if (CurrentFilePath.EndsWith(".rtf"))
                {
                    rtbSoanThao.LoadFile(CurrentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    rtbSoanThao.LoadFile(CurrentFilePath, RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void menuSave_Click_1(object sender, EventArgs e)
        {
            SaveFile();
        }




        private void tscbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (float.TryParse(tscbSize.Text, out float Size))
            {
                if (rtbSoanThao.SelectionFont != null)
                {
                    Font currentFont = rtbSoanThao.SelectionFont;
                    rtbSoanThao.SelectionFont = new Font(currentFont.FontFamily, Size, currentFont.Style);
                }
            }
        }
        private void tscbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = tscbFont.Text;
            if (rtbSoanThao.SelectionFont != null)
            {
                Font currentFont = rtbSoanThao.SelectionFont;
                rtbSoanThao.SelectionFont = new Font(fontName, currentFont.Size, currentFont.Style);
            }
        }

        private void sbtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        
        private void sbtnNewFile_Click(object sender, EventArgs e)
        {
           menuNew_Click(sender, e);
        }

        

        private void menuDinhDang_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                rtbSoanThao.ForeColor = fontDlg.Color;
                rtbSoanThao.Font = fontDlg.Font;
            }
        }
        private void btnBold_Click(object sender, EventArgs e)
        {
            if (rtbSoanThao.SelectionFont != null)
            {
                Font currentFont = rtbSoanThao.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;
                rtbSoanThao.SelectionFont = new Font(currentFont, newStyle);
                btnBold.Checked = rtbSoanThao.SelectionFont.Bold;
            }
        }
        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (rtbSoanThao.SelectionFont != null)
            {
                Font currentFont = rtbSoanThao.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;
                rtbSoanThao.SelectionFont = new Font(currentFont, newStyle);
                btnItalic.Checked = rtbSoanThao.SelectionFont.Italic;
            }
        }
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (rtbSoanThao.SelectionFont != null)
            {
                Font currentFont = rtbSoanThao.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;
                rtbSoanThao.SelectionFont = new Font(currentFont, newStyle);
                btnUnderline.Checked = rtbSoanThao.SelectionFont.Underline;
            }
        }

        private void tsbtnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }
    }
}

