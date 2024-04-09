using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsUlLibrary
{
    public interface IClothesDL
    {
        bool AddClothes(ClothesBL c);
        bool CheckClothes();
        ClothesBL FindClothByID(int id);
        void ChangeQuantity(int id, int quantity);
        void UpdateCloth(ClothesBL cloth);
        List<ClothesBL> GetAllClothes();
        bool DeleteCloth(ClothesBL c);
        bool CheckClothExistence(ClothesBL c);
        bool CheckClothExistenceByQuantity(ClothesBL c);

    }
}
