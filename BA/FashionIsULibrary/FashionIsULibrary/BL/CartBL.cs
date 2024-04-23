using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    public class CartBL
    {
        private List<ClothesBL> Cart; // List Of Clothes In The Cart

        // Constructor Of Cart
        public CartBL()
        {
            Cart = new List<ClothesBL>();
        }

        //Adds a cloth in the cart
        public void AddIntoCart(ClothesBL c)
        {
            if(!Cart.Contains(c))
            {
                Cart.Add(c);
            }
            
        }

        // Calculates the total Amount of Cart Items
        public int GetTotalCartAmount()
        {
            int total = 0;
            foreach (ClothesBL c in Cart)
            {
                total += c.GetPrice() * c.GetQuantity();
            }

            return total;
        }

        // Gives the list of All Cart Items
        public List<ClothesBL> GetCartItems()
        {
            return Cart;
        }

        public bool CheckCart() // Checks the count of clothes in the cart
        {
            return Cart.Count > 0;
        }


        public ClothesBL FindClothFromCart(int id) // Finds a Cloth from Cart 
        {
            foreach(ClothesBL c in Cart)
            {
                if(c.GetId() == id)
                {
                    return c;
                }
            }
            return null;
        }

        public bool DelItem(ClothesBL c) // Deletes a cloth from the cart
        {
            foreach(ClothesBL cloth in Cart)
            {
                if(c == cloth)
                {
                    Cart.Remove(cloth);
                    return true;
                }
            }
            return false;
        }
    }
}
