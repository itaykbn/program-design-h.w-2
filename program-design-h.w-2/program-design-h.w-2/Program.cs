using System;

namespace program_design_h.w_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursion recursion = new Recursion();
            Console.WriteLine(recursion.Ex6Arr(new int[] {1,2,4,5}, 3));
            //Console.WriteLine(Mystery(233193123));
            
        }
        
        public static int Mystery(int num)
        {
            if (num < 10)
            {
                return num;
            }
            else
            {
                int x = num%10;
                int y = Mystery(num / 10);
                if (x > y)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            }
        }
    }
}
