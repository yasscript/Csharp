namespace _33_Abstract_Vs_Interface
{
    /*
        - les deux sont des class incompletes
        - les deux je ne peux creer des objects d eux
        - les deux obligent la class enfant d heriter d eux

        Abstract
            - je peux implementer les methodes dans l abstarct
            - pas d attributs
            - herite d une autre abstract class ou une interface 


        Interface
            - interface les methodes ne sont que des promesses c un contrat
            - pas de acces "public private .." elle est par defaut public
            - peux avoir des attributs
            - L'interface n herite que d une autre interface 

    */


    abstract class AbClass1 : AbClass2, Int1
    {
        public abstract void MethodAbClass1();
        public virtual void MethodInt1(){ Console.WriteLine("MethodInt1"); }
        public virtual void MethodInt2(){ Console.WriteLine("MethodInt2"); }

    }
     abstract class AbClass2
    {
        public abstract void MethodAbClass2();
        
    }

    public interface Int1 : Int2
    {
        void MethodInt1();
    }

    public interface Int2 
    {
        void MethodInt2();
    }

    class Test : AbClass1
    {
        // Toutes ces Methodes sont obligatoires si la class Test herite de AbClass1

        //Obliger de les overrider parce que ce sont  des methodes abstracts dans les classes abstracts
        public override void MethodAbClass1(){Console.WriteLine("MethodAbClass1");}
        public override void MethodAbClass2(){Console.WriteLine("MethodAbClass2");}
       
        // Ils sont virtual
        // public override void MethodInt1(){}
        // public override void MethodInt2(){}

    }

}

// using _33_Abstract_Vs_Interface;
// Test T = new Test();
// T.MethodAbClass1();
// T.MethodAbClass2();
// T.MethodInt1();
// T.MethodInt2();