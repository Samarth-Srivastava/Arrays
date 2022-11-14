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
            Console.WriteLine("Prefix Sum array: Press 9 --");
            Console.WriteLine("Special Index of an array: Press 10 --");
            Console.WriteLine("Count A G pairs in an array: Press 11 --");
            Console.WriteLine("Closest Min Max in an array: Press 12 --");
            Console.WriteLine("Leaders in an array: Press 13 --");
            Console.WriteLine("All Sub Arrays in an array: Press 14 --");
            Console.WriteLine("Max Sub Array Sum in an array: Press 15 --");
            Console.WriteLine("All Sub Array Sum in an array: Press 16 --");
            Console.WriteLine("Starting Index of Least Average Sub Array Sum in an array: Press 17 --");
            Console.WriteLine("Pick from both sides: Press 18 --");
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
                    case 9: 
                        CallPrefixSum();
                        break;
                    case 10: 
                        CallSpecialIndexes();
                        break;
                    case 11: 
                        CallCountAGPairs();
                        break;
                    case 12: 
                        CallClosestMinMax();
                        break;
                    case 13: 
                        CallLeaders();
                        break;
                    case 14: 
                        CallAllSubArrays();
                        break;
                    case 15: 
                        CallmaxSubArraySum();
                        break;
                    case 16: 
                        CallGetSumOfAllSubArrays();
                        break;
                    case 17:
                        Call_GetIndexOfSubarrayOfSizeBWithLeastAverage();
                        break;
                    case 18:
                        CallPickFromBothSides();
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

        public void CallPrefixSum(){
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            int[] sfarr = new int[n_arr_str.Length];
            int[] pfarr = new int[n_arr_str.Length];
            int[] pfEvenarr = new int[n_arr_str.Length];
            int[] pfOddarr = new int[n_arr_str.Length];

            for (int i = 0; i < n_arr_str.Length; i++)
            {
                sfarr[i] = Convert.ToInt32(n_arr_str[i]);
                pfarr[i] = Convert.ToInt32(n_arr_str[i]);
                pfEvenarr[i] = Convert.ToInt32(n_arr_str[i]);
                pfOddarr[i] = Convert.ToInt32(n_arr_str[i]);
            }
            
            pfarr = s.GetPrefixSumArray(pfarr, pfarr.Length);
            sfarr = s.GetSuffixSumArray(sfarr, sfarr.Length);
            pfEvenarr = s.GetPrefixEvenArray(pfEvenarr, pfEvenarr.Length);
            pfOddarr = s.GetPrefixOddArray(pfOddarr, pfOddarr.Length);

            Console.WriteLine("Prefix Sum array is :");
            for (int i = 0; i < pfarr.Length; i++)
            {
                Console.Write(Convert.ToInt32(pfarr[i]) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Suffix Sum array is :");
            for (int i = 0; i < sfarr.Length; i++)
            {
                Console.Write(Convert.ToInt32(sfarr[i]) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Prefix Even array is :");
            for (int i = 0; i < pfEvenarr.Length; i++)
            {
                Console.Write(Convert.ToInt32(pfEvenarr[i]) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Prefix Odd array is :");
            for (int i = 0; i < pfOddarr.Length; i++)
            {
                Console.Write(Convert.ToInt32(pfOddarr[i]) + " ");
            }
        }

        public void CallSpecialIndexes()
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
            
            int[] indexArr = s.GetSpecialIndexesOfArray(arr, arr.Length);

            Console.WriteLine("Special Indexes are :");
            for (int i = 0; i < arr.Length; i++)
            {
                if(indexArr[i] != -1){
                    Console.Write(Convert.ToInt32(indexArr[i]) + " ");
                }
            }
            
        }

        public void CallCountAGPairs()
        {
            Console.Clear();
            Console.WriteLine("Enter Character Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            char[] arr = new char[n_arr_str.Length];
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr[i] = n_arr_str[i][0];
            }
            
            int count = s.CountAGPairs(arr, arr.Length);

            Console.WriteLine("Total number of pairs are :" + count);
            
        }

        public void CallClosestMinMax()
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
            
            int min = s.ClosestMinMax(arr, arr.Length);

            Console.WriteLine(min);
        }

        public void CallLeaders()
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
            
            int[] leaders = s.Leaders(arr, arr.Length);

            Console.WriteLine("Leaders are :");
            for (int i = 0; i < arr.Length; i++)
            {
                if(leaders[i] != -1){
                    Console.Write(Convert.ToInt32(leaders[i]) + " ");
                }
            }
        }

        public void CallAllSubArrays()
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
            
            int[][] subarrays = s.GetAllSubArrays(arr, arr.Length);
            for (int i = 0; i < subarrays.Length; i++)
            {
                for (int j = 0; j < subarrays[i].Length; j++)
                {
                    if(subarrays[i][j] != -1){
                        Console.Write(subarrays[i][j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void CallmaxSubArraySum()
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
            
            int[] a = s.maxSubArraySum(arr, arr.Length);
            
            Console.WriteLine("Max sum is : " + a[0] + "\r\nAnd the sub array is : ");
            for (int i = a[1]; i <= a[2]; i++)
            {
                Console.Write(n_arr_str[i] +" ");
            }
            
        }

        public void Call_GetIndexOfSubarrayOfSizeBWithLeastAverage()
        {
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            System.Collections.Generic.List<int> arr = new System.Collections.Generic.List<int>();
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr.Add(Convert.ToInt32(n_arr_str[i]));
            }

            Console.WriteLine("Enter size of sub array");
            int subarraySize = Convert.ToInt32(Console.ReadLine());
            
            int[] index = s.GetIndexOfSubarrayOfSizeBWithLeastAverage(arr, subarraySize);
            
            Console.WriteLine("Starting index is " + index[0] + "\r\nArray is");
            for (int i = index[0]; i <= index[1]; i++)
            {
                Console.Write(n_arr_str[i] +" ");
            }
        }

        public void CallGetSumOfAllSubArrays()
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
            
            int sum = s.GetSumOfAllSubArrays(arr, arr.Length);
            
            Console.WriteLine(sum);
            
        }

        public void CallPickFromBothSides(){
            Console.Clear();
            Console.WriteLine("Enter Integer Array with spaces in between");

            string? line = Console.ReadLine();
            string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(", ");

            int[] arr = new int[n_arr_str.Length];
            System.Collections.Generic.List<int> lst = new System.Collections.Generic.List<int>();
            for (int i = 0; i < n_arr_str.Length; i++)
            {
                arr[i] = Convert.ToInt32(n_arr_str[i]);
                lst.Add(arr[i]);
            }

            Console.WriteLine("Enter size of sub array");
            int subarraySize = Convert.ToInt32(Console.ReadLine());

            int sum = s.PickFromBothSides2List(lst, arr.Length, subarraySize);
            
            Console.WriteLine(sum);
        }
    }

}