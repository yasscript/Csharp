namespace _37_38_Delegate_Usage
{
    /*
        Le dlegate sert a rendre une function plus dynamique et plus lisible
        dans notre cas notre function avais une logique statique c a d ellle 
        nous rendait les employees avec une experience de plus= 5 ans 

        avec le delegate on peut pointer sur d autre fonction avec une autre logique 
        par exemple salaire, age,, et il suffi de passer le delegate a la function 
        pour faire le tri
    */

    class Employee 
    {
        public int id{set; get;}
        public string? name{set; get;}
        public double salaire{set; get;}
        public int experience{set; get;}
        public static List<Employee> TabEmp{set; get;}

        static Employee()
        {
            Console.WriteLine("Initialisation du Tableau des employees !!");
            TabEmp =  new List<Employee>();
        }

        public Employee(int id, string name, double salaire, int experience)
        {
            this.id = id;
            this.name = name;
            this.salaire = salaire;
            this.experience = experience;
        }
        public Employee(){}

        public override string ToString()
        {
            return "Id: " + id + "\tName: " + name + "\tSalaire: " + salaire + "  \tExperience: " + experience;
        }

        public void promotion()
        {
            if (this.experience >= 5) {
                this.salaire+=100;
            }
        }

        public static void promotionEmpS()
        {
            foreach(Employee x in TabEmp)
            {
                x.promotion();
            }
        }

        public static void displayEmpS()
        {
            foreach(Employee x in TabEmp)
            {
                Console.WriteLine(x.ToString());
            }
        }

        public static void displayPrmotedEmpS()
        {
            foreach(Employee x in TabEmp)
            {
                if (x.experience >= 5) {
                    Console.WriteLine(x.ToString());
                }
            }
        }

        // ======================================================
        
        public delegate bool DelegatePromered(Employee em);

        public static bool isExperience(Employee em)
        {
            if (em.experience >= 5) {
                return true;
            }
            return false;
        }

        public static void displayPrmotedEmpS_2(DelegatePromered del)
        {
            foreach(Employee x in TabEmp)
            {
                if (del(x)) {
                    Console.WriteLine(x.ToString());
                }
            }
        }
        // ======================================================

        // ======================================================
        public static bool isSalaire1000(Employee em)
        {
            if ( em.salaire >= 1000 ) {
                return true;
            }
            return false;
        }

        
    }

}

// using _37_38_Delegate_Usage;

// Employee.TabEmp.Add(new Employee(1,"Yass", 1200.5, 7));
// Employee.TabEmp.Add(new Employee(2,"Max", 4050.75, 2));
// Employee.TabEmp.Add(new Employee(3,"Lise", 900.55, 4));
// Employee.TabEmp.Add(new Employee(4,"Zoro", 770.5, 9));

// //Avant promotion
// Employee.displayEmpS();

// Console.WriteLine("\nList Add XXX =====");
// Employee.TabEmp.Add(new Employee(5,"XXX", 999.55, 11));
// Employee.displayEmpS();

// Console.WriteLine("\nEmployees a promouvoir =====");
// Employee.displayPrmotedEmpS();

// Console.WriteLine("\nApres Promotion >= 5 ans =====");
// //Apres promotion
// Employee.promotionEmpS();
// Employee.displayEmpS();

// Console.WriteLine("\nEmplpyé a promouvoir avec delegate Experience >= 5=====");
// //Le delegate peut s appeler en static !!
// Employee.DelegatePromered delPromoted = new Employee.DelegatePromered(Employee.isExperience);  
// Employee.displayPrmotedEmpS_2(delPromoted);

// Console.WriteLine("\nEmplpyé a promouvoir avec delegate Salaire >=1000 =====");
// Employee.DelegatePromered del1000Salaire = new Employee.DelegatePromered(Employee.isSalaire1000);  
// Employee.displayPrmotedEmpS_2(del1000Salaire);