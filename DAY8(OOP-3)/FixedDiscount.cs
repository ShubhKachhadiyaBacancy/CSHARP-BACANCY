using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_OOP_3_
{
    public class FixedDiscount:IDiscount
    {
        public void DiscountCalculator(int price)
        {
            Console.WriteLine("FIXED DISCOUNT : 10%");
            Console.WriteLine($"PRICE OF ONE ITEM : {price - price * 0.10}");
        }
    }
}
