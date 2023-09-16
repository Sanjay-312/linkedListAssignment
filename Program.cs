using System.Collections;

namespace LinkedListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListOpertaions list= new LinkedListOpertaions();
            list.addData(56);
            list.addData(30);
            list.addData(70);
            list.DisplayData();

            //list.removeFirstNode();
            //Console.WriteLine("linked list after deleting first node");
            //list.DisplayData();

            //list.removeLastNode();
            //Console.WriteLine("linked list after removing last node");
            //list.DisplayData();

             
            Console.WriteLine(list.SearchNode(30));


        }
    }
}