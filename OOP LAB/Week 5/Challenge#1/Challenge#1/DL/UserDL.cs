using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge_1;

namespace Challenge_1
{
    internal class UserDL
    {
        public static List <UserBL> Users = new List <UserBL> ();


        public static bool AddUser(UserBL u)
        {
            if (u.Role == "Admin")
            {
                Users.Add(u);
                return true;
            }
            else if (u.Role == "Customer")
            {
                Users.Add(u);
                UserUI.TakeDetailsCus(u);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GiveUserRole(UserBL cUser) // this verifies the usernamwe
        {
            foreach (UserBL stored in Users)
            {
                if (cUser.UserName == stored.UserName && cUser.Password == stored.Password)
                {
                    return stored.Role;
                }
            }

            return null;
        }

        public static bool IsUserExists(UserBL cUser)
        {
            foreach (UserBL stored in Users)
            {
                if (cUser.UserName == stored.UserName)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
