//Anthony Franklin afranklin18@cnm.edu
//FranklinP6
//Do/Undo
//03/19/2022
//InventoryItem.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranklinP6
{
    class InventoryItem
    {
        public InventoryItem(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
