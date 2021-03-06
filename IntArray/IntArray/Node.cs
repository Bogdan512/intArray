﻿using System;
using System.Text;

namespace IntArrays
{
    public class Node<T>
    {
        readonly T data;

        public Node(T data)
        {
            this.data = data;
        }

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

        public Node<T> Head { get; set; }

        public T GetData()
        {
            return data;
        }
    }
}
