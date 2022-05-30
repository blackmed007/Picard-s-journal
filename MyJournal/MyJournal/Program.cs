namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Jean-Luc Picard’s journal \n");//main page
            while (true)
            {
                Console.WriteLine("please type  <start> to start writting or <stop> to To end writing : \n");
                string read = Console.ReadLine();
                if (read == "start")
                {
                    Journal();
                }
                else
                if (read == "stop")
                {
                    Environment.Exit(0);
                }

            }


            static void Journal()//Journal
            {
                Console.Clear();
                
                string file = $"{DateTime.Now}.txt";

                using (StreamWriter Diary = File.Exists(file) ? File.AppendText(file) : new StreamWriter($"current-date.txt"))
                {
                    Diary.Flush();
                    Diary.WriteLine($"Captain’s log \n Stardate: <{DateTime.Now}> ");


                    while (true)
                    {
                        string input = Console.ReadLine();

                        if (input == "stop")
                        {
                            Diary.Flush();

                            Environment.Exit(0);
                        }

                        Diary.WriteLine(input);
                        Diary.WriteLine("Jean-Luc Picard");


                    }

                }

            }
        }
    }
}