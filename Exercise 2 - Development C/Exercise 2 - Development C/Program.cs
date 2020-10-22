using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise_2___Development_C
{
    class Exercise2
    {
        public int num;
        public int num2;
        private string cadena;

        //Constructor
        public Exercise2(int num)
        {
            this.num = num;
        }

        //Overloading Constructor
        public Exercise2(int num, int num2)
        {
            this.num = num;
            this.num2 = num2;
        }

        //method overloading
        public void sequenceofnumbers(int [] numbers)
        {
            Console.WriteLine("Numbers");
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
        }

        public void sequenceofnumbers(int[] numbers, string order)
        {
            if ( order == "asc")
            {
                Array.Sort(numbers);
                Console.WriteLine("Numbers");
                foreach (int value in numbers)
                {
                    Console.WriteLine(value);
                }

            }
            else
            {
                Array.Reverse(numbers);
                Console.WriteLine("Numbers");
                foreach (int value in numbers)
                {
                    Console.WriteLine(value);
                }

            }
    
        }

        //Property - String
        public string Cadena {
            get { return cadena; }
            set { cadena = value; }
        }

        //Method CheckForPalindrome
        public void CheckForPalindrome(string str1) 
        {
            string trim = Regex.Replace(str1, @"\s", "");
            char[] charArr = trim.ToCharArray();
            Array.Reverse(charArr);
            string str2 = new string(charArr);
            Console.WriteLine(trim);
            Console.WriteLine(str2);
            if (trim == str2)
            {
                Console.WriteLine("The String \"{0}\" is a  Palindrome", str1);
            }
            else
            {
                Console.WriteLine("The String \"{0}\" is not a  Palindrome", str1);
            }
            
        }

        //Method DiagonalPrint
        public void DiagonalPrint(int top)
        {

            int[] numbers = new int[top];

            for (int i = 0; i < top; i++)
            {
                numbers[i] = i;
            }

            StringBuilder s = new StringBuilder("");
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("" + s + numbers[i]);
                if (i < numbers.Length)
                    s.Append(" ");
            } 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor that will initialize a class variable.
            Exercise2 obj = new Exercise2(100);
            Console.WriteLine("The variable for object 1 is : {0}", obj.num);

            //Apply constructor overloading.
            Exercise2 obj2 = new Exercise2(100,200);
            Console.WriteLine("The variables for object 2 are : {0}, {1}",obj2.num, obj2.num2);

            //Apply method overloading.
            int[] numbers = new int[] { 1, 9, 200, 7, 5, 100 };
            obj2.sequenceofnumbers(numbers);
            obj2.sequenceofnumbers(numbers, "asc");

            //Create a property that returns a string.
            obj2.Cadena = "alli si maria avisa y asi va a ir a mi silla";
            Console.WriteLine("The private variable: {0}",obj2.Cadena);

            //Create a method to verify if a string is a palindrome (Use the created property).
            obj2.CheckForPalindrome(obj2.Cadena);

            //Create a method to print numbers in diagonal.
            obj2.DiagonalPrint(15);



        }
    }
}
