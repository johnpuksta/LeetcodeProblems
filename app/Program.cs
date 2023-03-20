using System.Numerics;

namespace app
{
    class Solution {
        static void Main(string[] args)
        {
            TreeNode p = new TreeNode(3);
            p.left = new TreeNode(9);
            p.right = new TreeNode(20);
            p.right.left = new TreeNode(15);
            p.right.right = new TreeNode(7);
            BinarySearches test = new BinarySearches();
            var t = test.MaxDepth(p);
        }
    }
}

