using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list2
{
    internal class BinNode<T>
    {
        private T value;
        private BinNode<T>left,right;
        public BinNode(T value)
        {
            this.value = value;
            this.left =null;
            this.right = null;
        }
        public BinNode(BinNode<T> left, T value, BinNode<T> right)
        {
            this.value = value;
            this.left =left;
            this.right = right;
        }
        internal BinNode<T> GetLeft()
        {
            return left;
        }
        internal BinNode<T> GetRight()
        {
            return right;
        }
        internal void SetLeft(BinNode<T> value)
        {
            left = value;
        }
        internal void SetRight(BinNode<T> value)
        {
            right = value;
        }
        public T GetValue()
        { 
            return value; 
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public bool HasLeft()
        {
            return this.GetLeft() != null;
        }
        public bool HasRight()
        {
            return this.right != null;
        }
        public override string ToString()
        {
            return this.value + "->>";
        }
    }
    }

