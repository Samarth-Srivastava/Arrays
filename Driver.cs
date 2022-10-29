using System;

#nullable enable

namespace Arrays
{
    public class Driver
    {
        Solution s = new Solution();

        public void Options()
        {
            Console.WriteLine("Reverse an array: Press 1 --");
            Console.WriteLine("Rotate Right an array: Press 2 --");
            Console.WriteLine("Rotate Left an array: Press 3 --");
            Console.WriteLine("Given N array elements, count no\r\nof elements having atleast 1 element\r\ngreater than itself: Press 4 --");
            Console.WriteLine("Given N array elements, check if \r\nthere exists a pair i, j such that \r\nar[i]+a[j]==k, i!=j: Press 5 --");
            Console.WriteLine("Max of an array: Press 6 --");
            Console.WriteLine("Min of an array: Press 7 --");
            Console.WriteLine("Equilibrium Index of an array: Press 8 --");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                switch (Convert.ToInt32(input))
                {
                    case 1:
                        CallReverse();
                        break;
                    case 2: 
                        CallRightRotate();
                        break;
                    case 3: 
                        CallLeftRotate();
                        break;
                    case 4: 
                        CallCountAtleast1GreaterElement();
                        break;
                    case 5: 
                        CallCheckSumPair();
                        break;
                    case 6: 
                        CallMax();
                        break;
                    case 7: 
                        CallMin();
                        break;
                    case 8: 
                        CallEquilibriumIndexes();
                        break;
                    default: 
                        Console.Clear();    
                        break;
                }
            }
        }

        public void CallRightRotate()
        {
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            int[] arr = new int[n_arr_str.Length];
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr[i] = Convert.ToInt32(n_arr_str[i]);
            }

            Console.WriteLine("Enter no of rotations expected");
            int rotations = Convert.ToInt32(Console.ReadLine());

            arr = s.RotateRight(arr, arr.Length, rotations);

            Console.WriteLine("Rotated Array is :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(Convert.ToInt32(arr[i]) + " ");
            }
        }

        public void CallLeftRotate()
        {
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            int[] arr = new int[n_arr_str.Length];
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr[i] = Convert.ToInt32(n_arr_str[i]);
            }

            Console.WriteLine("Enter no of rotations expected");
            int rotations = Convert.ToInt32(Console.ReadLine());

            arr = s.RotateLeft(arr, arr.Length, rotations);

            Console.WriteLine("Rotated Array is :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(Convert.ToInt32(arr[i]) + " ");
            }
        }

        public void CallReverse()
        {
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            int[] arr = new int[n_arr_str.Length];
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr[i] = Convert.ToInt32(n_arr_str[i]);
            }

            arr = s.Reverse(arr, 0, arr.Length - 1);

            Console.WriteLine("Reversed Array is :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(Convert.ToInt32(arr[i]) + " ");
            }
        }

        public void CallCountAtleast1GreaterElement()
        {
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            int[] arr = new int[n_arr_str.Length];
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr[i] = Convert.ToInt32(n_arr_str[i]);
            }

            int count = s.CountAtleast1GreaterElement(arr, arr.Length);

            Console.WriteLine(count);
            
        }

        public void CallCheckSumPair()
        {
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            int[] arr = new int[n_arr_str.Length];
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr[i] = Convert.ToInt32(n_arr_str[i]);
            }

            Console.WriteLine("Enter sum");
            int sum = Convert.ToInt32(Console.ReadLine());

            bool exists = s.CheckSumPair(arr, arr.Length, sum);

            Console.WriteLine(exists);
            
        }

        public void CallMax()
        {
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            int[] arr = new int[n_arr_str.Length];
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr[i] = Convert.ToInt32(n_arr_str[i]);
            }
            
            int max = s.Max(arr, arr.Length);

            Console.WriteLine(max);
            
        }

        public void CallMin()
        {
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            int[] arr = new int[n_arr_str.Length];
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr[i] = Convert.ToInt32(n_arr_str[i]);
            }
            
            int min = s.Min(arr, arr.Length);

            Console.WriteLine(min);
            
        }

        public void CallEquilibriumIndexes()
        {
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            int[] arr = new int[n_arr_str.Length];
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr[i] = Convert.ToInt32(n_arr_str[i]);
            }
            
            int[] indexArr = s.GetEquilibriumIndexesOfArray(arr, arr.Length);

            Console.WriteLine("Equlibrium Indexes are :");
            for (int i = 0; i < arr.Length; i++)
            {
                if(indexArr[i] != -1){
                    Console.Write(Convert.ToInt32(indexArr[i]) + " ");
                }
            }
            
        }
    }

}