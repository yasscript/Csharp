namespace _23_Virtual_Polymorphism
{
    /*
        Qui pointe sur quoi 
        si creation avec baseClass Virtual + ovveride => polymorphism
        si creation avec DriveClass new Methode => hidding
    */
    class BaseClass
    {
        public virtual void print()
        {
            Console.WriteLine("je suis la class Base print Mth");
        }
    }

    class DriveClass : BaseClass
    {

        public override void print()
        {
            Console.WriteLine("je suis la class drive print Mth");
            // base.print();
        }

        //  public  new void print()
        // {
        //     Console.WriteLine("je suis la class drive print Mth");
        // }

    }

}

// using _23_Virtual_Polymorphism;
// BaseClass bc = new DriveClass();
// bc.print();