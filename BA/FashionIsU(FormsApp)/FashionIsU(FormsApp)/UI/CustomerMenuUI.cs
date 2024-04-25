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
    public partial class CustomerMenuUI : Form
    {
        private CustomerBL customer;
        public CustomerMenuUI(CustomerBL customer)
        {
            InitializeComponent();
            this.customer = customer;
            ObjectHandler.GetCartDL().RetrieveCart(customer);
            ObjectHandler.GetOrderDL().RetrieveOrdersOfCustomer(customer); // loads the cart of the customer
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm) // proper functionality to open the child form
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Clear(); // Clear any existing controls in the panel
            panelChild.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentMenuBtn_Click(object sender, EventArgs e)
        {
            if(ObjectHandler.GetClothesDL().CheckClothes()) // open buyitem page
            {
                openChildForm(new BuyItemUI(customer));
            }
            else
            {
                MessageBox.Show("There Are No Clothes Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void panelChild_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ManageCart_Click(object sender, EventArgs e) // open the cart management page
        {
            if(customer.GetCart().CheckCart())
            {
                openChildForm(new ManageCartUI(customer));
            }
            else
            {
                MessageBox.Show("Your Cart Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaceOrderbtn_Click(object sender, EventArgs e) //opens the place order page
        {
            if (customer.GetCart().CheckCart())
            {
                openChildForm(new PlaceOrderUI(customer));
            }
            else
            {
                MessageBox.Show("Your Cart Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayOrderBtn_Click(object sender, EventArgs e) // open the display orders page
        {
            if(customer.CheckOrders())
            {
                openChildForm(new DisplayOrdersUI(customer));
            }
            else
            {
                MessageBox.Show("No Order Has Been Placed Yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReviewPageBtn_Click(object sender, EventArgs e) // opens give review page
        {
            if (ObjectHandler.GetClothesDL().CheckClothes())
            {
                openChildForm(new GiveReviewUI(customer));
            }
            else
            {
                MessageBox.Show("There Are No Clothes Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) // opens update profile page
        {
            openChildForm(new UpdateProfileCustomerUI(customer));

        }

        private void ExitBtn_Click(object sender, EventArgs e) // exit button
        {
            this.Hide();
            Form form = new MainUI();
            form.ShowDialog();
        }

        private void CustomerMenuUI_Load(object sender, EventArgs e)
        {

        }
    }
}
