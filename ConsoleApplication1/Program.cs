using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            Console.WriteLine ("Enter a  string:");
            string s = Console.ReadLine();
            bool k=false;
            
            for(int i=0;i<s.Length-1;i++)
            {

                if (s[i] == s[i + 1])
                {
                    k=true;
                } 
            }

            if (k)
                Console.WriteLine("you have similar letters in your string.");
            else
                Console.WriteLine(" You do not have similar letters in your string"); 

            Console.ReadKey();
            

        }
    }
}
