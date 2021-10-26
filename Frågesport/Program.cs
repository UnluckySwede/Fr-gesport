using System;

namespace Frågesport
{
    class Program
    {
        
            
        
        static void Main(string[] args)
        {
        int Points = 0;

        String Answer;
        
        String Correct;

        Correct = "ph2";
        
        Answer = "ph";
        
        Correct = "b";
        
            Console.WriteLine("What is the best pet? a) Dog  b) Cat or c) Hamster");
            Answer = Console.ReadLine();
            if (Answer == Correct)
            {
                Points ++;
                Answer = "ph";
                Correct = "a";
                System.Console.WriteLine("What is the first letter in the Alphabet? a) a b) ö c) oe");
                Answer = Console.ReadLine();
                if (Answer == Correct)
                {
                    Points ++;
                    Answer = "ph";
                    Correct = "";
                    System.Console.WriteLine("What is the worlds biggest city? a) New York b) Stockholm c) Tokyo");
                    Answer = Console.ReadLine();
                    if ()
                    {
                        
                    }
                }
                Console.ReadLine();

            }
            else{

            }
        }
    }
}
