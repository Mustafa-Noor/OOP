using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class ProductDL
    {
        public static List <ProductBL> Products = new List <ProductBL> ();

        public static void AddProduct(ProductBL p)
        {
            Products.Add (p);
        }

        public static ProductBL HighestPriceProduct()
        {
            ProductBL HighestPriceProduct = null;
            float HighestPrice = 0;
            foreach (ProductBL stored in Products) 
            {
                if (stored.ProductPrice > HighestPrice)
                {
                    HighestPrice = stored.ProductPrice;
                    HighestPriceProduct = stored;
                }
            }

            return HighestPriceProduct;
        }

        public static ProductBL FindProduct(string Name)
        {
            foreach(ProductBL stored in Products)
            {
                if(Name == stored.NameOfProduct)
                {
                    return stored;
                }
            }

            return null;
        }
            
    }
}
