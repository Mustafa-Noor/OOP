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

namespace LabWorkForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        int selectedRow;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Roll", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Fsc", typeof(string));

            dataGridView1.DataSource = dataTable;

            List<Student> students = StudentDL.GetAllStudents();
            foreach (Student student in students)
            {
                dataTable.Rows.Add(student.Roll, student.Name, student.FSc);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = InputForStudent();
                StudentDL.SaveStudent(s);
                MessageBox.Show("ADDed");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error");
            }



        }



        // this should be placed in the ui

        private Student InputForStudent()
        {
            int roll = Convert.ToInt32(rollBox.Text);
            string name = Convert.ToString(nameBox.Text);
            float matric = Convert.ToSingle(textBox4.Text);
            float fsc = Convert.ToSingle(textBox3.Text);
            float ecat = Convert.ToSingle(textBox5.Text);

            Student s = new Student(roll, name, ecat, matric, fsc);
            return s;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Student s = InputForStudent();
            StudentDL.UpdateStudent(s, ID);

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            StudentDL.DeleteStudent(ID);
        }

        private void DegreeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
