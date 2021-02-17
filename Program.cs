using System;

namespace HelloWorldInverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] array = new string[12] {"H","e","l","l","o"," ","W","o","r","l","d","!"};

             for (int i=12; i > -1; i--)
            {
                Console.WriteLine(array[i]);
            }
    
        }
    }
}
