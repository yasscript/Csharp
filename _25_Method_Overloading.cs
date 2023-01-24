namespace _25_Method_Overloading
{
    class A 
    {
        /*
            ca ne marche pas avec :
                - return
                - params 
        */
        
        public static void calc(int a, int b)
        {
           Console.WriteLine(a+b);
        }

        //Nombre de parametres 
         public static void calc(int a, int b, int c )
        {
           Console.WriteLine(a+b+c);
        }

        //Types des parametres
        public static void calc(int a, string b)
        {
           Console.WriteLine(a + " " + b);
        }

         public static void calc(int a, out int b)
        {
            b=a*2;
        }

    }

}

// using _25_Method_Overloading;

// A.calc(2,3);
// A.calc(2,3,4);
// A.calc(5, "yass");
// A.calc(2, out int b);
// Console.WriteLine(b);