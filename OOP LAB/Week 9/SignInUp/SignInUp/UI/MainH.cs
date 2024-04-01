using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignInUp.DL;
using SignInUp.UI;

namespace SignInUp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            string path = "data.txt";
            if(MUserDL.ReadDataFromFile(path))
            {
                MessageBox.Show("Data Loaded from the File");
            }
            else
            {
                MessageBox.Show("Data not loaded");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(SignIn.Checked)
            {
                Form moreForm = new SignIn();
                moreForm.Show();
                SignIn.Checked = false;
            }
            else if(SignUp.Checked)
            {
                Form moreForm = new SignUp();
                moreForm.Show();
                SignUp.Checked = false;
            }
        }
    }
}
