namespace _23_Virtual_Polymorphism
{
    /*
    Overrinding virtiual methods
     !!! Polymorphism = appel de methode des childs a partir de du parent !!!
    */
    class Employee
    {
        public string _Fname;
        public string _Lname;

        public Employee(string Fname, string Lname)
        {
            this._Fname = Fname;
            this._Lname = Lname;
        }

        public Employee()
        {
             this._Fname = "FN";
            this._Lname = "LN";
        }

        public virtual string printFullName()
        {
            return this._Fname + " " + this._Lname;
        }

        static int i = 1; 
        public static void displayEmployeeS(Employee[] Empls)
        {
            foreach(Employee x in Empls){
                Console.WriteLine("Employee n° {0} => {1}", i, x.printFullName());
                i++;
            }
        }
    }

    class Ouvrier : Employee
    {
        public override string printFullName()
        {
            return base.printFullName() + " Ouvrier";
            // return base.printFullName();
        }
        // public string printFullName()
        // {
        //     return this._Fname + " " + this._Lname + " Ouvrier";
        // }

    }

    class Secretaire : Employee
    {
        public override string printFullName()
        {
            return base.printFullName() + " Secretaire";
            // return base.printFullName();
        }

        // public string printFullName()
        // {
        //     return this._Fname + " " + this._Lname + " Secretaire";
        // }

    }

    class Temporaire : Employee
    {
        public override string printFullName()
        {
            return base.printFullName() + " Tomporaire";
            // return base.printFullName();
        }
        // public string printFullName()
        // {
        //     return this._Fname + " " + this._Lname + " Tomporaire";
        // }

    }


}

// using _23_Virtual_Polymorphism;

// Employee e = new Employee();
// Console.WriteLine(e.printFullName());

// Employee[] Templ = new Employee[4];
// Templ[0] = new Employee(); 
// Templ[1] = new Ouvrier(); 
// Templ[2] = new Secretaire(); 
// Templ[3] = new Temporaire(); 

// Employee.displayEmployeeS(Templ);