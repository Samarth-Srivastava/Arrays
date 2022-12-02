using System;

namespace Arrays{
    partial class Solution{
        public int MinimizeDiversity(string A, int B) {
            int N = A.Length;
            int[] arr = new int[26];
            for(int i = 0; i < N; i++){
                arr[A[i]-'a']++;
            }
            Array.Sort(arr);
            for(int i=0; i<26; i++){
                if(i == 25){
                    return 1;
                }
                if(arr[i] != 0){
                    if(B>0 && B>=arr[i])
                        B -= arr[i];
                    else
                        return 26-i;
                }
            }
            return 0;
        }
    }
}