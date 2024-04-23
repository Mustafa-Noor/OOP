using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsU
{
    public class OrderBL
    {
        // Attributes Of Order
        private int OrderId;
        private DateTime OrderDate;
        private List<ClothesBL> Items;
        private int TotalPrice;
        private string DeliveryAddress;
        private PaymentMethodBL PaymentMethod;
        private string Username;

        // Paramterized Consstructors
        public OrderBL(List<ClothesBL> items, int totalPrice, string deliveryAddress, PaymentMethodBL paymentMethod, string username)
        {
            OrderDate = DateTime.Now;
            Items = items;
            TotalPrice = totalPrice;
            DeliveryAddress = deliveryAddress;
            this.PaymentMethod = paymentMethod;
            this.Username = username;
        }

        public OrderBL(int id, DateTime orderDate, List<ClothesBL> items, int totalPrice, string deliveryAddress, PaymentMethodBL paymentMethod, string username) 
        {
            OrderId = id;
            OrderDate = orderDate;
            Items = items;
            TotalPrice = totalPrice;
            DeliveryAddress = deliveryAddress;
            this.PaymentMethod = paymentMethod;
            this.Username = username;
        }

        public OrderBL(OrderBL order)
        {
            
            OrderId = order.OrderId;
            OrderDate = order.OrderDate;
            Items = order.Items;
            TotalPrice = order.TotalPrice;
            DeliveryAddress = order.DeliveryAddress;
            this.PaymentMethod = order.PaymentMethod;
            this.Username = order.Username;

        }

        // Getter and Setters

        public int GetId()
        {
            return OrderId;
        }
       public string GetUsername()
        {
            return Username;
        }

        public void SetUsername(string username)
        {
            this.Username = username;
        }

        public DateTime GetOrderDate()
        {
            return OrderDate;
        }

        public void SetOrderDate(DateTime orderDate)
        {
            OrderDate = orderDate;
        }

        public List<ClothesBL> GetItems()
        {
            return Items;
        }

        public void SetItems(List<ClothesBL> items)
        {
            Items = items;
        }

        public int GetTotalPrice()
        {
            return TotalPrice;
        }

        public void SetTotalPrice(int totalPrice)
        {
            TotalPrice = totalPrice;
        }

        public string GetDeliveryAddress()
        {
            return DeliveryAddress;
        }

        public void SetDeliveryAddress(string deliveryAddress)
        {
            DeliveryAddress = deliveryAddress;
        }

        public PaymentMethodBL GetPaymentMethod()
        {
            return PaymentMethod;
        }
    }
}
