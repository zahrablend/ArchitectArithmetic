namespace FloorCalcSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rectangular area = length × width
            double rectFloorArea = RectArea(4, 5);
            //circle area = pi × radius
            double circleFloorArea = CircleArea(4);
            //trianle area = 0.5 x bottom x height
            double triangFloorArea = TriangArea(10, 9);

            //calc for Mexico: Teotihuacan floor area
            double floorAreaTotal = rectFloorArea + circleFloorArea + triangFloorArea;

            double materialPrice = 180;
            double totalFlooringCost = floorAreaTotal * materialPrice;
            Console.WriteLine($"Total Teotihuacan flooring cost: {Math.Round(totalFlooringCost, 2)}");
        }

        static double RectArea(double length, double width)
        {
            return length * width;
        }

        static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double TriangArea(double bottom, double height)
        {
            double constant = 0.5;
            return constant * bottom * height;
        }
    }
}