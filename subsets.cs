using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    public partial class Solution
    {
        // if the elements are distinct then number of subsequence and subsets are same as 2^N

        public List<List<int>> GetAllSubsets(List<int> A){
            int N = A.Count;
            int totalNoOfSubsets = 1 << N;

            List<List<int>> allSubSets = new List<List<int>>();

            //empty subset
            allSubSets.Add(new List<int>());

            for (int i = 1; i < totalNoOfSubsets; i++)
            {
                List<int> set_i = new List<int>();
                for (int j = 0; j < N; j++)
                {
                    if(((i >> j) & 1) == 1){
                        set_i.Add(A[j]);
                    }
                }
                allSubSets.Add(set_i);
            }
            allSubSets.Sort(new ListComparer());
            return allSubSets;
        }

        public bool CheckIfThereExistsASubSetWithSumK(List<int> A, int k){
            int N = A.Count;
            int totalNoOfSubsets = 1 << N;

            bool flag = false;

            for (int i = 0; i < totalNoOfSubsets; i++)
            {
                int sum = 0;
                List<int> set_i = new List<int>();
                for (int j = 0; j < N; j++)
                {
                    if(((i >> j) & 1) == 1){
                        sum += A[j];
                    }
                }
                if(sum == k){
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }

    public class ListComparer : IComparer<List<int>>{
        public int Compare(List<int> x, List<int> y){
            // sort by size of list
            // if(x.Count = y.Count){
            //     return 1;
            // }
            // else if(x.Count > y.Count) {
            //     return 1;
            // }
            // return -1;
            // sort by size of list one liner
            // return x.Count - y.Count;
            // sort by elements of list
            // int a = x.Count > 0 ? x[0] : 0;
            // int b = y.Count > 0 ? y[0] : 0;
            // return a - b;
            // sort by everything
            if(x.Count < y.Count){
                return -1;
            }
            else if(x.Count > y.Count){
                return 1;
            }
            else{
                int a = x.Count > 0 ? x[0] : 0;
                int b = y.Count > 0 ? y[0] : 0;
                return a - b;
            }
            

        }
    }
}