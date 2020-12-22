using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program_design_h.w_2
{
    class Recursion
    {
        public void TriRev(int numb)
        {
            if (numb == 1)
                Console.WriteLine("*");
            else
            {
                TriRev(numb - 1);
                Console.WriteLine(String.Concat(Enumerable.Repeat("*",numb)));
            }
        }

        public void Tri(int numb)
        {
            if (numb == 1)
                Console.WriteLine("*");
            else
            {
                for (int i = 1; i <= numb; i++)
                    Console.Write("*");
                Console.WriteLine();
                Tri(numb - 1);
            }
        }

        public bool CheckIfArrInRange(int[] array, int min, int max,int index = 0)
        {
            if(index == array.Length -1)
            {
                return checkIfInRange(array[index]) && checkIfInRange(array[0]);
            }
            return CheckIfArrInRange(array,min,max,index+1);



            bool checkIfInRange(int num)
            {
                if (num > min && num < max)
                {
                    return true;
                }
                return false;
            }
        }

        //Array Exercises...........................
        public int Ex1arr(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                if (arr[index] % 2 == 0)
                    return 1;
                return 0;
            }
            if (arr[index] % 2 == 0)
                return 1 + Ex1arr(arr, index + 1);

            return Ex1arr(arr, index + 1);

        }
        //-------------------------------------
        public int Ex1arr(int[] arr)
        {
            int index = 0;

            return Ex1arr(arr, index);
        }
        //---------------------------------------
        public bool Ex3arr(int[] arr, int index)
        {
            if (index == arr.Length - 2)
            {
                if (arr[index] < arr[index + 1])
                    return true;
                return false;
            }
            if (arr[index] >= arr[index + 1])
                return false;
            return Ex3arr(arr, index + 1);
        }
        //-------------------------------------
        public bool Ex3arr(int[] arr)
        {
            int index = 0;

            return Ex3arr(arr, index);
        }
        //---------------------------------------
        public int Ex4arr(int[] arr, int index, int num)
        {
            if (index == arr.Length - 1)
            {
                if (arr[index] % num == 0)
                    return 1;
                return 0;
            }
            if (arr[index] % num == 0)
                return 1 + Ex4arr(arr, index + 1, num);

            return Ex4arr(arr, index + 1, num);
        }

        public int Ex4arr(int[] arr, int num)
        {
            int index = 0;

            return Ex4arr(arr, index, num);
        }
        //-------------------------------------
        public int Ex2Arr(int[] arr, int index)
        {
            if (index == arr.Length - 1)

                return arr[index];

            int temp = Ex2Arr(arr, index + 1);

            if (arr[index] > temp)

                return arr[index];

            return temp;
        }
        //---------------------------------------------
        public bool Ex5Arr(int[] arr1, int[] arr2, int index = 0)
        {
            if (index == arr1.Length - 1)
            {
                return checkIfArraysEqualsInIndex(index);
            }
            return Ex5Arr(arr1, arr2, index + 1) && checkIfArraysEqualsInIndex(index);


            bool checkIfArraysEqualsInIndex(int idx)
            {
                return (arr1[idx] == arr2[idx]);
            }
        }
        //---------------------------------------------
        public bool Ex6Arr(int[] sortedArr, int num, int index = 0)
        {
            if (index == sortedArr.Length - 1)
            {
                return checkIfArraysContains(index);
            }
            if (num < sortedArr[index])
            {
                return false;
            }
            return Ex6Arr(sortedArr, num, index + 1) || checkIfArraysContains(index);

            bool checkIfArraysContains(int idx)
            {
                return (sortedArr[idx] == num);
            }
        }


        // recursia with no returns.................
        public void Print_rev_num(int numb)
        {
            if (numb < 10)
                Console.Write(numb);
            else
            {
                Console.Write(numb % 10);
                Print_rev_num(numb / 10);
            }
        }
        //---------------------------------------
        public void Print_to_One(int numb)
        {
            if (numb == 1)
                Console.Write(numb + " ");
            else
            {
                Console.Write(numb + " ");
                Print_to_One(numb - 1);
            }
        }
        //---------------------------------------
        public void One_To_Numb(int numb)
        {
            if (numb == 1)
                Console.Write(numb + " ");
            else
            {
                One_To_Numb(numb - 1);

                Console.Write(numb + " ");
            }
        }
        //---------------------------------------
        public void Print_Stars(int numb)
        {
            if (numb == 1)
                Console.WriteLine("*");
            else
            {
                for (int i = 1; i <= numb; i++)

                    Console.Write("*");

                Console.WriteLine();

                Print_Stars(numb - 1);

                for (int i = 1; i <= numb; i++)

                    Console.Write("*");

                Console.WriteLine();
            }
        }


        //Recursia with return......................
        public int CountMe(int numb)
        {
            if (numb < 10)
                return 1;
            return 1 + CountMe(numb / 10);
        }
        //---------------------------------------
        public int SumMe(int numb)
        {
            if (numb < 10)
                return numb;
            return numb % 10 + SumMe(numb / 10);
        }
        //---------------------------------------
        public int Hezka(int x, int y)
        {
            if (y == 1)
                return x;
            return x * Hezka(x, y - 1);
        }



        //page 32...................................
        public int SumDigits(int num)
        {
            if (num < 10)
                return num;
            return num % 10 + SumDigits(num / 10);
        }
        //---------------------------------------
        public int Ex42Page32(int num)
        {
            if (num < 10)
                return num;
            num = SumDigits(num);
            return (Ex42Page32(num));
        }
        //---------------------------------------


        //page 28...................................

    }
}
