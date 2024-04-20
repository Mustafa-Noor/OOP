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
        public void SaveItemInCart(ClothesBL cloth, CustomerBL customer)
        {
            string path = UtilityClass.GetCartsFilePath();
            if (!CheckItemInCart(cloth.GetId(), customer))
            {
                using (StreamWriter f = new StreamWriter(path, true))
                {
                    f.WriteLine(customer.GetUsername() + "," + cloth.GetId() + "," + cloth.GetType() + "," + cloth.GetGender() + "," + cloth.GetColor() + "," + cloth.GetPrice() + "," + cloth.GetQuantity());
                    f.Flush();

                }
            }

        }

        public bool CheckItemInCart(int id, CustomerBL customer)
        {
            string path = UtilityClass.GetCartsFilePath();

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

        public void RetrieveCart(CustomerBL customer)
        {
            string path = UtilityClass.GetCartsFilePath();
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


        public List<ClothesBL> GetAllClothesInCart(CustomerBL customer)
        {
            List<ClothesBL> AllClothes = new List<ClothesBL>();
            string path = UtilityClass.GetCartsFilePath();
            if (File.Exists(path))
            {
                List<string> linesToRemove = new List<string>();

                using (StreamReader f = new StreamReader(path))
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
                    string[] allLines = File.ReadAllLines(path);
                    List<string> remainingLines = new List<string>();

                    foreach (string line in allLines)
                    {
                        if (!linesToRemove.Contains(line))
                        {
                            remainingLines.Add(line);
                        }
                    }

                    File.WriteAllLines(path, remainingLines);
                }
            }

            return AllClothes;
        }

        public void DeleteAnItem(int id, CustomerBL customer)
        {
            string path = UtilityClass.GetCartsFilePath();
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

        public void UpdateQuantity(int id, CustomerBL customer, int quantity)
        {
            string path = UtilityClass.GetCartsFilePath();
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

        public void EmptyCart(CustomerBL customer)
        {
            
            string path = UtilityClass.GetCartsFilePath();
            if (File.Exists(path))
            {
                List<string> linesToRemove = new List<string>();

                using (StreamReader f = new StreamReader(path))
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
                    string[] allLines = File.ReadAllLines(path);
                    List<string> remainingLines = new List<string>();

                    foreach (string line in allLines)
                    {
                        if (!linesToRemove.Contains(line))
                        {
                            remainingLines.Add(line);
                        }
                    }

                    File.WriteAllLines(path, remainingLines);
                }
            }

            
        }


    }
}
