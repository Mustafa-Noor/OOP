using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class OrderFH:IOrderDL
    {
        public bool AddOrder(OrderBL order)
        {
            string path = UtilityClass.GetOrdersFilePath();
            int orderId = GetAllOrdersCount()+1;
            using (StreamWriter f = new StreamWriter(path, true))
            {
                if (f != null)
                {
                    f.WriteLine(orderId+","+order.GetOrderDate() + "," + order.GetTotalPrice() + "," + order.GetDeliveryAddress() + "," + order.GetPaymentMethod().GetPaymentType() + "," + order.GetUsername());
                    f.Flush();
                    SaveOrderItems(orderId, order);
                    return true;
                }
            }
            return false;
        }

        public void SaveOrderItems(int OrderId, OrderBL order)
        {
            string path = UtilityClass.GetOrderItemsFilePath();
            using (StreamWriter f = new StreamWriter(path, true))
            {
                foreach(ClothesBL cloth in order.GetItems())
                {
                    f.WriteLine(OrderId + "," + cloth.GetId() + "," + cloth.GetType() + "," + cloth.GetGender() + "," + cloth.GetColor() + "," + cloth.GetPrice() + "," + cloth.GetQuantity());
                    f.Flush();
                }
            }
        }

        public int GetAllOrdersCount()
        {
            int count = 0;  
            string path = UtilityClass.GetOrdersFilePath();
            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public List<ClothesBL> GetListOfClothesInOrder(int orderID)
        {
            List<ClothesBL> Clothes = new List<ClothesBL>();
            string path = UtilityClass.GetOrderItemsFilePath();
            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        string[] splittedRecord = record.Split(',');
                        int oID = Convert.ToInt32(splittedRecord[0]);
                        if(orderID == oID)
                        {
                            int clothesID = Convert.ToInt32(splittedRecord[1]);
                            string type = splittedRecord[2];
                            string gender = splittedRecord[3];
                            string color = splittedRecord[4];
                            int price = Convert.ToInt32(splittedRecord[5]);
                            int quantity = Convert.ToInt32(splittedRecord[6]);
                            ClothesBL cloth = new ClothesBL(clothesID, type, gender, color, price, quantity);
                            Clothes.Add(cloth);
                        }
                    }
                }
            }

            return Clothes;
        }

        public void RetrieveOrdersOfCustomer(CustomerBL customer)
        {
            string path = UtilityClass.GetOrdersFilePath();
            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        string[] splittedRecord = record.Split(',');
                        string username = splittedRecord[5];
                        if (username == customer.GetUsername())
                        {
                            int orderId = Convert.ToInt32(splittedRecord[0]);
                            DateTime date = Convert.ToDateTime(splittedRecord[1]);
                            int price = Convert.ToInt32(splittedRecord[2]);
                            string address = splittedRecord[3];
                            string paymentType = splittedRecord[4];
                            List<ClothesBL> Clothes = GetListOfClothesInOrder(orderId);
                            OrderBL order = new OrderBL(orderId, date, Clothes, price, address, new PaymentMethodBL(paymentType), customer.GetUsername());
                            customer.AddOrderCustomer(order);
                        }
                    }
                }
            }
        }


       
    }
}
