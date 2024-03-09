using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Task1.ReportingFolder
{
    public class Reporting : IExpenseInvoice, IinventoryReport, IProfitInvoice
    {
        public delegate void ShowMessageHandler(object sender, ShowMessageEvent e);
        public event ShowMessageHandler? Message;
        public  Dictionary<ProductInfo, int> ShippedGoods { get; set; } = new Dictionary<ProductInfo, int>();
        
        private void ShowMyMessage(string message)
        {
            if (Message != null)
            {
                Message(this, new ShowMessageEvent(message));
            }
        }
        public void ExpenseInvoice(Warehouse warehouse)
        {
            foreach (var expense in warehouse.ProductDictionary)
            {
                ShowMyMessage($"Incoming: {expense.Value} {expense.Key.product.Name} on {expense.Key.Date.ToShortDateString()}");
            }
        }
        public void InventoryReport(Warehouse warehouse)
        {
            ShowMyMessage("Inventory Report:");
            foreach (var group in warehouse.ProductDictionary.GroupBy(kvp => kvp.Key.product.Name))
            {
                int totalQuantity = group.Sum(kvp => kvp.Value);
                ShowMyMessage($"{group.Key}: {totalQuantity}");
            }
        }

        public void ProfitInvoice(Warehouse warehouse)
        {
            foreach (var expense in warehouse.ReportingList.ShippedGoods)
            {
                ShowMyMessage($"Outgoing: {expense.Value} {expense.Key.product.Name} on {expense.Key.Date.ToShortDateString()}");
            }
        }
    }
}
