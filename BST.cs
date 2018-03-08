using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BionarySearchTreeFinal
{
    class BST
    {
        //member variables
        Node head = null;

        //constructor
        public BST()
        {

        }

        //member methods
        public void Add(int item)
        {
            Node node = new Node(item);
            if (head == null)
            {
                head = node;
                return;
            }
            Node current = head;
            bool nodeAdded = false;
            while (!nodeAdded)
            {
                if (item < current.data)
                {
                    if (current.left != null)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current.left = node;
                        nodeAdded = true;
                    }
                }
                else if (item > current.data)
                {
                    if (current.right != null)
                    {
                        current = current.right;
                    }
                    else
                    {
                        current.right = node;
                        nodeAdded = true;
                    }
                }
                else
                {
                    nodeAdded = true;
                }
            }
        }

        public string Search(int searchItem)
        {
            if (searchItem == head.data)
            {
                return "Head";
            }
            StringBuilder searchPath = new StringBuilder();
            Node current = head;
            bool nodeFound = false;
            while (!nodeFound)
            {
                if (searchItem < current.data)
                {
                    searchPath.Append("Left ");
                    if (current.left != null)
                    {
                        current = current.left;
                    }
                    else
                    {
                        nodeFound = true;
                    }
                }
                else if (searchItem > current.data)
                {
                    searchPath.Append("Right ");
                    if (current.right != null)
                    {
                        current = current.right;
                    }
                    else
                    {
                        nodeFound = true;
                    }
                }
                else
                {
                    nodeFound = true;
                }
            }
            if (searchItem != current.data)
            {
                return "Not found";
            }
            return searchPath.ToString();
        }
    }
}
