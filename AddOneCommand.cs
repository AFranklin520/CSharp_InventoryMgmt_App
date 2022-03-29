//Anthony Franklin afranklin18@cnm.edu
//FranklinP6
//Do/Undo
//03/19/2022
//AddOneCommand.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranklinP6
{
    class AddOneCommand : IInventoryCommand
    {
        public AddOneCommand(InventoryItem item, List<InventoryItem> targetList)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            TargetList = targetList ?? throw new ArgumentNullException(nameof(targetList));
        }

        public InventoryItem Item { get; set; }
        public List<InventoryItem> TargetList { get; set; }

        public void Do()
        {
            TargetList.Add(Item);
        }

        public void Undo()
        {
            TargetList.Remove(Item);
        }
    }
}
