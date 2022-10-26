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
    }

}