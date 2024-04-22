﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class CustomerFH:ICustomerDL
    {
        private static CustomerFH CustomerFHInstance;
        private string FilePath = "";
        private CustomerFH(string FilePath)
        {
            this.FilePath = FilePath;
        }
        public static CustomerFH GetCustomerFH(string filePath)
        {
            if (CustomerFHInstance == null)
            {
                CustomerFHInstance = new CustomerFH(filePath);
            }
            return CustomerFHInstance;
        }
        public bool AddCustomer(CustomerBL customer)
        {
            using (StreamWriter f = new StreamWriter(FilePath, true))
            {
                if (f != null)
                {
                    f.WriteLine(customer.GetUsername() + "," + customer.GetPassword() + "," + customer.GetEmail() + "," + customer.GetFirstName() + "," + customer.GetLastName() + "," + customer.GetPhoneNumber() + "," + customer.GetRole());
                    f.Flush();
                    return true;
                }
            }
            return false;
        }

        public void UpdateProfile(CustomerBL customer)
        {
            List<CustomerBL> Customers = GetAllCustomers();

            foreach (CustomerBL stored in Customers)
            {
                if (stored.GetUsername() == customer.GetUsername())
                {
                    stored.UpdateProfile(customer.GetPassword(), customer.GetEmail(), customer.GetFirstName(), customer.GetLastName(), customer.GetPhoneNumber());
                }
            }

            File.WriteAllText(FilePath, "");

            foreach (CustomerBL stored in Customers)
            {
                AddCustomer(stored);
            }
        }

        public bool IsCustomerExists(string username)
        {
            if(File.Exists(FilePath))
            {
                using (StreamReader f = new StreamReader(FilePath))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            string[] splittedRecord = record.Split(',');
                            string name = splittedRecord[0];


                            if (name == username)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public CustomerBL FindCustomer(UserBL user)
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader f = new StreamReader(FilePath))
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
                            if (username == user.GetUsername() && password == user.GetPassword())
                            {
                                CustomerBL customer = new CustomerBL(username, password, email, fname, lname, phone, role);
                                return customer;
                            }

                        }
                    }
                }
            }

            return null;
        }

        public List<CustomerBL> GetAllCustomers()
        {
            List<CustomerBL> Customers = new List<CustomerBL>();
            if (File.Exists(FilePath))
            {
                using (StreamReader f = new StreamReader(FilePath))
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

                            CustomerBL cus = new CustomerBL(username, password, email, fname, lname, phone, role);
                            Customers.Add(cus);
                        }


                    }
                }
            }

            return Customers;
        }

        public bool CheckCustomersCount()
        {
            int count = 0;
            if (File.Exists(FilePath))
            {
                using (StreamReader f = new StreamReader(FilePath))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            count++;
                        }
                            
                    }
                }
            }
            return count > 0;
        }
        public CustomerBL FindCustomerByUsername(string username)
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader f = new StreamReader(FilePath))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            string[] splittedRecord = record.Split(',');
                            string name = splittedRecord[0];
                            if (name == username)
                            {
                                string password = splittedRecord[1];
                                string email = splittedRecord[2];
                                string fname = splittedRecord[3];
                                string lname = splittedRecord[4];
                                string phone = splittedRecord[5];
                                string role = splittedRecord[6];
                                return new CustomerBL(name, password, email, fname, lname, phone, role);

                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}
