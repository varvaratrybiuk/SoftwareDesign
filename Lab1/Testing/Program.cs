using Task1;
using Task1.ReportingFolder;

Product Barbie = new Product("Barbie", new Task1.MoneyFolder.MoneyUAH(500, 0), "sm", "Barbie girl");
Product Ken = new Product("Ken", new Task1.MoneyFolder.MoneyUSD(20, 0), "sm", "Ken enough");
ToysWarehouse toysWarehouse = new ToysWarehouse(Barbie, 10, new DateTime(2024, 2, 12));
toysWarehouse.Message += ShowMessage;
toysWarehouse.GetProductInfo("Barbie");
toysWarehouse.AddProduct(Barbie, 30, new DateTime(2024, 5, 12));
toysWarehouse.AddProduct(Ken, 20, new DateTime(2024, 3, 17));
toysWarehouse.GetProductInfo("Ken");
toysWarehouse.SendProduct("Ken", 10);
toysWarehouse.Message -= ShowMessage;
Reporting reporting = new Reporting();
reporting.Message += ShowMessage;
reporting.ProfitInvoice(toysWarehouse);
reporting.InventoryReport(toysWarehouse);
reporting.ExpenseInvoice(toysWarehouse);
reporting.Message -= ShowMessage;
Console.WriteLine(Barbie.Price.show());
Barbie.IncreasePrice(200);
Console.WriteLine(Barbie.Price.show());
static void ShowMessage(object sender, ShowMessageEvent e)
{
    Console.WriteLine(e.Message);
}

