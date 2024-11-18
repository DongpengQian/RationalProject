namespace RationalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rational Project");
            Rational r1 = new Rational();
            Rational r2 = new Rational(1, 3);
            Rational.WriteRational(r1);
            Rational.WriteRational(r2);
            r1.WriteRational2(r1);
            r2.WriteRational2(r2);
        }
    }
    
}
