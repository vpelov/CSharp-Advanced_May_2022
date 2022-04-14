using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songArray = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> songsQueue = new Queue<string>();
            foreach (string item in songArray)
            {
                songsQueue.Enqueue(item);
            }

            while (true)
            {                
                string commands = Console.ReadLine();

                if (songsQueue.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
                string[] command = commands
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    string song = commands.Substring(4, commands.Length - 4);
                    if (songsQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(song);
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));                    
                }           
            }

            
        }
    }
}
