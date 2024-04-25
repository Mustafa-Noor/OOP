using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FashionIsU_FormsApp_.UI;

namespace FashionIsU_FormsApp_
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void SignInMenubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new SignInUI(); // opens the sign in page
            form.ShowDialog();
        }

        private void SignUpMenuBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form form = new SignUpUI(); // opens the sign up page
            form.ShowDialog();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }
    }
}
