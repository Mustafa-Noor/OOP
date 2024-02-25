using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class ProductBL
    {
       public string NameOfProduct;
       public string ProductCategory;
       public float ProductPrice;
       public int AvailableStock;
       public int MinimumStockThreshold;

        public ProductBL(string nameOfProduct, string productCategory, float productPrice, int availableStock, int minimumStockThreshold)
        {
            NameOfProduct = nameOfProduct;
            ProductCategory = productCategory;
            ProductPrice = productPrice;
            AvailableStock = availableStock;
            MinimumStockThreshold = minimumStockThreshold;
        }

        public ProductBL(ProductBL otherProduct)
        {
            NameOfProduct = otherProduct.NameOfProduct;
            ProductCategory = otherProduct.ProductCategory;
            ProductPrice = otherProduct.ProductPrice;
            AvailableStock = otherProduct.AvailableStock;
            MinimumStockThreshold = otherProduct.MinimumStockThreshold;
        }

        public float CalculateTax()
        {
            if (ProductCategory == "Grocery")
            {
                return ProductPrice * 0.1f;
            }
            else if (ProductCategory == "Fruit")
            {
                return ProductPrice * 0.05f;
            }
            else
            {
                return ProductPrice * 0.15f;
            }
        }

        public bool IsAvailableToBuy(int Quantity)
        {
            if(Quantity>0 && Quantity<=AvailableStock)
            { return true; }
            return false;
        }

        public void SetQuantity(int Quantity)
        {
            this.AvailableStock = Quantity;
        }

        public void DropQuantity(int Quantity)
        {
            AvailableStock -= Quantity;
        }

        public float CalculateTotal()
        {
            return ProductPrice*AvailableStock - CalculateTax()*AvailableStock;
        }
    }
}
