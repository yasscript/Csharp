namespace _6_Nullable
{
    /**
    Value Types => int float double struct ..
    Value Types = default value 0 
    non nullable => use ? pour le rendre nullable => pour la DB et le web par exemple !
    **/

    /**
    Reference Type = Interface Class delegetes arrays "String"
    Reference Type = default value null
    **/

    class A 
    {
        // public int? a;

        // public Array? Tab;

        public void obliga()
        {
            Console.WriteLine("First name: ");

            // Coalesing Operator ??
            // string xx =  Console.ReadLine(); 
            // string? yy = xx == "" ? null:xx; 
            // string FN = yy ?? "null";

            string? FN = Console.ReadLine() == "" ? "null" : Console.ReadLine() ;
            Console.WriteLine("Last name: ");
            string? LN = Console.ReadLine() == "" ? "null" : Console.ReadLine() ;
            Console.WriteLine("Major?: ");
            string? GN = Console.ReadLine();
            // bool? bGN = GN=="true" ? true: GN=="false" ? false: GN=="null"?null:null; 
            string? bGN = GN=="" ? "null": GN=="true" ? "true": GN=="false"?"false":"null"; 
            Console.WriteLine("Bonjour Mr {0} {1} {2}", FN, LN, bGN);
        }
        
    }
}
// using _6_Nullable;

// _6_Nullable.A A = new _6_Nullable.A();
// // Console.WriteLine(A.a); // value 0
// // Console.WriteLine(A.Tab); // value null affiche rien
// A.obliga();