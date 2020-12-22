using System;

namespace program_design_h.w_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursion recursion = new Recursion();
            // Console.WriteLine(recursion.Ex6Arr(new int[] {1,2,4,5}, 3));
            // Console.WriteLine(SecondCheck(new int[] {400,200,100,25,351,33,34}, 0));     
            int[] a = new int[] { 4, 5, 13, 6, 2, 3, 9, 10, 11, 12 };
            PrintThisRev(a,a.Length - 1);

        }


        public static void PrintThisRev(int[] a, int n)
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

            PrintThis(a, n - 1);

        }

        public static bool CheckPrimeFor(int n, int k)
        {
            bool flag = true;
            for (int i = k; i > 1; i--)
            {
                if(n%i == 0)
                {
                    flag = false;
                }
            }
            return flag;
        }


        public static bool CheckDiv(int n, int k)
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

        public static bool CheckPrime(int n, int k)
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
        public static bool FirstCheck(int x, int num)
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

        public static int SecondCheck(int[] a, int k)
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
