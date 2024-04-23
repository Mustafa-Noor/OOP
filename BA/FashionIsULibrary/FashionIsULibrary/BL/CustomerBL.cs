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
       // Order List and Cart Of Customer
        private List<OrderBL> Orders;
        private CartBL Cart;
        
       // Parameterized Constructors
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

        // Getter and Setters
        public CartBL GetCart()
        {
            return Cart;
        }

        public List<OrderBL> GetOrderList()
        {
            return Orders;
        }

        // Add Order in List of order
        public void AddOrderCustomer(OrderBL order)
        {
            Orders.Add(new OrderBL(order)); //Compostion relation
        }

        public bool CheckOrders() // checks the count of orders
        {
            return Orders.Count > 0;
        }

        public void ClearCart() // this clears the cart
        {
            Cart.GetCartItems().Clear();
        }

        public float FindTotalAmountSpent() // calcultes the total amount spent by customer
        {
            float totalAmount = 0;
            foreach(OrderBL order in Orders)
            {
                totalAmount += order.GetTotalPrice();
            }

            return totalAmount;
        }

        public int GetOrdersCount() // return the count of orders
        {
            return Orders.Count;
        }

        public void ClearOrders() // clears the order list
        { Orders.Clear(); }

        
    }
}
