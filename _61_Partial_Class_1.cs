namespace _61_Partial_Class_1
{
    /*
        Partial Class = ecrire ou deviser une class dans plusieur files
         et le compilateur s en charge de la regrouper et la compiler

         Avantage ++ On peut segumenter la class de sorte a ce qu on specialise des parties 
         de la class au methodes ou au dsignes dans les class web par exemple et d autre parties 
         pour le back-end
    */
    class A 
    {
        public static void main()
        {
            Client c = new Client{
                Fname = "Bob",
                Lname = "Marley"
            };

            Console.WriteLine( c.FullName() );

            /*
                La partie des attributs et les getteurs sont dans un fichier
                et la methode FullName est dans autre 
                et avec le KeyWord "partial" le compilateur regroupe les 2 fichiers
                et je peux utilser ma methode avec mes les autres composants de ma class 
            */
            
        }
    }

    public partial class Client 
    {
        //// Premiere partie de ma class Client
        private string? _Fname;
        private string? _Lname;

        public string Fname
        {
            set{this._Fname = value;}
            get
            {
                if(string.IsNullOrEmpty(_Fname)){
                    return "No Fname";
                }
                return this._Fname;
            }
        }
    }
}

// using System.Threading;
// using System.Reflection;
// using _61_Partial_Class_1;
// A.main();