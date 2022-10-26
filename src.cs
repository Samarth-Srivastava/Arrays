using System.Collections.Generic;

namespace Arrays{
	public class Solution{
		public void solve(){

		}

		public int[] RotateLeft(int[] arr, int n, int k){
			int[] rotatedArray =  new int[n];

			for(int i = 0; i < n; i++){
				int newPos = (i+n+k)%n;
				rotatedArray[i] = arr[newPos];
			}

			return rotatedArray;
		}

		public List<int> RotateLeft(List<int> arr, int n, int k){
			List<int> rotatedArray =  new List<int>();

			for(int i = 0; i < n; i++){
				int newPos = (i+n+k)%n;
				rotatedArray.Add(arr[newPos]);
			}

			return rotatedArray;
		}

		public int[] RotateRight(int[] arr, int n, int k){
			int[] rotatedArray =  new int[n];

			for(int i = 0; i < n; i++){
				int newPos = (i+n-k)%n;
				rotatedArray[i] = arr[newPos];
			}

			return rotatedArray;
		}

		public List<int> RotateRight(List<int> arr, int n, int k){
			List<int> rotatedArray =  new List<int>();

			for(int i = 0; i < n; i++){
				int newPos = (i+n-k)%n;
				rotatedArray.Add(arr[newPos]);
			}

			return rotatedArray;
		}

		public int[] Reverse(int[] arr, int start, int end){
			while(start < end){
				int temp = arr[start];
				arr[start] = arr[end];
				arr[end] = temp;

				start++;
				end--;
			}
			return arr;
		}

		/*Given N array elements, count no of elements having atleast 1 element greater than itself
		...So the logic is like this, if we find max element of the array, all other numbers will have 
		atleast 1 element greater than itself...
		*/
		public int CountAtleast1GreaterElement(int[] arr, int N){
			//brute force
			// int count = 0;
			// for (int i = 0; i < N; i++)
			// {
			// 	for (int j = 0; j < N; j++)
			// 	{
			// 		if(arr[i] < arr[j]){
			// 			count++;
			// 			break;
			// 		}
			// 	}
			// }

			int max = arr[0];
			int maxCount = 1;
			for (int i = 1; i < N; i++)
			{
				if(arr[i] > max){
					max = arr[i];
					maxCount = 1;
				}
				else if(arr[i] == max){
					maxCount++;
				}
			}

			//find no of occurence of max element
			// for (int i = 0; i < N; i++)
			// {
			// 	if(arr[i] == max){
			// 		maxCount++;
			// 	}
			// }
			return N-maxCount;
		}
	
		/*Given N array elements, check if there exists a pair i, j such that ar[i]+a[j]==k, i!=j
		*/
		public bool CheckSumPair(int[] arr, int N){
			
		}
	}
}
