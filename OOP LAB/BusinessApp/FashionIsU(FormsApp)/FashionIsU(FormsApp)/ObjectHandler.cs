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
       private static ICartDL cartDL = new CartFH();
       private static IClothesDL clothesDL = new ClothesFH();
       private static IOrderDL orderDL = new OrderFH();
       private static IReviewDL reviewDL = new ReviewFH();
       private static IUserDL userDL = new UserFH();

        public static ICartDL GetCartDL() { return cartDL; }
        public static IClothesDL GetClothesDL() {  return clothesDL; }
        public static IOrderDL GetOrderDL() {  return orderDL; }
        public static IReviewDL GetReviewDL() {  return reviewDL; }
        public static IUserDL GetUserDL() { return userDL; }

    }
}
