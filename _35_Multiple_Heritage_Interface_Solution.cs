namespace _35_Multiple_Heritage_Interface_Solution
{


     interface IntA 
    {
        void Aprint();
    }
    class A : IntA 
    {
        public void Aprint()
        {
            Console.WriteLine("Class A method print");
        }
    }

    interface IntB
    {
        void Bprint();
    }
    class B : IntB
    {
        public void Bprint()
        {
            Console.WriteLine("Class B method print");
        }
    }

    class AB : IntA, IntB //A, B
    {
        A a = new A();
        B b = new B();

        public void Aprint(){
            a.Aprint();
        }

        public void Bprint(){
            b.Bprint();
        }
        
    }



    //Test==================================================================

    class Personne : InCode, InMajor
    {
        public int id{set; get;}
        public string? name{set; get;}
        public int age{set; get;}
        private string? _ville;
        public string ville
        {
            set{_ville = value;}
            get
            {
                if(string.IsNullOrEmpty(this._ville)){
                    return "No ville";
                }
                return this._ville;
            }
        }

        public Personne(int id, string name, int age, string ville)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.ville = ville;
        }

        Major m = new Major();
        CodePostal c = new CodePostal();

        public bool isMajor(int age) {
            return m.isMajor(age);
        }

        public int switchVille(string ville) {
            return c.switchVille(ville);
        }
        
        public void displayPersonne()
        {
            Console.WriteLine("ID: {0}, Name: {1}, Age: {2}, Ville: {3}, isMajor: {4}, CodePostal: {5}"
            , id,name,age,ville, this.isMajor(this.age), this.switchVille(this.ville));
        }
    }

    interface InMajor
    {   
        bool isMajor(int age);
    }
    class Major : InMajor
    {
        public bool isMajor(int age)
        {
            if (age > 18) {
                return true;
            }
            return false;
        }
    }

    interface InCode 
    {
        int switchVille(string ville);
    }
    class CodePostal : InCode
    {
        public int switchVille(string ville)
        {
            switch(ville.ToLower()) {
                case "bastogne" : return 6600;
                case "liege" : return 4000;
                case "bruxelle" : return 1000;
                default: return -1; 
            }
        }
    }
}

// using _35_Multiple_Heritage_Interface_Solution;

// AB ab = new AB();
// ab.Aprint();
// ab.Bprint();

// Console.WriteLine();
// Personne p = new Personne(111,"yass", 22, "liege");
// Console.WriteLine("11 is major? : " + p.isMajor(11));
// Console.WriteLine("Ville: Bastogne => code: {0} ", p.switchVille("Bastogne"));
// p.displayPersonne();