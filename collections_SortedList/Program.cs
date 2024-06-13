namespace collections_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();

            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            sortedList.Add(5, "Five");
            sortedList.Add(4, "Four");

            Console.WriteLine("Elements of SortedList:");
            foreach (KeyValuePair<int, string> kvp in sortedList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            // Access by key
            int keyToAccess = 3;
            if (sortedList.ContainsKey(keyToAccess))
            {
                string value = sortedList[keyToAccess];
                Console.WriteLine("Value by key {0}: {1}", keyToAccess, value);
            }
            else
            {
                Console.WriteLine("Key {0} not found", keyToAccess);
            }

            // Delete Element
            int keyToRemove = 2;
            if (sortedList.Remove(keyToRemove))
            {
                Console.WriteLine("Elements with key {0} deleted", keyToRemove);
            }
            else
            {
                Console.WriteLine("Key {0} not found", keyToRemove);
            }

            Console.WriteLine("Elements of SortedList after delete:");
            foreach (KeyValuePair<int, string> kvp in sortedList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            string valueToCheck = "Five";
            bool containsValue = sortedList.ContainsValue(valueToCheck);
            Console.WriteLine("Contains value \"{0}\": {1}", valueToCheck, containsValue);
        }
    }
}