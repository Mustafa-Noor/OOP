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
    public partial class UpdateClothUI : Form
    {
        public UpdateClothUI()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        private void UpdateClothUI_Load(object sender, EventArgs e)
        {

            MakeColumns();
            DisplayClothes();
        }

        private void MakeColumns()
        {
            dataTable.Columns.Add("ClothesID", typeof(string));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Color", typeof(string));
            dataTable.Columns.Add("Price", typeof(string));
            dataTable.Columns.Add("Availability", typeof(string));
        }

        private void DisplayClothes() // dispay all the cloths on the grid
        {
            List<ClothesBL> AllClothes = ObjectHandler.GetClothesDL().GetAllClothes();
            foreach (ClothesBL cloth in AllClothes)
            {
                dataTable.Rows.Add(cloth.GetId(), cloth.GetType(), cloth.GetGender(), cloth.GetColor(), cloth.GetPrice(), cloth.GetQuantity());
            }

            ClothesGrid.DataSource = dataTable;
        }

        private bool ValidateType() // validation for the type text box
        {

            if (UtilityClass.CheckforEmpty(TypeBox.Text) || UtilityClass.CheckingForSpace(TypeBox.Text) || UtilityClass.ContainsInteger(TypeBox.Text) || UtilityClass.CheckingForcomma(TypeBox.Text))
            {
                errorProvider1.SetError(TypeBox, "It Is Required and Should Not Contain Digits Or Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(TypeBox, string.Empty);
                return true;

            }
        }

        private bool ValidateGender() // validation for the gender text box
        {
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

        private bool ValidateColor() // validation for the color text box
        {
            if (UtilityClass.CheckforEmpty(colorBox.Text))
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

        private bool ValidatePrice() // validation for the price
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

        private bool ValidateQuantity() //validation for the quantity txt box
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

        private bool ValidateID() // validation for the id text box
        {
            int number;
            if (string.IsNullOrWhiteSpace(IdBox.Text) || !int.TryParse(IdBox.Text, out number))
            {
                errorProvider1.SetError(IdBox, "It Is Required and Should Be Number");
                return false;
            }
            else
            {
                errorProvider1.SetError(IdBox, string.Empty);
                return true;

            }
        }

        private void ClearTextBoxes() // clears all the text boxes
        {
            IdBox.Clear();
            TypeBox.Clear();
            PriceBox.Clear();
            QuantityBox.Clear();

        }

        private void Updatebtn_Click(object sender, EventArgs e) // updates the items of cloth
        {
            if (!ValidateID()) { return; } // validaiton for the input boxes
            if (!ValidateType()) { return; }
            if (!ValidateGender()) { return; }
            if (!ValidateColor()) { return; }
            if (!ValidatePrice()) { return; }
            if (!ValidateQuantity()) { return; }

            int id = Convert.ToInt32(IdBox.Text);
            int price = Convert.ToInt32(PriceBox.Text);
            int quantity = Convert.ToInt32(QuantityBox.Text);

            ClothesBL cloth = ObjectHandler.GetClothesDL().FindClothByID(id); // find the cloth by their id
            if (cloth != null)
            {
                ClothesBL c = new ClothesBL(TypeBox.Text, GenderCombo.Text, colorBox.Text, price, quantity);
                if (!ObjectHandler.GetClothesDL().CheckClothExistence(c) || !ObjectHandler.GetClothesDL().CheckClothExistenceByQuantity(c))
                {
                    cloth.UpdateCloth(c);
                    ObjectHandler.GetClothesDL().UpdateCloth(cloth);
                    MessageBox.Show("Successfully Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTable.Rows.Clear();
                    DisplayClothes();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Cloth Already Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                MessageBox.Show("Incorrect ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
