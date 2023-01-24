using System;
namespace _9_Comments
{
    /**
    Single line comments
    Multi line comments
    introduction to XML
    **/
    class A 
    {
        public void comments()
        {
            // Single line => //
            // Multu line => /* */
            // XML docmentation Comments => ///

            Console.WriteLine("Hello 1");
        
            /*
            Console.WriteLine("Hello 2");
            Console.WriteLine("Hello 2");
            Console.WriteLine("Hello 2");
            */
        }
    }
 
    /// <summary>
    /// class de test de la docmentation XML
    /// </summary>
    class X 
    {
        public string name = "yass";
    }
}

// using _9_Comments;
// _9_Comments.A A = new _9_Comments.A();
// A.comments();

// //OK class Commantée
// _9_Comments.X X = new _9_Comments.X();