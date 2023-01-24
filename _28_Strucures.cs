using System.Globalization;
namespace _28_Strucures
{

    /*

    */

    public struct Etudiant
    {
        private string _name;
        private int _age;
        private string? _email;

        public Etudiant(string name, int age, string email)
        {
            _name = name;
            _age = age;
            _email = email;
            
        }
        public int age
        {
            set{_age = value;}
            get{ return this._age;}
        }

        public string email
        {
            set{_email = value;}
            get{ 
                if(string.IsNullOrEmpty(this._email)){
                    return "No email";
                }
                return this._email;}
        }

        public string name
        {
            set{_name = value;}
            get{
                if(string.IsNullOrEmpty(this._name)){
                    return "No name";
                }
                return this._name;}
        }

        public void displayEtudiant()
        {
            Console.WriteLine("Nom: {0}, Age: {1}, Email: {2}", name, age, email );
        }
    } 

}

// using _28_Strucures;
// /*
//     les 3 manieres de faire une initialisation :
// */

// // -1
// Etudiant e1 = new Etudiant();
// e1.name = "yass";
// e1.age = 22;
// e1.email = "yass@gmail.com";

// // -2
// Etudiant e2 = new Etudiant("alex", 33,"alex@hmail.com" );

// // -3 
// Etudiant e3 = new Etudiant{
//     name = "Max",
//     age = 44,
//     email = "Max@gmail.com"
// };

// e1.displayEtudiant();
// e2.displayEtudiant();
// e3.displayEtudiant();


