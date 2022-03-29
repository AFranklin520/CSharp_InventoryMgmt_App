//Anthony Franklin afranklin18@cnm.edu
//FranklinP6
//Do/Undo
//03/19/2022
//AddMultipleCommands.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranklinP6
{
    class AddMultipleCommand : IInventoryCommand
    {
        private int number;
        public InventoryItem Item { get; set; }
        public List<InventoryItem> TargetList { get; set; }

        public AddMultipleCommand(InventoryItem item, List<InventoryItem> targetList)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            TargetList = targetList ?? throw new ArgumentNullException(nameof(targetList));
        }

        

        public void Do()
        {
            number = new Random().Next(1,6);
            for(int i = 0; i < number; i++)
            {
                TargetList.Add(Item);
            }
        }

        public void Undo()
        {
            for (int i = 0; i < number; i++)
            {
                TargetList.Remove(Item);
            }
        }
    }
}
