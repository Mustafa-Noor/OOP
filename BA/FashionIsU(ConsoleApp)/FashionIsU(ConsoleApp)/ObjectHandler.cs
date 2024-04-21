using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU_ConsoleApp_
{
    internal class ObjectHandler
    {
        /*
        private static ICartDL cartDL = CartFH.GetCartFH(UtilityClass.GetCartsFilePath());
        private static IClothesDL clothesDL = ClothesFH.GetClothesFH(UtilityClass.GetClothesFilePath());
        private static IOrderDL orderDL = OrderFH.GetOrderFH(UtilityClass.GetOrdersFilePath());
        private static IReviewDL reviewDL = ReviewFH.GetReviewFH(UtilityClass.GetReviewsFilePath());
        private static IUserDL userDL = UserFH.GetUserFH(UtilityClass.GetUserFilePath());
        */

        
        private static ICartDL cartDL = CartDB.GetCartDB(UtilityClass.GetConnectionString());
        private static IClothesDL clothesDL = ClothesDB.GetClothesDB(UtilityClass.GetConnectionString());
        private static IOrderDL orderDL = OrderDB.GetOrderDB(UtilityClass.GetConnectionString());
        private static IReviewDL reviewDL = ReviewDB.GetReviewDB(UtilityClass.GetConnectionString());
        private static IUserDL userDL = UserDB.GetUserDB(UtilityClass.GetConnectionString());
        

        public static ICartDL GetCartDL() { return cartDL; }
        public static IClothesDL GetClothesDL() { return clothesDL; }
        public static IOrderDL GetOrderDL() { return orderDL; }
        public static IReviewDL GetReviewDL() { return reviewDL; }
        public static IUserDL GetUserDL() { return userDL; }
    }
}
