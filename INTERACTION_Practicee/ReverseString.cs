using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERACTION_Practicee
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "my Name Is snehal";
            string[] str1=str.Split(" ");
            string reverse = " ";

            for(int i=0;i<str1.Length;i++)
            {
                string word = str1[i];
                string myword = " ";

                for(int j=word.Length-1;j>=0;j--)
                {
                    myword=myword+word[j];

                }
                reverse=reverse+myword+" ";

            }
            Console.WriteLine(reverse);
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            string str= "my Name Is snehal";
            char[]ch=str.ToCharArray();
            int j = ch.Length - 1;
            for(int i=0;i<ch.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            string str1= new string(ch);
            Console.WriteLine(str1);

            string reverse = " ";

            for(int i = 0; i < str.Length; i++)
            {
                reverse = str[i] + reverse;
            }
            Console.WriteLine(reverse);
        }
    }
    class Print1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {  2,  5, 7 };

            for (int i = 0; i < arr.Length; i++)
            {
                /*Console.WriteLine(i + " " + arr[i]);*/
                Console.WriteLine(arr[i]);


            }
                  List <int>  arr1= new List <int>( arr.Reverse());
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }

        }
        

        

    }
    class Copy1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, 7 };
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            int[] arr1 =  arr;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
                            
            }
          

        }
    }
    class Duplicate
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 2, 7 };
            for(int i = 0; i < arr.Length; i++)
            {
                int result = 0;
                int count = 0;
                bool isvisited = false;

                for(int k=i;k>=0;k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<arr.Length;j++)
                        if (arr[i] == arr[j])
                        {
                            //result = arr[j];
                            
                            count++;
                        }
                }
                Console.WriteLine(arr[i] + " " + count);
            }

        }
    }
    class Lengths
    {
        static void Main(string[] args)
        {
            string str = "India";
            char[] arr = str.ToCharArray();
            foreach (char ch in arr)
            {

                Console.WriteLine(ch);
            }
            Console.WriteLine(str.Reverse());
        }
    }
}
