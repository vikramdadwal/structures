using Interview.Arrays._37;
using Interview.Arrays._39;
using Interview.Arrays._41;
using Interview.Arrays._42;
using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {

            //Interview.Tree.BinarySearchTreeImplementation.MainClass.Run();

            //var hasPalindrom = Interview.Arrays._25.PalindromPermutation.HasPalindrom("talman");

            //var compressedstring = Interview.Arrays._26.StringCompression.CompressString("aaabbccc");

            //Interview.Arrays._29.SortColors.SortTheColors(new int[] { 0, 1, 1, 0, 2, 1, 1, 2 });

            //Interview.Arrays._35.QuickSort.PerformQuickSort(new int[] { 7, 2, 1, 6, 8, 5, 3, 4 });

            //var multidimentionarray = new int[,]
            //{
            //    { 1, 1, 0, 0, 0},
            //    { 1, 1, 0, 0, 0},
            //    { 0, 0, 1, 0, 0},
            //    { 0, 0, 0, 1, 1},
            //    { 0, 0, 0, 1, 1}

            //};

            //var numberofislands = Interview.Arrays._1.NumberOfIslands.FindNumberOfIslands(multidimentionarray);
            //Console.WriteLine($"Number of Islands {numberofislands}");


            //var root = Interview.Tree.BinarySearchTreeImplementation.MainClass.GetSampleBinarySearchTree();
            //Interview.Tree._9.Recursive.InOrderTraversal.Traverse(root);
            //Console.WriteLine();
            //Interview.Tree._9.Iterative.InOrderTraversal.Traverse(root);
            //Console.WriteLine();
            //Interview.Tree._13.KthSmallElementBST.PrintElement(root, 4);


            //int[] sortedArray = new int[] { 2, 6, 8, 10, 14, 20, 28, 32 };
            //var tree = Interview.Tree._1.SortedArrayToBalancedTree.Convert(sortedArray);

            //var ans = Interview.Arrays._36.PowerOfTwo.IsPOwerOfTwo(256);

            //var ans = Interview.Arrays._37.PalindromeORNot.IsPalindrome("A man, a plan, a canal: Panama");

            //var root = Interview.Tree.BinarySearchTreeImplementation.MainClass.GetSampleBinarySearchTree();
            //var depth = Interview.Tree._28.MaxDepthOfBinaryTree.FindMaxDepthOfBinaryTree(root);


            //var minsummatrix = new int[,]
            //{
            //    { 1, 3, 1 },
            //    { 1, 5, 1 },
            //    { 4, 2, 1 }
            //};

            //var minsum = Interview.Arrays._38.MinPathSumMatrix.GetMinPathSum(minsummatrix);

            //OldQuestions();


            // var result = ValidParentheses.HasValidParanthesis("([)]");

            //var result = LongestCommonPrefix.FindCommonPrefix(new string[] { "racecar", "racecar", "race" });

            //var result = PalindromeORNot.IsPalindrome202("A @@ man, a plan, a canal: Panama");

            var result = FirstUniqueCharacterinaString.FirstIndex("aadadaad");


            Console.ReadLine();
        }

        private static void OldQuestions()
        {
            //http://collabedit.com/us2xu
            //https://github.com/mission-peace/interview/tree/master/src/com/interview

            //var res = OddOccurenceIntegers.CheckIfPermutationOFPalindrome("13334");

            //Node temp = new Node
            //{
            //    Value = "1"
            //};

            //Node temp2 = new Node
            //{
            //    Value = "2"
            //};

            //Node temp3 = new Node
            //{
            //    Value = "3"
            //};

            //Node temp4 = new Node
            //{
            //    Value = "4"
            //};

            //Node temp5 = new Node
            //{
            //    Value = "5"
            //};

            //Node temp6 = new Node
            //{
            //    Value = "5"
            //};

            //LinkedList lst = new LinkedList();

            //lst.AddToLast(temp);
            //lst.AddToLast(temp2);
            //lst.AddToLast(temp3);
            //lst.AddToLast(temp4);
            //lst.AddToLast(temp5);


            //Node temp66 = new Node
            //{
            //    Value = "11"
            //};

            //Node temp67 = new Node
            //{
            //    Value = "21"
            //};

            //Node temp68 = new Node
            //{
            //    Value = "31"
            //};

            //LinkedList lst2 = new LinkedList();

            //lst2.AddToLast(temp66);
            //lst2.AddToLast(temp67);
            //lst2.AddToLast(temp68);
            //lst2.AddToLast(temp4);
            //lst2.AddToLast(temp5);

            //var node = LinkedListMethods.FindMergeNodeofTwoList(lst.head, lst2.head);


            //lst.tail.Next = temp3;

            //var result = LinkedListMethods.IsPalindrome(lst.head);

            // var resu = LinkedListMethods.hasLoop(lst.head);

            //LinkedList lst2 = new LinkedList();

            //lst2.AddToLast(temp);
            //lst2.AddToLast(temp2);
            //lst2.AddToLast(temp3);
            //lst2.AddToLast(temp4);
            //lst2.AddToLast(temp6);


            //if (LinkedListMethods.AreLinkedListsEqual(lst.head, lst2.head))
            //{
            //    Console.WriteLine("yupppy they are equal");
            //} else
            //{
            //    Console.WriteLine("No no no equal");
            //}

            //var middleNode = lst.GetMiddleNode();  // Find Middle
            ////Console.WriteLine(middleNode.Value);

            //lst.PrintList();

            //lst.Reverse(lst.head); //Reverse

            //lst.PrintList();

            //CommonStringMethods.PrintFirstNonRepeatedCharacter("asdaspd");


            //var num = OddOccurenceIntegers.FindUniqueIntegerFromPairs(new int[] { 1, 2, 1, 4, 4, 2, 3, 3 });
            //Console.WriteLine(num);

            //PrimeFactorial.IsPrimeNumber(11);
            //PrimeFactorial.IsPrimeNumber(8);

            //OddOccurenceIntegers.PrintPairToEqualsSum(new int[] { 1, 4, 2, 3, 7, 8 }, 3);
            //OddOccurenceIntegers.IsNumberIsPalindrome(1221);
            //OddOccurenceIntegers.IsNumberIsPalindrome(345345);

            // PrimeFactorial.PrintFibnocci(9, true);
            //PrimeFactorial.PrintFibnocci(9, false);

            //PrimeFactorial.FactorialSimple(5);
            //Console.WriteLine(PrimeFactorial.FactorialRecursive(5));

            //CommonStringMethods.AreAnagram("abcd", "acdt");
            //Console.WriteLine(PrimeFactorial.IsPowerOfTwo(8));
            // Console.WriteLine(PrimeFactorial.IsPowerOfTwo(4));
            //Tree();
            //var str = CommonStringMethods.ReverseWordOfStringWithoutStack("This is the test");
            //
            //BinarySearch.PrintOccurance();
            //BinarySearch.BInarySearch(new int[] { 1, 3, 6, 7, 2, 9, 10, 8 }, 10);
            //BinarySearch.DoBinarySearch(new int[] { 1, 3, 6, 7, 2, 9, 10, 8 }, 20);
            //var arr = new int[] { 2, 8, 3, 10, 4, 5, 1 };
            //Sorting.SelectionSort(arr);

            Console.ReadLine();
        }

        public static void Tree()
        {
            BinaryTree tree = new BinaryTree();

            tree.Add(4);
            tree.Add(14);
            tree.Add(5);
            tree.Add(8);
            tree.Add(3);
            tree.Add(2);
            tree.Add(18);
            tree.Add(16);
            tree.Add(19);


            TreeMethods.DeleteNode(tree._head, 18);
            TreeMethods.BT_is_BST(tree._head);

            //TreeMethods.IsBSTUsingInOrderTraversal(tree._head);

            //TreeMethods.PreOrderTraversal(tree._head);
            //Console.WriteLine("-----------------------------");

            //TreeMethods.InOrderTraversal(tree._head);
            //Console.WriteLine("-----------------------------");

            //TreeMethods.PostOrderTraversal(tree._head);
            //Console.WriteLine("-----------------------------");
            //TreeMethods.BFT_LevelOrderTraversal(tree._head);

            //TreeMethods.FindMaxinBST(tree._head);
            //TreeMethods.FindMininBST(tree._head);


            TreeMethods.FindHeight(tree._head);
        }
    }
}
