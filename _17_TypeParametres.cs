namespace _17_TypeParametres
{
    class A 
    {
        /*
            value parameters
            reference parameters
            out parameters
            parameters Arrays
            Method parameters Vs method Arguments
        */

        //REF
        /*
            la fonction demande  un parametre avec le mot cle ref
            et l appel avec le mot clé ref 
        */
        public static void simpleMethod(ref int a)
        {
            a = 100000;
        }

        //Out parametre
        /*
            plusieurs retours
        */
        public int addNbr(int f, int s, out int sum, out int mul )
        {
            sum = f+s;
            mul = f*s;
            return 0;
        }

        public void typeParams()
        {
            //Value parameters 
        }

        public static void displayArrays(params int[] Tab)
        {
            foreach(int x in Tab){
                Console.Write("{0} ",x);
                            }       
        }
    }
}

// using _17_TypeParams;
// _17_TypeParams.A A = new _17_TypeParams.A();
// A.typeParams();

// int k = 10;
// _17_TypeParams.A.simpleMethod(ref k);
// Console.WriteLine(k);

// int sum = 0;
// int mul = 0;
// int a = 5;
// int b = 7;
// A.addNbr(a, b, out sum, out mul);

// Console.WriteLine("la somme de {0} et {1} = {2}",a, b, sum);
// Console.WriteLine("la multiplication de {0} et {1} = {2}",a, b, mul);

// int[] Tab = new int[4];
// Tab[0] = 11;
// Tab[1] = 22;
// Tab[2] = 33;
// Tab[3] = 44;
// _17_TypeParams.A.displayArrays(Tab);
// _17_TypeParams.A.displayArrays(1,2,3,4); 
// // !!! marche avec la clé params !!!
// // params doit etre a la derniere position des parametres 
// // avec params je peux ne pas envoyer aucune valeur
// // avec params  je peux envoyer le tableau deja remplit
// // Je ne peux pas avoir deux params 

// //VS
// //parametres c est dans la declaration arguments c est dans l appel .