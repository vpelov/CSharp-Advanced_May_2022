using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> queueWithSongs = new Queue<string>();
            for (int i = 0; i < songs.Length; i++)
            {
                queueWithSongs.Enqueue(songs[i]);
            }

            string command = Console.ReadLine();
            while (queueWithSongs.Count > 0)
            {
                string[] cmd = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (cmd[0] == "Play")
                {
                    queueWithSongs.Dequeue();
                }
                else if (cmd[0] == "Add")
                {
                    string newSong = command.Substring(4, command.Length - 4);
                    if (queueWithSongs.Contains(newSong))
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                    else
                    {
                        queueWithSongs.Enqueue(newSong);
                    }
                }
                else if (cmd[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", queueWithSongs));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");

        }
    }
}
