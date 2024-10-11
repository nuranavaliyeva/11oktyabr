using System.Linq.Expressions;

namespace _11oktyabr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrey = { 1, 2, 3 };
            CustomResize(ref arrey, 4, 5, 6);
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.WriteLine(arrey[i]);
            }
           
            
        }

        static void CustomResize(ref int[] arr, params int[] arr1)
        {
            int[] newArr = new int[arr.Length + arr1.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[arr.Length + i] = arr1[i];
            }
            arr= newArr;
            }
            
        }
    }

       
        
