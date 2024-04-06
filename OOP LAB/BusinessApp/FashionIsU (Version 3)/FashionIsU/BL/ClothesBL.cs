using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class ClothesBL
    {
        private int ClothesID;
        private string Type;
        private string Gender;
        private string Color;
        private int Price;
        private int Quantity;
        private List<ReviewBL> Reviews;

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

        public bool IsAvailableToBuy(int Quantity)
        {
            if (Quantity > 0 && Quantity <= this.Quantity)
            { return true; }
            return false;
        }

        public void DropQuantity(int quantity)
        {
            Quantity -= quantity;
        }

        public void AddQuantity(int quantity)
        { Quantity += quantity; }

        public void AddReview(ReviewBL rev)
        {
            Reviews.Add(new ReviewBL(rev.GetRating(), rev.GetComment(), rev.GetUsername()));
        }

        public List<ReviewBL> GetReviews()
        {
            return Reviews;
        }


        public void UpdateCloth(string gender, string color, string type, int price, int available)
        {
            SetGender(gender);
            SetColor(color);
            SetType(type);
            SetPrice(price);
            SetQuantity(available);
        }   
    }
}
