using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public static void StoreProducts(string Path, ProductBL p)
        {
            StreamWriter f = new StreamWriter(Path, true);
            f.WriteLine(p.NameOfProduct + "," + p.ProductCategory + "," + p.ProductPrice + "," + p.AvailableStock + "," + p.MinimumStockThreshold);
            f.Flush();
            f.Close();
        }

        public static bool ReadProducts(string Path)
        {
            StreamReader f = new StreamReader(Path);
            string Record;
            if(File.Exists(Path))
            {
                while((Record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = Record.Split(',');
                    string NameOfProduct = splittedRecord[0];
                    string ProductCategory = splittedRecord[1];
                    float ProductPrice = float.Parse(splittedRecord[2]);
                    int AvailableStock = int.Parse(splittedRecord[3]);
                    int MinimumStock = int.Parse(splittedRecord[4]);
                    ProductBL p = new ProductBL(NameOfProduct, ProductCategory, ProductPrice, AvailableStock, MinimumStock);
                    AddProduct(p);

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
