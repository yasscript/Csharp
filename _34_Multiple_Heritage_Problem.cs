namespace _34_Multiple_Heritage_Problem
{
    /*
        - C# ne permet pas le multiple heritage direct
        - Mais autorise le multiple level heritage
        On va voir le pk?

    */

    class A 
    {
        public virtual void print()
        {
            Console.WriteLine("Class A method print() implementation");
        }
    }

    class B : A
    {
        public override void print()
        {
            Console.WriteLine("Class B method print() implementation");
            // base.print();
        }
    }

    class C : A 
    {
        public override void print()
        {
            Console.WriteLine("Class C method print() implementation");
            // base.print();
        }
    }

    class D : B //,C
    {
        // Donc si c# le permettait D heritera de print() de B et de C  
        /*
            D d = new D();
            d.print();

            ambiguité dans l origine de la methode print() dans
            est ce que c est celle de B ou de C ?
            "Diamon problem"
        */
    }
    
}
