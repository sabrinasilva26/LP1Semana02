using System;

namespace ChatGPTOne
 {
    public class Program
    {
        private static void Main(string[] args)
        {

           Console.WriteLine($"Insira uma questão: ");
            string read = Console.ReadLine();

            while (read != "EXIT")
            {
            
            if (read == "How are you?")
            {
                Console.WriteLine("I´m fine");
            }
            else if (read == "Can you recommend me one movie?")
            {    
                Console.WriteLine("I recommend you se7en");
            }
            else if (read == "Can you help me with my programming assignments?")
            {
                Console.WriteLine("yes, I can help you. What do you need?");
            }

            else if (read == "How´s the weather?")
            {
                Console.WriteLine("It´s sunny today");
            }
            else
            {
                Console.WriteLine("I don't understand the question.");
            }


            Console.WriteLine($"Insira uma questão: ");
            read = Console.ReadLine();
            }

                
            
            

        }

           
    }
}

