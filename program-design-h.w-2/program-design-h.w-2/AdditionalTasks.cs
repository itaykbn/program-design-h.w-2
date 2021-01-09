using System;
using System.Collections.Generic;
using System.Text;
using delete_and_add_chain;
using Queue;

namespace program_design_h.w_2
{
    class AdditionalTasks
    {
        public int LastAndRemove(Node<int> list)
        {
            Node<int> pos = list;
            while (pos.GetNext().GetNext() != null)
            {
                pos = pos.GetNext();
            }
            int value = pos.GetNext().GetValue();
            pos.SetNext(null);
            return value;
        }

        public Node<KeyValuePair<int, int>> GetEqualDistancePairs(Node<int> list1)
        {
            Node<KeyValuePair<int, int>> list2 = new Node<KeyValuePair<int, int>>();
            if (list1.Length() % 2 == 0)
                while (list1 != null)
                {
                    list2.Add(new KeyValuePair<int, int>(list1.GetValue(), LastAndRemove(list1)));
                    list1 = list1.GetNext();
                }
            else
            {
                while (list1.GetNext() != null)
                {
                    list2.Add(new KeyValuePair<int, int>(list1.GetValue(), LastAndRemove(list1)));
                    list1 = list1.GetNext();
                }

                list2.Add(new KeyValuePair<int, int>(list1.GetValue(), list1.GetValue()));

            }
            return list2.GetNext();
        }

        // --------------------------------------------------------------------------------------

        public MyQueue<char> GetGreatestCharFromSeperation(MyQueue<char> seperatedQueue)
        {
            MyQueue<char> result = new MyQueue<char>();
            char maxChar = char.MinValue;
            while (!seperatedQueue.IsEmpty())
            {
                char extractedValue = seperatedQueue.Remove();
                if (extractedValue != '#')
                {
                    if (extractedValue > maxChar)
                    {
                        maxChar = extractedValue;
                    }
                }
                else
                {
                    result.Insert(maxChar);
                    maxChar = char.MinValue;
                }
            }
            result.Insert(maxChar);
            return result;
        }
        // --------------------------------------------------------------------------------------

          


        // --------------------------------------------------------------------------------------


    }
}
