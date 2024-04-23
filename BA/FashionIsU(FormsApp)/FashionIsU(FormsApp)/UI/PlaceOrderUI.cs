using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU_FormsApp_.UI
{
    public partial class PlaceOrderUI : Form
    {
        private CustomerBL customer;
        public PlaceOrderUI(CustomerBL customer)
        {
            InitializeComponent();
            HidePanels();
            this.customer = customer;
            customer.ClearCart();
            ObjectHandler.GetCartDL().RetrieveCart(customer);
        }

        private void PlaceOrderUI_Load(object sender, EventArgs e)
        {
            SetLabelAmount();
        }

        private void DisplayPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void SetLabelAmount()
        {
            AmountLabel.Text = "Your Total Amount According To Your Cart is : Rs " + customer.GetCart().GetTotalCartAmount();
        }

        private void SetLabelAmountAfterPayment(PaymentMethodBL method)
        {
            int amount = method.GetAmount(customer.GetCart().GetTotalCartAmount());
            AmountLabelAfterPayment.Text = "Your Total Amount After Your Payment Method Selection Is : Rs " + amount;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetPayment_Click(object sender, EventArgs e)
        {
            if(!ValidatePaymentCombo())
            {
                return; 
            }
            else
            {
                PaymentMethodBL method = new PaymentMethodBL(PaymentCombo.Text.ToLower());
                SetLabelAmountAfterPayment(method);
                ShowPanels();
            }
            

        }

        

        private bool ValidatePaymentCombo()
        {
            
            if (string.IsNullOrWhiteSpace(PaymentCombo.Text))
            {
                errorProvider1.SetError(PaymentCombo, "It Is Required");
                return false;
            }
            else
            {
                errorProvider1.SetError(PaymentCombo, string.Empty);
                return true;

            }
        }

        private void HidePanels()
        {
            panel3.Hide();
            label3.Hide();
            address.Hide();
            PlaceOrderbtn.Hide();
        }

        private void ShowPanels()
        {
            panel3.Show();
            label3.Show();
            address.Show();
            PlaceOrderbtn.Show();
        }

        private void PlaceOrderbtn_Click(object sender, EventArgs e)
        {
            SetPayment_Click(sender, e);
            PaymentMethodBL method = new PaymentMethodBL(PaymentCombo.Text.ToLower());
            if (method == null) { return; }
            if (!ValidateAddress()) { return; }

            int amount = method.GetAmount(customer.GetCart().GetTotalCartAmount());
            OrderBL order = new OrderBL(customer.GetCart().GetCartItems(), amount, address.Text, new PaymentMethodBL(method.GetPaymentType()), customer.GetUsername());
            ObjectHandler.GetOrderDL().AddOrder(new OrderBL(order));
            customer.ClearOrders();
            ObjectHandler.GetOrderDL().RetrieveOrdersOfCustomer(customer);
            ObjectHandler.GetCartDL().EmptyCart(customer);
            ObjectHandler.GetCartDL().RetrieveCart(customer);
            MessageBox.Show("Successfully Placed Order", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();



        }

        public void ClearTextBoxes()
        {
            address.Clear();
        }

        private bool ValidateAddress()
        {
            if(UtilityClass.CheckforEmpty(address.Text) || UtilityClass.CheckingForcomma(address.Text))
            { 
                errorProvider1.SetError(address, "It Is Required & Should Not Contain Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(address, string.Empty);
                return true;

            }
        }

        private void AmountLabelAfterPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
