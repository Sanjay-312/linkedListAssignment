using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class LinkedListOpertaions
    {
        public Node head;

        public void addData(int data)
        {
            Node node = new Node(data);
            if(this.head==null )
            {
                head = node;
            }
            else
            {
                Node temp= head;
                while(temp.Next!=null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} is inserted into the linked list",node.data);

        }

        internal Node removeFirstNode()
        {
            if(this.head==null)
            {
                return null;
            }
            this.head=this.head.Next;
            return this.head;

        }

        internal Node removeLastNode()
        {
            if (head == null)
            {
                return null;
            }

            if(head.Next==null)
            {
                return null;
            }

            Node newNode = head;
            while(newNode.Next.Next!=null)
            {
                newNode= newNode.Next;
            }
            newNode.Next = null;
            return head;
        }

        internal Node SearchNode(int value)
        {
            while(this.head!=null)
            {
                if (this.head.data==value)
                {
                    return this.head;

                }
                this.head = this.head.Next;
            }
            return null;

        }

        public void DisplayData()
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else
            {
                Node tempNode = head;
                while (tempNode != null)
                {

                    Console.WriteLine(tempNode.data + " ");
                    tempNode = tempNode.Next;

                }
            }
        }


    }
}
