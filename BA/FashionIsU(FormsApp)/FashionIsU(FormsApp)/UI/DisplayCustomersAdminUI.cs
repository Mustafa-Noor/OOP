using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FashionIsU;

namespace FashionIsU_FormsApp_.UI
{
    public partial class DisplayCustomersAdminUI : Form
    {
        public DisplayCustomersAdminUI()
        {
            InitializeComponent();
        }

        private void DisplayCustomersAdminUI_Load(object sender, EventArgs e)
        {
            MakeColumns();
            DisplayCustomers();
        }

        DataTable dataTable = new DataTable();
        private void MakeColumns() // makes columns for the grid
        {
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("ContactNumber", typeof(string));

        }

        private void DisplayCustomers() // displays customers
        {
            List<CustomerBL> AllCustomers = ObjectHandler.GetCustomerDL().GetAllCustomers();
            foreach (CustomerBL customer in AllCustomers)
            {
                dataTable.Rows.Add(customer.GetUsername(), customer.GetFirstName(), customer.GetLastName(), customer.GetEmail(), customer.GetPhoneNumber());
            }

            CustomersGrid.DataSource = dataTable;
        }
    }
}
