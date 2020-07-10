using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"{a} {b}");
        }

        public void Add(int a, ref int b)
        {
            Console.WriteLine($"{a} {b}");
        }

        public void Add(ref int a, ref int b)
        {
            Console.WriteLine($"{a} {b}");
        }

        public void Add(out int a, int b)
        {
            a = 10;
            b = 10;
            Console.WriteLine($"{a} {b}");
        }
    }

    public enum SeeingOptions
    {
        Doctor,
        Nurse,
        Counseller
    }

    public abstract class Customer
    {
        public SeeingOptions Option { get; set; }
        public double Charges { get; set; }

        public abstract void Charge();


        public abstract void PrintChargeInformation();

    }

    class RegisteredCustomer : Customer
    {

        public RegisteredCustomer(SeeingOptions option)
        {
            Option = option;
        }

        public override void Charge()
        {
            switch (Option)
            {
                case SeeingOptions.Doctor:
                    Charges = 10;
                    break;
                case SeeingOptions.Nurse:
                    Charges = 5;
                    break;
                case SeeingOptions.Counseller:
                    Charges = 0;
                    break;
                default:
                    Charges = 0;
                    break;
            }
        }

        public override void PrintChargeInformation()
        {
            if(Charges <= 0)
            {
                Console.WriteLine($"No charge for seeing the Counsellor.");
            }
            else
            {
                Console.WriteLine($"The charges for seeing the {Option} is ${Charges}.");
            }
        }
    }

    class UnRegisteredCustomer : Customer
    {

        public UnRegisteredCustomer(SeeingOptions option)
        {
            Option = option;
        }

        public override void Charge()
        {
            switch (Option)
            {
                case SeeingOptions.Doctor:
                    Charges = 35;
                    break;
                case SeeingOptions.Nurse:
                    Charges = 10;
                    break;
                case SeeingOptions.Counseller:
                    Charges = 50;
                    break;
                default:
                    Charges = 0;
                    break;
            }
        }

        public override void PrintChargeInformation()
        {
            if (Charges <= 0)
            {
                Console.WriteLine($"No charge for seeing the Counsellor.");
            }
            else
            {
                Console.WriteLine($"The charges for seeing the {Option} is ${Charges}.");
            }
        }
    }

    class parent
    {
        public virtual void Display()
        {
            Console.WriteLine("Parent.Display");
        }
    }

    class Child : parent
    {
        public new void Display()
        {
            Console.WriteLine("child.Display");
        }
    }


    class Program
    {

        public int SearchForWordInDictionary(string searchWord, Dictionary<string, int> wordDictionary)
        {
            int count = 0;

            foreach(KeyValuePair<string,int> word in wordDictionary)
            {
                if(word.Key.ToUpper().Contains(searchWord.ToUpper()))
                {
                    count++;
                }
            }

            return count;
        }

       static string LongestWord(List<string> listOfWords)
        {
            string longestWord = string.Empty;

            foreach(string word in listOfWords)
            {
                if(word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;

        }

        static int gcd(int a, int b)
        {
            if(a == 0)
            {
                return b;
            }

            return gcd(b % a, a);
        }

        static int LCM(int a,int b)
        {
            return (a * b) / gcd(a, b);
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 12, 13, 15, 18 };

             int x = (int)Math.Pow(2, arr.Length);

            Console.WriteLine(LCM(15, 20));

            Console.ReadLine();


            //parent c = new Child();
            //c.Display();

            //List<string> lst = new List<string> { "123", "4659781", "14", "8511111111" };


            //LongestWord(lst);

            //B b = new B();
            //b.Add()


            //List<int> s = new List<int> { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1,3 ,3 ,4, 2, 1 };
            ////List<int> s = new List<int> { 1, 2, 1, 3, 2 };
            //int m = 7;
            //int d = 18;
            //int count = 0;

            //for (int i = 0; i <= s.Count - m; i++)
            //{
            //    int k = m;
            //    int n = i;
            //    int sum = 0;
            //    while (k > 0)
            //    {

            //        sum = sum + s[n];
            //        n++;
            //        k--;
            //    }

            //    if (sum == d)
            //    {
            //        count++;
            //    }

            //}

            // count = 0;



            //object i1 = 10;
            ////string s = (string)i1;

            //string s1 = i1 as string;

            //A a = new B();

            //int[] arr = new int[] { 88,2, 1, 3, 4, 8, 9, 7 , 6, 100 ,95 };
            //////To do: 
            //for (int i = 0; i < arr.Length - 1; i++)
            //{


            //    for(int j = i+1;j < arr.Length;j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            var temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }

            //}






        }
    }
}
