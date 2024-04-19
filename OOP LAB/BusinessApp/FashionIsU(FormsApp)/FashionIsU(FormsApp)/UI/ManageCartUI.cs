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
    public partial class ManageCartUI : Form
    {
        private CustomerBL customer;
        public ManageCartUI(CustomerBL customer)
        {
            InitializeComponent();
            this.customer = customer;
            customer.ClearCart();
            ObjectHandler.GetCartDL().RetrieveCart(customer);
        }

        DataTable dataTable = new DataTable();

        private void ManageCartUI_Load(object sender, EventArgs e)
        {
            MakeColumns();
            DisplayClothes();
        }

        private void DisplayClothes()
        {
            List<ClothesBL> CartItems = customer.GetCart().GetCartItems();
            foreach (ClothesBL cloth in CartItems)
            {
                dataTable.Rows.Add(cloth.GetId(), cloth.GetType(), cloth.GetGender(), cloth.GetColor(), cloth.GetPrice(), cloth.GetQuantity());
            }

            CartGrid.DataSource = dataTable;
        }


        private void MakeColumns()
        {
            dataTable.Columns.Add("ClothesID", typeof(string));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Color", typeof(string));
            dataTable.Columns.Add("Price", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(string));
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            if (!ValidateID(IdBox.Text)) { return; }
            int Id = Convert.ToInt32(IdBox.Text);
            ClothesBL cloth = customer.GetCart().FindClothFromCart(Id);
            if (cloth != null)
            {
                int quantity = cloth.GetQuantity();
                ClothesBL shopItem = ObjectHandler.GetClothesDL().FindClothByID(Id);
                shopItem.AddQuantity(quantity);
                ObjectHandler.GetClothesDL().ChangeQuantity(Id, shopItem.GetQuantity());
                ObjectHandler.GetCartDL().DeleteAnItem(Id, customer);
                customer.ClearCart();
                ObjectHandler.GetCartDL().RetrieveCart(customer);
                MessageBox.Show("Successfully Removed From Cart", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataTable.Rows.Clear();
                DisplayClothes();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Cloth Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateID(string ID)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ID) || !int.TryParse(ID, out number))
            {
                errorProvider1.SetError(IdBox, "It Is Required and Should Be Integer");
                return false;
            }
            else
            {
                errorProvider1.SetError(IdBox, string.Empty);
                return true;

            }
        }

        private bool ValidateQuantity(string quantity)
        {
           
            if (string.IsNullOrWhiteSpace(quantity) || !int.TryParse(quantity, out int number) || number <= 0)
            {
                errorProvider1.SetError(QuantityBox, "It Is Required and Should Be Integer");
                return false;
            }
            else
            {
                errorProvider1.SetError(QuantityBox, string.Empty);
                return true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateID(IdBox.Text)) { return; }
            if (!ValidateQuantity(QuantityBox.Text)) { return; }
            int Id = Convert.ToInt32(IdBox.Text);
            int Quantity = Convert.ToInt32(QuantityBox.Text);
            ClothesBL cloth = customer.GetCart().FindClothFromCart(Id);
            if (cloth != null)
            {
                int currentQuantity = cloth.GetQuantity();
                ClothesBL shopItem = ObjectHandler.GetClothesDL().FindClothByID(Id);
                shopItem.AddQuantity(currentQuantity);
                if (shopItem.IsAvailableToBuy(Quantity))
                {
                    ObjectHandler.GetCartDL().UpdateQuantity(Id, customer, Quantity);
                    shopItem.DropQuantity(Quantity);
                    ObjectHandler.GetClothesDL().ChangeQuantity(Id, shopItem.GetQuantity());
                    customer.ClearCart();
                    ObjectHandler.GetCartDL().RetrieveCart(customer);
                    MessageBox.Show("Successfully Updated Quantity In Cart", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTable.Rows.Clear();
                    DisplayClothes();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Not Possible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Cloth Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            IdBox.Clear();
            QuantityBox.Clear();
        }
    }
}
