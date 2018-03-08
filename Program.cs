using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BionarySearchTreeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            BST myBinarySearchTree = new BST();

            //TEST CASE 1:
            //myBinarySearchTree.Add(8);
            //myBinarySearchTree.Add(10);
            //myBinarySearchTree.Add(6);
            //myBinarySearchTree.Add(8);
            //myBinarySearchTree.Add(3);
            //myBinarySearchTree.Add(12);
            //myBinarySearchTree.Add(99);
            //myBinarySearchTree.Add(467);
            //myBinarySearchTree.Add(64);
            //myBinarySearchTree.Add(11);

            //TEST CASE 2:
            myBinarySearchTree.Add(127);
            myBinarySearchTree.Add(45);
            myBinarySearchTree.Add(38);
            myBinarySearchTree.Add(72);
            myBinarySearchTree.Add(117);
            myBinarySearchTree.Add(45);
            myBinarySearchTree.Add(2);
            myBinarySearchTree.Add(999);
            myBinarySearchTree.Add(50);
            myBinarySearchTree.Add(45);
            myBinarySearchTree.Add(100);

            Console.WriteLine(myBinarySearchTree.Search(100));
            Console.ReadKey();

        }
    }
}