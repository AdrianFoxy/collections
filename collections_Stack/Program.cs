namespace collections_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Elemenets of Stack:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Top element: " + stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("Element deleted: " + stack.Pop());
            }

            try
            {
                stack.Pop();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            int elementToCheck = 20;
            bool contains = stack.Contains(elementToCheck);
            Console.WriteLine("Contains element {0}: {1}", elementToCheck, contains);
        }
    }
}