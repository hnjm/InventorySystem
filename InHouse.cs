using System;
using System.Collections.Generic;

namespace InventorySystem
{
    class InHouse
    {
        public InHouse() : base()
        {
            this.machineID = 0;
        }

        public InHouse(int partID, string name, double price, int inStock, int min, int max, int machineID) : base(partID, name, price, inStock, min, max, machineID)
        {
            this.machineID = machineID;
        }

        /* Accessors */
        public int GetMachineID()
        {
            return this.machineID;
        }

        /* Mutators */
        public void SetMachineID(int machineID)
        {
            this.machineID = machineID;
        }

        private int machineID;
    }
}