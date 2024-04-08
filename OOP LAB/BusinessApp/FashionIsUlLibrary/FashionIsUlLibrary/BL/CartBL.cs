using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    public class CartBL
    {
        private List<ClothesBL> Cart;

        public CartBL()
        {
            Cart = new List<ClothesBL>();
        }

        public void AddIntoCart(ClothesBL c)
        {
            Cart.Add (c);
        }

        public int GetTotalCartAmount()
        {
            int total = 0;
            foreach (ClothesBL c in Cart)
            {
                total += c.GetPrice() * c.GetQuantity();
            }

            return total;
        }

        public List<ClothesBL> GetCartItems()
        {
            return Cart;
        }

        public bool CheckCart()
        {
            return Cart.Count > 0;
        }


        public ClothesBL FindClothFromCart(int id)
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

        public bool DelItem(ClothesBL c)
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
