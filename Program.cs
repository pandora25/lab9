using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\twelcome to the c# class\n\n");

            try
            {
                bool repeat1 = true;
                bool repeat2 = true;

                List<string> names = new List<string>() { "mike ", "anthony ", "timo " };
                List<string> favriotfood = new List<string>() { "pizza ", "noodles ", "pork " };
                List<string> hometown = new List<string>() { "google ", "yahoo ", "facebook " };
                List<string> color = new List<string>() { "blue ", "red ", "blacdk " };

                while (repeat1)
                {
                    Console.Write("the names are: ");
                    foreach (var item in names)
                    {
                        Console.Write($" {item}");
                    }

                    Console.Write("\nthe favriot food are: ");
                    foreach (var item in favriotfood)
                    {
                        Console.Write(item);
                    }

                    Console.Write("\nthe hometown are: ");
                    foreach (var item in hometown)
                    {
                        Console.Write(item);
                    }

                    Console.Write("\nthe color are: ");
                    foreach (var item in color)
                    {
                        Console.Write(item);
                    }


                    Console.Write("\n\nwhat student name would you like to know about ?");
                    Console.WriteLine("\n\nhint for the avaliable names are (1)  mike, (2) anthony and (3) timo.\n");


                    int input1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(names[input1 - 1] + " is exsit! )");
                    Console.WriteLine($"would else would you like to know about {names[input1 - 1]} ?");
                    Console.WriteLine("favriot food:'f' or hometown:'h' or color:'c'?");

                    string input2 = Console.ReadLine();
                    bool repeat7 = true;
                    while (repeat7)
                    {
                        if (input2 == "h")
                        {
                            Console.WriteLine(hometown[input1 - 1]);
                        }
                        else if (input2 == "f")
                        {
                            Console.WriteLine(favriotfood[input1 - 1]);
                        }
                        else if (input2 == "c")
                        {
                            Console.WriteLine(color[input1 - 1]);
                        }
                        else
                        {
                            Console.WriteLine("invalid entry !!!");
                        }
                        repeat7 = Confirmation("would you like to know more of the student (y/n) ");
                    }



                    Console.WriteLine("do you like to update the student names add:'1' or remove:'2' ? ");
                    string input3 = Console.ReadLine().ToLower();


                    if (input3 == "1")
                    {
                        bool repeat3 = true;
                        while (repeat3)
                        {
                            Console.WriteLine("what name you like to add");
                            string input4 = Console.ReadLine();
                            names.Add(input4);

                            Console.WriteLine("what favriotfood you like to add");
                            string input5 = Console.ReadLine();
                            favriotfood.Add(input4);

                            Console.WriteLine("what hometown you like to add");
                            string input6 = Console.ReadLine();
                            hometown.Add(input4);

                            Console.WriteLine("what color you like to add");
                            string input7 = Console.ReadLine();
                            color.Add(input4);

                            repeat3 = Confirmation("what you like to add more (y/n)");
                        }
                    }
                    else if (input3 == "2")
                    {
                        bool repeat4 = true;
                        while (repeat4)
                        {
                            Console.WriteLine("would names you like to remove");
                            string input5 = Console.ReadLine();
                            int index = names.IndexOf(input5);
                            if (index > -1)
                            {
                                names.RemoveAt(index);
                                favriotfood.RemoveAt(index);
                                hometown.RemoveAt(index);
                                color.RemoveAt(index);
                            }
                            repeat4 = Confirmation("whould you like to remove more (y/n)");
                        }

                    }
                    repeat1 = Confirmation("would you like to know more? (y/n)");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry");
            }
        }
        public static bool Confirmation(string message)
        {
            Console.WriteLine(message);
            string inputt = Console.ReadLine().ToLower();
            if (inputt == "y")
            {
                return true;
            }
            else if (inputt == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("invalid entry!!");
            }
            return Confirmation(message);
        }
    }
}