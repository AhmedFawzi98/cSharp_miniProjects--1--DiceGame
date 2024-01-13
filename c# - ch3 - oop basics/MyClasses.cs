namespace Myclasses;

public static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}


class Rectangle
{
    //private int _hegiht = 4; //in c# we can set values for field directly !, they will be used ONLY with the parametereless constructor
    private int _width;       //but since we already defined a constructorm now we must use the constructor cuz parameterless one does not exist anymore!
                              //so these values just for example, but they wont be used in our case :D 

    //old way of witing properties, the backing field must be there, cuz its already used in the property body
    /*public int Width //property names always Pascal !
    {
        get
        {
            return _width; // _width -> called backing field of property!
        }
        private set  //note that if its private, it cannot be used outside class, its like there is no setter for this field, only in class (same as using the field itself !)
                      //aslo can delete it tottally, and just use the field name ! you are inside class anyway :D
        {
            if (value > 0)
                _width = value; //value is a keyword that refers to the value on the right hand side of = when using the propery in main program
        }
    }
    */
    //expression bodied property syntax
    public int Width
    {
        get => _width;
        set => _width = value;
    }

    //modern syntax, used if no logic or code inside the property , it only sets and gets
    //when this is used, you have to delete the backing field, its no longer needed, you can ONLY use the propery name!
    //no semicolon after property ! also use curly braces not parenthesis!
    //public int Height { get; private set; }  //note that setter is private so it cannot be used outsidde, class, only in class!

    //also note i can remove setter at all, to make property no changable even inside class! like readonly
    //public int Height { get; } , also if you want to give it a value to be used if the parameter less constructor exists 
    // you can say public int Height { get; } = 5; //here must use semicolon

    //public int Height { get; set; }

    public int Height { get; init; } //init accessor allow the property to be setted outside the class BUT ONLY at  creation time!
                                     // afterthat it will be like it doesnt have a setter at all :D 


    //static property
    public static int CountOfRec { get; private set; } //private set cuz it will only be modifed inside class (in the constructor :D)

    //static field
    //public static int RecCount = 0;
    //or
    public static int RecCount;
    static Rectangle() //static constructor (only to initialize the static memebers (fields), will be called before the first instance of this class is created.
    {
          RecCount = 0; //also note i dont have to initalzie at all cuz as we agreed, all un-initilazed memebers of a class (static or non static) will be initiazled to default value of their datatype
                        //but if you want to initialze to something different than the default value , you can :D
    }

    public Rectangle() //my own parameterless constructor 
    {
        RecCount++;
        CountOfRec++;
    }

    public Rectangle(int h , int w)
    {
        Height = ValidateDimension(h, nameof(Height)); //using nameof() expression, it returns the same name of attribute passed, as a string!
        Width = ValidateDimension(w, nameof(Width));   //this is better than just passing the field name as a hardcoded string  i.e ValidateDimension(w, "Width")
        RecCount++;                                     //but using nameof(), whenever we change the attribute field name, the ValidateDimension will alway be passed the new name
        CountOfRec++;
    }
    /*public Rectangle(int h) //this is not clean, repetitive
    {   
        Height = h;
        Width = h;
    }
    */

    public Rectangle(int h) : this(h, h) //better way to do constructor overloading but instead of defining a new body, i can do something like constructor chaining 
                                        //but its not constructor chaining, am not calling a constructor from a parent class, am calling another version of my own constructor
    {                                   //and compiler will know which version am calling by checking the arguments given!
                                        //so basically the business meaning of this, that if only hegiht is given, just set the width to same value
    }

    public int CalcArea() => Width * Height;// expression bodies methods, for 1 line methods

    private int ValidateDimension(int dim, string dimName)
    {
        if(dim < 0)
        {
            Console.WriteLine($"{dimName} cant be negative value");
            return 0;
        }
        else
            return dim;
    }


}

