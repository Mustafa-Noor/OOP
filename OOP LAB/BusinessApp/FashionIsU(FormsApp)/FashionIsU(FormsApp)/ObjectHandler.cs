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
       private static ICartDL cartDL = CartDB.GetCartDB(UtilityClass.GetConnectionString());
       private static IClothesDL clothesDL = ClothesDB.GetClothesDB(UtilityClass.GetConnectionString());
       private static IOrderDL orderDL = OrderDB.GetOrderDB(UtilityClass.GetConnectionString());
       private static IReviewDL reviewDL = ReviewDB.GetReviewDB(UtilityClass.GetConnectionString());
       private static IUserDL userDL = UserDB.GetUserDB(UtilityClass.GetConnectionString());

        public static ICartDL GetCartDL() { return cartDL; }
        public static IClothesDL GetClothesDL() {  return clothesDL; }
        public static IOrderDL GetOrderDL() {  return orderDL; }
        public static IReviewDL GetReviewDL() {  return reviewDL; }
        public static IUserDL GetUserDL() { return userDL; }

    }
}
