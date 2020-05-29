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
        public Boolean check_File(string route, string filename)
        {
            FileInfo fi = new FileInfo(route + "\\" + filename);
            if (fi.Exists) return true;
            else return false;
        }
        public Boolean save_File(string text, string route, string filename)
        {
            if (check_File(route, filename))
            {
                if (MessageBox.Show("해당 위치에 파일이 이미 존재합니다.\n덮어씌우시겠어요?", "경고", MessageBoxButtons.YesNo) == DialogResult.No) return false;
            }
            System.IO.File.WriteAllText(route + "\\" + filename, text, Encoding.Default);
            if (check_File(route, filename)) return true;
            else
            {
                MessageBox.Show("알 수 없는 오류로 파일 저장에 실패했습니다.");
                return false;
            }
        }
    }
}
