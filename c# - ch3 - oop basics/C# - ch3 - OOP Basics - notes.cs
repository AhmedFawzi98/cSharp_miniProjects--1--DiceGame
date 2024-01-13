/*
 ------* DateTime built-in datatype, its a struct, immutable value type, non nullable.

                DateTime FawziBirthDayIn1998 = new DateTime(1998, 9, 22);
                Console.WriteLine($"in 1998, i was born on: {FawziBirthDayIn1998.DayOfWeek}");

                DateTime FawziBirthDayIn2023 = FawziBirthDayIn1998.AddYears(25);
                Console.WriteLine($"in 2023, my birthday was on: {FawziBirthDayIn2023.DayOfWeek}"); 

                DateTime currentdate  = DateTime.Now; //returns a new object with values of attributes of current date and time
                Console.WriteLine(currentdate); //   12/01/2024 18:04:04

                DateTime currentdate = DateTime.Now.AddDays(7); //same but also add 7 days from current time
                Console.WriteLine(currentdate); //  19/01/2024 18:04:04
 
------* in c# , class is refernec type , so the parameterless constructor initialize all class fieds with their defualt values!
        so even if you constructed a class without a constructor to initialzie fields, they will be automatically intialzied to default values!
        OR they will be set to the values you set for them directely in the class

------* defualt access modifier in c# is : the mose restrictive access modifier in context

------* this keyword: 
        1- same old use of refereng to an instanse (object) of the class inside the class itself
        2- same old use as in c++ --> to refer to the field of an object if a method has parameters with same name
                i.e  this.real  or  this.imag    (not this->real   this->imag) cuz in c# this is a REFERENCE to the caller object
                not an address (not a pointer) to it as in c++
        3- new use, for calling the constructor of class inside the class itself (such as in constructor overloading)

------* optional parameter :
            1- must be compile-time known value!
            2- if an optional aparameter is passed , all preceeding parameters must be passed to
                    i.e Myfun(int year, string month = "feb")    you cant say   MyFun("march")
                 or i.e Myfun(int year = "1990", string month = "feb")    bardo you cant say   MyFun("march")

------* readonly keyword for class fields vs  const keyword
class Rectangle
{
     private readonly int _height // in the declaration of field, we could set it to readonly , 
                                 //this means after the constructor is called and values are set to this field, it cant be modifed again ,not by any way!
     private readonly int _width;

    public Rectangle(int h , int w)
    {
        Height = ValidateDimension(h, nameof(_height)); 
        Width = ValidateDimension(w, nameof(_width)); 
    }
}
    ** readonly keyword is used only with fields , and field can be assigned a value later (in constructor) (value doesnt have to becompile-time  known) or at declaration time(to be used with pararmeterless constructor)
   
    ** const can be used with fields or variables, and field/variable MUST be assigned a value at declaration line! (also this value muse be compile-time know)

    note that all const are implictely static, this is an optimization automatically done to save memory ,cuz sense the value of this field doesnt change from an instance to another, why to store it multiple time?
    so its automatically made static so its stored only once in the class itself, thisis why if you have a public const memeber, you cant access it by object name, MUST use class name!


------* properties 

        property name is always written PascalCase even for private properties
        set, get --> called accessors


        note that properties are like field when it comes to access modifiers ,
            they can be public,private,internal,protected,protected internal



------* property
        - usually public 
        - similar to method 
        - can be overriden
        -set , get --> they dont have to have the same accss modifier
            also note that the defualt for them is to be the same as the access modifier of the property itself

vs

        field
        - usually private
        - only one access modifier
        - like a variable
        - can not be overriden


------* computed properties  vs parameterless methods 
        consider this parameterless method :
            public int CalcArea() => Width * Height;
        it can also be a property :
            public int CalcArea => Width * Height;
       
but how to choose whether it should be a parameterless method or property ?   
    -- if its heavy computation, more logic, loops, ...etc ---> use parameterless method!
    -- if its simple, more about presenting data rather than computing stuff --> use property 
 


 ------* static methods and static classes
     classes having fields/properties along with methods --> stateful classes
     classes having methods only --> stateless classes

    static method CAN NOT be called by an object of the class, must be called by the class itself 

    a normal class can have static members(method/fields) along with non static 3ady 
        then static method can ONLY access the class static members (as we already knew in c++), cant access instance memebrs (non static memebers)
        and it will be called also ONLY by class name

    but an instance method can access static fields 3ady gdnn :D

    its a good practice that if you have a class method that does not use any instance memeber of the class --> make it static
        cuz    1 - static methods work slightly faster cuz they dont need to be passed  this  keyword or access any object state
               2 - it clearly shows that this method does not mutate the object state.

    a class can be made static only if all members (methods, fields) in it are static !
            in other words, static class can only contatins static memebrs!

    static class can not be instansiated 
    


 --------* Enum 

 
 */