//Anthony Franklin afranklin18@cnm.edu
//FranklinP6
//Do/Undo
//03/19/2022
//InventoryCommand.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranklinP6
{
    interface IInventoryCommand
    {
        void Do();
        void Undo();
    }
}
