namespace Arrays
{
    public partial class Solution
    {

        // total number of subarrays in agiven array is (N*N + N)/2
        // number of subarrays in which ith index is present is (i+1)*(N-i)


        public int[][] GetAllSubArrays(int[] arr, int N)
        {
            int noOfSubarrays = (N * N + N) / 2;
            int[][] listOfSubArrays = new int[noOfSubarrays][];

            int counter = 0;
            for (int s = 0; s < N; s++)
            {
                for (int e = s; e < N; e++)
                {
                    int[] tempArr = new int[N];

                    for (int i = 0; i < N; i++)
                    {
                        tempArr[i] = -1;
                    }

                    for (int i = s, j = 0; i <= e; i++, j++)
                    {
                        tempArr[j] = arr[i];
                    }
                    listOfSubArrays[counter] = tempArr;
                    counter++;
                }
            }
            return listOfSubArrays;
        }

        public int[] maxSubArraySum(int[] arr, int N)
        {
            int[] pfArr = GetPrefixSumArray(arr, N);
            #region brute force
            // check all sub arrays
            int maxSubArraySum = int.MinValue;
            int startpoint = -1, endpoint = -1;
            for (int s = 0; s < N; s++)
            {
                for (int e = s; e < N; e++)
                {
                    int subArraySum = 0;
                    // getting sum of a subaary can be optimized using prefix sum, which reduces the algo to O(n2)
                    // for O(n) we have kadane's algo
                    // for (int i = s, j = 0 ; i <= e; i++, j++) {
                    //     subArraySum += arr[i];
                    // }
                    subArraySum = pfArr[e] - (s == 0 ? 0 : pfArr[s - 1]);
                    // maxSubArraySum = Max(maxSubArraySum, subArraySum);
                    // to return that subarray which has max sum, we need those start point and end point
                    if (maxSubArraySum < subArraySum)
                    {
                        startpoint = s;
                        endpoint = e;
                        maxSubArraySum = subArraySum;
                    }
                }
            }
            return new int[3] { maxSubArraySum, startpoint, endpoint };
            #endregion
        }

        // public int[,] GetSumsOfAllSubarrays(int[] arr, int givenSum){
        //     int N = arr.Length;
        //     int noOfSubarrays = (N * N + N) / 2;

        //     int[,] subArraySums = new int[noOfSubarrays,1];
            
        //     int pointer = 0;
        //     int currentsum = arr[0];
        //     subArraySums[0,0] = 
        //     for (int i = 1; i < N; i++)
        //     {
        //         currentsum += arr[i];
        //         if(currentsum <= givenSum)
        //     }
        // } 

        public int GetSumOfAllSubArrays(int[] arr, int N)
        {
            int allSubArraySum = 0;
            // for (int s = 0; s < N ; s++) {
            //     for (int e = s; e < N ; e++) {
            //         int subArraySum = 0;
            //         // getting sum of a subaary can be optimized using prefix sum, which reduces the algo to O(n2)
            //         // for (int i = s, j = 0 ; i <= e; i++, j++) {
            //         //     subArraySum += arr[i];
            //         // }
            //         subArraySum = pfArr[e] - (s == 0 ? 0 : pfArr[s-1]);
            //         allSubArraySum += subArraySum;
            //     }
            // }

            // this can be further optimized to O(n) using logic that no of subarrays that a particular elemnt is in.
            for (int i = 0; i < N; i++)
            {
                allSubArraySum += arr[i] * (i + 1) * (N - i);
            }

            return allSubArraySum;
        }

        /* Given an array of size N, find the subarray of size K with the least average. */
        public int[] GetIndexOfSubarrayOfSizeBWithLeastAverage(System.Collections.Generic.List<int> A, int B)
        {
            int N = A.Count;
            System.Collections.Generic.List<int> subArraySums = new System.Collections.Generic.List<int>();

            // calculate sum of subarrays of length B
            int s0 = 0, si = 0;
            for (int i = 0; i < B; i++)
            {
                s0 += A[i];
            }
            subArraySums.Add(s0);
            for (int i = 1; i < N-B+1; i++)
            {
                if(i == 1){
                    si =  s0 - A[i-1] + A[i+B-1];
                }
                else{
                    si = si - A[i-1] + A[i+B-1];
                }
                subArraySums.Add(si);
            }

            //just get the smallest sum and its index
            int minSum = int.MaxValue;
            int startIndex = -1;
            int endIndex = -1;
            for (int i = 0; i < subArraySums.Count; i++)
            {
                if(minSum > subArraySums[i]){
                    minSum = subArraySums[i];
                    startIndex = i;
                    endIndex = i + B - 1;
                }
            }
            return new int[2] { startIndex, endIndex};
        }
    }
}