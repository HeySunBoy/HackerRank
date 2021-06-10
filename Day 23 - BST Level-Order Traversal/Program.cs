using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
class Solution
{

    static void levelOrder(Node root)
    {
        //Write your code here
        List<Node> lstNode = new List<Node>() { root };
        int i = 0;
        do
        {
            if (lstNode[i].left != null)
            {
                lstNode.Add(lstNode[i].left);

            }
            if (lstNode[i].right != null)
            {
                lstNode.Add(lstNode[i].right);
            }
        } while (++i < lstNode.Count);
        Console.WriteLine(string.Join(" ", lstNode.Select(o => o.data).ToArray()));
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }
    static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        levelOrder(root);

    }
}