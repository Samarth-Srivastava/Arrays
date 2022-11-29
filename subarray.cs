using System.Collections.Generic;

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

        // given N array elements, check if there exists a subarray with sum = 0
        public int[] SubArrayWithSum0(int[] arr, int N){

            // loop thru array if there is any element = 0, that is sum 0 subarray
            // else create prefix sum array and loop thru it, if any sum is 0 (meaning startpoint 0 and endpoint i) or 
            // if any 2 sums are same (meaning startpoint is firstIndex +1 and endpoint is i)

            int flag = 0;
            int startpoint = -1;
            int endpoint = -1;
            int[] pfArr = GetPrefixSumArray(arr, N);
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < N; i++)
            {
                if(arr[i] == 0){
                    flag = 1;
                    startpoint = i;
                    endpoint = i;
                }
                if(dic.ContainsKey(pfArr[i])){
                    dic[pfArr[i]].Add(i);
                }
                else{
                    dic[pfArr[i]] = new List<int>{i};
                }
            }
            int maxLen = 0;
            if(flag != 1){
                for (int i = 0; i < dic.Count; i++)
                {
                    if(dic[pfArr[i]].Count > 1){
                        flag = 1;
                        startpoint = dic[pfArr[i]][0];
                        endpoint = dic[pfArr[i]][1];
                        maxLen = Max(maxLen, (endpoint - startpoint + 1));

                    }
                    // if(flag == 1){
                    //     break;
                    // }
                }
            }
            return new int[] { flag, startpoint, endpoint };
        }

        // public int[][] GetAllSubArrays2(int[] arr, int N){
        //     int noOfSubarrays = (N * N + N) / 2;
        //     int[][] listOfSubArrays = new int[noOfSubarrays][];

        //     listOfSubArrays[0] = arr;
        //     // arr[0] to arr[N-2]
        //     int[] suba = new int[N-1];
        //     for (int i = 0; i < N-1; i++)
        //     {
        //         suba[i] = arr[i];
        //     }
        //     listOfSubArrays[1] = suba;
        //     for (int i = 1; i < N-1; i++)
        //     {
        //         //remove i-1 th element from suba and add i+N-1 th element in suba
        //         suba.remove
        //     }
        // }

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

            // calculate sum of subarrays of length B
            int s0 = 0, si = 0;
            
            for (int i = 0; i < B; i++)
            {
                s0 += A[i];
            }
            int minSum = s0;
            int startIndex = 0;
            int endIndex = B-1;
            for (int i = 1; i < N-B+1; i++)
            {
                if(i == 1){
                    si =  s0 - A[i-1] + A[i+B-1];
                }
                else{
                    si = si - A[i-1] + A[i+B-1];
                }
                if(minSum > si){
                    minSum = si;
                    startIndex = i;
                    endIndex = i + B - 1;
                }
            }

            return new int[2] { startIndex, endIndex};
        }
    
        // Largest Positive Subarray
        public List<int> LargestPositiveSubarray(List<int> A) {
            int N = A.Count;
            List<int> indexOfNegativeElements = new List<int>();
            for(int i = 0; i <N; i++){
                if(A[i] < 0){
                    indexOfNegativeElements.Add(i);
                }
            }

            int startPoint = 0, newStartPoint = 0;
            int endPoint = -1;
            int maxlen = int.MinValue;
            for(int i = 0; i < indexOfNegativeElements.Count; i++){
                if(indexOfNegativeElements[i] != newStartPoint){
                    int len = indexOfNegativeElements[i] - newStartPoint;
                    if(len > maxlen){
                        endPoint = indexOfNegativeElements[i]-1;
                        maxlen = len;
                        startPoint = newStartPoint;
                    }
                }
                newStartPoint = indexOfNegativeElements[i] + 1;
            }

            if(newStartPoint <= N){
                int len = N - newStartPoint;
                if(len > maxlen){
                    endPoint = N-1;
                    maxlen = len;
                    startPoint = newStartPoint;
                }
            }
            
            List<int> longestSubArray = new List<int>();
            for(int i = startPoint; i <= endPoint; i++){
                longestSubArray.Add(A[i]);
            }

            return longestSubArray;
        }
    }
}