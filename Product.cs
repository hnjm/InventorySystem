using System;
using System.Collections.Generic;

namespace InventorySystem
{
    class Product
    {
        /* Constructors */
        public Product()
        {
            this.associatedParts = new List<Part>();
            this.productID = 0;
            this.name = "";
            this.price = 0.0;
            this.inStock = 0;
            this.min = 0;
            this.max = 0;
        }

        public Product(int productID, string name, double price, int inStock, int min, int max)
        {
            this.associatedParts = new List<Part>();
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.inStock = inStock;
            this.min = min;
            this.max = max;
        }

        /* Accessors */
        public int GetProductID()
        {
            return this.productID;
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public int GetInStock()
        {
            return this.inStock;
        }

        public int GetMin()
        {
            return this.min;
        }

        public int GetMax()
        {
            return this.max;
        }

        public List<Part> GetAssociatedParts()
        {
            return this.associatedParts;
        }

        public Part LookupAssociatedPart(int partID)
        {           
            foreach (Part part in this.associatedParts)
            {
                if(part.GetPartID() == partID)
                {
                    return part;
                }
            }
            return null;
        }

        /* Mutators */
        public void SetProductID(int productID)
        {
            this.productID = productID;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void SetInStock(int inStock)
        {
            this.inStock = inStock;
        }

        public void SetMin(int min)
        {
            this.min = min;
        }

        public void SetMax(int max)
        {
            this.max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            this.associatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
        }

        /* State variables */
        private List<Part> associatedParts;
        private int productID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;
    }
}
