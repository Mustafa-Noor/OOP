using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU_FormsApp_
{
    public class ObjecHandler
    {
        private static ICartDL cartDL = new CartDL(); 
        private static IClothesDL clothesDL = new ClothesDL();
        private static IOrderDL orderDL = new OrderDL();
        private static IReviewDL reviewDL = new ReviewDL();
        private static IUserDL userDL = new UserDL();


        public static ICartDL GetCartDL()
        {
            return cartDL;
        }

        public static IClothesDL GetClothesDL()
        {
            return clothesDL;
        }

        public static IOrderDL GetOrderDL()
        {
            return orderDL;
        }

        public static IReviewDL GetReviewDL()
        {
            return reviewDL;
        }

        public static IUserDL GetUserDL()
        {
            return userDL;
        }


    }
}
