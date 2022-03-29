//Anthony Franklin afranklin18@cnm.edu
//FranklinP6
//Do/Undo
//03/19/2022
//MainWindow.xaml.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FranklinP6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<InventoryItem> inventoryItems;
        List<IInventoryCommand> commands;
        public MainWindow()
        {
            inventoryItems = new List<InventoryItem>();
            commands = new List<IInventoryCommand>();            
            InitializeComponent();
            lbxInventory.ItemsSource = inventoryItems;
        }

        private void onAddOne(object sender, RoutedEventArgs e)
        {         
            InventoryItem item = new InventoryItem(txbItemName.Text);
            txbItemName.Clear();
            AddOneCommand addOne = new AddOneCommand(item, inventoryItems);
            addOne.Do();
            commands.Add(addOne);
            lbxInventory.Items.Refresh();
        }

        private void onRandClick(object sender, RoutedEventArgs e)
        {
            InventoryItem item = new InventoryItem(txbItemName.Text);
            txbItemName.Clear();
            AddMultipleCommand addMultiple = new AddMultipleCommand(item, inventoryItems);
            addMultiple.Do();
            commands.Add(addMultiple);
            lbxInventory.Items.Refresh();
        }

        private void onUndoClick(object sender, RoutedEventArgs e)
        {
            commands.Last().Undo();
            commands.Remove(commands.Last());
            lbxInventory.Items.Refresh();
        }
    }
}
