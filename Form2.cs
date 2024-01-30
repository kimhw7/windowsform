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
    public partial class Form2 : Form
    {
        public string ReceivedId;
        public string ReceivedPwd;

        public Form2(string Id, string Pwd)
        {
            InitializeComponent();
            ReceivedId = Id;
            ReceivedPwd = Pwd;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = ReceivedId;
            textBox2.Text = ReceivedPwd;
        }
    }
}
