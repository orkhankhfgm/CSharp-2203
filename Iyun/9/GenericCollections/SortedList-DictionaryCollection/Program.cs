using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DictionaryCollection
            //Generic collection deyil
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "salam");
            hashtable.Add(2, "sagol");
            //hashtable.Add(2, "necesen"); //runtime error (same key)

            //Dictionary<TKey, TValue> T tipinde key ve value
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
            dictionary1.Add(1, "salam");
            dictionary1.Add(2, "sagol");
            //dictionary1.Add(2, "necesen"); //runtime error (same key)

            Dictionary<bool, char> dictionary2 = new Dictionary<bool, char>();
            dictionary2.Add(true, 'A');

            Dictionary<decimal, long> dictionary3 = new Dictionary<decimal, long>();
            dictionary3.Add(40.2M, 15615156156156);
            dictionary3.Add(35.2M, 15615156156156);
            dictionary3.Add(19.2M, 15615156156156);
            dictionary3.Add(7.2M, 15615156156156);

            bool delResult = dictionary1.Remove(2);

            if(delResult)
                Console.WriteLine("Deyer dictionary collection'dan silindi!");
            else
                Console.WriteLine("Deyer dictionary collection'dan silindi!");

            //hashtable["5"] = 100;
            //dictionary1[5] = "changed value";

            //var a = dictionary1[5];

            bool key5 = dictionary1.ContainsKey(5);

            if (key5)
            {
                var test = dictionary1[5];
            }
            else
            {
                Console.WriteLine("5-ci key tapilmadi");
            }


            bool valCar = dictionary1.ContainsValue("Car");
            if (valCar)
            {
                Console.WriteLine("Car deyeri tapildi");
            }
            else
            {
                Console.WriteLine("Car deyeri tapilmadi");
            }

            foreach (KeyValuePair<int, string> item in dictionary1)
            {
                Console.WriteLine("Acar: {0} || Deyer: {1}", item.Key, item.Value);
            }
            #endregion





            #region SortedList & SortedDictionary Generic Collections
            SortedList<int, string> sortedListCollection = new SortedList<int, string>();
            sortedListCollection.Add(10, "salam");
            sortedListCollection.Add(5, "sagol");
            sortedListCollection.Add(3, "necesen");
            sortedListCollection.Add(18, "yaxsiyam");


            SortedDictionary<int, string> sortedDictionaryCollection = new SortedDictionary<int, string>();
            sortedDictionaryCollection.Add(30, "salam");
            sortedDictionaryCollection.Add(53, "sagol");
            sortedDictionaryCollection.Add(42, "necesen");
            sortedDictionaryCollection.Add(79, "yaxsiyam");
            #endregion
        }
    }
}
