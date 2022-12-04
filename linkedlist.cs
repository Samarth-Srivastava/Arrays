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

    public class ListCustom<T> : IList<T>{

        Node<T> first {get; set;}
        int Capacity = -1;
        
        public ListCustom() {}
        public ListCustom(int Capacity) {
            this.Capacity = Capacity;
            for(int i = 0; i < Capacity; i++){
                T data = default(T);
                Insert(i, data);
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public int Count {
            get{
                int i = 0;
                Node<T> temp = first;
                while(temp != null){
                    i++;
                    temp = temp.next;
                }
                return i;
            }
        }

        public T this[int index]
        {
            get {
                if (index < 0 || index > this.Count - 1) {
                    throw new ArgumentOutOfRangeException("index");
                }
                Node<T> temp = first;
                int i = -1;
                while(temp != null){
                    i++;
                    if(index == i){
                        break;
                    }
                    temp = temp.next;
                }
                return temp.data;
            }
            set {
                if (index < 0) {
                    throw new ArgumentOutOfRangeException("index");
                }
                Node<T> current = first;
                int i = 0;
                while (current != null && i < index) {
                    current = current.next; i++;
                }
                if (current == null) {
                    throw new ArgumentOutOfRangeException("index");
                }
                current.data = value;
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            return IndexOf(item) > -1;
        }
        
        public void Add(T item){
            try{
                if(Count == 0){
                    Node<T> temp = new Node<T>(item);
                    first = temp;
                }
                else{
                    Node<T> temp = first;
                    while(temp.next != null){
                        temp = temp.next;
                    }
                    Node<T> newNode = new Node<T>(item);
                    temp.next = newNode;
                }
                Capacity = Count;
            }
            catch(Exception ex){
                throw ex;
            }
        }

        public void Clear(){
            first = null;
        }

        public int IndexOf(T item)
        {
            Node<T> temp = first;
            int i = -1;
            int index = -1;
            while(temp != null){
                i++;
                if(temp.data.Equals(item)){
                    index = i;
                    break;
                }
                temp = temp.next;
                
            }
            return index;
        }

        public void Insert(int index, T item){
            if(index >= 0 && index <= Capacity+1 && Capacity != -1){
                if(index == 0){
                    Node<T> newNode = new Node<T>(item);
                    newNode.next = first;
                    first = newNode;
                    Capacity = Capacity < Count ? Count : Capacity;
                }
                else{
                   Node<T> temp = first;
                   int i = 1;
                    while(temp.next != null && i < index-1){
                        temp = temp.next;
                        i++;
                    }
                    Node<T> newNode = new Node<T>(item);
                    newNode.next = temp.next;
                    temp.next = newNode;
                    Capacity = Capacity < Count ? Count : Capacity;
                }
            }
        }

        public bool Remove(T item){
            int position = IndexOf(item);
            bool flag = false;
            try{
                if(position != -1){
                    RemoveAt(position);
                    flag = true;
                }
            }
            catch(Exception ex){
                flag = false;
            }
            return flag;
        }

        public void RemoveAt(int position){
            if(position >= 0 && position <= Count){
                if(position == 0){
                    first = first.next;
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
                    Capacity = Capacity < Count ? Count : Capacity;
                }
            }
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
            l.Insert(2, 4);
            l.Insert(0, 89);
            l.Insert(51, 52);
            l.Insert(6, 74);
            l.RemoveAt(0);

            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i]+ " ");
            }

            foreach (int item in l)
            {
                Console.Write(item+ " ");
            }

            return l;           
        }
    }
}