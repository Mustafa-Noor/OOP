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
using FashionIsUlLibrary;

namespace FashionIsU_FormsApp_.UI
{
    public partial class DisplayOrderOfCustomerUI : Form
    {
        public DisplayOrderOfCustomerUI()
        {
            InitializeComponent();
            
        }

        private void DisplayOrderOfCustomerUI_Load(object sender, EventArgs e)
        {
            
            MakeColumns();
        }

        private bool ValidateUsername() // validation for the username textboxes
        {
            if (UtilityClass.CheckforEmpty(username.Text) || UtilityClass.CheckingForSpace(username.Text))
            {
                errorProvider1.SetError(username, "It Must Not Be Empty or Contain Space");
                return false;
            }
            else
            {
                errorProvider1.SetError(username, string.Empty);
                return true;
            }
        }

        private void Diplaybtn_Click(object sender, EventArgs e) // displays orders
        {
            if (!ValidateUsername()) { return; }
            CustomerBL cus = ObjectHandler.GetCustomerDL().FindCustomerByUsername(username.Text); // finds customer
            if (cus != null)
            {
                ObjectHandler.GetOrderDL().RetrieveOrdersOfCustomer(cus); // for displaying their order
                dataTable.Rows.Clear();
                DisplayOrders(cus.GetOrderList());
            }
            else
            {
                MessageBox.Show("Customer Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DataTable dataTable =  new DataTable();

        private void DisplayOrders(List <OrderBL> customerOrders) // display orders
        {
            foreach (OrderBL order in customerOrders)
            {
                dataTable.Rows.Add(order.GetOrderDate().ToShortDateString(), FormatItems(order.GetItems()), order.GetTotalPrice(), order.GetDeliveryAddress(), order.GetPaymentMethod().GetPaymentType());
            }
            OrdersGrid.DataSource = dataTable;
        }

        private void MakeColumns()
        {
            dataTable.Columns.Add("OrderDate", typeof(string));
            dataTable.Columns.Add("Items", typeof(string));
            dataTable.Columns.Add("Price", typeof(string));
            dataTable.Columns.Add("DeliveryAddress", typeof(string));
            dataTable.Columns.Add("PaymentType", typeof(string));

        }

        private string FormatItems(List<ClothesBL> items) // this is for formatting the items in order with comma between them
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.Append(item.GetType()).Append(", ");
            }
            return sb.ToString().TrimEnd(',', ' ');
        }
    }
}
