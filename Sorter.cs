using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFuncs
{
    public class Sorter
    {
        protected string[] arrayToSort;
        public Sorter(string[] arrayToSort)
        {
            this.arrayToSort = arrayToSort;
        }
        public void SortStrings(int type)
        {
            string[] arr = new string[5];
            arrayToSort.CopyTo(arr, 0);
            string tmpStr;
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if ((type == 1 && arr[i].CompareTo(arr[k]) > 0)
                     || (type == 2 && arr[i].CompareTo(arr[k]) < 0))
                    {
                        tmpStr = arr[i];
                        arr[i] = arr[k];
                        arr[k] = tmpStr;                       
                    }
                    else continue;                    
                }
            }
            Console.WriteLine("Отсортированный массив фамилий:");
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }        
    }
}
