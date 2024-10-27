namespace _21321
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "fxce xt sxd";
            foreach (char c in str)
            {
                if (c == 'x')
                {
                    str = str.Replace(c, 'a');
                }
            }
            Console.WriteLine(str);
        }
    }
}
