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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabWorkForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataTable dataTable = new DataTable();

        private void Form2_Load(object sender, EventArgs e)
        {

            dataTable.Columns.Add("Title", typeof(string));
            dataTable.Columns.Add("Duration", typeof(string));

            List<DegreeProgram> degrees = DegreeProgramDL.GetAllDegrees();

            foreach (DegreeProgram degreeProgram in degrees)
            {
                dataTable.Rows.Add(degreeProgram.Title, degreeProgram.Duration);
            }

            dataGridView1.DataSource = dataTable;


        }

        private DegreeProgram InputForDegree()
        {
            int duration = Convert.ToInt32(durationBox.Text);
            string title = Convert.ToString(titleBox.Text);
           

            DegreeProgram deg = new DegreeProgram(title, duration);
            return deg;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            
               DegreeProgram deg = InputForDegree();
                DegreeProgramDL.SaveDegree(deg);
                MessageBox.Show("ADDed");
            
            
        }


        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string title = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
            DegreeProgram deg =  InputForDegree();
            DegreeProgramDL.UpdateDegree(deg, title);
            

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string title = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
            DegreeProgramDL.DeleteDegreet(title);
            MessageBox.Show("ADDed");
        }
    }
}
