using System.Xml.Linq;

class Program
    {
        static void Main()
        {
           
            string[] input = Console.ReadLine()!.Split(' ');
            List<string> sequence = new List<string>(input);

            int moves = 0; 

            while (true)
            {
                string command = Console.ReadLine()!;
                if (command == "end")
                {
               
                    Console.WriteLine("Sorry you lose :(");
                    Console.WriteLine(string.Join(' ', sequence));
                    break;
                }

                moves++;

           
                string[] parts = command.Split(' ');
                int firstIndex = int.Parse(parts[0]);
                int secondIndex = int.Parse(parts[1]);

              
                if (firstIndex == secondIndex || firstIndex < 0 || secondIndex < 0
                    || firstIndex >= sequence.Count || secondIndex >= sequence.Count)
                {
                    string elementToAdd = "-" + moves + "a";
                    int middle = sequence.Count / 2;
                    sequence.Insert(middle, elementToAdd);
                    sequence.Insert(middle, elementToAdd);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

            
                if (sequence[firstIndex] == sequence[secondIndex])
                {
                    string matched = sequence[firstIndex];

                 
                    if (firstIndex > secondIndex)
                    {
                        sequence.RemoveAt(firstIndex);
                        sequence.RemoveAt(secondIndex);
                    }
                    else
                    {
                        sequence.RemoveAt(secondIndex);
                        sequence.RemoveAt(firstIndex);
                    }

                    Console.WriteLine($"Congrats! You have found matching elements - {matched}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                
                if (sequence.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
            }
        }
    }




