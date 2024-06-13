namespace collections_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a queue
            Queue<int> queue = new Queue<int>();

            // Enqueue elements into the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // Peek at the first element of the queue
            Console.WriteLine("First element in the queue: " + queue.Peek());

            // Dequeue elements from the queue
            Console.WriteLine("Dequeued element: " + queue.Dequeue());
            Console.WriteLine("Dequeued element: " + queue.Dequeue());

            // Peek at the first element after several dequeues
            Console.WriteLine("First element in the queue after dequeues: " + queue.Peek());

            // Iterate over the remaining elements in the queue with foreach
            Console.WriteLine("Remaining elements in the queue:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            // Check if a specific element is in the queue
            int elementToCheck = 3;
            bool contains = queue.Contains(elementToCheck);
            Console.WriteLine("Does the queue contain element {0}: {1}", elementToCheck, contains);

            // Clear the queue
            queue.Clear();
            Console.WriteLine("Number of elements in the queue after clearing: " + queue.Count);

        }
    }
}