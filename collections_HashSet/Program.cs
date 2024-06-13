namespace collections_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myhash1 = new HashSet<string>();

            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");
            Console.WriteLine("Elements of myhash1:");

            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine($"\n{myhash1.Contains("C")}");

            Console.WriteLine("\n");

            HashSet<int> myhash2 = new HashSet<int>() {10, 10, 10, 100,
                               100,1000,10000,100000};

            Console.WriteLine("Elements of myhash2:");
            foreach (var value in myhash2)
            {
                Console.WriteLine(value);
            }


        }
    }
}