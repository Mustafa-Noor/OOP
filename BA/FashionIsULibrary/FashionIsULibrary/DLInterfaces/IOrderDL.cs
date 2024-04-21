using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsUlLibrary
{
    public interface IOrderDL
    {
        bool AddOrder(OrderBL order);
        void SaveOrderItems(int OrderId, OrderBL order);
        void RetrieveOrdersOfCustomer(CustomerBL customer);
        List<ClothesBL> GetListOfClothesInOrder(int orderID);


    }
}
