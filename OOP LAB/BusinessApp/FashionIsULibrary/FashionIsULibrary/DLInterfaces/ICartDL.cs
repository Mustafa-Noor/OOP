using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsUlLibrary
{
    public interface ICartDL
    {
        void SaveItemInCart(ClothesBL cloth, CustomerBL customer);
        bool CheckItemInCart(int id, CustomerBL customer);
        void RetrieveCart(CustomerBL customer);
        void DeleteAnItem(int id, CustomerBL customer);
        void UpdateQuantity(int id, CustomerBL customer, int quantity);
        void EmptyCart(CustomerBL customer);

    }
}
