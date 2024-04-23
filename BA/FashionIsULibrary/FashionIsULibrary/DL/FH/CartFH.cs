using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class CartFH : ICartDL
    {
        // this is the for singleton functionality
        private static CartFH CartFHInstance; // this if the instance
        private string FilePath = "";
        private CartFH(string FilePath)
        {
            this.FilePath = FilePath;
        }
        public static CartFH GetCartFH(string filePath)  //get the instance
        {
            if (CartFHInstance == null)
            {
                CartFHInstance = new CartFH(filePath);
            }
            return CartFHInstance;
        }

        public void SaveItemInCart(ClothesBL cloth, CustomerBL customer) // save an item of clothing in the cart file
        {
            
            if (!CheckItemInCart(cloth.GetId(), customer))
            {
                using (StreamWriter f = new StreamWriter(FilePath, true))
                {
                    f.WriteLine(customer.GetUsername() + "," + cloth.GetId() + "," + cloth.GetType() + "," + cloth.GetGender() + "," + cloth.GetColor() + "," + cloth.GetPrice() + "," + cloth.GetQuantity());
                    f.Flush();

                }
            }

        }

        public bool CheckItemInCart(int id, CustomerBL customer) // check the existence of an item in cart
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
                            int clothId = Convert.ToInt32(splittedRecord[1]);


                            if (username == customer.GetUsername() && clothId == id)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public void RetrieveCart(CustomerBL customer) //loads the cart of the customer
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
                            if (username == customer.GetUsername())
                            {

                                int clothesID = Convert.ToInt32(splittedRecord[1]);
                                string type = splittedRecord[2];
                                string gender = splittedRecord[3];
                                string color = splittedRecord[4];
                                int price = Convert.ToInt32(splittedRecord[5]);
                                int quantity = Convert.ToInt32(splittedRecord[6]);
                                ClothesBL cloth = new ClothesBL(clothesID, type, gender, color, price, quantity);
                                customer.GetCart().AddIntoCart(cloth);
                            }
                        }

                    }
                }
            }
        }


        public List<ClothesBL> GetAllClothesInCart(CustomerBL customer) // get the list of clothes in the cart
        {
            List<ClothesBL> AllClothes = new List<ClothesBL>();
            
            if (File.Exists(FilePath))
            {
                List<string> linesToRemove = new List<string>();

                using (StreamReader f = new StreamReader(FilePath))
                {
                    
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(record))
                        {
                            string[] splittedRecord = record.Split(',');
                            string username = splittedRecord[0];
                            if (username == customer.GetUsername())
                            {
                                int clothesID = Convert.ToInt32(splittedRecord[1]);
                                string type = splittedRecord[2];
                                string gender = splittedRecord[3];
                                string color = splittedRecord[4];
                                int price = Convert.ToInt32(splittedRecord[5]);
                                int quantity = Convert.ToInt32(splittedRecord[6]);
                                ClothesBL cloth = new ClothesBL(clothesID, type, gender, color, price, quantity);
                                AllClothes.Add(cloth);
                                linesToRemove.Add(record);

                            }
                        }

                    }
                }

                if (linesToRemove.Count > 0)
                {
                    string[] allLines = File.ReadAllLines(FilePath);
                    List<string> remainingLines = new List<string>();

                    foreach (string line in allLines)
                    {
                        if (!linesToRemove.Contains(line))
                        {
                            remainingLines.Add(line);
                        }
                    }

                    File.WriteAllLines(FilePath, remainingLines);
                }
            }

            return AllClothes;
        }

        public void DeleteAnItem(int id, CustomerBL customer) // deletes an item of cloth
        {
            
            List<ClothesBL> AllClothes = GetAllClothesInCart(customer);
            for (int i = AllClothes.Count - 1; i >= 0; i--)
            {
                if (AllClothes[i].GetId() == id)
                {
                    AllClothes.RemoveAt(i);
                }
            }

            foreach (ClothesBL stored in AllClothes)
            {
                SaveItemInCart(stored, customer);
            }
        }

        public void UpdateQuantity(int id, CustomerBL customer, int quantity) // updates the quantity of an item
        {
            
            List<ClothesBL> AllClothes = GetAllClothesInCart(customer);
            foreach (ClothesBL stored in AllClothes)
            {
                if (stored.GetId() == id)
                {
                    stored.SetQuantity(quantity);
                }
            }

            foreach (ClothesBL stored in AllClothes)
            {
                SaveItemInCart(stored, customer);
            }

        }

        public void EmptyCart(CustomerBL customer) // empties the cart
        {
            if (File.Exists(FilePath))
            {
                List<string> linesToRemove = new List<string>();

                using (StreamReader f = new StreamReader(FilePath))
                {

                    string record;
                    while ((record = f.ReadLine()) != null)
                    {

                        string[] splittedRecord = record.Split(',');
                        string username = splittedRecord[0];
                        if (username == customer.GetUsername())
                        {
                            
                            linesToRemove.Add(record);

                        }

                    }
                }

                if (linesToRemove.Count > 0)
                {
                    string[] allLines = File.ReadAllLines(FilePath);
                    List<string> remainingLines = new List<string>();

                    foreach (string line in allLines)
                    {
                        if (!linesToRemove.Contains(line))
                        {
                            remainingLines.Add(line);
                        }
                    }

                    File.WriteAllLines(FilePath, remainingLines);
                }
            }

            
        }


    }
}
