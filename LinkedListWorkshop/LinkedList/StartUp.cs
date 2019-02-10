using System;

namespace LinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomList asd = new CustomList();

            asd.Add(1);
            asd.Add(2);
            asd.Add(3);
            asd.Add(4);
            asd.Add(5);
            asd.Swap(0, 4);
            
        }
    }
}
