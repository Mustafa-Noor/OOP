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
    public partial class DisplayOrdersUI : Form
    {
        private CustomerBL customer;
        public DisplayOrdersUI(CustomerBL customer)
        {
            InitializeComponent();
            this.customer = customer;
            customer.ClearOrders();
            ObjectHandler.GetOrderDL().RetrieveOrdersOfCustomer(customer);
        }

        DataTable dataTable = new DataTable();

        private void DisplayOrdersUI_Load(object sender, EventArgs e)
        {
            MakeColumns();
            DisplayOrders();
            DisplayAmount();
        }

        private void DisplayOrders() // display orders
        {
            foreach (OrderBL order in customer.GetOrderList())
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

        private string FormatItems(List<ClothesBL> items) // formatting items in order with comma
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.Append(item.GetType()).Append(", ");
            }
            return sb.ToString().TrimEnd(',', ' ');
        }

        private void DisplayAmount() // display amount spent
        {
            AmountLabel.Text = "Your Total Amount Spent Including All The Orders is : Rs " + customer.FindTotalAmountSpent();
        }
    }
}
