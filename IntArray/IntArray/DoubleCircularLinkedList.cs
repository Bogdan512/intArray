using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrays
{
    public class DoubleCircularLinkedList
    {
        static Node root;
        static Node current;

        public void AddNode(int data)
        {
            Node node = new Node(data);

            if (root == null)
            {
                root = node;
                root.NextNode = root;
                root.PreviousNode = root;
            }
            else
            {
                current = root;
                while (current.NextNode != root)
                {
                    current = current.NextNode;
                }

                current.NextNode = node;
                node.NextNode = root;
                node.PreviousNode = current;
                root.PreviousNode = node;
            }
        }

        public void InsertNode(int data, int numberNodeToInsert)
        {
            Node temp;
            Node node = new Node(data);
            int numberNodes = 1;
            current = root;

            while (numberNodes != numberNodeToInsert)
            {
                current = current.NextNode;
                numberNodes++;
            }

            temp = current.NextNode;
            current.NextNode = node;
            node.NextNode = temp;
            temp.PreviousNode = node;
            node.PreviousNode = current;
        }

        public void DeleteNode(int nodeToDelete)
        {
            int numberNode = 1;
            current = root;

            if (nodeToDelete == 1)
            {
                root.NextNode.PreviousNode = root.PreviousNode;
                root.PreviousNode.NextNode = root.NextNode;
                root = root.NextNode;
            }
            else
            {
                while (numberNode != nodeToDelete)
                {
                    current = current.NextNode;
                    numberNode++;
                }

                current.NextNode.PreviousNode = current.PreviousNode;
                current.PreviousNode.NextNode = current.NextNode;
                current = current.NextNode;
            }
        }

        public void Print()
        {
            current = root;
            while (current.NextNode != root)
            {
                Console.Write("|" + current.Data + "|-->");
                current = current.NextNode;
            }

            Console.Write(root.PreviousNode.Data);
        }
    }
}
