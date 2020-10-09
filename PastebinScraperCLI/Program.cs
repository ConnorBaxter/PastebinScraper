using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PastebinScraperLib;

namespace PastebinScraperCLI
{
    class Program
    {
        private static Scraper scraper;

        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                RunInInteractiveMode();
                return;
            };

            if (args[0].ToLower() == "-i"|| args[0].ToLower() == "--interactive")
            {
                Console.WriteLine("Starting in interactive mode...");
                RunInInteractiveMode();
                return;
            }

            if (args.Length == 2)
            {
                try
                {
                    Search(args[0], int.Parse(args[1]));
                }
                catch 
                {
                    Search(args[0]);
                }
            }

            if (args.Length == 3)
            {
                try
                {
                    Search(args[0], int.Parse(args[1]), int.Parse(args[2]));
                }
                catch
                {
                    Search(args[0], int.Parse(args[1]));
                    scraper.SaveToJson(args[2]);
                }
            }
        }

        static void Search()
        {
            scraper = new Scraper();
            SearchAndOutput();
        }

        static void Search(string searchTerm)
        {
            scraper = new Scraper(searchTerm);
            SearchAndOutput();
        }

        static void Search(string searchTerm, int pageNum)
        {
            scraper = new Scraper(searchTerm, pageNum);
            SearchAndOutput();
        }

        static void Search(string searchTerm, int pageFrom, int pageTo)
        {
            scraper = new Scraper(searchTerm, pageFrom, pageTo);
            SearchAndOutput();
        }

        static void SearchAndOutput()
        {
            scraper.Search();
            Console.WriteLine(scraper.BingResult.ToString());
        }

        static void RunInInteractiveMode()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("cmd:?> ");
            Console.ForegroundColor = ConsoleColor.White;
            string command = Console.ReadLine();
            string op = command.Split(' ')[0];
            List<string> args = command.Split(' ').ToList();
            args.RemoveAt(0);

            while (op != "exit")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("cmd:?> ");
                Console.ForegroundColor = ConsoleColor.White;
                command = Console.ReadLine();
                args = command.Split(' ').ToList();
                op = args[0];
                args.RemoveAt(0);

                switch (op.ToLower())
                {
                    case "q":
                    case "exit":
                    case "quit":
                        return;
                    case "cls":
                    case "clear":
                        Console.Clear();
                        break;
                    case "v":
                    case "version":
                        Console.WriteLine(Assembly.GetExecutingAssembly().GetName().Version);
                        break;
                    case "help":
                        Console.WriteLine("No help available");
                        break;
                    case "search":
                        if (args.Count > 0)
                        {
                            if (args.Count == 1)
                            {
                                Search(args[0]);
                            }

                            else if(args.Count == 2)
                            {
                                int page = 1;
                                try
                                {
                                    page = int.Parse(args[1]);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                                Search(args[0], page);
                            }
                            else if(args.Count == 3)
                            {
                                int pageFrom = 1;
                                int pageTo = 10;
                                try
                                {
                                    pageFrom = int.Parse(args[1]);
                                    pageTo = int.Parse(args[2]);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                                Search(args[0], pageFrom, pageTo);
                            }
                        }
                        else
                        { Search(); }
                        break;
                    case "cat":
                        if (args.Count <= 0)
                        {
                            Console.WriteLine("Specify filename");
                            return;
                        }

                        using (StreamReader sr = new StreamReader(args[0]))
                        {
                            while (!sr.EndOfStream)
                            {
                                Console.WriteLine(sr.ReadLine());
                            }
                        }
                        break;
                    case "ls":
                        List<string> filenames = Directory.EnumerateFiles(Environment.CurrentDirectory, "*.json").ToList();
                        foreach (string file in filenames)
                        {
                            string[] fullname = file.Split('\\');

                            Console.WriteLine(fullname[fullname.Length-1]);
                        }
                        break;
                }
            }
        }
    }
}
