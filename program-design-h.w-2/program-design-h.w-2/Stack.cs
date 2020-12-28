using delete_and_add_chain;
using System.Collections.Generic;

namespace Stack
{
    class MyStack<T>
    {
        public Node<T> first { get; set; }

        public MyStack()
        {
            this.first = null;
        }

        public bool IsEmpty()
        {
            return this.first == null;
        }

        public void Push(T value)
        {
            this.first = new Node<T>(value, this.first);
        }
        public T Top()
        {
            return this.first.GetValue();
        }
        public T Pop()
        {
            T value = this.first.GetValue();

            this.first = this.first.GetNext();

            return value;
        }

        public int Size()
        {
            Node<T> pos = this.first;
            int count = 0;

            while (pos != null)
            {
                count++;
                pos = pos.GetNext();
            }
            return count;
        }

        public override string ToString()
        {
            string st = "[";
            Node<T> pos = this.first;

            while (pos != null)
            {
                st += pos.GetValue() + "-->";
                pos = pos.GetNext();
            }
            st += "Null]";
            return st;
        }
    }
}