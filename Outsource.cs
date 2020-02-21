using System;
using System.Collections.Generic;

namespace InventorySystem
{
    class Outsource : Part
    {
        public Outsource() : base()
        {
            this.companyName = "";
        }

        public Outsource(int partID, string name, double price, int inStock, int min, int max, string companyName) : base(partID, name, price, inStock, min, max)
        {
            this.companyName = companyName;
        }

        /* Accessors */
        public string GetCompanyName()
        {
            return this.companyName;
        }

        /* Mutators */
        public void SetCompanyName(string companyName)
        {
            this.companyName = companyName;
        }

        private string companyName;
    }
}