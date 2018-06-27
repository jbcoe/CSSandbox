using System;

namespace IfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rachel = 20;
            int Robin = 26;
            //int Stacey = 54;
            //int Jesse = 60;

            if(Rachel>18){
                Console.WriteLine("Rachel can vote.");
            }
             
            if(Rachel>21 && Robin>21){
                Console.WriteLine("Rachel and Robin can both drink.");
            }
            
            if(Rachel>21 || Robin>21){
                Console.WriteLine("At least one of Rachel or Robin can drink.");
            }
        }
    }
}
