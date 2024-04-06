using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Labwork.BL;
using Labwork.DL;

namespace LabWorkForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dataTable= new DataTable();
        int selectedRow;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Roll", typeof(string));
            dataTable.Columns.Add("Name",  typeof(string));
            dataTable.Columns.Add("Fsc", typeof(string));

            dataGridView1.DataSource = dataTable;

            List<Student> students = StudentDL.GetAllStudents();
            foreach(Student student in students)
            {
                dataTable.Rows.Add(student.Roll, student.Name, student.FSc);
            }
            dataGridView1.DataSource = dataTable;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
