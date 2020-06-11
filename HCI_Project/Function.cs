using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;

namespace HCI_Project
{
    class Function
    {
        public Function() { }   //생성자

        //파일 존재 여부 체크.
        public Boolean check_File(string route)
        {
            FileInfo fi = new FileInfo(route);
            if (fi.Exists) return true;
            else return false;
        }

        //현재 텍스트와 저장된 파일의 일치 여부 체크.
        public Boolean check_Content(string route, string content)
        {
            string temp_data = System.IO.File.ReadAllText(route, Encoding.Default);
            return temp_data.Equals(content);
        }

        //파일 저장
        public Boolean save_File(string text, string route)
        {
            System.IO.File.WriteAllText(route, text, Encoding.Default);
            if (check_File(route)) return true;
            else
            {
                MessageBox.Show("알 수 없는 오류로 파일 저장에 실패했습니다.");
                return false;
            }
        }

        //파일 열기
        public String open_File(string route){ return System.IO.File.ReadAllText(route, Encoding.Default); }

        //프로그램 타이틀에 저장 여부 표시.
        public void change_Title(Boolean TF, string route)
        {
            string temp_data;
            if (route == null) route = "이름 없음";
            if (TF) temp_data = route + " (저장됨)";
            else temp_data = route + " (저장 안 됨)";
            Form1.ActiveForm.Text = temp_data;
        }

        //텍스트 찾기
        public int Find_Text(TextBox tb, RichTextBox rt)
        {
            rt.SelectionStart = 0;
            rt.SelectionLength = rt.Text.Length;
            rt.SelectionColor = Color.Black;

            int start = 0, pos = 0, count = 0, limit_max = rt.Text.Length;
            while (!(start > limit_max) && pos != -1 && tb.TextLength != 0)
            {
                pos = rt.Text.IndexOf(tb.Text, start, StringComparison.CurrentCulture);
                if (pos == -1) break;
                start = pos + tb.Text.Length;
                rt.SelectionStart = pos;
                rt.SelectionLength = tb.Text.Length;
                rt.SelectionBackColor = Color.AliceBlue;
                rt.SelectionColor = Color.Red;
                count++;
            }
            return count;
        }

        //텍스트 박스에 붙여넣기
        public void Paste_Text(RichTextBox rt)
        {
            rt.Paste();
        }

        //글자 수 지정 크기만큼 줄이는 함수
        public string StringSummary(string text, int num)
        {
            string temp_text;
            if (text.Length > num)
            {
                temp_text = text.Substring(0, num);
                temp_text = temp_text + "...";
            }
            else{ temp_text = text; }
            return temp_text;
        }

        //Label TEXT 변경하는 함수
        public void ChangeLabel(Label l, string text)
        {
            l.Text = text;
        }

        //형광펜 Dialog
        private bool ShowColorDialog(ref Color color, Form temp_f)
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
                if (dlg.ShowDialog(temp_f) == DialogResult.OK)
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

        //형광펜 설정 함수.
        public void SelectBackColor(RichTextBox rt, Form1 temp_f)
        {
            Color color = rt.SelectionBackColor;
            if (ShowColorDialog(ref color, temp_f))
                rt.SelectionBackColor = color;
        }

    }
}
