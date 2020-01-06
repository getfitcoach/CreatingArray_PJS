using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Array
{
    class Program
    {
        static void Main(string[] args)
        {


            //print all of them
            string[] namearray = new string[5];

            for (int counter1 = 0; counter1 < namearray.Length; counter1++)
       
                {
                    Console.WriteLine("Please enter a name");
                    namearray[counter1] = Console.ReadLine();
                    // Console.WriteLine(namearray[0]);
                }


            //Console.WriteLine("please enter a name");
           // namearray[1] = Console.ReadLine();
            //Console.WriteLine(namearray[1]);


            //Console.WriteLine("next name please");
           // namearray[2] = Console.ReadLine();
            //Console.WriteLine(namearray[2]);


           // Console.WriteLine("another name please");
           // namearray[3] = Console.ReadLine();
            //Console.WriteLine(namearray[3]);


           // Console.WriteLine("last name please");
           // namearray[4] = Console.ReadLine();
            //Console.WriteLine(namearray[4]);
        



            for (int counter = 0; counter < namearray.Length; counter++)
            {
                Console.WriteLine(namearray[counter]);

            }

            Console.ReadLine();




        }
    }
}
