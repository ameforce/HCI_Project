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
        private int edit_label_num = 8;
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
                    string[] temp_data = route.Split('\\');
                    f.ChangeLabel(EditLabel, f.StringSummary(temp_data[temp_data.Length - 1], edit_label_num) + "가 저장되었습니다.");
                    f.change_Title(f.check_Content(route, TextEdit.Text), route);
                }
            }
        }

        //붙여넣기
        private void BtnPaste_Click(object sender, EventArgs e) 
        {
            TextEdit.Paste();
            f.ChangeLabel(EditLabel, f.StringSummary(Clipboard.GetText(), edit_label_num) + "가 붙여 넣어졌습니다.");
        }

        //복사하기
        private void BtnCopy_Click(object sender, EventArgs e)
        {
            TextEdit.Copy();
            string temp_data = Clipboard.GetText();
            temp_data = f.StringSummary(temp_data, edit_label_num) + "가 복사되었습니다.";
            f.ChangeLabel(EditLabel, temp_data);
        }

        //오려두기
        private void BtnCut_Click(object sender, EventArgs e) {
            TextEdit.Cut();
            string temp_data = Clipboard.GetText();
            temp_data = f.StringSummary(temp_data, edit_label_num) + "가 오려졌습니다.";
            f.ChangeLabel(EditLabel, temp_data);
        }

        //TextEdit의 Text가 선택될 때
        private void TextEdit_SelectionChanged(object sender, EventArgs e)
        {
            if (TextEdit.SelectedText == "")
            {
                BtnCopy.Enabled = false;
                BtnCut.Enabled = false;
            }
            else
            {
                BtnCopy.Enabled = true;
                BtnCut.Enabled = true;
            }
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
        private void BtnUndo_Click(object sender, EventArgs e) { TextEdit.Undo(); }

        //다시 실행
        private void BtnRerun_Click(object sender, EventArgs e) { TextEdit.Redo(); }

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
            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily,TextEdit.SelectionFont.Size + 1,
                TextEdit.SelectionFont.Bold ? FontStyle.Bold : FontStyle.Regular);
        }
        
        //굵게
        private void BtnBold_Click(object sender, EventArgs e)
        {
            {
                TextEdit.SelectionFont = new Font(TextEdit.Font, TextEdit.SelectionFont.Style ^ FontStyle.Bold);
            }
        }

        //기울임
        private void BtnItalic_Click(object sender, EventArgs e)
        {
            {
                TextEdit.SelectionFont = new Font(TextEdit.Font,TextEdit.SelectionFont.Style ^ FontStyle.Italic);
            }
        }

        //밑줄
        private void BtnUnder_Click(object sender, EventArgs e)
        {
            {
                TextEdit.SelectionFont = new Font(TextEdit.Font,TextEdit.SelectionFont.Style ^ FontStyle.Underline);
            }
        }

        //취소선
        private void BtnStrikethrough_Click(object sender, EventArgs e)
        {
            {
                TextEdit.SelectionFont = new Font(TextEdit.Font,TextEdit.SelectionFont.Style ^ FontStyle.Strikeout);
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
            if (status == "Find")   //찾기
            {
                int count = f.Find_Text(Search, TextEdit);
                SearchStatus.Text = count + "개 찾음";
            }
            else if (status == "FindAndChange") //바꾸기
            {
                int count = f.Find_Text(Search, TextEdit);
                SearchStatus.Text = count + "개 찾음";
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

        //TextEdit Hotkey Setting
        private void TextEdit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //잘라내기 HOTKEY
            if (e.Control && e.KeyCode == Keys.T){ TextEdit.Cut(); }
            if (e.Control && e.KeyCode == Keys.Z) { TextEdit.Undo(); }
        }
        //콤보박스 글자크기
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             TextEdit.Font = new Font(TextEdit.Font.FontFamily, Convert.ToInt32(comboBox1.SelectedItem), TextEdit.Font.Style);

            
        }

        private void 시간날짜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEdit.SelectedText = DateTime.Now.ToString();
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TextEdit.WordWrap = !(this.TextEdit.WordWrap);
            this.자동줄바꿈ToolStripMenuItem.Checked = !(this.자동줄바꿈ToolStripMenuItem.Checked);
           
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}