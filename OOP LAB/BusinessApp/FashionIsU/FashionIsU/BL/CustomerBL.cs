using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsU
{
    internal class CustomerBL : UserBL
    {
        private string CustomerAddress;
        private List<OrderBL> Orders;
        private CartBL Cart;
        
       
        public CustomerBL(string username,string password, string email, string firstName,string lastName, string phone,string role, string customerAddress) : base(username, password, email, firstName, lastName, phone, role)
        {
            this.CustomerAddress = customerAddress;
            Orders = new List<OrderBL>();
            Cart = new CartBL();
            
        }
        public CustomerBL(UserBL u, string customerAddress) : base(u)
        {
            this.CustomerAddress = customerAddress;
            Orders = new List<OrderBL>();
            Cart = new CartBL();
           
           
        }

        public string GetCustomerAddress()
        {
            return CustomerAddress;
        }

        // Setter method for CustomerAddress
        public void SetCustomerAddress(string address)
        {
            CustomerAddress = address;
        }

        public CartBL GetCart()
        {
            return Cart;
        }

        public List<OrderBL> GetOrderList()
        {
            return Orders;
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

        public void UpdateProfile(string username, string password, string email, string firstName, string lastName, string phoneNumber, string customerAddress)
        {
            SetUsername(username);
            SetPassword(password);
            SetEmail(email);
            SetFirstName(firstName);
            SetLastName(lastName);
            SetPhoneNumber(phoneNumber);
            SetCustomerAddress(customerAddress);
        }

        public int GetOrdersCount()
        {
            return Orders.Count;
        }

        
    }
}
