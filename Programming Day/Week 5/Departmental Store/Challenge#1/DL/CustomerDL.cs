using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_1
{
    internal class CustomerDL
    {
        public static List<CustomerBL> Customers = new List<CustomerBL>();

        public static void AddCustomers(UserBL u)
        {
            if(u.Role == "Customer")
            {
                CustomerBL c = CustomerUI.TakeDetailsCus(u);
                Customers.Add(c);
            }
        }

        public static CustomerBL FindCustomer(UserBL u)
        {
            foreach(CustomerBL stored in Customers)
            {
                if(u.UserName==stored.UserName)
                {
                    return stored;
                }
            }

            return null;
        }

      

       public static void StoreCustomer(string Path, CustomerBL c)
       {
           StreamWriter f = new StreamWriter(Path, true);
           string ProductNames = "";
           for(int i=0; i<c.BoughtProducts.Count-1;i++)
           {
               ProductNames = ProductNames + c.BoughtProducts[i].NameOfProduct + "~" + c.BoughtProducts[i].AvailableStock + ";";
           }
           ProductNames = ProductNames + c.BoughtProducts[c.BoughtProducts.Count-1].NameOfProduct + "~" + c.BoughtProducts[c.BoughtProducts.Count - 1].AvailableStock;

           f.WriteLine(c.UserName + "," + c.Password +"," + c.Email + "," + c.PhoneNumber + "," + c.Address + "," + ProductNames);
           f.Flush();
           f.Close();
       }

        public static bool ReadCustomers(string Path)
        {
            StreamReader f = new StreamReader(Path);
            string Record = "";
            if(File.Exists(Path))
            {
                while((Record =f.ReadLine()) !=null)
                {
                    string[] splittedRecord = Record.Split(',');
                    string Username = splittedRecord[0];
                    string Password = splittedRecord[1];
                    string Email = splittedRecord[2];
                    string PhoneNumber = splittedRecord[3];
                    string Address = splittedRecord[4];
                    string[] SplittedRecordForProducts = splittedRecord[5].Split(';');
                    List<ProductBL> Bought = new List<ProductBL>();
                    for (int i=0; i<SplittedRecordForProducts.Length; i++)
                    {
                        string[] NameQuantity = SplittedRecordForProducts[i].Split('~');
                        string Name = NameQuantity[0];
                        int Quantity = int.Parse(NameQuantity[1]);
                        ProductBL p = ProductDL.FindProduct(Name);
                        if(p != null)
                        {
                            Bought.Add(p);
                            p.SetQuantity(Quantity);
                        }

                    }

                    CustomerBL c = new CustomerBL(Username, Password, Email, PhoneNumber, Address, Bought);
                    Customers.Add(c);

                    

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
