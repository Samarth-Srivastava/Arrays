using System;
using DynamicArrays;

#nullable enable

namespace DynamicArrays{
    public class DynamicArraysCustom<T>{
        T?[] arr {get; set;}
        int _size {get; set;}
        public int LengthCustom{
            get{
                int i = 0;
                while(arr[i]!= null){
                    i++;
                }
                return i;
            }
        }

        public DynamicArraysCustom(int size){
            arr = new T[size];
            _size = size;
        }

        public T? this[int i]{
            get{
                if (i < 0 || i > this._size - 1) {
                    throw new ArgumentOutOfRangeException("index");
                }
                return arr[i];
            }
            set{
                if (i < 0 ) {
                    throw new ArgumentOutOfRangeException("index");
                }
                Add(value);
            }
        }

        private T[] Copy(){
            T[] newArr = new T[(2*_size)];
            for (int i = 0; i < _size; i++)
            {
                newArr[i] = arr[i];
            }
            _size = 2*_size;
            return newArr;
        }

        public void Add(T item){
            if(LengthCustom == _size){
                arr = Copy();
            }
            arr[LengthCustom + 1] = item;
        }
    }
}

namespace Arrays{
    public class DynamicArraysTest{
        
        public void solve(){
            DynamicArraysCustom<int> d = new DynamicArraysCustom<int>(2);
            d[1] = 1;
            d[2] = 2;
            d[3] = 3;
            d[4] = 4;
            d[5] = 5;
            d.Add(6);
        }
    }
}