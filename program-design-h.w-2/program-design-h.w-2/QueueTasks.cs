using System;
using System.Collections.Generic;
using System.Text;
using delete_and_add_chain;
using Queue;
using System.Linq;
using Stack;
namespace program_design_h.w_2
{
    class QueueTasks
    {
        //tested
        public void DequeueJobsThatCanBeDone(int time, MyQueue<Job> jobs)
        {
            MyQueue<Job> unwantedJobs = new MyQueue<Job>();
            while (!jobs.IsEmpty())
            {
                Job job = jobs.Remove();
                if (job.Deadline <= time)
                {
                    Console.WriteLine(job.WorkCode);
                    time -= job.Deadline;
                }
                else
                {
                    break;
                }
            }

        }

        //not tested
        public void MergeSupermarketQueues(MyQueue<string> closedQ, MyQueue<string> openQ)
        {
            MyQueue<string> mergedQuque = new MyQueue<string>();
            int interval = 0;
            while (!closedQ.IsEmpty() && !openQ.IsEmpty())
            {
                if (interval % 2 == 0)
                {
                    mergedQuque.Insert(closedQ.Remove());
                }
                else
                {
                    mergedQuque.Insert(openQ.Remove());
                }
                interval++;
            }
            if (closedQ.IsEmpty())
            {
                while (!openQ.IsEmpty())
                {
                    mergedQuque.Insert(openQ.Remove());
                }
            }
            else
            {
                while (!closedQ.IsEmpty())
                {
                    mergedQuque.Insert(closedQ.Remove());
                }
            }

            while (!mergedQuque.IsEmpty())
            {
                openQ.Insert(mergedQuque.Remove());
            }

        }

        //tested
        private void CheckLastChar(int lastNUm, int queueNum, MyQueue<int> queue, MyQueue<int> mergedQueue)
        {
            while (!queue.IsEmpty())
            {
                if (lastNUm < queueNum)
                {
                    mergedQueue.Insert(lastNUm);
                    lastNUm = int.MaxValue;
                }
                queueNum = queue.Remove();
                mergedQueue.Insert(queueNum);

            }
        }

        //tested
        public MyQueue<int> MergeSortedQueues(MyQueue<int> q1, MyQueue<int> q2)
        {
            MyQueue<int> mergedQueue = new MyQueue<int>();
            int q1Num = q1.Remove();
            int q2Num = q2.Remove();
            while (!q1.IsEmpty() || !q2.IsEmpty())
            {
                if (q1Num < q2Num)
                {
                    mergedQueue.Insert(q1Num);
                    q1Num = q1.Remove();
                }
                else if (q1Num > q2Num)
                {
                    mergedQueue.Insert(q2Num);
                    q2Num = q2.Remove();
                }
                else
                {
                    mergedQueue.Insert(q1Num);
                    q1Num = q1.Remove();
                    q2Num = q2.Remove();
                }
            }

            if (!q1.IsEmpty())
            {
                CheckLastChar(q2Num, q1Num, q1, mergedQueue);
            }
            else if (!q2.IsEmpty())
            {
                CheckLastChar(q1Num, q2Num, q2, mergedQueue);
            }

            else
            {
                mergedQueue.Insert(Math.Min(q1Num, q2Num));
                mergedQueue.Insert(Math.Max(q1Num, q2Num));
            }
            return mergedQueue;
        }

        //tested
        public string SendCarrier(int requiredEngieneCapacity, MyQueue<Carrier> Carriers)
        {
            MyQueue<Carrier> unwantedCarriers = new MyQueue<Carrier>();
            Carrier wantedCarrier = null;
            bool found = false;
            while (!Carriers.IsEmpty())
            {
                Carrier carrier = Carriers.Remove();
                if (carrier.EngieneCapacity >= requiredEngieneCapacity && !found)
                {
                    wantedCarrier = carrier;
                    found = true;
                }
                else
                {
                    unwantedCarriers.Insert(carrier);
                }
            }
            while (!unwantedCarriers.IsEmpty())
            {
                Carriers.Insert(unwantedCarriers.Remove());
            }

            if (wantedCarrier != null)
            {
                Carriers.Insert(wantedCarrier);
                return wantedCarrier.ID;
            }
            else
            {
                return "You live to far sorry - service unavilable";
            }

        }

        //tested
        public MyQueue<int> ReverseQueue(MyQueue<int> queue)
        {
            MyStack<int> tempStack = new MyStack<int>();
            MyQueue<int> result = new MyQueue<int>();
            while (!queue.IsEmpty())
            {
                tempStack.Push(queue.Remove());
            }
            while (!tempStack.IsEmpty())
            {
                result.Insert(tempStack.Pop());
            }
            return result;
        }

        //tested
        public MyQueue<int> ReverseQueueRecursion(MyQueue<int> queue, int value)
        {
            if (queue.IsEmpty())
            {
                MyQueue<int> reversedQueue = new MyQueue<int>();
                reversedQueue.Insert(value);
                return reversedQueue;
            }
            int popped = queue.Remove();
            MyQueue<int> myQueue = ReverseQueueRecursion(queue, popped);
            myQueue.Insert(value);
            return myQueue;

        }

        //tested
        public int GetSize(MyQueue<int> queue)

        {
            int count = 0;
            MyQueue<int> temp = new MyQueue<int>();
            while (!queue.IsEmpty())
            {
                temp.Insert(queue.Remove());
                count++;
            }
            while (!temp.IsEmpty())
            {
                queue.Insert(temp.Remove());
            }
            return count;
        }

        //tested
        public MyQueue<int> GetPairQueue(MyQueue<int> queue)
        {
            MyQueue<int> pairQueue = new MyQueue<int>();
            int size = GetSize(queue);
            int[] posCount = new int[size];
            int i = 0;
            while (!queue.IsEmpty())
            {
                int value = queue.Remove();
                if (posCount.Contains(value))
                {
                    pairQueue.Insert(value);
                }
                posCount[i] = value;
                i++;
            }
            return pairQueue;
        }

        //tested
        public MyQueue<int> GetMiddleQueue(int m, MyQueue<int> queue)
        {
            int queueSize = GetSize(queue);
            int posStartMiddleNums = (queueSize - m) / 2;
            int i = 0;
            int count = 0;
            MyQueue<int> temp = new MyQueue<int>();
            MyQueue<int> middleQueue = new MyQueue<int>();

            while (!queue.IsEmpty())
            {
                int value = queue.Remove();
                if (i >= posStartMiddleNums && count < 3)
                {
                    middleQueue.Insert(value);
                    count++;
                }
                temp.Insert(value);
                i++;
            }
            while (!temp.IsEmpty())
            {
                queue.Insert(temp.Remove());
            }
            return middleQueue;

        }


        //tested
        public string OperateDriveAndHike(DateTime date1, DateTime date2, string tripID, MyQueue<Trip> trips)
        {
            DriveAndHike driveAndHike = new DriveAndHike(trips);

            double totalSum = driveAndHike.TotalIncome(tripID);
            double sumForPeriodOfTime = driveAndHike.IncomeForPeriodOfTime(date1, date2);

            return $"Total income : {totalSum}\nIncome for period of time : {sumForPeriodOfTime}";
        }


        //tested
        public void ArrangeShop(DateTime date)
        {
            MyQueue<Product> products1 = new MyQueue<Product>();
            products1.Insert(new Product(new DateTime(2020, 01, 06), "IceCream"));
            products1.Insert(new Product(new DateTime(2020, 01, 05), "IceCream"));
            products1.Insert(new Product(new DateTime(2020, 01, 04), "IceCream"));
            products1.Insert(new Product(new DateTime(2020, 01, 03), "IceCream"));
            products1.Insert(new Product(new DateTime(2020, 01, 01), "IceCream"));
            products1.Insert(new Product(new DateTime(2020, 01, 01), "IceCream"));

            MyQueue<Product> products2 = new MyQueue<Product>();
            products2.Insert(new Product(new DateTime(2020, 01, 01), "Milk"));
            products2.Insert(new Product(new DateTime(2020, 01, 03), "Milk"));
            products2.Insert(new Product(new DateTime(2020, 01, 02), "Milk"));
            products2.Insert(new Product(new DateTime(2020, 01, 05), "Milk"));
            products2.Insert(new Product(new DateTime(2020, 01, 04), "Milk"));
            products2.Insert(new Product(new DateTime(2020, 01, 06), "Milk"));

            MyQueue<Product>[] allProducts = new MyQueue<Product>[] { products1, products2 };



            Shop shop = new Shop(allProducts);
            shop.ArrangeProducts(date);
        }





    }
}

