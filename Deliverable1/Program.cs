using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the restocking tool.");

        //User inputs stock values

        //Check soda stock
        Console.Write("How many Sodas have been sold today? 100 are in stock. ");
        int sodaStock = (100 - int.Parse(Console.ReadLine()));
        int sodaRestock = 40;
        if (sodaStock >= 0) {
            string sodaResult = $"There are {sodaStock} Sodas left.";
            Console.WriteLine(sodaResult);
        } else {
            sodaStock = 100;
            Console.WriteLine("Soda sale input too high. Stock not adjusted.");
        }

        //Check chips stock
        Console.Write("How many Chips have been sold today? 40 are in stock. ");
        int chipStock = (40 - int.Parse(Console.ReadLine()));
        int chipRestock = 20;
        if (chipStock >= 0)
        {
            string chipResult = $"There are {chipStock} Chips left.";
            Console.WriteLine(chipResult);
        }
        else
        {
            chipStock = 40;
            Console.WriteLine("Chip sale input is too high. Stock not adjusted.");
        }

        //Check candy stock
        Console.Write("How many Candies have been sold today? 60 are in stock. ");
        int candyStock = (60 - int.Parse(Console.ReadLine()));
        int candyRestock = 40;
        if (candyStock >= 0)
        {
            string candyResult = $"There are {candyStock} Candies left.";
            Console.WriteLine(candyResult);
        }
        else
        {
            candyStock = 60;
            Console.WriteLine("Candy sale input is too high. Stock not adjusted.");
        }

        //Print restock report

        //if nothing needs to be restocked
        if (sodaStock >= sodaRestock && chipStock >= chipRestock && candyStock >= candyRestock) {
            Console.WriteLine("Thank you for filling out the values. Nothing needs to be restocked today.");
        } else //if any inventory needs restocking
        {
            Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");
            //check Soda restock
            if (sodaStock <= sodaRestock) {
                Console.WriteLine("Sodas need to be restocked.");
            }
            //check Chips restock
            if (chipStock <= chipRestock) {
                Console.WriteLine("Chips need to be restocked.");
            }
            //check Candy restock
            if (candyStock <= candyRestock)
            {
                Console.WriteLine("Candies need to be restocked.");
            }
        }
        
         

    }
}