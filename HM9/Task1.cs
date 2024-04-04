using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM9
{
    internal class Task1
    {

public class Money
    {
        private int dollars;
        private int cents;

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public void SetMoney(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public void DisplayMoney()
        {
            Console.WriteLine($"Total: {dollars} dollars and {cents} cents");
        }

        public int GetDollars()
        {
            return dollars;
        }

        public int GetCents()
        {
            return cents;
        }
    }

    public class Product
    {
        private string name;
        private Money price;

        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        public void ReducePrice(int dollars, int cents)
        {
            int totalDollars = price.GetDollars() - dollars;
            int totalCents = price.GetCents() - cents;

            if (totalCents < 0)
            {
                totalDollars -= 1;
                totalCents += 100;
            }

            if (totalDollars < 0)
            {
                Console.WriteLine("Price cannot be negative.");
            }
            else
            {
                price.SetMoney(totalDollars, totalCents);
                Console.WriteLine($"Price of {name} reduced to {totalDollars} dollars and {totalCents} cents");
            }
        }
    }

}
}
