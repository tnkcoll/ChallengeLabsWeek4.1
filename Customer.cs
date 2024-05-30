using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabsWeek4._1
{
    internal class Customer
    {
        public string? Name { get; set; }
        public string? Id { get; set; }
        public double UnitsConsumed { get; set; }

        public double CalculateAmountCharged(double units)
        {
            if (units < 200)
            {
                return units * 1.20;
            }
            else if (units >= 200 && units < 400)
            {
                return units * 1.50;
            }
            else if (units >= 400 && units < 600)
            {
                return units * 1.80;
            }
            else
            {
                return units * 2;
            }
        }

        public double CalculateSurcharge(double amount)
        {
            if (amount > 400) 
            {
                return amount * .15;
            }
            else
            {
                return 0;
            }
        }

        public double CalculateNetAmount(double amount, double surcharge)
        {
            return amount + surcharge;
        }
    }
}
