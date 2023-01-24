namespace _52_Attributes_Obsolete
{
    /*
        L attribut Obsollete herite de la classe Attribut utilsé pour rendre une methode 
            déconseillé ou interdite généralement quand on cree une nouvelle methode plus
            sofistiqué mais que léeffacement de l ancienne entrainnera de gros rectification
            dans le programme.
            ex d autre attributes :
                [Obsolete]
                [WebMethod] 
                [serialisable]
    */
    using System.Collections.Generic;
    class Calculator 
    {
        public static void main()
        {
            // ******* // 
            //Origine Obsolete
            // Console.WriteLine(add(6,7)); // desactivé pour le warnnong/erreur => Atribut OBSOLETE 
           
            //3 parametre
            Console.WriteLine(add(1,2,3));

            List<int>? Tnumbers = new List<int>();
            Tnumbers.Add(1);
            Tnumbers.Add(11);
            Tnumbers.Add(8);
            Tnumbers.Add(99);
            Tnumbers.Add(2);

            //Lists
            Console.WriteLine(add(Tnumbers));

            //Params
            Console.WriteLine(add(1,3,3,4,100));
        }

        //Trois constructeur pour 'obsolete' vide, message, message+errur
        [Obsolete("Methode deprissié utilise add(params int[])", true)] // Attribut = Cette methode est obsolete a éviter d utiliser
        public static int add(int a, int b)
        {
            return a + b;
        }

        // si on veut upgarder la methodde a 3 nombre
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        //Le problemme si c est 100 chiffre cette fois
        public static int add(List<int> numbers)
        {
            int sum = 0;
            foreach(int x in numbers)
            {
                sum += x;
            }
            return sum;
        }

        //Avec params on peut upgrader a + infini
        public static int add(params int[] Tnumbers)
        {
            int sum = 0;
            foreach(int x in Tnumbers)
            {
                sum += x;
            }
            return sum;
        }
    }
}
// using _52_Attributes_Obsolete;
// Calculator.main();