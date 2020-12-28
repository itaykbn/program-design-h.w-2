using System;
using System.Collections.Generic;
using System.Text;
using delete_and_add_chain;
namespace Queue
{
    class MyQueue<T>
    {
        private Node<T> first;

        private Node<T> last;
        //-----------------------------------
        public MyQueue()
        {
            this.first = null;

            this.last = null;
        }
        //-----------------------------------
        public bool IsEmpty()
        {
            return (this.first == null);
        }
        //-----------------------------------
        public void Insert(T x)
        {
            Node<T> temp = new Node<T>(x);

            if (this.first == null)

                this.first = temp;
            else
                this.last.SetNext(temp);
            this.last = temp;

        }
        //-------------------------------------
        public T Remove()
        {
            T value = this.first.GetValue();

            this.first = this.first.GetNext();

            if (this.first == null)
                this.last = null;

            return value;
        }
        //-------------------------------------
        public T Head()
        {
            return this.first.GetValue();
        }

        //-------------------------------------
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
