using System;
using System.Collections;
using System.Collections.Generic;
using LinkedList;

namespace LinkedList{
    internal class Node<T>{
        internal Node() {}
        internal Node(T d){
            this.data = d;
            this.next = null;
        }
        internal Node(T d, Node<T> pointer){
            this.data = d;
            this.next = pointer;
        }
        internal T data {get; set;}
        internal Node<T> next {get; set;}
    }

    public class ListCustom<T> : IEnumerable<T>{
        Node<T> first {get; set;}
        Node<T> last {get; set;}
        int Count = 0;
        int Capacity = -1;
        public ListCustom() {}
        public ListCustom(int Capacity) {
            this.Capacity = Capacity;
            for(int i = 0; i < Capacity; i++){
                T data = default(T);
                Insert(data, i);
            }
        }
        
        public void Add(T data){
            try{
                if(Count == 0){
                    last = new Node<T>(data);
                    first = last;
                }
                else{
                    Node<T> temp = first;
                    while(temp.next != null){
                        temp = temp.next;
                    }
                    Node<T> newNode = new Node<T>(data);
                    temp.next = newNode;
                }
                Count++;
                Capacity = Count;
            }
            catch(Exception ex){
                throw ex;
            }
        }

        public ListCustom<T> Insert(T data, int position){
            if(position >= 0 && position <= Capacity+1 && Capacity != -1){
                if(position == 0){
                    Node<T> newNode = new Node<T>(data);
                    newNode.next = first;
                    first = newNode;
                    Count++;
                    Capacity = Capacity < Count ? Count : Capacity;
                }
                else{
                   Node<T> temp = first;
                   int index = 1;
                    while(temp.next != null && index < position-1){
                        temp = temp.next;
                        index++;
                    }
                    Node<T> newNode = new Node<T>(data);
                    newNode.next = temp.next;
                    temp.next = newNode;
                    Count++;
                    Capacity = Capacity < Count ? Count : Capacity;
                }
            }
            return this;
        }

        public ListCustom<T> Remove(int position){
            if(position >= 0 && position <= Count){
                if(position == 0){
                    first = first.next;
                    Count--;
                    Capacity = Capacity < Count ? Count : Capacity;
                }
                else{
                    Node<T> temp = first;
                    int index = 1;
                    while(temp.next != null && index < position-1){
                        temp = temp.next;
                        index++;
                    }

                    temp.next = temp.next.next;
                    Count--;
                    Capacity = Capacity < Count ? Count : Capacity;
                }
            }
            return this;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> temp = first;
            while(temp != null){
                yield return temp.data;
                temp = temp.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


namespace Arrays{
    public class LinkedListTest{
        public ListCustom<int> solve(){
            ListCustom<int> l = new ListCustom<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Insert(4, 2);
            l.Insert(89, 0);
            l.Insert(51, 52);
            l.Insert(74, 6);
            l.Remove(0);

            foreach (int item in l)
            {
                Console.Write(item+ " ");
            }

            return l;           
        }
    }
}