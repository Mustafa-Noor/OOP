using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU_FormsApp_
{
    internal class ObjectHandler
    {
       private static ICartDL cartDL = new CartDB();
       private static IClothesDL clothesDL = new ClothesDB();
       private static IOrderDL orderDL = new OrderDB();
       private static IReviewDL reviewDL = new ReviewDB();
       private static IUserDL userDL = new UserDB();

        public static ICartDL GetCartDL() { return cartDL; }
        public static IClothesDL GetClothesDL() {  return clothesDL; }
        public static IOrderDL GetOrderDL() {  return orderDL; }
        public static IReviewDL GetReviewDL() {  return reviewDL; }
        public static IUserDL GetUserDL() { return userDL; }

    }
}
