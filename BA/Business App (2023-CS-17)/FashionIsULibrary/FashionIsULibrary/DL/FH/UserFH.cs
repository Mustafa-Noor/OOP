using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class UserFH:IUserDL
    {
        public bool AddUser(UserBL user)
        {
            string path = UtilityClass.GetUserFilePath();
            using (StreamWriter f = new StreamWriter(path,true))
            {
                if (f != null)
                {
                    f.WriteLine(user.GetUsername() + "," + user.GetPassword() + "," + user.GetEmail() + "," + user.GetFirstName() + "," + user.GetLastName() + "," + user.GetPhoneNumber() + "," + user.GetRole());
                    f.Flush();
                    return true;
                }
            }
            return false;



        }

        public UserBL FindUser(UserBL u)
        {
            string path = UtilityClass.GetUserFilePath();

            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            string[] splittedRecord = record.Split(',');
                            string username = splittedRecord[0];
                            string password = splittedRecord[1];
                            string email = splittedRecord[2];
                            string fname = splittedRecord[3];
                            string lname = splittedRecord[4];
                            string phone = splittedRecord[5];
                            string role = splittedRecord[6];
                            if (role == "customer")
                            {
                                if (username == u.GetUsername() && password == u.GetPassword())
                                {
                                    CustomerBL customer = new CustomerBL(username, password, email, fname, lname, phone, role);
                                    return customer;
                                }

                            }
                            else
                            {
                                if (username == u.GetUsername() && password == u.GetPassword())
                                {
                                    EmployeeBL employee = new EmployeeBL(username, password, email, fname, lname, phone, role);
                                    return employee;
                                }

                            }
                        }
                    }
                }
            }

            return null; // User not found

        }

        public List<CustomerBL> GetAllCustomers()
        {
            List <CustomerBL> customers = new List<CustomerBL>();
            string path = UtilityClass.GetUserFilePath();
            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            string[] splittedRecord = record.Split(',');
                            string username = splittedRecord[0];
                            string password = splittedRecord[1];
                            string email = splittedRecord[2];
                            string fname = splittedRecord[3];
                            string lname = splittedRecord[4];
                            string phone = splittedRecord[5];
                            string role = splittedRecord[6];
                            if (role == "customer")
                            {
                                CustomerBL customer = new CustomerBL(username, password, email, fname, lname, phone, role);
                                customers.Add(customer);
                            }
                        }
                        
                    }
                }
            }

            return customers;


        }

        public bool CheckCustomersCount()
        {
            int count = 0;
            string path = UtilityClass.GetUserFilePath();
            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        string[] splittedRecord = record.Split(',');
                        string role = splittedRecord[6];
                        if (role == "customer")
                        {
                            count++;
                        }

                    }
                }
            }
            return count > 0;
           
        }

        public bool IsUserExists(UserBL cUser)
        {
            string path = UtilityClass.GetUserFilePath();

            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            string[] splittedRecord = record.Split(',');
                            string username = splittedRecord[0];


                            if (username == cUser.GetUsername())
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;

        }

        public CustomerBL FindCustomerByUsername(string username)
        {
            string path = UtilityClass.GetUserFilePath();
            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {


                            string[] splittedRecord = record.Split(',');
                            string name = splittedRecord[0];
                            string role = splittedRecord[6];

                            if (name == username && role == "customer")
                            {
                                string password = splittedRecord[1];
                                string email = splittedRecord[2];
                                string fname = splittedRecord[3];
                                string lname = splittedRecord[4];
                                string phone = splittedRecord[5];
                                return new CustomerBL(name, password, email, fname, lname, phone, role);

                            }
                        }
                    }
                }
            }

            return null;

        }

        public void UpdateProfile(UserBL user)
        {
            string path = UtilityClass.GetUserFilePath();
            List <UserBL> AllUsers = new List <UserBL>();
            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            string[] splittedRecord = record.Split(',');
                            string username = splittedRecord[0];
                            string password = splittedRecord[1];
                            string email = splittedRecord[2];
                            string fname = splittedRecord[3];
                            string lname = splittedRecord[4];
                            string phone = splittedRecord[5];
                            string role = splittedRecord[6];
                            if (role == "customer")
                            {
                                CustomerBL customer = new CustomerBL(username, password, email, fname, lname, phone, role);
                                AllUsers.Add(customer);
                            }
                            else
                            {
                                EmployeeBL employee = new EmployeeBL(username, password, email, fname, lname, phone, role);
                                AllUsers.Add(employee);
                            }
                        }
                        

                    }
                }
            }

            foreach(UserBL stored in AllUsers)
            {
                if(stored.GetUsername() == user.GetUsername())
                {
                    stored.UpdateProfile(user.GetPassword(), user.GetEmail(), user.GetFirstName(), user.GetLastName(), user.GetPhoneNumber());
                }
            }

            File.WriteAllText(path, "");

            foreach(UserBL stored in AllUsers)
            {
                AddUser(stored);
            }


        }
    }
}
