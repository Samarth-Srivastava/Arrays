using System.Collections.Generic;

namespace Arrays{
	public partial class Solution{
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
		public bool CheckSumPair(int[] arr, int N, int k){
			bool flag = false;

			//brute force
			// for (int i = 0; i < N; i++)
			// {
			// 	for (int j = 0; j < N; j++)
			// 	{
			// 		if(i!= j && arr[i] + arr[j] == k){
			// 			flag = true;
			// 			break;
			// 		}
			// 	}
			// 	if(flag){
			// 		break;
			// 	}
			// }

			// in brute force we are checking all the pairs, which are repetitive, so instead we can only check lower triangle or upper triangle, 
			// complexity is still N^2 but iterations are less

			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if(i!= j && arr[i] + arr[j] == k){
						flag = true;
						break;
					}
				}
				if(flag){
					break;
				}
			}

			return flag;
		}
	
		public int Max(int[] arr, int N){
			int Max = int.MinValue;
			for(int i = 0; i < N; i++){
				if(arr[i] >  Max){
					Max = arr[i];
				}
			}
			return Max;
		}

		public int Min(int[] arr, int N){
			int Min = int.MaxValue;
			for(int i = 0; i < N; i++){
				if(arr[i] <  Min){
					Min = arr[i];
				}
			}
			return Min;
		}
	}
}
