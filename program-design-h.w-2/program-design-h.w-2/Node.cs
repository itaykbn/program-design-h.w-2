using System;
using System.Collections.Generic;
using System.Text;

namespace delete_and_add_chain
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node(T value)
        {
            this.value = value;
            next = null;
        }

        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }

        public T GetValue()
        {
            return value;
        }

        public void SetValue(T value)
        {
            this.value = value;
        }

        public Node<T> GetNext()
        {
            return next;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public bool HasNext()
        {
            return (next != null);
        }

        public void Add(T value)
        {
            Node<T> copy_node = this;
            SetNext(new Node<T>(value, copy_node.GetNext()));
        }
    }
}
