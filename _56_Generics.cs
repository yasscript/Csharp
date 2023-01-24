namespace _56_Generics
{
    /*
        Generics = 
        cas d'utilisations => 
    */
    class Genericx
    {
        // Base
        public static bool areEqual(int a, int b)
        {
            return a == b;
        }

        // Object
        public static bool areEqual2(object a, object b)
        {
            return a.Equals(b);
        }


        // Generic
        public static bool areEqual3<T>(T a, T b)
        {
            if(a == null){
                return false;
            }

            return a.Equals(b);
        }

        public static void main()
        {
            string result = areEqual(1,1) == true? "ils sont eagaux": "ils sont differents";
            Console.WriteLine(result);

            // Maintenant je teste d'envoyer des strings a la place des ints 
            // string result2 = areEqual("A","B") == true? "ils sont eagaux": "ils sont differents";
            // Console.WriteLine(result2);
            // J ai une erreur !! tu attendais que ca marche ou koi ?!! hhh

            // Deux façons pour remedier a ca 
            // 1 - changer le type des parametres en "object"
            // Le problem avec "Object" c est que je peux comparer de type different a la base 
            string result3 = areEqual2("A",1000) == true? "ils sont eagaux": "ils sont differents";
            Console.WriteLine(result3);


            // 2 - Le generic me force a comparer 2 values du meme type 
            string result4 = areEqual3<string>("A","B") == true? "ils sont eagaux": "ils sont differents";
            Console.WriteLine(result4);

            string result5 = areEqual3<int>(2,2) == true? "ils sont eagaux": "ils sont differents";
            Console.WriteLine(result5);
            //si on precise pas le genre il ca comparer le type envoyé !!

            // une class une interface ... peuvent etre aussi generic => a developper !!
        }
    }
}

// using _56_Generics;
// Genericx.main();