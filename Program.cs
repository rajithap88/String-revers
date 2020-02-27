using System;

namespace Asg2_ques2
{
    class Program
    {
        static void Main(string[] args)
        {


            string s = "Welcome to the world";
            string a = "";
            string final = "";
            //initializing i value to the number of array elements and loop stops once i becomes negative
            for (int i = s.Length - 1; i > -1; i--)
            {
                //if checks for the empty space between words,if true to it appends the temporary value 'a' to the existing final value
                if (s[i] == ' ')
                {
                    //the below final will keep appending each word in reverse order
                    final = a + " " + final;
                    a = "";
                  
                }
                else
                //if there are no empty spaces then the temporary value 'a' will store the array elemnts of a word in rever order as i is stated with array last element
                {
                    a += s[i];
                   
                }
            }
            //the below final is required to add the last reversed word,else if we try to print from the earlier final value it prints all words except last word(as it skips the result executed in last else loop)
           final = a + " " + final;
            Console.WriteLine(final);
        }
    }
}
