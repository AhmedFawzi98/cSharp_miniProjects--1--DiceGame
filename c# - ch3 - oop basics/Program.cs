//using MyClasses;
using Myclasses;
using MyEnum;


namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(7);
            Console.WriteLine(rec1.CalcArea()); //49
            Rectangle rec2 = new Rectangle(7,9); //63
            Console.WriteLine(rec2.CalcArea());

            //using object initalizer: pros -> dont have to assign values for all properties
            //
            //instead of consturctor , to set values for properties 
            //this is valid only if properties setters exists, and they are (the setters) public !

            // if you have a parameterless constructor!
            /*Rectangle rec2 = new Rectangle
            {
                Height = 20,
                Width = 40
            };

            //or even if i have a parameterized constructor, it will be used to set values, then it will be overriden by the object initialzier !
            Rectangle rec3 = new Rectangle(10, 10)
            {
                Width = 20,
                Height = 20
            };

            Console.WriteLine(rec3.CalcArea()); //20 * 20 = 400 ! not 10 * 10

            //using the object initialzier , i can set some properties and some not !, the rest willl be with the default value if any given in class, or the defualt value of datatype if non given in class
            Rectangle rec4 = new Rectangle
            {
                Width = 20
            };
            Console.WriteLine(rec4.CalcArea()); // 20 * 0 = 0

            //but thats a problem cuz that means i must have a public setter for property!
            //so now i can change the property anytime
            rec3.Width = 8000;
            Console.WriteLine(rec3.CalcArea()); // 8000 * 20 !!!!!!!

            //but there is a solution to that introduced in c#9 , which is init accessor!  --> check the class
            Rectangle rec5 = new Rectangle
            {
                Width = 20,
                Height = 40
            };
            rec5.Height = 1000;//error ! cant change property , with init accessor its only available at declaration of object! (with object initialzer)
            */

            Console.WriteLine(Calculator.Add(5, 10)); //15


            Console.WriteLine(Rectangle.RecCount);
            Console.WriteLine(Rectangle.CountOfRec);

            Season myseason = Season.winter;
            Console.WriteLine(myseason); //winter
            Console.WriteLine((int) myseason); //2

            Season2 myseason2 = Season2.winter;
            Console.WriteLine(myseason2); //winter
            Console.WriteLine((int)myseason2); //5

            //Season myseason3 = Season.ayklam; //error , variables from enumenator type can only be assigned values of the Enum

            Accessories myAccessory = Accessories.watch;
            Console.WriteLine(myAccessory); //watch
            Console.WriteLine((int) myAccessory); //400


        }


    }
}
