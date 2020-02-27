using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem Ravioli = new MenuItem();
            Ravioli.Name = "Ravioli";
            //Ravioli.MenuCategory = MainCourse;
            Ravioli.Price = 9;
            Ravioli.Description = "Choice of beef or cheese with either marinara or garlic cream sauce";
            MenuItem ChocolateCake = new MenuItem();
            ChocolateCake.Name = "Chocolate Cake";

            Menu.AddToMenu(Ravioli);
            Menu.AddToMenu(ChocolateCake);
            Menu.RemoveFromMenu(ChocolateCake);

            Menu.PrintMenu();

        }
    }
}
