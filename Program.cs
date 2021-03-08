using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictoanory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyDictionary<int, string> Id_name = new MyDictionary<int, string>();

            Id_name.Add(2549, "Yusuf Kara");

            Id_name.Add(2637, "Resül ŞAHİN");

            Id_name.Add(5158, "Murat Ceylan");

            Id_name.Add(9197, "Ayşe Sarı");

            Id_name.gosterr();


        }
    }



    // R: you can write anyletter
    class MyDictionary<Id, Name>
    {
        Id[] keyArray;
        Name[] valueArray;
        Id[] tempkeyArray;
        Name[] tempvalueArray;


        //constructor
        public MyDictionary()
        {
            keyArray = new Id[0];  // empty list for key 
            valueArray = new Name[0];    // empty list for value
        }

        public void Add(Id Idd, Name Namee)
        {
            tempkeyArray = keyArray;
            keyArray = new Id[keyArray.Length + 1];
                      
            for (int i = 0; i < tempkeyArray.Length; i++)
            {
                keyArray[i] = tempkeyArray[i];
            }
            keyArray[keyArray.Length-1]=Idd;

            tempvalueArray = valueArray;
            valueArray = new Name[valueArray.Length + 1];

            for (int i = 0; i < tempvalueArray.Length; i++)
            {
                valueArray[i] = tempvalueArray[i];
            }
            valueArray[valueArray.Length - 1] = Namee;
           
        }
        public void gosterr()
        {
            for (int i = 0; i < keyArray.Length; i++)
            {
                Console.WriteLine("Id: " + keyArray[i] + "  Name: " + valueArray[i]);
            }

        }
    }

}


