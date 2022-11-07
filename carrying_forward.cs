/* if we have to count something we can think of carry forward or sliding window kind of approach
*/

namespace Arrays
{
    public partial class Solution{

        /*Given a charcater array, calculate number of pairs i, j such that i < j && arr[i]='a' && arr[j]='g'
        */
        public int CountAGPairs(char[] arr, int N){
            int count = 0;
            //brute force
            // for (int i = 0; i < N; i++){
            //     for (int j = 0; j < N; j++){
            //         if(i < j && arr[i] == 'a' && arr[j] == 'g'){
            //             count++;
            //         }
            //     }
            // }

            int g_counter = 0;
            for (int i = N-1; i >= 0; i--)
            {
                if(arr[i] == 'g'){
                    g_counter++;
                }
                if(arr[i] == 'a'){
                    count = count + g_counter;
                }
            }

            return count;
        }
    
        public int Min(int a, int b){
            if(a < b)
                return a;
            else
                return b;
        }

        public int Max(int a, int b){
            if(a > b)
                return a;
            else
                return b;
        }

        /*Closest min max in a array*/
        public int ClosestMinMax(int[] arr, int N){

            // find min and max of array and traverse through array, if encounter min of array then pass that location and find
            // max of the array and get the length for it, else if encounter max of array then find min of array.
            
            int min = Min(arr, N); //O(n)
            int max = Max(arr, N); //O(n)
            int minLen = int.MaxValue;
            if(min == max) { 
                minLen = 1;
                return minLen;
            }

            #region brute force
            // int maxLocation = 0;
            // int minLocation = 0;
            // for (int i = 0; i < N; i++)
            // {
            //     if(arr[i] == max){
            //         maxLocation = i;
            //         minLocation = GetNextMinLocation(arr, N, min, i);
            //         if(minLocation != -1){
            //             minLen = Min(minLen, minLocation-maxLocation);
            //         }
            //     }
            //     if(arr[i] == min){
            //         minLocation = i;
            //         maxLocation = GetNextMaxLocation(arr, N, max, i);
            //         if(maxLocation != -1){
            //             minLen = Min(minLen, maxLocation-minLocation);
            //         }
            //     }
            // }
            // return minLen+1;
            #endregion

            int maxLocation = -1;
            int minLocation = -1;
            for (int i = 0; i < N; i++)
            {
                if(arr[i] == max){
                    maxLocation = i;
                    minLen = minLocation != -1 && maxLocation != -1 ? CalculateLength(maxLocation,minLocation, minLen) : minLen;
                }
                if(arr[i] == min){
                    minLocation = i;
                    minLen = minLocation != -1 && maxLocation != -1 ? CalculateLength(maxLocation, minLocation, minLen) : minLen;
                }
            }
            return minLen+1;
        }

        public int CalculateLength(int maxLocation, int minLocation, int len){
            int minLen = len;
            int diff = minLocation-maxLocation;
            diff = diff < 0 ? (-1)*diff : diff;
            minLen = Min(minLen, diff);
            return minLen;
        }

        public int GetNextMinLocation(int[] arr, int N, int min, int maxLoc){
            for (int i = maxLoc+1; i < N; i++)
            {
                if(arr[i] == min){
                    return i;
                }
            }
            return -1;
        }

        public int GetNextMaxLocation(int[] arr, int N, int max, int minLoc){
            for (int i = minLoc+1; i < N; i++)
            {
                if(arr[i] == max){
                    return i;
                }
            }
            return -1;
        }
    
        /* A wire connects N light bulbs.
        Each bulb has a switch associated with it; however, due to faulty wiring, a switch also changes the state of all the bulbs to the right of the current bulb.
        Given an initial state of all bulbs, find the minimum number of switches you have to press to turn on all the bulbs.
        You can press the same switch multiple times.
        Note: 0 represents the bulb is off and 1 represents the bulb is on.

        
        */
        public int minBulbsToSwitchOn(int[] arr, int N) {
            // we have to count bulb status = 0, but bulb status chnages once we switch on any bulb, so we have to just check 
            // for differet bulb status once we encounter the bulb that we have to switch on.
            int bulb_status = 0;
            int ans = 0;
            for(int i = 0; i < N; i++){
                if(arr[i] == bulb_status){
                    ans = ans + 1;
                    bulb_status = bulb_status == 0 ? 1 : 0;
                }
            }
            return ans;
        }

        /* You are given an integer array A.
        Decide whether it is possible to divide the array into one or more subarrays of even length such that the first and last element of all subarrays will be even.
        Return "YES" if it is possible; otherwise, return "NO" (without quotes).
        */

        public string EvenLengthSubarrayWithEvenEdgeElements(int[] arr, int N) {
            // so the sub arrays have to be of even length, so arrays with odd length are out
            // check the edge elements are even
            // check the alternate middle elements to be even 
            if(N%2 == 1){
                return "NO";
            }
            if(arr[0]%2 == 1 || arr[N-1]%2 == 1){
                return "NO";
            }
            if(arr[0]%2 == 0 && arr[N-1]%2 == 0){
                return "YES";
            }
            for(int i = 1; i < N-1; i=i+2){
                if(arr[i]%2 == 0 && arr[i+1]%2 == 0){
                    return "YES";
                }
            }
            return "NO";
        }

        /*Given an integer array A containing N distinct integers, you have to find all the leaders in array A.
        An element is a leader if it is strictly greater than all the elements to its right side.
        NOTE:The rightmost element is always a leader.
        */

        public int[] Leaders(int[] arr, int N){
            int[] leaders = new int[N];
            for (int i = 0; i < N; i++){
                leaders[i] = -1;
            }

            int count = 1; //right most element is a leader
            int max = arr[N-1];
            leaders.Add(arr[N-1]);
            for (int i = N-2; i >= 0; i--)
            {
                if(arr[i] > max){
                    count++;
                    max = arr[i];
                    leaders.Add(arr[i]);
                }
            }
            return leaders;
        }
    }
}