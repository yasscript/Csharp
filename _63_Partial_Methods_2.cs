namespace _63_Partial_Methods_1
{

    partial class Client
    {
        public void printFullName()
        {
            Console.WriteLine(" {0} {1} ", Fname, Lname);

            //Appel de la class partial
            partialMethod();
        } 

        // ipmlementation de la method qui a ete declarée dans la l autre partie de la class
        partial void partialMethod()
        {
            Console.WriteLine("La methode partial a été invokée !!");
        }
    }
}