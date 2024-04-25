using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU_FormsApp_.UI
{
    public partial class AddClothUI : Form
    {
        public AddClothUI()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        private void AddClothUI_Load(object sender, EventArgs e)
        {
            MakeColumns(); // this makes column for the datagrid on loading of the form
            DisplayClothes(); // this is a function to display clothes
        }

        private void MakeColumns() // this method makes column
        {
            dataTable.Columns.Add("ClothesID", typeof(string));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Color", typeof(string));
            dataTable.Columns.Add("Price", typeof(string));
            dataTable.Columns.Add("Availability", typeof(string));
        }

        private void DisplayClothes() // this displays clothes
        {
            List<ClothesBL> AllClothes = ObjectHandler.GetClothesDL().GetAllClothes();
            foreach (ClothesBL cloth in AllClothes)
            {
                dataTable.Rows.Add(cloth.GetId(), cloth.GetType(), cloth.GetGender(), cloth.GetColor(), cloth.GetPrice(), cloth.GetQuantity());
            }

            ClothesGrid.DataSource = dataTable;
        }

        private void ClothesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e) // add button event
        {
            if (!ValidateType()) { return; } // Validations
            if(!ValidateGender()) { return; }
            if(!ValidateColor()) { return; }
            if(!ValidatePrice()) { return; }
            if(!ValidateQuantity()) { return; }

            int price = Convert.ToInt32(PriceBox.Text); // convert textbox to int
            int quantity = Convert.ToInt32(QuantityBox.Text);

            ClothesBL cloth = new ClothesBL(TypeBox.Text, GenderCombo.Text, colorBox.Text, price, quantity);
            if (!ObjectHandler.GetClothesDL().CheckClothExistence(cloth))
            {
                ObjectHandler.GetClothesDL().AddClothes(cloth); // add cloth in list of dl
                MessageBox.Show("Successfully Added!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataTable.Rows.Clear();
                DisplayClothes();
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show("Item Already Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateType()
        {
            // Validation for type
            
            if (UtilityClass.CheckforEmpty(TypeBox.Text) || UtilityClass.CheckingForSpace(TypeBox.Text) || UtilityClass.ContainsInteger(TypeBox.Text) || UtilityClass.CheckingForcomma(TypeBox.Text))
            {
                errorProvider1.SetError(TypeBox, "It Is Required and Should Not Contain Digits or Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(TypeBox, string.Empty);
                return true;

            }
        }

        private bool ValidateGender()
        {
            // Validation for gender
            if (UtilityClass.CheckforEmpty(GenderCombo.Text))
            {
                errorProvider1.SetError(GenderCombo, "It Is Required");
                return false;
            }
            else
            {
                errorProvider1.SetError(GenderCombo, string.Empty);
                return true;

            }
        }

        private bool ValidateColor() // validaiton for color
        {
            if (UtilityClass.CheckforEmpty(colorBox.Text) || UtilityClass.CheckingForSpace(colorBox.Text) || UtilityClass.ContainsInteger(colorBox.Text) || UtilityClass.CheckingForcomma(colorBox.Text))
            {
                errorProvider1.SetError(colorBox, "It Is Required");
                return false;
            }
            else
            {
                errorProvider1.SetError(colorBox, string.Empty);
                return true;

            }
        }

        private bool ValidatePrice() // validation for price
        {
            
            if (string.IsNullOrWhiteSpace(PriceBox.Text) || !int.TryParse(PriceBox.Text, out int number) || number <= 0)
            {
                errorProvider1.SetError(PriceBox, "It Is Required and Should Be Number");
                return false;
            }
            else
            {
                errorProvider1.SetError(PriceBox, string.Empty);
                return true;

            }
        }

        private bool ValidateQuantity() // validation for quantity
        {
            
            if (string.IsNullOrWhiteSpace(QuantityBox.Text) || !int.TryParse(QuantityBox.Text, out int number) || number <= 0)
            {
                errorProvider1.SetError(QuantityBox, "It Is Required and Should Be Number");
                return false;
            }
            else
            {
                errorProvider1.SetError(QuantityBox, string.Empty);
                return true;

            }
        }

        private void ClearTextBoxes() // clears all the text boxes
        {
            TypeBox.Clear();
            PriceBox.Clear();
            QuantityBox.Clear();

        }
    }
}
