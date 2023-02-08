namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        { return x + y; }
        public static double Add(double x, double y)
        { return x + y; }
        public static int Add(string x, string y)
        {
            return int.Parse(x) + int.Parse(y);
        }
        public static string Add(int x, int y, bool dollars)
        {
            string ans = "";
            if (dollars)
            {
                ans = (x + y > 1) ? $"{x + y} dollars" : $"{x + y} dollar";
            }
            else { ans = $"{x + y}"; }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.1, 2.2));
            Console.WriteLine(Add("1", "2"));
            Console.WriteLine(Add(1, 0, true));
        }
    }
}
