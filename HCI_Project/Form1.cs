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
        public Form1()
        {
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
            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {
                StreamReader sr = new StreamReader(
                    openFileDialog.FileName, Encoding.Default);
                text.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        //파일저장
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "텍스트파일|*.txt";
            
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(
                    saveFileDialog.FileName, false, Encoding.Default);
                MessageBox.Show("파일 저장 : " + saveFileDialog.FileName);

         
                sw.Write(text.Text);
                sw.Close();
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
        private void btnpaste_Click(object sender, EventArgs e)
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
            panel5.Hide();
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
            panel5.Hide();
            child.Hide();
            child2.Show();



        }
        //서식기능 메뉴바
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child2.Hide();
            child.Hide();
            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Show();
            panel5.Show();
        }
    }
}
