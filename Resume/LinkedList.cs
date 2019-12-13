using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class LinkedList : ICollection
    {
        public Node head;
        public Node tail;

        private int count;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddToFront(Node nodeToAdd)
        {
            //Save the head node
            Node temp = head;

            head = nodeToAdd;

            head.Next = temp;

            count++;

            if (count == 1)
            {
                tail = head;
            }

        }

        public void AddToLast(Node nodeToAdd)
        {
            if (count == 0)
            {
                head = nodeToAdd;
            }
            else
            {
                tail.Next = nodeToAdd;
            }

            tail = nodeToAdd;
            count++;
        }

        public void RemoveLast()
        {
            if (this.count != 0)
            {
                if (count == 1)
                {
                    this.head = null;
                    this.tail = null;
                }
                else
                {
                    var current = head;
                    while (current.Next != tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    tail = current;
                }

                count--;
            }
        }

        public void RemoveFirst()
        {
            if (this.count != 0)
            {
                head = head.Next;
                count--;

                if (count == 0)
                {
                    this.tail = null;
                }
            }
        }

        public bool Remove(string value)
        {
            Node previous = null;
            Node current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (previous.Next == null)
                        {
                            tail = previous;
                        }

                        count--;


                    }
                    else
                    {
                        this.RemoveFirst();
                    }

                    return true;
                }


                previous = current;
                current = current.Next;

            }

            return false;
        }

        public int Count
        {
            get { return this.count; }
        }

        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerator GetEnumerator()
        {
            var current = head;

            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public Node GetMiddleNode()
        {
            Node fastPointer = this.head;
            Node slowPointer = this.head;
            
            while(fastPointer != null && fastPointer.Next != null)
            {
                fastPointer = fastPointer.Next.Next;
                slowPointer = slowPointer.Next;
            }
            
            return slowPointer;
        }

        public void Reverse(Node header)
        {
            Node previous = null;
            Node current = header;
            Node next;

            while(current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            header = previous;
        }

        public void PrintList()
        {
            var current = head;
            Console.WriteLine("Print Start");
            while (current != null)
            {

                Console.WriteLine(current.Value);
                current = current.Next;
            }

            Console.WriteLine("Print End");
        }
    }
}
