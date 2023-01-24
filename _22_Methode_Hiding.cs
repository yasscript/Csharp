namespace _22_Methode_Hiding
{
    class Employee 
    {
        public string _Fname;
        public string _Lname;
        public int _age ;


        public Employee(string Fname,string Lname, int age)
        {
            this._Fname = Fname;
            this._Lname = Lname;
            this._age = age;
        }

        public void printFullName()
        {
            Console.WriteLine(this._Fname + " " + this._Lname);
        }

        public string displayEmployee()
        {
            return ("Nom: " + this._Fname + ", Prenom: " + this._Lname + ", Age: this._age");
        }
    }

    class Ouvrier : Employee
    {
        public int _anciennete;

        public Ouvrier(int anciennete, string Fname,string Lname, int age) : base(Fname, Lname, age)
        {
            this._anciennete = anciennete;
        }

        public new string displayEmployee()
        {
            return base.displayEmployee() + " Anciennete: " + this._anciennete; 
        }
    }

    class Secretaire : Employee
    {
        public string _departement;
        public Secretaire(string departement, string Fname,string Lname, int age) : base(Fname, Lname, age)
        {
            this._departement = departement;
            
        }
        public new string displayEmployee()
        {
            return base.displayEmployee() + " Deparetement: " + this._departement; 
        }

    }

}

// using _22_Methode_Hiding;
// Ouvrier o = new Ouvrier(8,"Yass","Echi", 22);
// Console.WriteLine(o.displayEmployee());
// Secretaire s = new Secretaire("Comptabilité", "Sophie", "Dupont", 33);
// Console.WriteLine(s.displayEmployee());

// Pour viser les composant du parent a partir du child 
    // - keyword base 
    // - cast en partent
    // - creer a partir du parent