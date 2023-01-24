using System;
namespace _19_IntroductionClass
{
    class Client
    {
        private string? _Fname;
        private string? _Lname;
        private int _age;

        public int getAge()
        {
            return this._age;
        }

        public void setAge(int age)
        {
            this._age = age;
        }

        public Client(string Fname, string _Lname, int age)
        {
            this._Fname = Fname;
            this._Lname = _Lname;
            this._age = age;
        }

        public Client(): this("New","New", 0){} //OK

        // public Client(){} //OK

        //Distructeur
        ~Client(){}

        public static void displayClient(Client C)
        {
            Console.WriteLine("Nom: {0}, Prenom: {1}, Age: {2}", C._Fname, C._Lname, C._age);
        }

        public static void displayClientS(Client[] TabClt)
        {
            foreach(Client x in TabClt){
                Client.displayClient(x);
            }
        }
    }
}

// using _19_IntroductionClass;

// Client[] TabClient = new Client[3];
// TabClient[0] = new Client("yass","echi",22);
// TabClient[1] = new Client("max","dupont",33);
// TabClient[2] = new Client("alex","albert",44);

// TabClient[0].setAge(77);


// Console.WriteLine(" === Display One Client ===");
// Client.displayClient(TabClient[0]);

// Console.WriteLine("\n === Display All Client ===");
// Client.displayClientS(TabClient);

// Console.WriteLine("\n === Display One Client Const+this ===");
// Client C1 = new Client();
// Client.displayClient(C1);