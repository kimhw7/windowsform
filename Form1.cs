using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // 입력내용 초기화
        private void InitInput()
        {
 
            Id_textbox.Text = null;
            Pwd_textbox.Text = null;
            checkBox_showPwd.Checked = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 체크여부에 따라 비밀번호 표시
            Pwd_textbox.UseSystemPasswordChar = !checkBox_showPwd.Checked;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            // 입력받은 내용 변수 할당
            string Id = Id_textbox.Text;
            string Pwd = Pwd_textbox.Text;

            InitInput();

            Console.WriteLine($"입력한 아이디: {Id} \t 입력한 암호: {Pwd}");

            // Form2로 데이터 전달
            Form2 form2 = new Form2(Id, Pwd );
            this.Hide();
            form2.Show();
        }        
    }
}
