namespace _62_Partial_Class_Creating
{
    /*
        Les Rules a respecter dans la creation d une class partial :
            - keyword partial dans toutes les parties 
            - Le Acces modifiers dans les 2 partie "Public ou Internal"
            - si je declare qu une partie est abstracte l autre l est aussi par defaut
            - si une seald l autre l est aussi  seald = ne fait hériter personne
            - les deux parties ne peuvent pas avoir un multible heriatge de plusieur class
            - parcontre les pltuple class peuve heriter de plusieur interfaces
            

    */
    class A 
    {
        public static void main()
        {

        }
    }
}
// using _62_Partial_Class_Creating;
// A.main(); 