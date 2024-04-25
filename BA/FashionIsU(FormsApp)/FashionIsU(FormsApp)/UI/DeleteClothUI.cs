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
    public partial class DeleteClothUI : Form
    {
        public DeleteClothUI()
        {
            InitializeComponent();
        }

        private void DeleteClothUI_Load(object sender, EventArgs e)
        {
            MakeColumns();
            DisplayClothes();
        }

        DataTable dataTable = new DataTable();
        private void MakeColumns() // makes columns
        {
            dataTable.Columns.Add("ClothesID", typeof(string));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Color", typeof(string));
            dataTable.Columns.Add("Price", typeof(string));
            dataTable.Columns.Add("Availability", typeof(string));
        }

        private void DisplayClothes() // displays clothes on the grid
        {
            List<ClothesBL> AllClothes = ObjectHandler.GetClothesDL().GetAllClothes();
            foreach (ClothesBL cloth in AllClothes)
            {
                dataTable.Rows.Add(cloth.GetId(), cloth.GetType(), cloth.GetGender(), cloth.GetColor(), cloth.GetPrice(), cloth.GetQuantity());
            }

            ClothesGrid.DataSource = dataTable;
        }

        private bool ValidateID() // validation for id
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

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (!ValidateID()) { return; } // validate id text box
            int Id = Convert.ToInt32(IdBox.Text);
            ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(Id);

            if (c != null)
            {
                ObjectHandler.GetReviewDL().DeleteReview(c); // delete their review and the cloth
                if (ObjectHandler.GetClothesDL().DeleteCloth(c))
                {
                    MessageBox.Show("Successfully Deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTable.Rows.Clear();
                    DisplayClothes();
                    IdBox.Clear();
                }

            }
            else
            {
                MessageBox.Show("Incorrect ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
