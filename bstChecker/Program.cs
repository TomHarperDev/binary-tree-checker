using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace bstChecker
{


    internal class Program
    {
        public static List<int> depths = new List<int>();

        static void Main(string[] args)
        {
            tree myTree = new tree();
            myTree.root = new Node("treeRoot");

            myTree.root.LeftChild = new Node("treeRootLeft");
            //myTree.root.LeftChild.LeftChild = new Node("treeRootLeftLeft");


            myTree.root.RightChild = new Node("treeRootRight");
            myTree.root.RightChild.RightChild = new Node("treeRootRightRight");
            myTree.root.RightChild.RightChild.RightChild = new Node("treeRootRightRightRight");
            myTree.root.RightChild.RightChild.RightChild.RightChild = new Node("treeRootRightRightRightRight");


            myTree.CheckingDepths(myTree.root, 0);
            Console.WriteLine(ChekcIfBalanced(depths));

        }

        public static bool ChekcIfBalanced(List<int> depths)
        {
            int max = depths.Max();
            int min = depths.Min();

            if (max - min > 1)
            {
                return false;
            }
            else { return true; }
        }

        public class tree
        {
            public Node root;

           

            public void CheckingDepths(Node currentNode, int currentDepth)
            {
                if (currentNode == null)
                {
                    depths.Add(currentDepth-1);   
                    return;
                }

                CheckingDepths(currentNode.LeftChild, currentDepth+1);


                CheckingDepths(currentNode.RightChild, currentDepth+1);

            }
        }
        public class Node
        {
            public string name;
            public Node LeftChild;
            public Node RightChild;

            public Node(string name)
            {
                this.name = name;
                LeftChild = null;
                RightChild = null;
            }
        }
    }
}