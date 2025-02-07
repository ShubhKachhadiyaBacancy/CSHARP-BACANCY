//A DiscountCalculator class applies a fixed 10% discount.
//Modify it to support multiple discount types without modifying the class.

using DAY8_OOP_3_;

Console.Write("Enter value : ");
int val = Convert.ToInt32(Console.ReadLine());
FixedDiscount fixedDiscount = new FixedDiscount();
fixedDiscount.DiscountCalculator(val);

Console.Write("\nEnter value : ");
val = Convert.ToInt32(Console.ReadLine());
FirstUserDiscount firstUserDiscount = new FirstUserDiscount();
firstUserDiscount.DiscountCalculator(val);