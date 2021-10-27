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

            Console.WriteLine("1) What is the best pet? a) Dog  b) Cat or c) Hamster");
            Answer = Console.ReadLine();
            if (Answer == Correct)
            {
                Points++;
                Answer = "ph";
                Correct = "a";
                System.Console.WriteLine("2) What is the first letter in the Alphabet? a) a b) ö c) oe");
                Answer = Console.ReadLine();
                if (Answer == Correct)
                {
                    Points++;
                    Answer = "ph";
                    Correct = "c";
                    System.Console.WriteLine("3) What is the worlds biggest city? a) New York b) Stockholm c) Tokyo");
                    Answer = Console.ReadLine();
                    if (Answer == Correct)
                    {
                        Points++;
                        Answer = "ph";
                        Correct = "c";
                        System.Console.WriteLine("4) Who was the king of the largest kingdom called Francia, formed close to the collapse of rome? a) Hitler b) Stalin c) Charlemagne");
                        Answer = Console.ReadLine();
                        if (Answer == Correct)
                        {
                            Points++;
                            Answer = "ph";
                            Correct = "Placeholder";
                            System.Console.WriteLine("congratz you got " + Points + "points");
                        }
                        else
                        {
                            Answer = "ph";
                            Correct = "Placeholder";
                            System.Console.WriteLine("congratz you got " + Points + "points");
                        }
                    }
                    else
                    {
                        Answer = "ph";
                        Correct = "c";
                        System.Console.WriteLine("3) What is the worlds biggest city? a) New York b) Stockholm c) Tokyo");
                        Answer = Console.ReadLine();
                        if (Answer == Correct)
                        {
                            Points++;
                            Answer = "ph";
                            Correct = "c";
                            System.Console.WriteLine("4) Who was the king of the largest kingdom called Francia, formed close to the collapse of rome? a) Hitler b) Stalin c) Charlemagne");
                            Answer = Console.ReadLine();
                            if (Answer == Correct)
                            {
                                Points++;
                                Answer = "ph";
                                Correct = "Placeholder";
                                System.Console.WriteLine("congratz you got " + Points + "points");
                            }
                            else
                            {
                                Answer = "ph";
                                Correct = "Placeholder";
                                System.Console.WriteLine("congratz you got " + Points + "points");
                            }
                        }
                    }
                    Console.ReadLine();

                }
                else
                {
                    Answer = "ph";
                    Correct = "a";
                    System.Console.WriteLine("2) What is the first letter in the Alphabet? a) a b) ö c) oe");
                    Answer = Console.ReadLine();
                    if (Answer == Correct)
                    {
                        Points++;
                        Answer = "ph";
                        Correct = "c";
                        System.Console.WriteLine("3) What is the worlds biggest city? a) New York b) Stockholm c) Tokyo");
                        Answer = Console.ReadLine();
                        if (Answer == Correct)
                        {
                            Points++;
                            Answer = "ph";
                            Correct = "c";
                            System.Console.WriteLine("4) Who was the king of the largest kingdom called Francia, formed close to the collapse of rome? a) Hitler b) Stalin c) Charlemagne");
                            Answer = Console.ReadLine();
                            if (Answer == Correct)
                                Points++;
                            Answer = "ph";
                            Correct = "Placeholder";
                            System.Console.WriteLine("congratz you got " + Points + "points");
                        }
                    }
                    else
                    {
                        Answer = "ph";
                        Correct = "c";
                        System.Console.WriteLine("3) What is the worlds biggest city? a) New York b) Stockholm c) Tokyo");
                        Answer = Console.ReadLine();
                        if (Answer == Correct)
                        {
                            Points++;
                            Answer = "ph";
                            Correct = "c";
                            System.Console.WriteLine("4) Who was the king of the largest kingdom called Francia, formed close to the collapse of rome? a) Hitler b) Stalin c) Charlemagne");
                            Answer = Console.ReadLine();
                            if (Answer == Correct)
                            {
                                Points++;
                                Answer = "ph";
                                Correct = "Placeholder";
                                System.Console.WriteLine("congratz you got " + Points);
                            }
                            else
                            {
                                Answer = "ph";
                                Correct = "Placeholder";
                                System.Console.WriteLine("congratz you got " + Points + "points");
                            }
                        }
                    }
                }
            }
        }
    }
}
