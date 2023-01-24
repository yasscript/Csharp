namespace _18_NameSpace
{
    namespace AA
    {
        class A 
        {
            public static void nameSpacee()
            {
                Console.WriteLine("Je suis la Team AA");
            }
        }

    }

    namespace BB
    {
        class A 
        {
            public static void nameSpacee()
            {
                Console.WriteLine("Je suis la Team BB");

            }
        }

    }
    
}
// using _18_NameSpace;
// using NAA = _18_NameSpace.AA; //Alias
// using NBB = _18_NameSpace.BB;

// using _18_NameSpace.AA;
// // using _18_NameSpace.BB;
// A.nameSpacee();
// // A.nameSpacee(); Ambiguité

// //Alias
// NAA.A.nameSpacee();
// NBB.A.nameSpacee();

// //Name space doit etre déclaré AA
// // AA.A.nameSpacee();

// //Entier
// _18_NameSpace.AA.A.nameSpacee();
// _18_NameSpace.BB.A.nameSpacee();
