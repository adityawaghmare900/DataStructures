namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(56);
            list.AddLast(30);
            list.AddLast(70);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}