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
    }
}