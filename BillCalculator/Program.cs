using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Input from the user
            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter unit Consumed: ");
            int unitsConsumed = int.Parse(Console.ReadLine());

            // Calculate charges based on the given rules
            double chargePerUnit;
            if (unitsConsumed <= 199)
            {
                chargePerUnit = 1.20;
            }
            else if (unitsConsumed >= 200 && unitsConsumed < 400)
            {
                chargePerUnit = 1.50;
            }
            else if (unitsConsumed >= 400 && unitsConsumed < 600)
            {
                chargePerUnit = 1.80;
            }
            else
            {
                chargePerUnit = 2.00;
            }

            double totalAmount = unitsConsumed * chargePerUnit;

            // Apply surcharge if bill exceeds $400
            if (totalAmount > 400)
            {
                double surcharge = 0.15 * totalAmount;
                totalAmount += surcharge;
            }

            // Display the bill details
            Console.WriteLine($"Customer IDNO: {customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Unit Consumed: {unitsConsumed}");
            Console.WriteLine($"Amount Charges @$ {chargePerUnit:F2} per unit: {totalAmount:F2}");
            Console.WriteLine($"Surcharge Amount: {(totalAmount - unitsConsumed * chargePerUnit):F2}");
            Console.WriteLine($"Net Amount Paid By the Customer: {totalAmount:F2}");
            Console.ReadKey();
        }
    }
}
