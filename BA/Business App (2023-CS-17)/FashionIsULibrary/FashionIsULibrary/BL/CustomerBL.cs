using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsU
{
    public class CustomerBL : UserBL
    {
       
        private List<OrderBL> Orders;
        private CartBL Cart;
        
       
        public CustomerBL(string username,string password, string email, string firstName,string lastName, string phone,string role) : base(username, password, email, firstName, lastName, phone, role)
        {
            
            Orders = new List<OrderBL>();
            Cart = new CartBL();
            
        }

        public CustomerBL(string username, string password) : base(username, password) { }

        public CustomerBL(UserBL u) : base(u)
        {
            
            Orders = new List<OrderBL>();
            Cart = new CartBL();
           
           
        }

        
        public CartBL GetCart()
        {
            return Cart;
        }

        public List<OrderBL> GetOrderList()
        {
            return Orders;
        }

        public void SetOrderList(List <OrderBL> Orders)
        {
            this.Orders = Orders;
        }

        public void AddOrderCustomer(OrderBL order)
        {
            Orders.Add(order);
        }

        public bool CheckOrders()
        {
            return Orders.Count > 0;
        }

        public void ClearCart()
        {
            Cart.GetCartItems().Clear();
        }

        public float FindTotalAmountSpent()
        {
            float totalAmount = 0;
            foreach(OrderBL order in Orders)
            {
                totalAmount += order.GetTotalPrice();
            }

            return totalAmount;
        }

        public int GetOrdersCount()
        {
            return Orders.Count;
        }

        public void ClearOrders()
        { Orders.Clear(); }

        
    }
}
