﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsUlLibrary
{
    public interface IReviewDL
    {
        bool AddReviews(ReviewBL rev, ClothesBL cloth);
        List<ReviewBL> RetrieveReviews(int id);

    }
}
