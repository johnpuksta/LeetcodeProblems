using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class BinarySearches
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> retList = new List<int>();
            RecusivePreorder(retList, root);
            return retList;
        }
        private void RecusivePreorder(List<int> L, TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            L.Add(root.val);
            RecusivePreorder(L, root.left);
            RecusivePreorder(L, root.right);
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> retList = new List<int>();
            RecusiveInorder(retList, root);
            return retList;
        }
        private void RecusiveInorder(List<int> L, TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            RecusiveInorder(L, root.left);
            L.Add(root.val);
            RecusiveInorder(L, root.right);
        }
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> retList = new List<int>();
            RecursivePostOrder(retList, root);
            return retList;
        }
        private void RecursivePostOrder(List<int> L, TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            RecursivePostOrder(L, root.left);
            RecursivePostOrder(L, root.right);
            L.Add(root.val);
        }
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            {
                IList<IList<int>> retList = new List<IList<int>>();
                if (root != null)
                {
                    List<int> tempL = new List<int>();
                    tempL.Add(root.val);
                    retList.Add(tempL);
                }
                int level = 1;
                RecursiveLevelOrder(retList, root, level);
                if(retList.Count != 0){
                    retList.Remove(retList.Last());
                }
                return retList;
            }
        }
        private void RecursiveLevelOrder(IList<IList<int>> L, TreeNode root, int level)
            {
                if (root == null)
                {
                    return;
                }
                while(L.Count <= level){
                    L.Add(new List<int>());
                }
                if (root.left != null)
                {
                    L[level].Add(root.left.val);
                }
                if (root.right != null)
                {
                    L[level].Add(root.right.val);
                }
                level += 1;
                RecursiveLevelOrder(L, root.left, level);
                RecursiveLevelOrder(L, root.right, level);
            }
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftMaxDepth = MaxDepth(root.left);
            var rightMaxDepth = MaxDepth(root.right);

            return Math.Max(leftMaxDepth, rightMaxDepth) + 1;
        }
 
    }
        
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
