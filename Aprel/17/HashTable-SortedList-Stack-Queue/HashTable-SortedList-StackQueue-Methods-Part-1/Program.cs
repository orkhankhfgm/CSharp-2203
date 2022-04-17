using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_SortedList_StackQueue_Methods_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Last homework 3
            //int[] randNums = new int[100];
            //Random rand = new Random();

            //int min = 100000;
            //int max = 0;
            //int sum = 0;

            //for (int i = 0; i < randNums.Length; i++)
            //{
            //    randNums[i] = rand.Next(1, 100000);

            //    if (randNums[i] > max)
            //        max = randNums[i];
                
            //    if (randNums[i] < min)
            //        min = randNums[i];

            //    sum += randNums[i];
            //}

            //Console.WriteLine("Min: " + min);
            //Console.WriteLine("Max: " + max);
            //Console.WriteLine("Sum: " + sum);
            #endregion

            //HashTable
            //ArrayList
            //Stack Queue

            #region ArrayList
            //Adding values to ArrayList
            string[] arr = new string[2];
            string[] arr2 = new string[]
            {
                "One",
                "Two"
            };

            ArrayList ArrList = new ArrayList();

            int capacity = 0;
            int count = 0;

            ArrayList students = new ArrayList();
            students.Add("Samir");
            students.Add("John");
            students.Add("Fuad");
            students.Add("Vefa");
            students.Add("Chinara");
            students.Add("Chinara");
            students.Add("Chinara");
            students.Add("Chinara");
            students.Add("Chinara");
            students.Add("Chinara");
            students.Add("Chinara");
            students.Add("Chinara");

            capacity = students.Capacity;
            count = students.Count;
            students.Add(5);
            students.Add(true);

            //Adding Collection to ArrayList
            //A1 sinifi
            ArrayList A1 = new ArrayList();
            A1.Add("Samir");
            A1.Add("John");
            A1.Add("John");
            A1.Add("Fuad");
            A1.Add("Hikmet");
            A1.Add("Gunay");
            A1.Add("Sevinc");

            //A2 sinifi
            ArrayList A2 = new ArrayList();
            A2.Add("Chinara");
            A2.Add("Vefa");
            A2.Add("Tural");

            A1.AddRange(A2);

            //Getting values from ArrayList
            var samir = A1[0];
            object objJohn = A1[1];
            string stringVefa = A2[1].ToString();


            ArrayList mixarray = new ArrayList();

            mixarray.Add("string value");
            mixarray.Add(1);
            mixarray.Add(5.5F);
            mixarray.Add(true);

            var strVal = mixarray[0].ToString();
            int numVal = (int)mixarray[1];
            float floatVal = (float)mixarray[2];
            bool booleanVal = (bool)mixarray[3];

            //Sorting values in ArrayList
            A1.Reverse(); //Ters siralama
            A1.Sort(); //A-Z ve ya kicikden boyuye siralama

            A2.Sort();
            A2.Reverse();


            //Removing values
            A1.RemoveAt(3);
            A1.RemoveRange(2, 2);
            A1.Remove("John");

            //Checking if value exists
            A1.Add("Orxan");

            bool ct = A1.Contains("Orxan");

            if (A1.Contains("Orxan"))
            {
                int indexOfOrkhan = A1.IndexOf("Orxan");
                A1.RemoveAt(indexOfOrkhan);
            }

            var capacityOfA1 = A1.Capacity;
            var countOfA1 = A1.Count;
            A1.Clear();
            A1.TrimToSize();
            #endregion


            #region Hashtable
            //What is hashtable and how to use it
            //Key-Value pair
            Hashtable ht = new Hashtable();
            ht.Add("Human", "Insan");
            ht.Add("House", "Ev");
            ht.Add("You", "Sen");
            ht.Add("Price", "Qiymet");
            //https://www.api.tap.az/ru/GetTranslation/

            //Value'e gore check etmek
            bool ct1 = ht.Contains("House");
            bool ct2 = ht.Contains("You");
            bool ct3 = ht.Contains("Me");

            //Key'e gore check etmek
            bool ctKey = ht.ContainsKey("House");

            //Value'e gore check etmek
            bool ctVal = ht.ContainsValue("Ev");

            //arr[1] = "Some Value"; 
            ht[0] = "Villa";
            ht[true] = "True";

            ht.Remove("Price");

            int countOfht = ht.Count;
            ht.Clear();
            #endregion





            #region SortedList
            SortedList sortedListEngAz = new SortedList();

            sortedListEngAz.Add("Hello", "Salam");
            sortedListEngAz.Add("Car", "Avtomobil");
            sortedListEngAz.Add("Home", "Ev");
            sortedListEngAz.Add("One", "Bir");
            sortedListEngAz.Add("A", "Bir");
            sortedListEngAz.Add("C", "Bir");
            sortedListEngAz.Add("B", "Bir");
            sortedListEngAz.Add("100", "Bir");
            //sortedListEngAz.Add(100, "Yuz"); //runtime exception
            #endregion



            #region Stack
            Stack stack = new Stack();

            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            stack.Push("Four");

            object o1 = stack.Pop();

            object o2 = stack.Peek();
            #endregion



            #region Queue
            Queue queue = new Queue();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");


            object obj = queue.Dequeue();

            object obj1 = queue.Peek();
            #endregion
        }
    }
}
