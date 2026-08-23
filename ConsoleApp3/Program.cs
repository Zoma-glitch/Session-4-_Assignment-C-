using System.Diagnostics;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1- Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75.Print the second price(index 1).

            //double[] prices = { 25.5, 40.0, 33.75 };

            //Console.WriteLine(prices[1]);
            #endregion
            //PrintWelcomeMessage();


            #region Question2

            //2- Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.

            //int[,] shelfCopies =
            //    {

            //{3,5},
            //{1,4}

            //};

            //Console.WriteLine(shelfCopies[1, 0]);


            #endregion

            //printBookTilte("CleanCode");
            //int pages = 400;

            //AddBounsPages(pages);

            //Console.WriteLine(pages);

            //double [] prices = {25.5 , 40.0};
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);

            //int pages = 400;

            //AddBounsPagesRef(ref pages);

            //Console.WriteLine(pages);


            //double[] prices = { 25.5, 40.0 };

            //ReplaceArray(ref prices);

            //Console.WriteLine(prices.Length);

            //double price;

            //if (TryGetPrice("Clean Code", out price))
            //{
            //    Console.WriteLine(price);
            //}

            printBookInfo("Clean Code");
            printBookInfo("The Pragmatic Programmer", 352);

        }
        #region Question03  

        //private static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        #endregion

        #region Question04

        //4-Write a method PrintBookTitle(string title) that prints "Book title: " + title.Call it with "Clean Code".

        //private static void printBookTilte(string title)
        //{
        //    Console.WriteLine("Book Title" + title);
        //}


        #endregion




        #region Question05
        //5-Write a method AddBonusPages(int pages) that adds 50 to pages.Call it with a variable int pages = 400; and print pages afterward.What do you expect to see, and why?

        //private static void AddBounsPages(int pages)
        //{
        //    pages = pages + 50;
        //}


        #endregion



        #region Question06

        //6-Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why?

        //private static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] = prices[0] - 5;
        //}




        #endregion


        #region Question07

        //7-Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward.How is the result different from question 5?
        //private static void AddBounsPagesRef(ref int pages)
        //{
        //    pages = pages + 50;
        //}


        #endregion


        #region Question08

        //8-Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward.

        //private static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] {10.0 , 12.5 , 15.0};
        //}
        #endregion


        #region Question09
        //9-Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it  and print the price if found

        //public static bool TryGetPrice(string title , out double price)
        //{
        //    if(title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }
        //    price = 0;
        //    return false;
        //}
        #endregion

        #region Question10

        public static void printBookInfo(string title , int pages = 300)
        {
            Console.WriteLine("Title:" + title);
            Console.WriteLine("Pages:" + pages);    
        }

        #endregion
    }
}
