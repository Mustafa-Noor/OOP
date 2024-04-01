using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInUp.BL;

namespace SignInUp.DL
{
    internal class MUserDL
    {
        private static List <MUserBL> Users = new List <MUserBL> ();

        public static void AddUserIntoList(MUserBL user)
        {
            Users.Add (user);
        }

        public static MUserBL SignIn(MUserBL user)
        {
            foreach(MUserBL u in Users)
            {
                if(u.getUserName() == user.getUserName() && u.getUserPassword() == user.getUserPassword())
                {
                    return u;
                }
            }
            return null;
        }

        public static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for(int x=0; x<record.Length; x++)
            {
                if (record[x] == ',') {  comma++; }
                else if(comma == field)
                {
                    item = item + record[x];
                }
                
            }
            return item;
            
        }

        public static bool ReadDataFromFile(string path)
        {
            if(File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while((record = fileVariable.ReadLine()) != null)
                {
                    string userName = ParseData(record, 1);
                    string password = ParseData(record, 2);
                    string role = ParseData(record, 3);
                    MUserBL user = new MUserBL(userName, password, role);
                    AddUserIntoList(user);
                }
                fileVariable.Close();
                return true;

            }
            else
            {
                return false;
            }
        }

        public static void StoreUserIntoFile(MUserBL user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            Console.WriteLine(user.getUserName() + "," + user.getUserPassword() + "," + user.getUserRole());
            file.Flush();
            file.Close();       
        }
    }

}
