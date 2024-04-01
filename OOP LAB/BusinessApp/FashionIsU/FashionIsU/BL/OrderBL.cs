using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsU
{
    internal class OrderBL
    {
        
        private DateTime OrderDate;
        private List<ClothesBL> Items;
        private float TotalPrice;
        private string DeliveryAddress;
        private PaymentMethodBL PaymentMethod;
        public OrderBL(List<ClothesBL> items, float totalPrice, string deliveryAddress, PaymentMethodBL PaymentMethod)
        {
            OrderDate = DateTime.Now;
            Items = items;
            TotalPrice = totalPrice;
            DeliveryAddress = deliveryAddress;
            this.PaymentMethod = PaymentMethod;
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

        public float GetTotalPrice()
        {
            return TotalPrice;
        }

        public void SetTotalPrice(float totalPrice)
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
