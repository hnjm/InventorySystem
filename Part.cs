using System;
using System.Collections.Generic;

namespace InventorySystem
{
    abstract class Part
    {
        public Part()
        {
            this.partID = 0;
            this.name = "";
            this.price = 0.0;
            this.inStock = 0;
            this.min = 0;
            this.max = 0;
        }

        public Part(int partID, string name, double price, int inStock, int min, int max)
        {
            this.partID = partID;
            this.name = name;
            this.price = price;
            this.inStock = inStock;
            this.min = min;
            this.max = max;
        }

        /* Accessors */
        public int GetPartID()
        {
            return this.partID;
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

        /* Mutators */
        public void SetPartID(int partID)
        {
            this.partID = partID;
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


        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;
    }
}
