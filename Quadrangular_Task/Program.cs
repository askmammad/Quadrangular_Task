namespace Quadrangular_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l1: Console.WriteLine("Please choose the figure type and click corresponding number:\n1.Rectangular\n2.Rhomb\n3.Square\n4.Trapeze\n");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x == 1) 
            {
                Console.WriteLine("Please insert the height of Rectangular: ");
                double heightRec = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert the length of Rectangular: ");
                double lengthRec = Convert.ToInt32(Console.ReadLine());
                Rectangular rectangular = new Rectangular(heightRec, lengthRec);
                Console.WriteLine($"Perimetr of Rectangular: {rectangular.Perimetr()}");
                Console.WriteLine($"Area of Rectangular: {rectangular.Area()}");
                Console.WriteLine("---------------------\n");
                goto l1;
            }
            else if (x == 2)
            {
                Console.WriteLine("Please insert the side of Rhomb: ");
                double sideRhomb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert the angle of Rhomb: ");
                double angleRhomb = Convert.ToInt32(Console.ReadLine());
                Rhomb rhomb = new Rhomb(sideRhomb,angleRhomb);
                Console.WriteLine($"Perimetr of Rectangular: {Rhomb.Perimetr()}");
                Console.WriteLine($"Area of Rectangular: {Rhomb.Area()}");
                Console.WriteLine("---------------------\n");
                goto l1;
            }
            else if (x == 3) 
            {
                Console.WriteLine("Please insert the side of Square: ");
                double sideSquare = Convert.ToInt32(Console.ReadLine());
                Square square = new Square(sideSquare);
                Console.WriteLine($"Perimetr of Rectangular: {Square.Perimetr()}");
                Console.WriteLine($"Area of Rectangular: {Square.Area()}");
                Console.WriteLine("---------------------\n");
                goto l1;
            }
            else if (x == 4) 
            {
                Console.WriteLine("Please insert the top side of Trapeze: ");
                double topsideTrapeze = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert the bottom side of Trapeze: ");
                double bottomsideTrapeze = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert the left/right side of Trapeze: ");
                double sideTrapeze = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert the height of Trapeze: ");
                double heightTrapeze = Convert.ToInt32(Console.ReadLine());
                Trapeze trapeze = new Trapeze(topsideTrapeze, bottomsideTrapeze, sideTrapeze, heightTrapeze);
                Console.WriteLine($"Perimetr of Rectangular: {Trapeze.Perimetr()}");
                Console.WriteLine($"Area of Rectangular: {Trapeze.Area()}");
                Console.WriteLine("---------------------\n");
                goto l1;
            }
            else
            {
                Console.WriteLine("Wrong number inserted\n");
                goto l1;
            }
        }
    }
}