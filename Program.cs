using System;

class Program
{
   
    struct price
    {
     public String allprice;

    }
    enum Snackdrinkprice
    {
        cola = 20,
        juice = 15,
        water = 7,
        potatochip = 30,
        Chocolate = 25,
        Jelly = 10

    }
     static void Main()
    {
        Console.WriteLine("you wanna check something please input to string ");
        Console.WriteLine("we have cola juice water potatochip Chocolate jelly");
        price sell = new price();
        input(ref sell);
        Console.WriteLine();
    }
    static void input(ref price sell)
    {
        sell.allprice = Console.ReadLine();
        switch (sell.allprice)
        {
            case "cola":
                Console.WriteLine("price : " + (int)Snackdrinkprice.cola);
                break;
            case "juice":
                Console.WriteLine("price : " + (int)Snackdrinkprice.juice);
                break;
            case "water":
                Console.WriteLine("price : " + (int)Snackdrinkprice.water);
                break;
            case "potatochip":
                Console.WriteLine("price : " + (int)Snackdrinkprice.potatochip);
                break;
            case "Chocolate":
                Console.WriteLine("price : " + (int)Snackdrinkprice.Chocolate);
                break;
            case "Jelly":
                Console.WriteLine("price : " + (int)Snackdrinkprice.Jelly);
                break;
        }
        
    }
   
}
