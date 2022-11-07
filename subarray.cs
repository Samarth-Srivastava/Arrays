namespace Arrays
{
    public partial class Solution{

        // total number of subarrays in agiven array is N(N+1)/2
        public int[][] GetAllSubArrays(int[] arr, int N){
            int noOfSubarrays = (N*N + N)/2;
            int[][] listOfSubArrays = new int[noOfSubarrays][];

            int counter = 0;
            for (int s = 0; s < N ; s++) {
                for (int e = s; e < N ; e++) {
                    int[] tempArr = new int[N];

                    for ( int i = 0; i < N;i++ ) {
                        tempArr[i] = -1;
                    }

                    for (int i = s, j = 0 ; i <= e; i++, j++) {
                        tempArr[j] = arr[i];
                    }
                    listOfSubArrays[counter] = tempArr;
                    counter++;
                }
            }
            return listOfSubArrays;
        }
        
        public int maxSubArraySum(int[] arr, int N){
            int[] pfArr = GetPrefixSumArray(arr, N);
            #region brute force
            // check all sub arrays
            int maxSubArraySum = int.MinValue;
            for (int s = 0; s < N ; s++) {
                for (int e = s; e < N ; e++) {
                    int subArraySum = 0;
                    // getting sum of a subaary can be optimized using prefix sum, which reduces the algo to O(n2)
                    // for O(n) we have kadane's algo
                    // for (int i = s, j = 0 ; i <= e; i++, j++) {
                    //     subArraySum += arr[i];
                    // }
                    subArraySum = pfArr[e] - (s == 0 ? 0 : pfArr[s-1]);
                    maxSubArraySum = Max(maxSubArraySum, subArraySum);
                }
            }
            return maxSubArraySum;
            #endregion
        
        
        }
    }
}