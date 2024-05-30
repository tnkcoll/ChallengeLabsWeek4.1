using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabsWeek4._1.Controls.Classes
{
    internal class Customer
    {
        public string? Name { get; set; }
        public string? Id { get; set; }
        public double UnitsConsumed { get; set; }

        public override string ToString()
        {
            return $"{Name} (ID: {Id}) (Units: {UnitsConsumed})";
        }

        public string CalculateBill(double units)
        {
            if (units > 199 && units < 400)
            {
                double result = units * 1.50;
                return Convert.ToString(result);
            }
            else if (units >= 400 && units < 600)
            {
                double result = units * 1.80;
                return Convert.ToString(result);
            }
            else if (units >= 600)
            {
                double result = units * 2;
                return Convert.ToString(result);
            }
            else
            {
                double result = units * 1.20;
                return Convert.ToString(result);
            }
        }

        public string AddSurcharge(double total)
        {
            double bill = total * .15;
            return Convert.ToString(bill);
        }

        public string NetAmount(double amount, double surcharge)
        {
            double totalBill = amount + surcharge;
            return Convert.ToString(totalBill);
        }
    }
}
