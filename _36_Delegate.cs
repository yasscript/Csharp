namespace _36_Delegate
{
    class Aclass
    {
        /*
            Utilisé pour rendre le code plus lisible 
                enfaite on change le nom des methode
                complexe ou externe par des noms plus comprehensible

            il doit correspondre a la function target en return
                data, parametres, accesibilite et on ajoute le keyword "delegate"
            +++ Voir 37 _ 38
        */
       
       
        // creation du delegate semblable a la target function
        public delegate void HelloDelegate(string name);

        public delegate void diplay(string str);



        public void test()
        {

            HelloDelegate del = new HelloDelegate(hello);
            del("Katim");

            diplay dis = new diplay(affiche);
            dis("salam alikoum comment ca va ?");

        }



        // target Function
        public static void hello(string name)
        {
            Console.WriteLine("Bonjour {0}", name);
        }


        public void affiche(string str)
        {
            Console.WriteLine(str);
        }   
    }
}

// using _36_Delegate;
// Aclass x = new Aclass();
// Aclass.hello("Yass");
// x.test();