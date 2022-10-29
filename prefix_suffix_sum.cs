// prefix sum approach to be used when we have to calculate some type of sum is required in an array, in parts or whole
// we have to create another array of cumulative sums of array
// we can do this from both side, summing from 0 to N (left prefix sum) and N to 0 (right prefix sum)

namespace Arrays
{
    public partial class Solution{
        // finding equilibrium index in array
        // an index is said to be equilibrium index if sum of elements before ith index = sum of elements after ith index
        public int[] GetEquilibriumIndexesOfArray(int[] arr, int N)
        {
            int[] EquilibriumIndexes = new int[N];
            for (int i = 0; i < N; i++){
                EquilibriumIndexes[i] = -1;
            }

            // construct left prefix array
            int[] pfSum = new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++){
                sum += arr[i];
                pfSum[i] = sum;
            }

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