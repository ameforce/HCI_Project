using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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

        public String open_File(string route){ return System.IO.File.ReadAllText(route, Encoding.Default); }

        public void change_Title(Boolean TF, string route)
        {
            string temp_data;
            if (route == null) route = "이름 없음";
            if (TF) temp_data = route + " (저장됨)";
            else temp_data = route + " (저장 안 됨)";
            Form1.ActiveForm.Text = temp_data;
        }
    }
}
