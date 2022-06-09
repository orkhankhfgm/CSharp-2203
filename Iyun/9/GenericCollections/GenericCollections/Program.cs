using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                VirtualDatabase virtualDb = new VirtualDatabase();
                virtualDb.Add(10);
                virtualDb.Add(20);

                List<Student> students = new List<Student>();

                //1-ci yol
                students.Add(new Student()
                {
                    Id = 1,
                    Name = "Cavid",
                    Surname = "Cavidov",
                    Age = 25
                });

                //2-ci yol
                Student student = new Student()
                {
                    Id = 1,
                    Name = "Hesen",
                    Surname = "Hesenov",
                    Age = 23
                };
                students.Add(student);

                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3}",
                                        students[i].Id,
                                        students[i].Name,
                                        students[i].Surname,
                                        students[i].Age);
                }

                foreach (Student item in students)
                {
                    Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3}",
                                        item.Id,
                                        item.Name,
                                        item.Surname,
                                        item.Age);
                }

                /*
                 numbersToAdd adinda bir arrayiniz olsun ve bir dene de numbers adinda list'iniz olsun. Ikisi de int tipinde olacaq.
                 Sonra numbersToAdd arrayinin icindeki reqemleri, numbers listine elave etmeye calisin.
                 */
                List<int> numbers = new List<int>();
                numbers.Add(1);

                int[] numbersToAdd = new int[10];

                numbersToAdd[0] = 10;
                numbersToAdd[1] = 20;
                numbersToAdd[2] = 30;
                numbersToAdd[3] = 40;
                numbersToAdd[4] = 50;
                numbersToAdd[5] = 60;
                numbersToAdd[6] = 70;
                numbersToAdd[7] = 80;
                numbersToAdd[8] = 90;
                numbersToAdd[9] = 100;


                //1. yol
                for (int i = 0; i < numbersToAdd.Length; i++)
                {
                    numbers.Add(numbersToAdd[i]);
                }

                //2. yol
                numbers.AddRange(numbersToAdd);

                List<double> doubleList = new List<double>();
                doubleList.Add(10.1);
                doubleList.Add(20.1);
                doubleList.Add(30.1);
                doubleList.Add(40.1);

                var capacityOfDoubleList = doubleList.Capacity; //Fuad:4, Cinare: 16, Vefa: 4, Orxan: 4

                var countOfDoubleList = doubleList.Count;

                doubleList.Add(50.1);

                var secondCapacityOfDoubleList = doubleList.Capacity; //Fuad:8, Cinare: 32, Vefa: 8, Orxan: 8
                var secondCountOfDoubleList = doubleList.Count;

                doubleList.TrimExcess();

                doubleList.ForEach(i => Console.WriteLine(i));
            }


            {
                List<int> numbers = new List<int>();
                numbers.Add(1);
                numbers.Add(2);
                numbers.Add(3);
                numbers.Add(4);
                numbers.Add(5);
                numbers.Add(6);

                int secondNumber = numbers[1];

                numbers.Insert(1, 25);

                var control1 = numbers.Any();
                var control2 = numbers.Any(i => i > 3);

                //A-Z ve ya 1-N siralama
                numbers.Sort();
                //Z-A ve ya N-1 siralama
                numbers.Reverse();

                bool delResult = numbers.Remove(6);
                int removedItemCount = numbers.RemoveAll(i => i > 4);

                numbers.RemoveAt(2);
                numbers.Clear();

                int maxValue = numbers.Max();
                int minValue = numbers.Min();
                int sumValue = numbers.Sum();
            }
        }
    }
}
