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
    public partial class DisplayReviewsUI : Form
    {
        public DisplayReviewsUI()
        {
            InitializeComponent();
        }

        private void DisplayReviewsUI_Load(object sender, EventArgs e)
        {
            MakeColumns();
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

        DataTable dataTable = new DataTable();
        private void DisplayReviews(ClothesBL c) // display reviews of a cloth
        {
            foreach (ReviewBL rev in c.GetReviews())
            {
                dataTable.Rows.Add(rev.GetRating(), rev.GetComment(), rev.GetUsername());
            }
            ReviewsGrid.DataSource = dataTable;
        }

        private void MakeColumns()
        {
            dataTable.Columns.Add("Rating", typeof(string));
            dataTable.Columns.Add("Comment", typeof(string));
            dataTable.Columns.Add("Username", typeof(string));
            

        }

        private void Diplaybtn_Click(object sender, EventArgs e)
        {
            if (!ValidateID(IdBox.Text)) { return; } // validation for id box
            int id = Convert.ToInt32(IdBox.Text);

            ClothesBL c = ObjectHandler.GetClothesDL().FindClothByID(id); // find the cloth

            if (c != null)
            {
                c.ClearReviews();
                ObjectHandler.GetReviewDL().RetrieveReviews(c); // functionality for displaying reviews
                dataTable.Rows.Clear();
                DisplayReviews(c);


            }
            else
            {
                MessageBox.Show("Incorrect ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
