using OpenClosePrinciple.BeforeOCP;
using OpenClosePrinciple.WithOCP;

//Before OCP
var orderAmount = 100;
var calculteDiscount = new DiscountCalculator(orderAmount);
Console.WriteLine($"Your discount amount is {calculteDiscount.CalculateTotalDiscount()}$");

//With OCP
var orderAmountOCP = 200;
var calculteDiscountOCP = new PurchasedMoreThan200Dollar();
Console.WriteLine($"Your discount amount is {calculteDiscountOCP.CalculateDiscount(orderAmountOCP)}$");
