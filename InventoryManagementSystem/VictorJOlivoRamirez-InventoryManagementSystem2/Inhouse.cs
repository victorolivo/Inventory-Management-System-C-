using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictorJOlivoRamirez_InventoryManagementSystem2
{
    class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int id, string name, int amount, decimal price, int minVal, int maxVal, int machineID) : base (id, name, amount, price, minVal, maxVal)
        {
            MachineID = machineID;
        }

    }
}
