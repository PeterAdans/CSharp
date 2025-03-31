using System;

namespace CSharpHelloWorld
 {


class HelloWorld
{
    static void Main(string[] args) 
    {

        
        Console.WriteLine("Hello, C#");
        //hola mundo
        /*
        Console.WriteLine("Hello, C#");
        Console.WriteLine("Hello, C#");
        esto 
        es 
        un
        comentario

        */

        string myString = "Esto es una cadena de texto";
        myString = "Aqui cambio el valor de la cadena de texto";
        Console.WriteLine(myString);

        int myInt = 7;
        myInt = myInt + 4;
        Console.WriteLine(myInt);
        Console.WriteLine(myInt - 1);

        double myDouble = 6.5;
        Console.WriteLine(myDouble);

        Console.WriteLine(myDouble + myInt);

        bool myBool = true;
        myBool = false;
        Console.WriteLine(myBool);

        var myVar = "Mi variable de tipo inferido";
        //myVar = 6; Error
        Console.WriteLine(myVar);



        Console.WriteLine($"El valor de mi entero es {myInt} y el valor de mi bool {myBool}");


        //Estructuras

        var myArray = new string[] { "Pedro", "Fuentes", "Guerrero" };
        Console.WriteLine(myArray[0]);

        myArray[2] = "36";
        Console.WriteLine(myArray[2]);

        var myDictionary = new Dictionary<string, int>
         {
            {"Guerrero", 36},
            {"Fuentes", 5},
            {"Leon", 10}
         };

         Console.WriteLine(myDictionary["Guerrero"]);


         //bucles

         for (int index = 0; index < 5; index++)
         {
            Console.WriteLine(index);
         }


         foreach (var myItem in myArray)
         {
             Console.WriteLine(myItem);
         }

         foreach (var myItem in myDictionary)
         {
             Console.WriteLine(myItem);
         }


         //Flujos

         

         if (myInt == 11 && myBool == true )
         {
            Console.WriteLine("El valor es 11");
         }
         else if (myInt == 12 || myBool == false)
         {
            Console.WriteLine("El valor es 12");
         }
         else
         {
            Console.WriteLine("El valor no es 11 ni 12");
         }


         //Clases 

         var myClass = new MyClass("Pedro");
         myClass.myName = "Adrian";
         Console.WriteLine(myClass.myName);

         //llamar funciones

         myFunction();
         myFunction();
         myFunction();
         Console.WriteLine(myFunctionWithReturn(5));

         


         //funciones

         static void myFunction()
         {
            Console.WriteLine("Mi función");

         }

         static int myFunctionWithReturn(int param)
         {
          return  10 + param;

         }
    }
         //Clase
         class MyClass
         {
           public string myName { get; set; }

           public MyClass(string myName)
            {
               this.myName = myName;
            }

         }


    








    }
}
