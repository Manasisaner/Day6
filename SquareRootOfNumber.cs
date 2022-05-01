namespace NUnitTestingProject
{
    public class SquareRootOfNumber
    {
        public void SquareRoot()
        {
            Console.WriteLine("Enter the positive Number");
            int number = Convert.ToInt32(Console.ReadLine());
            double root = Math.Sqrt(number);
            Console.WriteLine("square root of the number is :--->" + root);
        }
    }
}
