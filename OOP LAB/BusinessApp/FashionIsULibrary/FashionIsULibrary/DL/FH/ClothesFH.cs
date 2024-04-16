
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsUlLibrary;

namespace FashionIsU
{
    public class ClothesFH : IClothesDL
    {
        private static int ClothesId = 0;
        public bool AddClothes(ClothesBL c)
        {
            string path = UtilityClass.GetClothesFilePath();
            ClothesId = GetAllClothes().Max(cloth => cloth.GetId())+1;
            using (StreamWriter f = new StreamWriter(path, true))
            {
                if (f != null)
                {

                    f.WriteLine(ClothesId + "," + c.GetType() + "," + c.GetGender() + "," + c.GetColor() + "," + c.GetPrice() + "," + c.GetQuantity());
                    f.Flush();
                    return true;
                }
            }
            return false;
        }

        public bool CheckClothes()
        {
            int count = 0;
            string path = UtilityClass.GetClothesFilePath();
            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
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

        public List<ClothesBL> GetAllClothes()
        {
            List<ClothesBL> Clothes = new List<ClothesBL>();
            string path = UtilityClass.GetClothesFilePath();
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
                            int cID = Convert.ToInt32(splittedRecord[0]);
                            string type = splittedRecord[1];
                            string gender = splittedRecord[2];
                            string color = splittedRecord[3];
                            int price = Convert.ToInt32(splittedRecord[4]);
                            int quantity = Convert.ToInt32(splittedRecord[5]);

                            ClothesBL cloth = new ClothesBL(cID, type, gender, color, price, quantity);
                            Clothes.Add(cloth);
                        }

                    }
                }
            }

            return Clothes;
        }

        public ClothesBL FindClothByID(int id)
        {
            string path = UtilityClass.GetClothesFilePath();

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
                            int cID = Convert.ToInt32(splittedRecord[0]);
                            string type = splittedRecord[1];
                            string gender = splittedRecord[2];
                            string color = splittedRecord[3];
                            int price = Convert.ToInt32(splittedRecord[4]);
                            int quantity = Convert.ToInt32(splittedRecord[5]);

                            if (id == cID)
                            {

                                ClothesBL cloth = new ClothesBL(cID, type, gender, color, price, quantity);
                                return cloth;

                            }
                        }

                    }
                }
            }

            return null;
        }

        public bool CheckClothExistence(ClothesBL c)
        {
            string path = UtilityClass.GetClothesFilePath();

            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string record;
                    while ((record = f.ReadLine()) != null)
                    {
                        
                        
                            string[] splittedRecord = record.Split(',');
                            string type = splittedRecord[1];
                            string gender = splittedRecord[2];
                            string color = splittedRecord[3];

                            if (type.ToLower() == c.GetType().ToLower() && gender.ToLower() == c.GetGender().ToLower() && color.ToLower() == c.GetColor().ToLower())
                            {

                                return true;

                            }

                        

                    }
                }
            }

            return false;
        }

        public bool CheckClothExistenceByQuantity(ClothesBL c)
        {
            string path = UtilityClass.GetClothesFilePath();

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
                            string type = splittedRecord[1];
                            string gender = splittedRecord[2];
                            string color = splittedRecord[3];
                            int quantity = Convert.ToInt32(splittedRecord[5]);

                            if (type.ToLower() == c.GetType().ToLower() && gender.ToLower() == c.GetGender().ToLower() && color.ToLower() == c.GetColor().ToLower() && quantity == c.GetQuantity())
                            {

                                return true;

                            }

                        }

                    }
                }
            }

            return false;
        }

        public void ChangeQuantity(int id, int quantity)
        {
            string path = UtilityClass.GetClothesFilePath();
            List<ClothesBL> AllClothes = GetAllClothes();
            foreach (ClothesBL stored in AllClothes)
            {
                if (stored.GetId() == id)
                {
                    stored.SetQuantity(quantity);
                }
            }

            File.WriteAllText(path, "");

            foreach (ClothesBL stored in AllClothes)
            {
                using (StreamWriter f = new StreamWriter(path, true))
                {

                    f.WriteLine(stored.GetId() + "," + stored.GetType() + "," + stored.GetGender() + "," + stored.GetColor() + "," + stored.GetPrice() + "," + stored.GetQuantity());
                    f.Flush();

                }
            }
        }

        public void UpdateCloth(ClothesBL cloth)
        {
            string path = UtilityClass.GetClothesFilePath();
            List<ClothesBL> AllClothes = GetAllClothes();
            foreach (ClothesBL stored in AllClothes)
            {
                if (stored.GetId() == cloth.GetId())
                {
                    stored.UpdateCloth(cloth);
                }
            }

            File.WriteAllText(path, "");

            foreach (ClothesBL stored in AllClothes)
            {
                using (StreamWriter f = new StreamWriter(path, true))
                {

                    f.WriteLine(stored.GetId() + "," + stored.GetType() + "," + stored.GetGender() + "," + stored.GetColor() + "," + stored.GetPrice() + "," + stored.GetQuantity());
                    f.Flush();

                }
            }
        }

        public bool DeleteCloth(ClothesBL c)
        {
            string path = UtilityClass.GetClothesFilePath();
            List<ClothesBL> AllClothes = GetAllClothes();

            bool clothDeleted = false;

            foreach (ClothesBL stored in AllClothes)
            {
                if (stored.GetId() == c.GetId())
                {
                    AllClothes.Remove(stored);
                    clothDeleted = true;
                    break;
                }
            }

            if (clothDeleted)
            {
                File.WriteAllText(path, "");
                foreach (ClothesBL stored in AllClothes)
                {
                    using (StreamWriter f = new StreamWriter(path, true))
                    {
     
                            f.WriteLine(stored.GetId() + "," + stored.GetType() + "," + stored.GetGender() + "," + stored.GetColor() + "," + stored.GetPrice() + "," + stored.GetQuantity());
                            f.Flush();

                    }
                }
            }

            return clothDeleted;
        }






    }
}
