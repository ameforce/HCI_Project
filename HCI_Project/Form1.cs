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
using System.Text.RegularExpressions;

namespace HCI_Project
{
    public partial class Form1 : Form
    {
        private Function f = new Function();
        private string route = null;
        private string status = null;
        private int edit_label_num = 8;
        private int font_label_num = 4;
        private int default_font_size;
        public Form1()
        {
            InitializeComponent();
            default_font_size = (int)TextEdit.SelectionFont.Size;
        }

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
        //$$$$$$$$$$$$$$편집 영역$$$$$$$$$$$$$$$
        //파일저장
        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "텍스트파일|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Function f = new Function();
                if (f.SaveFile(TextEdit, TextEdit.Text, saveFileDialog.FileName))
                {
                    route = saveFileDialog.FileName;
                    string[] temp_data = route.Split('\\');
                    f.ChangeLabel(EditLabel, f.StringSummary(temp_data[temp_data.Length - 1], edit_label_num) + "가 저장되었습니다.");
                    //f.ChangeTitle(f.CheckContent(route, TextEdit.Text), route);
                    f.ChangeTitle(true, route);
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

        //잘라내기
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
            temp_data = "새 파일이 생성되었습니다.";
            f.ChangeLabel(EditLabel, temp_data);
            f.ChangeTitle(false, route);
        }

        //불러오기
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "텍스트파일|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                route = openFileDialog.FileName;
                //TextEdit.Text = f.OpenFile(openFileDialog.FileName);
                f.OpenFile(TextEdit, route);
                string[] temp_data = route.Split('\\');
                f.ChangeLabel(EditLabel, f.StringSummary(temp_data[temp_data.Length - 1], edit_label_num) + " 파일을 불러왔습니다.");
                f.ChangeTitle(true, route);
            }
        }

        //실행취소
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            TextEdit.Undo();
            f.ChangeLabel(EditLabel, "실행 취소되었습니다.");
        }

        //다시 실행
        private void BtnRerun_Click(object sender, EventArgs e) {
            TextEdit.Redo();
            f.ChangeLabel(EditLabel, "다시 실행되었습니다.");
        }

        //$$$$$$$$$$$$$$글꼴 영역$$$$$$$$$$$$$$$
        //폰트
        private void BtnFont_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.fdFont.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TextEdit.Font = fdFont.Font;
                BtnFont.Text = fdFont.Font.Name;
                f.ChangeLabel(FontLabel, f.StringSummary(fdFont.Font.Name, font_label_num) + " 글꼴 적용 완료");
            }
        }

        //글자 축소
        private void BtnReduction_Click(object sender, EventArgs e)
        {
            default_font_size--;
            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, default_font_size, TextEdit.SelectionFont.Bold ? FontStyle.Bold : FontStyle.Regular);
            FontSize.Text = TextEdit.SelectionFont.Size.ToString();
            f.ChangeLabel(FontLabel, "현재 글자 크기: " + default_font_size);
            
        }

        //글자 확대
        private void BtnEnlargement_Click(object sender, EventArgs e)
        {
            default_font_size++;
            TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, default_font_size,TextEdit.SelectionFont.Bold ? FontStyle.Bold : FontStyle.Regular);
            FontSize.Text = TextEdit.SelectionFont.Size.ToString();
            f.ChangeLabel(FontLabel, "현재 글자 크기: " + default_font_size);
        }

        //FontSize 조절
        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            default_font_size = Convert.ToInt32(FontSize.SelectedItem);
            TextEdit.Font = new Font(TextEdit.Font.FontFamily, default_font_size, TextEdit.Font.Style);
            f.ChangeLabel(FontLabel, "현재 글자 크기: " + default_font_size);
        }

        //굵게
        private void BtnBold_Click(object sender, EventArgs e)
        {
            TextEdit.SelectionFont = new Font(TextEdit.Font, TextEdit.SelectionFont.Style ^ FontStyle.Bold);
            if (TextEdit.SelectionFont.Bold) { f.ChangeLabel(FontLabel, "글자 굵게 적용 완료"); }
            else { f.ChangeLabel(FontLabel, "글자 굵게 적용 해제"); }
        }

        //기울임
        private void BtnItalic_Click(object sender, EventArgs e)
        {
            TextEdit.SelectionFont = new Font(TextEdit.Font,TextEdit.SelectionFont.Style ^ FontStyle.Italic);
            if (TextEdit.SelectionFont.Italic) { f.ChangeLabel(FontLabel, "글자 기울임 적용 완료"); }
            else { f.ChangeLabel(FontLabel, "글자 기울임 적용 해제"); }
        }

        //밑줄
        private void BtnUnder_Click(object sender, EventArgs e)
        {
            TextEdit.SelectionFont = new Font(TextEdit.Font,TextEdit.SelectionFont.Style ^ FontStyle.Underline);
            if (TextEdit.SelectionFont.Underline) { f.ChangeLabel(FontLabel, "글자 밑줄 적용 완료"); }
            else { f.ChangeLabel(FontLabel, "글자 밑줄적용 해제"); }
        }

        //취소선
        private void BtnStrikethrough_Click(object sender, EventArgs e)
        {
            TextEdit.SelectionFont = new Font(TextEdit.Font,TextEdit.SelectionFont.Style ^ FontStyle.Strikeout);
            if (TextEdit.SelectionFont.Strikeout) { f.ChangeLabel(FontLabel, "글자 취소선 적용 완료"); }
            else { f.ChangeLabel(FontLabel, "글자 취소선 적용 해제"); }
        }

        //폰트색상
        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (fdcolor.ShowDialog() != DialogResult.Cancel)
            {
                TextEdit.ForeColor = fdcolor.Color;
                f.ChangeLabel(FontLabel, "글자 색 적용 완료");
            }
        }

        //형광펜
        private void BtnHighlight_Click(object sender, EventArgs e)
        {
            f.SelectBackColor(TextEdit, this);
            f.ChangeLabel(FontLabel, "형광펜 적용 완료");
        }


        //$$$$$$$$$$$$$$단락 영역$$$$$$$$$$$$$$$
        //텍스트 왼쪽 정렬
        private void BtnLeftAlign_Click(object sender, EventArgs e)
        {
            TextEdit.Select();
            TextEdit.SelectionAlignment = HorizontalAlignment.Left;
            f.ChangeLabel(ParagraphLabel, "왼쪽 정렬 완료");
        }

        //텍스트 가운데 정렬
        private void BtnCenterAlign_Click(object sender, EventArgs e)
        {
            TextEdit.Select();
            TextEdit.SelectionAlignment = HorizontalAlignment.Center;
            f.ChangeLabel(ParagraphLabel, "중앙 정렬 완료");
        }

        //텍스트 오른쪽 정렬
        private void BtnRightAlign_Click(object sender, EventArgs e)
        {
            TextEdit.Select();
            TextEdit.SelectionAlignment = HorizontalAlignment.Right;
            f.ChangeLabel(ParagraphLabel, "오른쪽 정렬 완료");
        }

        //글머리 표
        private void BtnBullet_Click(object sender, EventArgs e)
        {
            TextEdit.SelectionBullet = !TextEdit.SelectionBullet;
            if (TextEdit.SelectionBullet) { f.ChangeLabel(ParagraphLabel, "글머리 적용 완료"); }
            else { f.ChangeLabel(ParagraphLabel, "글머리 적용 해제"); }
        }

        //$$$$$$$$$$$$$$도구 영역$$$$$$$$$$$$$$$
        //찾기
        private void BtnFind_Click(object sender, EventArgs e)
        {
            status = "Find";
            Search.ReadOnly = false;
            Search.Focus();
            Search.SelectAll();
        }

        //하나 바꾸기
        private void BtnSingleChange_Click(object sender, EventArgs e)
        {
            if (status != "Change")
            {
                status = "Change";
                Change.ReadOnly = false;
                Change.Focus();
                Change.SelectAll();
            }
            else
            {
                var regax = new Regex(Regex.Escape(Search.Text));
                TextEdit.Text = regax.Replace(TextEdit.Text, Change.Text, 1);
                int count = f.Find_Text(Search, TextEdit);
                SearchStatus.Text = count + "개 찾음";
            }
        }

        //전부 바꾸기
        private void BtnAllChange_Click(object sender, EventArgs e)
        {
            if (status != "Change")
            {
                status = "Change";
                Change.ReadOnly = false;
                Change.Focus();
                Change.SelectAll();
            }
            else
            {
                TextEdit.Text = TextEdit.Text.Replace(Search.Text, Change.Text);
                int count = f.Find_Text(Search, TextEdit);
                SearchStatus.Text = count + "개 찾음";
            }
        }

        //Search 내용 변경 시 status에 따라 찾기 및 바꾸기 수행.
        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (status == "Find" || status == "Change")   //찾기 & 바꾸기
            {
                int count = f.Find_Text(Search, TextEdit);
                SearchStatus.Text = count + "개 찾음";
                if (count != 0)
                {
                    BtnSingleChange.Enabled = true;
                    BtnAllChange.Enabled = true;
                }
                else
                {
                    BtnSingleChange.Enabled = false;
                    BtnAllChange.Enabled = false;
                }
            }
        }
        //###################################################################

        //#######################Background Function############################
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
                f.ChangeTitle(false, route);
        }











        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //TextEdit Hotkey Setting
        private void TextEdit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //잘라내기 HOTKEY
            if (e.Control && e.KeyCode == Keys.X){ TextEdit.Cut(); }
            if (e.Control && e.KeyCode == Keys.Z) { TextEdit.Undo(); }
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
        
        //상위메뉴바 실행취소
        private void 실행취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEdit.Undo();
            f.ChangeLabel(EditLabel, "실행 취소되었습니다.");
        }

        //상위메뉴바 잘라내기
        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEdit.Cut();

            string temp_data = Clipboard.GetText();
            temp_data = f.StringSummary(temp_data, edit_label_num) + "가 오려졌습니다.";
            f.ChangeLabel(EditLabel, temp_data);

        }
        //상위메뉴바 글꼴

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.fdFont.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TextEdit.Font = fdFont.Font;
            }
        }

        private void TextEdit_KeyUp(object sender, KeyEventArgs e)
        {
            TextEdit.AcceptsTab = true;
            if (e.KeyCode == Keys.Tab)
            {
                TextEdit.SelectionIndent = 1;
            }
        }

        //도움말-사용방법 폼 연결
        private void 사용방법ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manual aa = new Manual();
            aa.Show();
        }

        //도움말-정보
        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information I = new Information();
            I.Show();
        }


        //###################################################################

    }
}