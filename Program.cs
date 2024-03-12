namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mark", "Wade", "Dave", "Gilbert", "Dan" };

            Array.Sort(names);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
