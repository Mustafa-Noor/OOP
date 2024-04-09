using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionIsU_FormsApp_.UI
{
    public partial class SignUpUI : Form
    {
        public SignUpUI()
        {
            InitializeComponent();
        }

        private void SignUpUI_Load(object sender, EventArgs e)
        {

        }

        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form form = new SignInUI();
            form.ShowDialog();
        }
    }
}
