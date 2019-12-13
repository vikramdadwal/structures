using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public static class LinkedListMethods
    {
        public static bool IsPalindrome(Node header)
        {
            Node fastPointer = header;
            Node slowPointer = header;
            Node mideNode = null;
            Node previousSlowPointer = header;
            Node SecondHalf = null;

            while (fastPointer != null && fastPointer.Next != null)
            {
                fastPointer = fastPointer.Next.Next;
                previousSlowPointer = slowPointer;
                slowPointer = slowPointer.Next;
            }

            if (fastPointer != null)
            {
                mideNode = slowPointer;
                slowPointer = slowPointer.Next;
            }

            SecondHalf = slowPointer;
            previousSlowPointer.Next = null;

            Reverse(SecondHalf);

            var res = AreLinkedListsEqual(header, SecondHalf);

            Reverse(SecondHalf);

            if (mideNode != null)
            {
                previousSlowPointer.Next = mideNode;
                mideNode.Next = SecondHalf;
            }
            else
            {
                previousSlowPointer.Next = slowPointer;
            }


            return res;
        }

        public static bool AreLinkedListsEqual(Node first, Node Second)
        {
            Node temp1 = first;
            Node temp2 = Second;


            while (temp1 != null && temp2 != null)
            {
                if (temp1 == null && temp2 == null)
                {
                    return true;
                }

                if (temp1 != null && temp2 == null)
                {
                    return false;
                }

                if (temp1 == null && temp2 != null)
                {
                    return false;
                }

                if (temp2.Value != temp1.Value)
                {
                    return false;
                }

                temp1 = temp1.Next;
                temp2 = temp2.Next;
            }

            return false;

        }

        public static Node GetMiddleNode(Node head)
        {
            Node fastPointer = head;
            Node slowPointer = head;

            while (fastPointer != null && fastPointer.Next != null)
            {
                fastPointer = fastPointer.Next.Next;
                slowPointer = slowPointer.Next;
            }

            return slowPointer;
        }

        #region > Reverse a linked list <

        /// <summary>
        /// Iterative method
        /// </summary>
        /// <param name="header"></param>
        /// <returns></returns>
        public static Node Reverse(Node header)
        {
            Node previous = null;
            Node current = header;
            Node next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            header = previous;

            return next;
        }

        /// <summary>
        /// Recursive method
        /// </summary>
        /// <param name="p"></param>
        public static void ReverseRecursive(Node p)
        {
            if (p.Next == null)
            {
                //head = p;
                return;
            }

            ReverseRecursive(p.Next);

            Node temp = p.Next;
            temp.Next = p;
            p.Next = null;

        }

        #endregion

        #region > Loop Detection <

        public static bool hasLoop(Node head)
        {
            Node slowPointer = head;
            Node fastPointer = head.Next;
            while (fastPointer != null && slowPointer != null)
            {
                if (slowPointer.Equals(fastPointer))
                {
                    return true;
                }

                if ((fastPointer.Next != null) && (slowPointer.Next != null))
                {
                    fastPointer = fastPointer.Next.Next;
                    slowPointer = slowPointer.Next;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Meeting point
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Node FindMeetingPointInLoop(Node head)
        {
            Node fast = head;
            Node slow = head;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;

                if (slow == fast)
                {
                    break;
                }
            }

            if (fast == null || fast.Next == null)
            {
                return null;
            }

            slow = head;

            while (fast != slow)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            return fast;  // if want to remove the loop then take a previous node and asssing it to null here;
        }

        #endregion

        #region > Print linked list <

        /// <summary>
        /// Print elements of a linked list in forward and reverse order using recursion
        /// </summary>
        public static void PrintLinkedListFwd(Node head)
        {
            //Fwd

            if (head == null) return;
            Console.WriteLine(head.Value);
            PrintLinkedListFwd(head.Next);  // Recursive call

        }

        /// <summary>
        /// Print elements of a linked list in forward and reverse order using recursion
        /// </summary>
        public static void PrintLinkedListReverse(Node head)
        {
            //Fwd

            if (head == null) return;
            PrintLinkedListReverse(head.Next);
            Console.WriteLine(head.Value);
        }

        #endregion

        #region > Merge point of two lined list <

        /// <summary>
        /// Find merge point of two linked list === Brute force  == O(m* n)
        /// </summary>
        /// <param name="header1"></param>
        /// <param name="Header2"></param>
        /// <returns></returns>
        public static Node FindMergeNodeofTwoList(Node header1, Node Header2)
        {
            int m = FindLenth(header1);
            int n = FindLenth(Header2);

            Node temp = Header2;

            for (int i = 0; i < m; i++)
            {
                Header2 = temp;
                for (int j = 0; j < n; j++)
                {
                    if (header1 == Header2)
                    {
                        return header1;
                    }

                    Header2 = Header2.Next;
                }

                header1 = header1.Next;
            }

            return null;
        }

        /// <summary>
        /// Find merge point of two linked list === Optimal  == O(m + n)
        /// </summary>
        /// <param name="header1"></param>
        /// <param name="Header2"></param>
        /// <returns></returns>
        public static Node FindMergeNodeofTwoListImporoved(Node header1, Node Header2)
        {
            int m = FindLenth(header1);
            int n = FindLenth(Header2);
            
            if (n > m)
            {
                return MergerHelper(n - m, Header2, header1);
            }
            else
            {
                return MergerHelper(m - n, header1, Header2);
            }
        }

        public static Node MergerHelper(int d, Node Header2, Node header1)
        {
            for (int i = 0; i < d; i++) // this logic should run for longest list so there is one step aboe for swapping
            {
                if (Header2 == null)
                    return null;
                Header2 = Header2.Next;
            }

            while (header1 != null && Header2 != null)
            {
                if (header1 == Header2)
                {
                    return header1;
                }

                header1 = header1.Next;
                Header2 = Header2.Next;
            }

            return null;
        }

        public static int FindLenth(Node head)
        {
            int lenght = 0;
            Node current = head;
            while (current != null)
            {
                lenght++;
                current = current.Next;
            }

            return lenght;
        }

        #endregion

        #region > Remove duplicate from Linked List <

        // TIme = O(n)  but space O(n)  --- Unsorted linked list
        public static void RemoveDuplicateFromList(Node head)
        {
            Node previous = null;
            Dictionary<int, int> hash = new Dictionary<int, int>();

            while (head != null)
            {
                if (hash.ContainsKey(int.Parse(head.Value)))
                {
                    previous.Next = head.Next;
                }
                else
                {
                    hash.Add(int.Parse(head.Value), 1);
                    previous = head;
                }

                head = head.Next;
            }
        }

        // TIme = O(n^2)  but space O(1)  --- Unsorted linked list
        public static void RemoveDuplicateWithout(Node head)
        {
            Node current = head;

            while (current != null)
            {
                Node runner = current;
                while (runner.Next != null)
                {
                    if (runner.Next.Value == current.Value)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }

                current = current.Next;
            }
        }

        /// <summary>
        /// Remove duplicate from Sorted linked list
        /// </summary>
        /// <param name="head"></param>
        public static void RemoveDuplicateSorted(Node head)
        {
            Node current = head;

            if (current == null) return;

            while (current.Next != null)
            {
                if(current.Value == current.Next.Value)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
        }

        #endregion

        #region > Remove Node (when the node itself is provided <

        public static void RemoveNode(Node node)
        {
            if(node.Next != null)
            {
                Node temp = node.Next;
                node.Value = temp.Value;
                node.Next = temp.Next;
            }
        }

        #endregion

        #region > Nth node from the end of a Linked List <

        public static string nthNode(Node head, int n)
        {
            int lenght = FindLenth(head);

            for(int i=1; i < lenght - n + 1; i++)
            {
                head = head.Next;
            }

            return head.Value;
        }

        public static void nthNodeFromBackRecursive(Node head, int n)
        {
            int i = 0;
            if (head == null) return;

            nthNodeFromBackRecursive(head.Next, n);

            if(i++ == n)
            {
                Console.Write(head.Value);
            }
        }

        #endregion


    }
}
