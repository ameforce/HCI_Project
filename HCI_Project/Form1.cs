#pragma warning disable IDE0044 // 읽기 전용 한정자 추가
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace HCI_Project
{
    public partial class Form1 : Form
    {
        private Function f = new Function();
        private string route = null;
        private string status = null;
        public Form1()
        {
            InitializeComponent();
        }


        private RichTextBox doc;
        public class EnterKeyEventArgs : EventArgs
        {
            private bool _cancel = false;

            public bool Cancel
            {
                get { return _cancel; }
                set { _cancel = value; }
            }

        }
        
        //#######################Button Function############################
        //파일저장
        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "텍스트파일|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Function f = new Function();
                if (f.save_File(TextEdit.Text, saveFileDialog.FileName))
                {
                    route = saveFileDialog.FileName;
                    f.change_Title(f.check_Content(route, TextEdit.Text), route);
                }
            }
        }

        //붙여넣기
        private void BtnPaste_Click(object sender, EventArgs e)
        {
            f.Paste_Text(TextEdit);
        }

        //오려두기
        private void BtnCut_Click(object sender, EventArgs e)
        {
            if (status == null) { } //쓰레기.
            TextEdit.Cut();
        }

        //복사하기
        private void BtnCopy_Click(object sender, EventArgs e)
        {
            TextEdit.Copy();
        }

        //새 파일 버튼 클릭
        private void BtnNewFile_Click(object sender, EventArgs e)
        {
            string temp_data = ActiveForm.Text;
            if (temp_data.Contains("(저장 안 됨)"))
            {
                if (MessageBox.Show("이전 파일이 저장되지 않았습니다.\n새 파일을 계속 만드시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            route = null;
            TextEdit.Text = "";
            f.change_Title(false, route);
        }

        //불러오기
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "텍스트파일|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                route = openFileDialog.FileName;
                TextEdit.Text = f.open_File(openFileDialog.FileName);
                f.change_Title(true, route);
            }
        }

        //실행취소
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            TextEdit.Undo();
        }

        //다시 실행
        private void BtnRerun_Click(object sender, EventArgs e)
        {
            TextEdit.Redo();
        }

        //폰트
        private void BtnFont_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.fdFont.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TextEdit.Font = fdFont.Font;
            }
        }
        //형광펜
        private bool ShowColorDialog(ref Color color)
        {
            bool selected;
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.SolidColorOnly = true;
                dlg.AllowFullOpen = false;
                dlg.AnyColor = false;
                dlg.FullOpen = false;
                dlg.CustomColors = null;
                dlg.Color = color;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    selected = true;
                    color = dlg.Color;
                }
                else
                {
                    selected = false;
                }
            }
            return selected;
        }
        public void SelectBackColor()
        {
            Color color = TextEdit.SelectionBackColor;
            if (ShowColorDialog(ref color))
                TextEdit.SelectionBackColor = color;
        }

        //글자 축소
        private void BtnReduction_Click(object sender, EventArgs e)
        {
            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, TextEdit.SelectionFont.Size - 1,
                TextEdit.SelectionFont.Bold ? FontStyle.Bold : FontStyle.Regular);
        }

        //글자 확대
        private void BtnEnlargement_Click(object sender, EventArgs e)
        {
            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, TextEdit.SelectionFont.Size + 1,
                TextEdit.SelectionFont.Bold ? FontStyle.Bold : FontStyle.Regular);
        }

        //굵게
        private void BtnBold_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectionFont.Bold)
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, FontStyle.Regular);
            }
            else
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, FontStyle.Bold);
            }
        }

        //기울임
        private void BtnItalic_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectionFont.Italic)
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, FontStyle.Regular);
            }
            else
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, FontStyle.Italic);
            }
        }

        //밑줄
        private void BtnUnder_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectionFont.Underline)
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, FontStyle.Regular);
            }
            else
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, FontStyle.Underline);
            }
        }

        //취소선
        private void BtnStrikethrough_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectionFont.Strikeout)
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, FontStyle.Regular);
            }
            else
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, FontStyle.Strikeout);
            }
        }

        //폰트색상
        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (fdcolor.ShowDialog() != DialogResult.Cancel)
            {
                TextEdit.ForeColor = fdcolor.Color;  
            }
        }

        //찾기
        private void BtnFind_Click(object sender, EventArgs e)
        {
            status = "Find";
            Search.ReadOnly = false;
            Search.Focus();
            Search.SelectAll();
        }

        //바꾸기
        private void BtnFindAndChange_Click(object sender, EventArgs e)
        {
            status = "FindAndChange";
            Search.ReadOnly = false;
            Search.Focus();
            Search.SelectAll();
        }
        //################################################################

        //
        private void 컨트롤CToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //서식기능 메뉴바
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //TextEdit 내용 변경 시 타이틀 내용 변경.
        private void TextEdit_TextChanged(object sender, EventArgs e)
        {
            string temp_data = ActiveForm.Text;
            if (temp_data.Contains("(저장됨)") || temp_data == "TEXT EDITOR")
                f.change_Title(false, route);
        }

        //Search 내용 변경 시 status에 따라 찾기 및 바꾸기 수행.
        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (status == "Find")
            {
                int count = f.Find_Text(Search, TextEdit);
                SearchStatus.Text = count + "개 찾음";
            }
            else if (status == "FindAndChange")
            {

            }
        }

        //도움말-정보
        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제작: 김종인, 이단일, 김민주", " Text Editor 정보");
        }


        //텍스트 오른쪽 정렬
        private void button15_Click(object sender, EventArgs e)
        {
            TextEdit.Select();
            TextEdit.SelectionAlignment = HorizontalAlignment.Right;
        }

        //텍스트 왼쪽 정렬
        private void button18_Click(object sender, EventArgs e)
        {
            TextEdit.Select();
            TextEdit.SelectionAlignment = HorizontalAlignment.Left;
        }

        //텍스트 가운데 정렬
        private void button17_Click(object sender, EventArgs e)
        {
            TextEdit.Select();
            TextEdit.SelectionAlignment = HorizontalAlignment.Center;
        }
        //형광펜
        private void button1_Click(object sender, EventArgs e)
        {
            SelectBackColor();
        }
        //글머리 표
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            TextEdit.SelectionBullet = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string temp_data = "데이터: " + e.KeyChar;
            //MessageBox.Show(temp_data);
            /*

            else if (e.Control && e.KeyCode == Keys.C)
            {
                ((RichTextBox)sender).Copy();
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                //((RichTextBox)sender).Paste();
                BtnPaste_Click(sender, e);
                MessageBox.Show("check");
                //TextEdit.Paste();
            }
            */
        }

        //TextEdit Hotkey Setting
        private void TextEdit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //잘라내기 HOTKEY
            if (e.Control && e.KeyCode == Keys.X){ TextEdit.Cut(); }
        }

    }
}