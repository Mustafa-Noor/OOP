using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    public class ClothesBL
    {
        // attributes of clothes
        private int ClothesID;
        private string Type;
        private string Gender;
        private string Color;
        private int Price;
        private int Quantity;
        private List<ReviewBL> Reviews;

        // Parameterized Constructors
        public ClothesBL(int id, string type, string gender, string color, int price, int availability)
        {
            ClothesID = id;
            Type = type;
            Gender = gender;
            Color = color;
            Price = price;
            Quantity = availability;
            Reviews = new List<ReviewBL>();
        }

        public ClothesBL(string type, string gender, string color, int price, int availability)
        {
            Type = type;
            Gender = gender;
            Color = color;
            Price = price;
            Quantity = availability;
            Reviews = new List<ReviewBL>();
        }



        public ClothesBL(ClothesBL c) 
        {
            ClothesID = c.GetId();  
            Type = c.GetType();
            Gender = c.Gender;
            Color = c.Color;
            Price = c.Price;
            Quantity = c.Quantity;

        }


        // Getter and Setters
        public int GetId()
        {
            return ClothesID;
        }

        public void SetId(int id)
        {
            ClothesID = id;
        }


        public string GetType()
        {
            return Type;
        }

        public void SetType(string type)
        {
            Type = type;
        }

        public string GetGender()
        {
            return Gender;
        }

        public void SetGender(string gender)
        {
            Gender = gender;
        }

        public string GetColor()
        {
            return Color;
        }

        public void SetColor(string color)
        {
            Color = color;
        }

        public int GetPrice()
        {
            return Price;
        }

        public void SetPrice(int price)
        {
            Price = price;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int availability)
        {
            Quantity = availability;
        }


        public bool IsAvailableToBuy(int Quantity) // Compares the quantity to tell if an item is available to buy
        {
            if (Quantity > 0 && Quantity <= this.Quantity)
            { return true; }
            return false;
        }

        public void DropQuantity(int quantity) // Reduces the quantity of Cloth after being bought
        {
            Quantity -= quantity;
        }

        public void AddQuantity(int quantity) // Increases the quantity of Cloth
        { Quantity += quantity; }

        public void AddReview(ReviewBL rev) // Adds the review In the List Of Reviews
        {
            Reviews.Add(new ReviewBL(rev.GetRating(), rev.GetComment(), rev.GetUsername())); //Compostion Relation
        }

        public List<ReviewBL> GetReviews() // Gives the list of reviews
        {
            return Reviews;
        }

        public void SetReviews(List<ReviewBL> reviews) 
        {
            this.Reviews = reviews;
        }

        public void ClearReviews() //Clears the list of reviews
        { Reviews.Clear(); }


        public void UpdateCloth(ClothesBL cloth) // Updates the details of the cloth
        {
            SetGender(cloth.GetGender());
            SetColor(cloth.GetColor());
            SetType(cloth.GetType());
            SetPrice(cloth.GetPrice());
            SetQuantity(cloth.GetQuantity());
        }   
    }
}
