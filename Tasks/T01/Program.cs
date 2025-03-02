namespace T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small = 25;
            int big = 35;

            double tax = 0.06;

            Console.Write("Enter Number of small carpets: ");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number of big carpets: ");
            int bigCarpets = Convert.ToInt32(Console.ReadLine());

            double total = (small * smallCarpets) + (big * bigCarpets);

            double totalTax = total * tax;

            double totalCost = total + totalTax;


            Console.WriteLine("Total Cost: " + totalCost);

        }
    }
}
