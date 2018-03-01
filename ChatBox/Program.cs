using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBox {
    class Program {
        static void Main(string[] args) {
            string question;

            do {
                question = Console.ReadLine();

                switch (question) {
                    case "Hello":
                        Console.WriteLine("Heya");
                        break;
                    case "How are you?":
                        Console.WriteLine("I'm gucci, and y- oh wait you can't answer");
                        break;
                    case "What's your name?":
                        Console.WriteLine("That's a very good question, I have no idea");
                        break;
                    case "What do you do?":
                        Console.WriteLine("I don't do anything, I'm useless, but i can tell u that u look stunning");
                        break;
                    case "EXIT":
                        break;
                    default:
                        Console.WriteLine("??? que ???");
                        break;
                }
            } while (question != "EXIT");
        }
    }
}
