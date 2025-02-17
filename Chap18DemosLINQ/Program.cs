using ConsoleLibrary;

namespace Chap18DemosLINQ;

internal class Program
{
    static void Main(string[] args)
    {
        MyConsole.PrintLine("Welcome to LINQ!\n");


        //inital array p 581
        int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //query for even numbers
        var evenNbrQuery = from number in numbers
                           where number % 2 == 0
                           orderby number descending
                           select number;
        //execute query - loop through evenNbrQUery (results) and store in string
        string evenNbrResult = "";
        foreach (var nbr in evenNbrQuery)
        {
            evenNbrResult += nbr + " ";
        }
        MyConsole.Print("Even numbers: " + evenNbrResult);

        //p. 583

        decimal[] salesTotals = { 1286.45m, 2433.49m, 2893.85m, 2094.53m };
        var salesList = from sales in salesTotals
                        select sales;
        decimal sum = 0;
        foreach (var sales in salesTotals) { sum += sales; }
        MyConsole.PrintLine("Total Sales: " + sum.ToString("c"));

        //***583 Invoices List
        List<Invoice> invoicesList = InvoiceDB.GetInvoices();
        //foreach (var invoice in invoicesList)
        //{
        //    MyConsole.PrintLine(invoice.ToString());
        //}
        var invoices = from invoice in invoicesList
                       select invoice;
        foreach (var invoice in invoices)
        {
            MyConsole.PrintLine(invoice.ToString());
        }
        //***

        //585
        salesList = from sales in salesTotals
                    where sales > 2000
                    select sales;
        string salesDisplay = "";
        foreach (var sales in salesList)
            //{?
            salesDisplay += sales.ToString("c") + "|";
        MyConsole.PrintLine(salesDisplay);
        //}?

        MyConsole.PrintLine("---- Invoices with totals over $150 ----");
        invoices = from invoice in invoicesList
                   where invoice.InvoiceTotal > 150
                   select invoice;
        string invoiceDisplay = "";
        foreach (var invoice in invoices)
        {
            invoiceDisplay += invoice.InvoiceTotal.ToString("c") + "|";
        }
        MyConsole.PrintLine(invoiceDisplay);

        MyConsole.PrintLine("==== join in LINQ ====");

        List<Customer> customerList = CustomerDB.GetCustomers();

        //join
        var invoices2 = from invoice in invoicesList
                        join customer in customerList
                        on invoice.CustomerID equals customer.CustomerID
                        where invoice.InvoiceTotal > 150
                        orderby customer.Name, invoice.InvoiceTotal descending
                        select new { customer.Name, invoice.InvoiceTotal };
        invoiceDisplay = "Customer Name\t\tInvoice Amount\n";
        foreach (var i in invoices2)
        {
            invoiceDisplay += i.Name + "\t\t" + i.InvoiceTotal.ToString("c") + "\n";
        }

        MyConsole.PrintLine(invoiceDisplay);


        //p.593 - extension methods
        //list of invoices > 150 ordered by customerID, then by InvoiceTotal (desc)
        var invoices3 = invoicesList.
            Where(i => i.InvoiceTotal > 150).
            OrderBy(i => i.CustomerID).
            ThenByDescending(i => i.InvoiceTotal).
            Select(i => new { i.CustomerID, i.InvoiceTotal });

        foreach (var i in invoices3)
        {  MyConsole.PrintLine ($"{i.CustomerID}, {i.InvoiceTotal:c}"); 
        }

        MyConsole.PrintLine("\nBye");
    }
}
