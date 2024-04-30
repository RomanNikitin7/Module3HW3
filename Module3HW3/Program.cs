namespace Module3HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Class1();
            var c2 = new Class2();
            var result  = c2.Calc(c1.Multiply, 2, 3);
            var show = new MyShowDelegate(Show);
            show(result.Invoke(5));
        }
        
        public static void Show(bool b)
        {
            if (b)
            {
                Console.WriteLine("No reminder after division");
            } else
            {
                Console.WriteLine("There is reminder after division");
            }
        }
    }
}
