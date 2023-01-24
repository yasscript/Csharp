using System.Net.WebSockets;
using System.Threading;
namespace _47_Enums_Suite
{
    /*
        Conceptes Enums:
            - pk? j ai besoins des Enums
            - Exemple pratique des Enums 
    */


    class Voiture
    {
        public int id{set;get;}
        public string? marque{set;get;}
        public Couleur couleur{set;get;}

        public Voiture(){}
        // public Voiture(int id, string marque, string couleur)
        // {
        //     this.id = id;
        //     this.marque = marque;
        //     this.couleur = getCouleur(couleur);
        // }
        public Voiture(int id, string marque, Couleur couleur)
        {
            this.id = id;
            this.marque = marque;
            this.couleur = couleur;
        }

        public enum Couleur // : short je peut changer le type de l Enum par dafault "int"
        {
            rouge, // = 10 je peux changer le debut  
            jaune, // = 33 je peux changer la value pour chaqye 
            noire,
            blanche,
            indefini
        }

        public static void main()
        {
            //Constructeur avec string
            // Voiture v = new Voiture(1,"mercedes", "noire");
            // Voiture.displayVoiture(v);

            //Constructeur avec Enum
            Voiture v2 = new Voiture(1,"mercedes", Couleur.rouge);
            Voiture.displayVoiture(v2);
            
            // Console.WriteLine();
            // int[] Tvalures = (int[])Enum.GetValues(typeof(Couleur));
            // for(int i=0; i < Tvalures.Length ;i++){
            //     Console.Write("{0} ", Tvalures[i]);
            // }
            // Console.WriteLine();

            // string[] Tnames = (string[])Enum.GetNames(typeof(Couleur));
            // for(int i=0; i < Tvalures.Length ;i++){
            //     Console.Write("{0} ", Tnames[i]);
            // }
            // Console.WriteLine();

            /* 
                On sait mnt que la value des Enums est un int
                mais est ce que je peux stauquer un int dans Enums ?
                    Couleur couleur = 4; // Faux
                    Couleur couleur = (Couleur)4; //Vrai
                    int number = (int)Couleur.noire; //Vrai 

            */

        }
        public static Couleur getCouleur( string coul)
        {
            string[] Tnames = (string[])Enum.GetNames(typeof(Couleur));
            switch(coul.ToLower())
            {
                case "rouge" : return Couleur.rouge ; 
                case "jaune" : return Couleur.jaune; 
                case "noire" : return Couleur.noire; 
                case "blanche" : return Couleur.blanche; 
                default : return Couleur.indefini; 
            }
        }

        public static void displayVoiture(Voiture v)
        {
            Console.WriteLine("ID: {0},  Marque: {1}, Couleur: {2}", v.id, v.marque, Enum.GetName(typeof(Couleur), v.couleur));
        }
    }
}

// using _47_Enums_Suite;
// Voiture.main();