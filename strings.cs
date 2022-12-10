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

        public string Add_Very_Big_Numbers(string num1, string num2){
            string strfirst = num1.Length > num2.Length ? num1 : num2;
			string strsecnd = num1.Length <= num2.Length ? num1 : num2;

			char[] chr1 = strfirst.ToCharArray();
			char[] chr2 = strsecnd.ToCharArray();
			string str3 = "";

			int carry = 0;
			int i = chr1.Length -1;
			int j = chr2.Length -1;

			while(carry > 0 || j >= 0){
				int f = i < 0 ? 0 : int.Parse(chr1[i].ToString());
				int s = j < 0 ? 0 : int.Parse(chr2[j].ToString());
				int temp = f + s + carry;
				i--;
				j--;
				int sum = temp%10;
				carry = temp/10;
				str3 = sum.ToString() + str3;	
			}

			str3 = i >= 0 ? strfirst.Substring(0, i+1) + str3 : str3;
			return str3;

        }

        public string Multiply_Very_Big_Numbers(string num1, string num2){
            if(num1 == "0" || num2 == "0"){
                return "0";
            }

            string prod = "";
            string num1Temp = num1;
            
            for(int i = 0; i < num1.Length; i++){
                int carry = 0;
                string prod_i = new string('0', i);
                int num1Digt = Int32.Parse(num1Temp[num1Temp.Length - 1].ToString());
                string num2Temp = num2;
                for(int j = 0; j < num2.Length; j++){
                    int num2Digt = Int32.Parse(num2Temp[num2Temp.Length - 1].ToString());
                    int temp = (num1Digt * num2Digt)+carry;
                    int p = temp%10;
                    carry = temp/10;
                    prod_i = p.ToString() + prod_i;
                    num2Temp = num2Temp.Substring(0, num2Temp.Length - 1);
                }
                if(carry > 0){
                    prod_i = carry.ToString() + prod_i;
                }
                prod = Add_Very_Big_Numbers(prod_i, prod);
                num1Temp = num1Temp.Substring(0, num1Temp.Length - 1);
            }
            return prod;
        }
    }
}