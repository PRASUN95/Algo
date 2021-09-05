using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        static void Heapify(int[] arr,int currInd,int size){
            int l = currInd * 2 + 1;
            int r = currInd * 2 + 2;
            var largest = currInd;
            if(l < size && arr[l] > arr[largest]){
                largest = l;
            }
            if(r < size && arr[r] > arr[largest])
            {
                largest = r;
            }
            if(largest != currInd){
                var temp = arr[largest];
                arr[largest] = arr[currInd];
                arr[currInd] = temp;
                Heapify(arr,largest,size);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Heapify");
            int[] arr = { 1, 3, 5, 4, 6, 13, 10,9, 8, 15, 17 }; 
            int size = arr.Length;
            var parent = arr.Length / 2 - 1;
            for(int i = parent;i>=0;i--){
                Heapify(arr,i,size);
            }
            foreach(var item in arr) Console.WriteLine(item);
            Console.WriteLine("Heap Sort");
            for(int i=size-1;i>0;i--){
                var temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr,0,i);
            }
            foreach(var item in arr) Console.WriteLine(item);
        }
    }
}