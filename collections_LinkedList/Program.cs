namespace collections_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            // Add Elemts
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddFirst(100);
            linkedList.AddFirst(123);
            linkedList.AddLast(1235);

            Console.WriteLine("Elements of LinkedList:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Delete elemts from middle of the list
            linkedList.Remove(20);

            int searchElement = 30;
            if (linkedList.Contains(searchElement))
            {
                Console.WriteLine($"Element {searchElement} was found in the list.");
            }
            else
            {
                Console.WriteLine($"Element {searchElement} was not found in the list.");
            }
            Console.WriteLine();

            LinkedListNode<int> node20 = linkedList.Find(20);

            if (node20 != null)
            {
                linkedList.AddAfter(node20, 25);
            }

            LinkedListNode<int> node10 = linkedList.Find(10);
            if (node10 != null)
            {
                linkedList.AddBefore(node10, 5);
            }

            Console.WriteLine("Elements of LinkedList:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}