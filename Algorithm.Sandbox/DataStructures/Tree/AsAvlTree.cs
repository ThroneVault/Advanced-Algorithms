﻿using System;

namespace Algorithm.Sandbox.DataStructures
{
    public class AsAVLTreeNode<T> where T : IComparable
    {
        public T Value { get; set; }

        public AsAVLTree<T> Left { get; set; }
        public AsAVLTree<T> Right { get; set; }

        public bool IsLeaf => Left == null && Right == null;

        public int Height { get; set; }

        public AsAVLTreeNode(T value)
        {
            this.Value = value;
        }

    }

    public class AsAVLTree<T> where T : IComparable
    {
        public AsAVLTreeNode<T> Root { get; set; }

        public void Insert(T data)
        {

        }

        public void Delete(T data)
        {

        }
    }
}