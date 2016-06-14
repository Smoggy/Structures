using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> intTree = new BinaryTree<int>();
            
        }
    }
    //gdfgdf
    class TreeNode<T>: IComparable where T: IComparable
    {
        public TreeNode(T value)
        {
            Value = value;
        }

        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public T Value { get; set; }

        public int CompareTo(Object other)
        {
            if (other == null) return 1;
            TreeNode<T> t = other as TreeNode<T>;
            if(t != null)
            {
                return Value.CompareTo(t.Value);
            } else
            {
                throw new ArgumentException("object is not TreeNode");
            }
            
        }
    }

    public class BinaryTree<T> where T: IComparable
    {
        private TreeNode<T> root;

        public int Length { get; private set; } = 0;

        public void Insert(T value)
        {
            TreeNode<T> parent = null;
            var temp = root;
            var newNode = new TreeNode<T>(value);

            while(temp != null)
            {
                parent = temp;
                if(newNode.CompareTo(parent) < 0)
                {
                    temp = temp.Left;
                } else
                {
                    temp = temp.Right;
                }
            }

            if(parent == null)
            {
                root = newNode;
            } else if(newNode.CompareTo(parent) < 0)
            {
                parent.Left = newNode;
            } else
            {
                parent.Right = newNode;
            }

            Length++;
        }
    }
}
