// prefix sum approach to be used when we have to calculate some type of sum is required in an array, in parts or whole
// we have to create another array of cumulative sums of array
// we can do this from both side, summing from 0 to N (left prefix sum) and N to 0 (right prefix sum)

using System.Collections.Generic;

namespace Arrays
{
    public partial class Solution{

        public int[] GetPrefixSumArray(int[] arr, int N){
            int sum = 0;
            int[] pfSumArr = new int[N];
            for (int i = 0; i < N; i++){
                sum += arr[i];
                pfSumArr[i] = sum;
            }
            return pfSumArr;
        }

        public int[] GetSuffixSumArray(int[] arr, int N){
            // arr = Reverse(arr, 0, N-1);
            // arr = GetPrefixSumArray(arr, N);
            
            // return Reverse(arr, 0, N-1);

            int sum = 0;
            int[] sfSumArr = new int[N];
            for (int i = N-1; i >= 0; i--){
                sum += arr[i];
                sfSumArr[i] = sum;
            }
            return sfSumArr;
        }

        public int[] GetPrefixEvenArray(int[] arr, int N){
            int[] newArr = new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++){
                if(i%2 == 0){
                    sum += arr[i];
                }
                newArr[i] = sum;
            }
            return newArr;
        }

        public int[] GetPrefixOddArray(int[] arr, int N){
            int[] newArr = new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++){
                if(i%2 == 1){
                    sum += arr[i];
                }
                newArr[i] = sum;
            }
            return newArr;
        }

        public int[] GetPrefixMaxArray(int[] arr, int N){
            int[] pfMaxArr = new int[N];
            int max_so_far = int.MinValue;
            for (int i = 0; i < N; i++)
            {
                if(max_so_far < arr[i]){
                    max_so_far = arr[i];
                }
                pfMaxArr[i] = max_so_far;
            }
            return pfMaxArr;
        }

        public List<int> GetPrefixMaxArray(List<int> arr, int N){
            List<int> pfMaxArr = new List<int>(N);
            int max_so_far = int.MinValue;
            for (int i = 0; i < N; i++)
            {
                if(max_so_far < arr[i]){
                    max_so_far = arr[i];
                }
                pfMaxArr.Add(max_so_far);
            }
            return pfMaxArr;
        }

        public int[] GetSuffixMaxArray(int[] arr, int N){
            int[] sfMaxArr = new int[N];
            int max_so_far = int.MinValue;
            for (int i = N-1; i >= 0; i--)
            {
                if(max_so_far < arr[i]){
                    max_so_far = arr[i];
                }
                sfMaxArr[i] = max_so_far;
            }
            return sfMaxArr;
        }

        public List<int> GetSuffixMaxArray(List<int> arr, int N){
            List<int> sfMaxArr = new List<int>(N);
            int max_so_far = int.MinValue;
            for (int i = N-1; i >= 0; i--)
            {
                if(max_so_far < arr[i]){
                    max_so_far = arr[i];
                }
                sfMaxArr.Add(max_so_far);
            }
            sfMaxArr.Reverse();
            return sfMaxArr;
        }

        // finding equilibrium index in array
        // an index is said to be equilibrium index if sum of elements before ith index = sum of elements after ith index
        public int[] GetEquilibriumIndexesOfArray(int[] arr, int N)
        {
            int[] EquilibriumIndexes = new int[N];
            for (int i = 0; i < N; i++){
                EquilibriumIndexes[i] = -1;
            }

            // construct prefix array
            int[] pfSum = GetPrefixSumArray(arr, N); // new int[N];
            // int sum = 0;
            // for (int i = 0; i < N; i++){
            //     sum += arr[i];
            //     pfSum[i] = sum;
            // }

            for(int i = 0; i < N; i++){
                int left = 0;
                int right = 0;
                if(i == 0){
                    left = 0;
                }
                else{
                    left = pfSum[i-1];
                }

                right = pfSum[N-1] - pfSum[i];
                
                if(left == right){
                    EquilibriumIndexes.Add(i);
                }
            }

            return EquilibriumIndexes;
        }
    
    
        /*Given an array, arr[] of size N, the task is to find the count of array indices such that removing an element 
        from these indices makes the sum of even-indexed and odd-indexed array elements equal.
        */
        public int[] GetSpecialIndexesOfArray(int[] arr, int N){
            int[] SpecialIndexes = new int[N];
            for(int i = 0; i < N; i++){
                SpecialIndexes[i] = -1;
            }

            int[] pfEvenArr = GetPrefixEvenArray(arr, N);
            int[] pfOddArr = GetPrefixOddArray(arr, N);

            for(int i = 0; i < N; i++){
                int S_even = (i == 0 ? 0 : pfEvenArr[i-1]) + pfOddArr[N-1] - pfOddArr[i];
                int S_odd = (i == 0 ? 0 : pfOddArr[i-1]) + pfEvenArr[N-1] - pfEvenArr[i];

                if(S_even == S_odd){
                    SpecialIndexes.Add(i);
                }
            }

            return SpecialIndexes;
        }
    }

    public static class CommonExtensions{
        public static int[] Add(this int[] arr, int value){

            int N = arr.Length;
            for(int i = N-1; i >= 0; i--){
                if(i == 0 && arr[i] == -1){
                    arr[i] = value;
                    break;
                }
                else if(arr[i] != -1 && (i+1 != N || i == 0)){
                    arr[i+1] = value;
                    break;
                }
            }
            return arr;
        }
    }
}