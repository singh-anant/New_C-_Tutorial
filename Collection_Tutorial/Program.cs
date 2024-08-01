using System;
using System.Collections.Generic;
using System.Collections;


namespace Collection_Tutorial
{
    class Program
    {
        public static void Main()
        {
            // Create a new collection
            List<int> myList = new List<int>() { 10, 20, 30 };
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
                 System.Console.WriteLine(myList.Count);
            for (int i = 0; i < myList.Count; i++)
            {
                    Console.WriteLine(myList[i]);
            }

            ArrayList arr=new ArrayList();
            arr.Add(10);
            arr.Add(20);
            arr.Add("Hello");
            string[] pirate={"WhiteBeard","Roger Pirate","Big Mom Pirates"};
            arr.AddRange(pirate);

            arr.Remove(5);

            //to insert a value at any index
            arr.Insert(2,"Kidd Pirates");

            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }


         Hashtable ht = new Hashtable();
        // can be any datatype
        ht.Add(true, 12345);
        ht.Add(1, "Straw Hats");

        foreach (DictionaryEntry item in ht)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
        System.Console.WriteLine("=======================");
        List<string> ls=new List<string>();
          ls.Add("Naruto Uzumaki");
          ls.Add("Sasuke Uchiha");
          ls[0]="Itachi Uchiha";//it will change data....
          ls.Add("=====================");
          foreach (var item in ls)
          {
            System.Console.WriteLine(item);
          }

          ls.ForEach((item)=>{
            System.Console.WriteLine(item);
          });

          System.Console.WriteLine("Is Naruto Uzumaki Presenet-:"+ls.Contains("Naruto Uzumaki"));
          System.Console.WriteLine("If presnet then Index is-:"+ls.FindIndex(fi=>fi=="Naruto Uzumaki"));
        }
    }
}