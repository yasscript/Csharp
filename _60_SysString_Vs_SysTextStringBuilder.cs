namespace _60_SysString_Vs_SysTextStringBuilder
{
    using System.Text;  
    class A 
    {
        public static void main()
        {
            /*
                string appartient au namespace String dans le namespace System
                a chaque fois qu on fait une concaténation il cree un nouveau object "string"
                 avec les 2 valeur et ainsi de suite on se trouve avec plusieur objets dans la RAM ! 
            */
            string str = "Bienvenue";
            str += " à";
            str += " l'ecole";
            str += " promotion";
            str += " social";
            str += " de marche";
            str += " en famenne";

            Console.WriteLine(str);

            /*
                String builder dans System.text 
                Lui il change dans le meme string
                gain de performance
            */

            StringBuilder str2 = new StringBuilder("Bienvenue");
            str2.Append(" à");
            str2.Append(" l'ecole");
            str2.Append(" promotion");
            str2.Append(" social");
            str2.Append(" de marche");
            str2.Append(" en famenne");

            Console.WriteLine(str2);


            // //Exemple pratique

            //PAS BON = 1000 string dans la RAM
            // string str3 = string.Empty;
            // for(int i=0;i<1000;i++) {
            //     str3 += i.ToString() + " ";
            // }
            // Console.WriteLine(str3);

            // BON = 1 objet dans la RAM
            StringBuilder str4 = new StringBuilder("");
            for(int i=0;i<1000;i++) {
                str4.Append(i.ToString() + " ");
            }
            Console.WriteLine(str4);

        }
    }
}

// using _60_SysString_Vs_SysTextStringBuilder;
// A.main();