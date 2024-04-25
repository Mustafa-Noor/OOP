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
    public partial class BuyItemUI : Form
    {
        private CustomerBL customer;
        public BuyItemUI(CustomerBL customer)
        {
            InitializeComponent();
            this.customer = customer;
            ObjectHandler.GetCartDL().RetrieveCart(customer); // loads the cart of the customer
        }

        DataTable dataTable = new DataTable();

        private void BuyItemUI_Load(object sender, EventArgs e)
        {
            MakeColumns();
            DisplayClothes();
        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void DisplayClothes() // display all the clothes
        {
            

            List<ClothesBL> AllClothes = ObjectHandler.GetClothesDL().GetAllClothes();
            foreach(ClothesBL cloth in AllClothes)
            {
                dataTable.Rows.Add(cloth.GetId(), cloth.GetType(), cloth.GetGender(), cloth.GetColor(), cloth.GetPrice(), cloth.GetQuantity());
            }

            ClothesGrid.DataSource = dataTable;
        }


        private void MakeColumns() // makes columns for the table
        {
            dataTable.Columns.Add("ClothesID", typeof(string));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Color", typeof(string));
            dataTable.Columns.Add("Price", typeof(string));
            dataTable.Columns.Add("Availability", typeof(string));
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if(!ValidateID(IdBox.Text)) { return; } // validation for text boxes
            if(!ValidateQuantity(QuantityBox.Text)) { return; }

            int Id = Convert.ToInt32(IdBox.Text);
            int Quantity = Convert.ToInt32(QuantityBox.Text);

            ClothesBL cloth = ObjectHandler.GetClothesDL().FindClothByID(Id); // find cloth from their id

            if (cloth != null && customer.GetCart().FindClothFromCart(Id) == null)
            {
                if(cloth.IsAvailableToBuy(Quantity))
                {
                    ClothesBL cartItem = new ClothesBL(cloth); // functionality for buying the cloth
                    cartItem.SetQuantity(Quantity);
                    cloth.DropQuantity(Quantity);
                    ObjectHandler.GetClothesDL().ChangeQuantity(Id, cloth.GetQuantity());
                    ObjectHandler.GetCartDL().SaveItemInCart(cartItem, customer);
                    customer.ClearCart();
                    ObjectHandler.GetCartDL().RetrieveCart(customer);
                    MessageBox.Show("Successfully Added To Cart", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjectHandler.GetCartDL().RetrieveCart(customer);
                    dataTable.Rows.Clear();
                    DisplayClothes();
                    
                }
                else
                {
                    MessageBox.Show("Not Possible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(customer.GetCart().FindClothFromCart(Id) != null)
            {
                MessageBox.Show("Item Already Bought", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateID(string ID) // validation for id
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

        private bool ValidateQuantity(string quantity) // validation for quantity
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
    }
}
