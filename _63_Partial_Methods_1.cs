namespace _63_Partial_Methods_1
{
    class AA
    {
        /*
            - Les partial methodes ne peuvent etre que dans les partial methods ou structures
            - pareil partial keyword
            - 
        */
        
        
        public static void main()
        {
            Client c = new Client{
                Fname = "Michael",
                Lname = "Jackson"
            };

            c.printFullName();
            
        }
    }

    partial class Client
    {
        public string? Lname{set; get;}
        public string? Fname{set; get;}

        // la methode partielle a été declaré dansune partie de ma class partial
        // L'implémentaion de la method elle est faite dans l autre partie de la class
        partial void partialMethod();

        // je peux faire l implementation de la method dans le meme file aussi
        // La partial method est private par defaut => pas d access modifiers
        // la partial method est toujours une void !!
        // la partial method ne peux exister que dans une partial class ou partial structure
        // je neux pas avoir qu une implementation de la methode dans une partie de la class partial
    }
}

// using _63_Partial_Methods_1;
// AA.main();