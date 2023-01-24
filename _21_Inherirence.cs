namespace _21_Inherirence
{
    /*
        - pas de multiple heritage
        - multibale level inheritance  
    */
    class Mamifere
    {
        public string? _name;
        public int _age;

        public Mamifere()
        {
            Console.WriteLine("Constructeur Mamifere Vierge");
        }

        public Mamifere(string name, int age)
        {
            this._name = name;
            this._age = age;   
            Console.WriteLine("Constructeur Mamifere Parametres"); 
        }


        public void mange()
        {
            Console.WriteLine("mamiferes mangent banane ");
        }

        public void displayMam()
        {
            Console.WriteLine("Name: {0}, Age {1}",_name, _age);
        }
    }

    class Chien : Mamifere
    {
        public int _vitesseHeure;

        public Chien(int vitesseHeure, string name, int age) : base(name,age) //Choisir le constructeur PARENT /////////////////
        {
            this._vitesseHeure = vitesseHeure;
            Console.WriteLine("Constructeur Chien");
        }
        public new void mange()
        {
            Console.WriteLine("Les chiens mangent de la viande ");
        }


    }

    class Chat : Mamifere
    {
        // public float longuerPoile;

        public Chat()
        {
            Console.WriteLine("Constructeur Chat");
        }
        public new void mange()
        {
            Console.WriteLine("Les chats boient du lait ");
        }

    }
}

// using _21_Inherirence;

// // Mamifere m = new Mamifere();
// // m._name = "Rex";
// // m._age = 22;
// // m.displayMam();

// Chien c = new Chien(333,"uuu",11);
// // c._name = "lala";
// // c._age = 33;
// // c.vitesseHeure = 44;
// c.displayMam();
// c.mange();