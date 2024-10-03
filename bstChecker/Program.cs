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
            
        }

        public bool ChekcIfBalanced(List<int> depths)
        {
            int max = depths.Max();
            int min = depths.Min();

            if (max - min < 1) { return true; }
            return false;
        }

        public class tree
        {
            public Node root;

           

            public void CheckingDepths(Node currentNode, int currentDepth)
            {
                if (currentNode == null)
                {
                    depths.Add(currentDepth);   
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