using System;
using delete_and_add_chain;
using Queue;
using System.Collections.Generic;
namespace program_design_h.w_2
{
    class Program
    {
        static void Main(string[] args)
        {
            RecursionTasks recursion = new RecursionTasks();
            QueueTasks queueTasks = new QueueTasks();
            AdditionalTasks additionalTasks = new AdditionalTasks();

            MyQueue<Trip> trips = new MyQueue<Trip>();
            MyQueue<Family> familyQ1 = new MyQueue<Family>();
            familyQ1.Insert(new Family("1","shiran", 1));
            familyQ1.Insert(new Family("1","miki", 2));
            familyQ1.Insert(new Family("1","lili", 2));
            familyQ1.Insert(new Family("1","zizi", 6));
            trips.Insert(new Trip("Tel aviv","1", new DateTime(2020, 3, 5),100, familyQ1));  

            MyQueue<Family> familyQ2 = new MyQueue<Family>();
            familyQ2.Insert(new Family("2","shiran", 4));
            familyQ2.Insert(new Family("2","miki", 2));
            familyQ2.Insert(new Family("2","lili", 3));
            familyQ2.Insert(new Family("2","zizi", 5));
            trips.Insert(new Trip("Jerusalem","2", new DateTime(2020, 3, 3),80, familyQ2));

            Console.WriteLine(queueTasks.OperateDriveAndHike(new DateTime(2020, 3, 4), new DateTime(2020, 4, 4), "2",trips));

            //OperateSuperMarket();
            //GetGreatestCharFromSeperation(additionalTasks);
            //GetEqualDistancePairs(additionalTasks);
            //Console.WriteLine(Trouble(2,6));
            //TestTrackingTableQueue();
            //DisplayAsTable(recursion);
            //recursion.PrintAllEvenDigits(123456789);
            //MergeSuperQueues(queueTasks);
            //ArrangeSHop(queueTasks);
            //GetMiddleQueue(queueTasks);
            //GetPairQueue(queueTasks);
            //ReverseQueue(queueTasks);
            //MergeSortedQueues(queueTasks);
            //Jobs(queueTasks);
            //Carriers(queueTasks);
        }

        private static void OperateSuperMarket()
        {
            Supermarket supermarket = new Supermarket();
            for (int i = 0; i < 100; i++)
            {
                supermarket.AddToSuperMarketQueue("itay");
            }
            supermarket.ArrangeAClosedLine(1);



            foreach (var line in supermarket.Lines)
            {
                Console.WriteLine(line.Clients);
            }
        }

        private static void GetGreatestCharFromSeperation(AdditionalTasks additionalTasks)
        {
            MyQueue<char> seperatedQueue = new MyQueue<char>();
            seperatedQueue.Insert('t');
            seperatedQueue.Insert('a');
            seperatedQueue.Insert('x');
            seperatedQueue.Insert('#');
            seperatedQueue.Insert('m');
            seperatedQueue.Insert('#');
            seperatedQueue.Insert('r');
            seperatedQueue.Insert('a');
            seperatedQueue.Insert('b');


            Console.WriteLine(additionalTasks.GetGreatestCharFromSeperation(seperatedQueue));
        }

        private static void GetEqualDistancePairs(AdditionalTasks additionalTasks)
        {
            Node<int> list =
                new Node<int>(1,
                new Node<int>(2,
                new Node<int>(3,
                new Node<int>(5,
                new Node<int>(6)
                ))));

            Node<KeyValuePair<int, int>> result = additionalTasks.GetEqualDistancePairs(list);

            while (result != null)
            {
                Console.WriteLine($"{result.GetValue().Value} , {result.GetValue().Key}");
                result = result.GetNext();
            }
        }

        private static double Trouble(double a, double b)
        {
            double t1, t2;
            if (a >= b)
            {
                return (a + b) / 2.00;
            }
            else
            {
                t1 = Trouble(a + 2, b - 1);
                t2 = Trouble(a + 1, b - 2);
                //Console.WriteLine(t1);
                //Console.WriteLine(t2);
                //Console.WriteLine("a - " + a + " b - "+b);
            }

            return Trouble(t1, t2);


        }

        private static void TestTrackingTableQueue()
        {
            MyQueue<MyQueue<int>> que = new MyQueue<MyQueue<int>>();
            MyQueue<int> q1 = new MyQueue<int>();
            q1.Insert(5);
            q1.Insert(2);
            q1.Insert(13);
            q1.Insert(54);
            MyQueue<int> q2 = new MyQueue<int>();
            MyQueue<int> q3 = new MyQueue<int>();
            q3.Insert(841);
            q3.Insert(27);
            q3.Insert(500);
            MyQueue<int> q4 = new MyQueue<int>();
            q4.Insert(12);
            MyQueue<int> q5 = new MyQueue<int>();
            q5.Insert(7);
            q5.Insert(2);
            q5.Insert(4);
            q5.Insert(3);
            q5.Insert(11);
            MyQueue<int> q6 = new MyQueue<int>();
            q6.Insert(8);
            q6.Insert(5);

            que.Insert(q1);
            que.Insert(q2);
            que.Insert(q3);
            que.Insert(q4);
            que.Insert(q5);
            que.Insert(q6);

            MyQueue<double> qNew = new MyQueue<double>();
            MyQueue<int> q;
            while (!que.IsEmpty())
            {
                q = que.Remove();
                int sum = 0, count = 0;
                while (!q.IsEmpty())
                {
                    sum += q.Remove();
                    Console.WriteLine(sum);
                    count++;
                    //Console.WriteLine(count);
                }
                if (count != 0)
                {
                    qNew.Insert((double)sum / count);
                }
            }
            Console.WriteLine(qNew.ToString());
        }

        private static void DisplayAsTable(RecursionTasks recursion)
        {
            int[][] map = new int[][] {
                new int[] {1,2,3,4 },
                new int[] {5,6,7,8 },
                new int[] {9,11,12,13 }
            };
            recursion.PrintMapAsTable(map);
        }

        private static void MergeSuperQueues(QueueTasks queueTasks)
        {
            MyQueue<string> closedQ = new MyQueue<string>();
            closedQ.Insert("closed1");
            closedQ.Insert("closed2");
            closedQ.Insert("closed3");
            closedQ.Insert("closed4");
            closedQ.Insert("closed5");
            closedQ.Insert("closed6");
            closedQ.Insert("closed7");
            closedQ.Insert("closed8");
            closedQ.Insert("closed9");
            closedQ.Insert("closed10");
            closedQ.Insert("closed11");
            closedQ.Insert("closed12");

            MyQueue<string> openQ = new MyQueue<string>();
            openQ.Insert("open1");
            openQ.Insert("open2");
            openQ.Insert("open3");
            openQ.Insert("open4");
            openQ.Insert("open5");
            openQ.Insert("open6");
            openQ.Insert("open7");
            openQ.Insert("open8");
            openQ.Insert("open9");



            queueTasks.MergeSupermarketQueues(closedQ, openQ);
            Console.WriteLine(openQ.ToString());
        }

        private static void ArrangeSHop(QueueTasks queueTasks)
        {
            DateTime date1 = new DateTime(2021, 11, 2);
            DateTime date2 = new DateTime(2020, 11, 3);
            queueTasks.ArrangeShop(new DateTime(2020, 01, 02));
        }

        private static void GetMiddleQueue(QueueTasks queueTasks)
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Insert(2);
            queue.Insert(5);
            queue.Insert(6);
            queue.Insert(9);
            queue.Insert(1);
            queue.Insert(3);

            MyQueue<int> middleQueue = queueTasks.GetMiddleQueue(3, queue);
            Console.WriteLine(queue.ToString());
            Console.WriteLine(middleQueue.ToString());
        }

        private static void GetPairQueue(QueueTasks queueTasks)
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Insert(2);
            queue.Insert(4);
            queue.Insert(1);
            queue.Insert(5);
            queue.Insert(7);
            queue.Insert(8);
            queue.Insert(9);
            queue.Insert(1);
            queue.Insert(5);
            queue.Insert(2);

            MyQueue<int> pairQueue = queueTasks.GetPairQueue(queue);
            Console.WriteLine(pairQueue.ToString());
        }

        private static void ReverseQueue(QueueTasks queueTasks)
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);
            queue.Insert(4);

            MyQueue<int> Revqueue = queueTasks.ReverseQueue(queue);
        }

        private static void MergeSortedQueues(QueueTasks queueTasks)
        {
            MyQueue<int> q1 = new MyQueue<int>();
            MyQueue<int> q2 = new MyQueue<int>();

            q1.Insert(1);
            q1.Insert(3);
            q1.Insert(8);


            q2.Insert(1);
            q2.Insert(4);
            q2.Insert(5);
            q2.Insert(6);
            q2.Insert(7);
            MyQueue<int> queue = queueTasks.MergeSortedQueues(q2, q1);
        }

        private static void Carriers(QueueTasks queueTasks)
        {
            MyQueue<Carrier> carriers = new MyQueue<Carrier>();
            carriers.Insert(new Carrier("1", 3));
            carriers.Insert(new Carrier("2", 4));
            carriers.Insert(new Carrier("3", 8));
            carriers.Insert(new Carrier("4", 16));
            carriers.Insert(new Carrier("5", 15));
            carriers.Insert(new Carrier("6", 17));
            carriers.Insert(new Carrier("7", 14));

            Console.WriteLine(queueTasks.SendCarrier(14, carriers));
            Console.WriteLine("");
        }

        private static void Jobs(QueueTasks queueTasks)
        {
            MyQueue<Job> jobs = new MyQueue<Job>();

            jobs.Insert(new Job("1", 3));
            jobs.Insert(new Job("2", 3));
            jobs.Insert(new Job("3", 4));
            jobs.Insert(new Job("4", 3));
            jobs.Insert(new Job("5", 1));
            jobs.Insert(new Job("6", 17));
            jobs.Insert(new Job("7", 2));
            jobs.Insert(new Job("8", 10));


            queueTasks.DequeueJobsThatCanBeDone(14, jobs);
        }


        private static void PrintThisRev(int[] a, int n)
        {
            if (n < 0)
            {
                return;
            }
            Console.Write(a[n]);
            if (CheckPrime(a[n], a[n] - 1))
            {
                Console.WriteLine(" - is prime.");
            }
            else
            {
                Console.WriteLine(" - is not prime.");
            }

            PrintThisRev(a, n - 1);

        }
        private static bool CheckPrimeFor(int n, int k)
        {
            bool flag = true;
            for (int i = k; i > 1; i--)
            {
                if (n % i == 0)
                {
                    flag = false;
                }
            }
            return flag;
        }
        private static bool CheckDiv(int n, int k)
        {
            if (n < k)
            {
                return false;
            }
            if (n == k)
            {
                return true;
            }
            return CheckDiv(n - k, k);
        }
        private static bool CheckPrime(int n, int k)
        {
            if (k == 1)
            {
                return true;
            }
            if (CheckDiv(n, k))
            {
                return false;
            }
            return CheckPrime(n, k - 1);
        }
        private static bool FirstCheck(int x, int num)
        {
            if (num == 0)
            {
                return false;
            }
            if (num % 10 == x)
            {
                return true;
            }
            return FirstCheck(x, num / 10);
        }
        private static int SecondCheck(int[] a, int k)
        {
            if (k == a.Length - 1)
            {
                return 0;
            }
            Console.WriteLine(FirstCheck(a[k] % 10, a[k + 1]));
            if (FirstCheck(a[k] % 10, a[k + 1]))
            {
                //Console.WriteLine($"{a[k]%10} in {a[k+1]}");
                int t = SecondCheck(a, k + 1) + 1;
                return t;
                Console.WriteLine(t);


            }
            int r = SecondCheck(a, k + 1);
            return r;
            Console.WriteLine(r);

        }
    }
}
