using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Types
            Console.WriteLine("Hello");
            string stringVar = "Hello World!!";
            
            int intVar = 100; // -2,147,483,648 to 2,147,483,647
            float floatVar = 10.2f;
            char charVar = 'A';
            bool boolVar = true;
            long longVar = 9443248324923423; //-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            


            //value type
            static void Increment(int i)

            {

                i = i + 1;

            }

            static void Main()

            {

                int x = 1;

                Increment(x);

                Console.WriteLine("The value of x is: " + x);

                Console.Read();

            }


            //Refernce type
            static void Increment1(ref int i)

            {

                i = i + 1;

            }

            static void Main1()

            {

                int x = 1;

                Increment1(ref x);

                Console.WriteLine("The value of x is: " + x);

                Console.Read();

            }


            //Implicit Conversion
            int i = 345;
            float f = i;

            Console.WriteLine(f); //output: 345

            //Explicit Conversion
            double d = 75.25;
            int p;
            p = (int)d;
            Console.WriteLine(i); //output: 75  

            //type Conversion
            int typeConversion = 10;
            typeConversion.ToString();




            //Constant
            const double pi = 3.14159;
            //pi = 8123; //Error



            //while loop
            int x = 1;
            while (x <= 4)
            {
                Console.WriteLine("Hello World!!!");

                // Increment the value of x for
                // next iteration
                x++;
            }

            //for loop
            for (int k = 0; k < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", k);
            }

            //do while loop
            int y = 1;
            do
            {
                Console.WriteLine("Hello World!!!");
                y++;
            }
            while (y < 20);


            //for Each Loop
            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int items in a_array)
            {
                Console.WriteLine(items);
            }


            //Break and Continue
            for (int l = 1; l < 3; l++)
            {
                if (l == 2)
                    continue;
                //break;
                Console.WriteLine("Hello World!!!");
            }


            //Conditional
            //If else
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("Good evening");
            }

            //Switch
            int nitem = 5;
            switch (nitem)
            {

                case 1:
                    Console.WriteLine("case 1");
                    break;

                case 5:
                    Console.WriteLine("case 5");
                    break;

                case 9:
                    Console.WriteLine("case 9");
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;

            }

            //Try Catch Finally
            int num1 = 25;
            int num2 = 0;
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }


            //Collections
            //array
            int[] array1 = new int[5];
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            int[] array3 = { 1, 2, 3, 4, 5, 6 };


            //List
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            lst.Clear();

            //Array List
            ArrayList al = new ArrayList();
            string str = "Saksham Srivastava";
            int s = 7;
            DateTime dt = DateTime.Parse("8-oct-1985");
            al.Add(str);
            al.Add(x);
            al.Add(dt);
            al.Remove(s);
            al.RemoveAt(1);

            //Hashtable
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("go", "google");
            ht.Add("fb", "facebook");
            ht.Add("gm", "gmail");
            ht.ContainsKey("ora");
            var value = ht["ora"];
            foreach (DictionaryEntry e in ht)
            {
                Console.WriteLine("{0}{1}",e.Key, e.Value);
            }

            //Dictionary
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "Twitter");
            dct.Add(2, "Facebook");
            dct.Add(3, "Instagram");
            dct.Add(4, "Quora");
            
            foreach (var t in dct)
                Console.WriteLine("Key: {0}, Value: {1}", t.Key, t.Value);


            //Stack
            Stack stk = new Stack();
            stk.Push("Twitter");
            stk.Push("wikipedia");
            stk.Push("google");
            stk.Push("Sql");
            

            //Queue
            Queue q = new Queue();
            q.Enqueue("Football");
            q.Enqueue("Cricket");
            q.Enqueue("Basketball");
            q.Enqueue("Hockey");
        }

        private void NonParameterised() // No Parameter  
        {
            Console.WriteLine("This is non parameterized function");
            // No return statement  
        }

        public int ParameterisedFunction(string message)
        {
            Console.WriteLine("Hello " + message);
            // No return statement  
            return 4;
        }

    }
}