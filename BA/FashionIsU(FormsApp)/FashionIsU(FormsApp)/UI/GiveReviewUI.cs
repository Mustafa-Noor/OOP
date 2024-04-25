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
    public partial class GiveReviewUI : Form
    {
        private CustomerBL customer;
        public GiveReviewUI(CustomerBL customer)
        {
            InitializeComponent();
            this.customer = customer;
        }
        DataTable dataTable = new DataTable();
        private void GiveReviewUI_Load(object sender, EventArgs e)
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

        private void DisplayClothes() // display all the cloth
        {
            List<ClothesBL> AllClothes = ObjectHandler.GetClothesDL().GetAllClothes();
            foreach (ClothesBL cloth in AllClothes)
            {
                dataTable.Rows.Add(cloth.GetId(), cloth.GetType(), cloth.GetGender(), cloth.GetColor(), cloth.GetPrice(), cloth.GetQuantity());
            }

            ClothesGrid.DataSource = dataTable;
        }


        private bool ValidateID(string ID) // validaiton for id text box
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

        private bool ValidateRating() // validation for rating text box
        {
            
            if (!UtilityClass.ValidateRatingString(RatingBox.Text))
            {
                errorProvider1.SetError(RatingBox, "It Is Required and Should Be Integer From 1 to 5.");
                return false;
            }
            else
            {
                errorProvider1.SetError(RatingBox, string.Empty);
                return true;

            }
        }

        private bool ValidateComment() // validation for comment text box
        {
            if (UtilityClass.CheckforEmpty(CommentBox.Text) || UtilityClass.CheckingForcomma(CommentBox.Text))
            {
                errorProvider1.SetError(CommentBox, "It Is Required & Should not Contain a Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(CommentBox, string.Empty);
                return true;

            }
        }

        private void ReviewBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateID(IdBox.Text)) { return; } // validation for text boxes
            if (!ValidateRating()) { return; }
            if (!ValidateComment()) { return; }
            int rating = int.Parse(RatingBox.Text);
            int Id = int .Parse(IdBox.Text);    
            ClothesBL cloth = ObjectHandler.GetClothesDL().FindClothByID(Id); // finds the cloth by their id
            if (cloth != null)
            {
                ObjectHandler.GetReviewDL().AddReviews(new ReviewBL(rating, CommentBox.Text, customer.GetUsername()), cloth); // adds review through composition
                cloth.ClearReviews();
                ObjectHandler.GetReviewDL().RetrieveReviews(cloth);
                MessageBox.Show("Successfully Submitted Review", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearTextBoxes() // clears all the text boxes
        {
            IdBox.Clear();
            RatingBox.Clear();
            CommentBox.Clear();           
        }
    }
}
