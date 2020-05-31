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


namespace HCI_Project
{
    public partial class Form1 : Form
    {
        private Function f;
        private string route = null;
        private string status = null;
        public Form1()
        {
            f = new Function();
            InitializeComponent();
        }
        Form2 child = new Form2();
        Form3 child2 = new Form3();

        //폰트색상
        private void btncolor_Click(object sender, EventArgs e)
        {
            if (fdcolor.ShowDialog() != DialogResult.Cancel)
            {
                text.ForeColor = fdcolor.Color;
            }
        }
        //폰트
        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.fdFont.ShowDialog();
            if (dr == DialogResult.OK)
            {
                text.Font = fdFont.Font;
            }
        }



        //파일열기
        private void btnforlder_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "텍스트파일|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                route = openFileDialog.FileName;
                text.Text = f.open_File(openFileDialog.FileName);
                f.change_Title(true, route);
            }
        }

        //파일저장
        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "텍스트파일|*.txt";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Function f = new Function();
                if (f.save_File(text.Text, saveFileDialog.FileName))
                {
                    route = saveFileDialog.FileName;
                    f.change_Title(f.check_Content(route, text.Text), route);
                }
            }
        }
      
        //잘라내기
        private void btncut_Click(object sender, EventArgs e)
        {
            text.Cut();
        }
        //실행취소
        private void btnundo_Click(object sender, EventArgs e)
        {
            text.Undo();
        }
        //복사하기
        private void btncopy_Click(object sender, EventArgs e)
        {
            text.Copy();
        }

        //붙여넣기
        private void BtnPaste_Click(object sender, EventArgs e)
        {
            text.Paste();
        }

        //굵게
        private void button21_Click(object sender, EventArgs e)
        {
          if(text.SelectionFont.Bold)
            {
                text.SelectionFont = new Font(text.SelectionFont, FontStyle.Regular);
            }
            else
            {
                text.SelectionFont = new Font(text.SelectionFont, FontStyle.Bold);
            }
        }
        //밑줄
        private void button23_Click(object sender, EventArgs e)
        {
            if (text.SelectionFont.Underline)
            {
                text.SelectionFont = new Font(text.SelectionFont, FontStyle.Regular);
            }
            else
            {
                text.SelectionFont = new Font(text.SelectionFont, FontStyle.Underline);
            }
        }
        //기울임
        private void button12_Click(object sender, EventArgs e)
        {
            if (text.SelectionFont.Italic)
            {
                text.SelectionFont = new Font(text.SelectionFont, FontStyle.Regular);
            }
            else
            {
                text.SelectionFont = new Font(text.SelectionFont, FontStyle.Italic);
            }
        }

        //글자 크기
        private void button10_Click(object sender, EventArgs e)
        {
            text.SelectionFont = new Font(text.SelectionFont.FontFamily, text.SelectionFont.Size - 1,
                text.SelectionFont.Bold? FontStyle.Bold:FontStyle.Regular );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text.SelectionFont = new Font(text.SelectionFont.FontFamily, text.SelectionFont.Size + 1,
                text.SelectionFont.Bold ? FontStyle.Bold : FontStyle.Regular);
            
          

        }
        //취소선
        private void button16_Click(object sender, EventArgs e)
        {
            if (text.SelectionFont.Strikeout)
            {
                text.SelectionFont = new Font(text.SelectionFont, FontStyle.Regular);
            }
            else
            {
                text.SelectionFont = new Font(text.SelectionFont, FontStyle.Strikeout);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 child =new Form2();
        }

        private void 컨트롤CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            child.TopLevel = false;
            this.Controls.Add(child);
            child.Text = "";
            child.ControlBox = false;
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            child2.Hide();
            child.Show();
        }
        //편집기능 메뉴바
        private void 편집ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child2.TopLevel = false;
            this.Controls.Add(child2);
            child2.Text = "";
            child2.ControlBox = false;
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            child.Hide();
            child2.Show();



        }
        //서식기능 메뉴바
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void 홈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child2.Hide();
            child.Hide();
            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Show();
        }


        //텍스트 변경 시 타이틀 내용 변경.
        private void text_TextChanged(object sender, EventArgs e)
        {
            string temp_data = ActiveForm.Text;
            if (temp_data.Contains("(저장됨)") || temp_data == "TEXT EDITOR")
                f.change_Title(false, route);
        }

        //새 파일 버튼 클릭
        private void NewFile_Click(object sender, EventArgs e)
        {
            string temp_data = ActiveForm.Text;
            if (temp_data.Contains("(저장 안 됨)"))
            {
                if (MessageBox.Show("이전 파일이 저장되지 않았습니다.\n새 파일을 계속 만드시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            route = null;
            text.Text = "";
            f.change_Title(false, route);
        }

    }
}
