using System;
using System.Collections.Generic;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TK shop!");
            Console.WriteLine();
            Console.WriteLine("Choose option:");
            Console.WriteLine();
            Console.WriteLine("1. Type 'LIST' for item list.");
            Console.WriteLine("2. Type 'BUY' to buy an item.");
            Console.WriteLine("3. Type 'Add' to add an item.");
            Console.WriteLine();
            Console.WriteLine("If you want to exit shop type 'Exit'.");
            Console.WriteLine();

            //var shop = new Shop();
            var book = new Books();
            var cup = new Cups();
            var sweet = new Sweets();
            var items = new List<string>() { book.GetName(), cup.GetName(), sweet.GetName() };

            bool close = false;

            while (!close)
            {
                var itemValue = new List<int>() { book.GetQuantity(), cup.GetQuantity(), sweet.GetQuantity() };
                string shopInput = Console.ReadLine();
                shopInput = shopInput.ToUpper();

                switch (shopInput)
                {
                    case "LIST":
                        Console.WriteLine();
                        Console.WriteLine($"{items[0]}   {itemValue[0]} (units left)");
                        Console.WriteLine($"{items[1]}    {itemValue[1]} (units left)");
                        Console.WriteLine($"{items[2]}  {itemValue[2]} (units left)");
                        Console.WriteLine();
                        break;
                    case "BUY":
                        Console.WriteLine();
                        Console.WriteLine("Add item you want to buy:");
                        string buy = Console.ReadLine();
                        buy = buy.ToLower();

                        if (buy == "book" || buy == "books")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Add quantity:");
                            string quantity = Console.ReadLine();
                            if (int.Parse(quantity) <= 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You can't buy 0 or less.");
                                break;
                            }
                            if (book.GetQuantity() <= 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("No more books to buy.");
                                break;
                            }
                            book.SetQuantity(int.Parse(quantity) * -1);
                        }

                        if (buy == "cup" || buy == "cups")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Add quantity:");
                            string quantity = Console.ReadLine();
                            if (int.Parse(quantity) <= 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You can't buy 0 or less.");
                                break;
                            }
                            if (book.GetQuantity() <= 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("No more cups to buy.");
                                break;
                            }
                            cup.SetQuantity(int.Parse(quantity) * -1);
                        }


                        if (buy == "sweet" || buy == "sweets")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Add quantity:");
                            string quantity = Console.ReadLine();
                            if (int.Parse(quantity) <= 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You can't buy 0 or less.");
                                break;
                            }
                            if (book.GetQuantity() <= 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("No more sweets to buy.");
                                break;
                            }
                            sweet.SetQuantity(int.Parse(quantity) * -1);
                        }
                        break;
                    case "ADD":
                        Console.WriteLine();
                        Console.WriteLine("Write item whitch you want to add:");
                        string add = Console.ReadLine();
                        add = add.ToLower();

                        if (add == "cup" || add == "cups")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Add quantity:");
                            string quantity = Console.ReadLine();
                            cup.SetQuantity(int.Parse(quantity));
                            Console.WriteLine();
                        }

                        if (add == "book" || add == "books")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Add quantity:");
                            string quantity = Console.ReadLine();
                            book.SetQuantity(int.Parse(quantity));
                            Console.WriteLine();
                        }

                        if (add == "sweet" || add == "sweets")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Add quantity:");
                            string quantity = Console.ReadLine();
                            sweet.SetQuantity(int.Parse(quantity));
                            Console.WriteLine();
                        }

                        break;
                    case "EXIT":
                        close = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("You have to choose option from list below:");
                        Console.WriteLine();
                        Console.WriteLine("1. Type 'LIST' for item list.");
                        Console.WriteLine("2. Type 'BUY' to buy an item.");
                        Console.WriteLine("3. Type 'Add' to add an item.");
                        Console.WriteLine();
                        Console.WriteLine("If you want to exit shop type 'Exit'.");
                        Console.WriteLine();
                        break;
                }
            }
            //Console.ReadLine();
        }
    }
}
