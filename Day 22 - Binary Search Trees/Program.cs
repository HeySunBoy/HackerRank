using System;
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

    static int getHeight(Node root)
    {
        //Write your code here
        int max_height = 0;
        getMaxHeight(root, 0, ref max_height);
        return max_height;
    }

    static void getMaxHeight(Node node, int height, ref int max_height)
    {
        if (height > max_height)
        {
            max_height = height;
        }

        if (node.left != null)
        {
            getMaxHeight(node.left, height + 1, ref max_height);
        }
        if (node.right != null)
        {
            getMaxHeight(node.right, height + 1 , ref max_height);
        }
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
        int height = getHeight(root);
        Console.WriteLine(height);

    }
}