using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jabin_Choi_Excercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Invoice> invoice = new List<Invoice> ()
            {
                new Invoice(87, "Electric Sander", 7, 57.98M),
                new Invoice(24, "Power Saw", 18, 99.99M),
                new Invoice(7, "Sledge Hammer", 11, 21.50M),
                new Invoice(77, "Hammer", 76, 11.99M),
                new Invoice(39, "Lawn Mower", 3, 79.50M),
                new Invoice(68, "Screw Driver", 106, 6.99M),
                new Invoice(56, "Jig saw", 21, 11.00M)
            };


            // a) Use LINQ to select from each Invoice the PartDescription and value of the Invoice ( i.e. Quantity * Price). 
            //    Name the calculated column as InvoiceTotal.Order the results by invoice value in ascending order.
            //    [Hint: use let]
            var calculatedInvoiceTotal =
                    from i in invoice
                    let InvoiceTotal = i.Quantity * i.Price
                    orderby InvoiceTotal ascending
                    select new { i.PartDescription, InvoiceTotal };

            Console.WriteLine("Part Description and Total Invoice (Quantity * Price)");
            if (calculatedInvoiceTotal.Any())
                foreach (var item in calculatedInvoiceTotal)
                    Console.WriteLine(item);
            else
                Console.WriteLine("NOT FOUND");

            Console.WriteLine("\n\n");


            // b) Part description of the part who has highest quantity.
            var highestQuantity =
                (from i in invoice
                 orderby i.Quantity descending
                 select new
                 {
                     i.PartDescription, i.Quantity
                 }).First();

            Console.WriteLine("Part Description and Highest Quantity");
            Console.WriteLine($"{{ PartDesciption = {highestQuantity.PartDescription}, Quantity = {highestQuantity.Quantity} }}");
            Console.WriteLine("\n\n");


            // c) Average price of the parts
            decimal average = (from i in invoice select i.Price).Average();
            Console.WriteLine("Average price of the parts: {0:C}", average);
            Console.WriteLine("\n\n");
        }
    }
}
