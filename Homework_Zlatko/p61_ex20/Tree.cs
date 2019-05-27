using System;

namespace p61_ex20
{
    class Tree
    {
        public Unit Insert(Unit root, int val)
        {
            if (root == null)
            {
                root = new Unit();
                root.value = val;
            }
            else if (val < root.value) root.left = Insert(root.left, val);
            else root.right = Insert(root.right, val);
            return root;
        }
        public bool Correct(Unit root, int a)
        {
            return root.value == a;
        }
        public bool Search(Unit root, int b)
        {
            try
            {
                if (root == null || root.value == b)
                { 
                    return true;
                }
                if (root.value > b) return Search(root.left, b);
                return Search(root.right, b);
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }
        public int MinVal(Unit root)
        {
            Unit current = root;
            while (current.left != null)
            {
                current = current.left;
            }
            return current.value;
        }
        public int MaxVal(Unit root)
        {
            Unit current = root;
            while (current.right != null)
            {
                current = current.right;
            }
            return current.value;
        }
    }
}
