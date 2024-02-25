using System;
using System.Collections.Generic;
using System.IO;
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



       

        public static void StoreUser(string Path, UserBL u)
        {
            StreamWriter f = new StreamWriter(Path, true);
            f.WriteLine(u.UserName + "," + u.Password + "," + u.Role);
            f.Flush();
            f.Close();
        }

        public static bool ReadUsers(string Path)
        {
            StreamReader f = new StreamReader(Path);
            string Record;
            if (File.Exists(Path))
            {
                while ((Record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = Record.Split(',');
                    string UserName = splittedRecord[0];
                    string Password = splittedRecord[1];
                    string Role = splittedRecord[2];
                    UserBL u = new UserBL(UserName, Password, Role);
                    AddUser(u);

                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }







    }
}
