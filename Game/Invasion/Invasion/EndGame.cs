using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invasion
{
    public partial class RestartForm : Form
    {
        public RestartForm()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Invasion();
            form.ShowDialog();
        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
