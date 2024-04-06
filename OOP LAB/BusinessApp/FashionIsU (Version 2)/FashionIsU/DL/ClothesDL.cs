using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class ClothesDL
    {
        private static List<ClothesBL> TotalClothes = new List<ClothesBL> { };

        public static void AddClothes(ClothesBL c)
        {
            TotalClothes.Add(c);
        }

        public static bool CheckClothes()
        {
            return TotalClothes.Count > 0;
        }

        public static ClothesBL FindClothByID(int id)
        {
            foreach(ClothesBL c in TotalClothes)
            {
                if(c.GetId() == id)
                {
                    return c;
                }
            }

            return null;
        }

        public static List <ClothesBL> GetAllClothes()
        {
            return TotalClothes;
        }

        public static void DeleteCloth(ClothesBL c)
        {
            TotalClothes.Remove(c);
        }

        
    }
}
