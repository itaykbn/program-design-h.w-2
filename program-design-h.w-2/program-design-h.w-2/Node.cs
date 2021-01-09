using System;
using System.Collections.Generic;
using System.Text;

namespace delete_and_add_chain
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node()
        {
            
        }
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


        public override string ToString()
        {
            string str = "";
            Node<T> pos = this;
            while (pos != null)
            {
                str += pos.GetValue();
                str += " --> ";
                pos = pos.GetNext();
            }
            str += "Null";
            return str;
        }
    }


    public static class NodeExtensions
    {

        public static void Add<T>(this Node<T> node , T value)
        {
            Node<T> copy_node = node;
            node.SetNext(new Node<T>(value, copy_node.GetNext()));
        }

        public static int Length<T>(this Node<T> node)
        {
            Node<T> pos = node;
            int length = 0;
            while(pos!= null)
            {
                length++;
                pos = pos.GetNext();
            }
            return length;
        }
    }
}