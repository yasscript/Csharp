namespace _51_Acces_Modifiers_Types
{
    class One 
    {
        public static void print()
        {

        }
    }
    
}

// Supposant que j ai un autre projet dans ce name space 
namespace AutreProjet
{
    /* lors de la creation de ce projet il y a un fichier assemby qui s est creer dans 
    le dossier reference avec l exentension .dll .. ou .exe pour une appli console .
    ce fichier est ce lui qui englobe ce que le projet peut voir.
        
        - si la class est public dans l autre projet et qui j ai ajouter ce projet comme reference 
        un petit "Using project" et je peux utilser cerre classe.

        - si la class est internal, la class n est utilsable que dans le projet qui la contient meme 
            si j on ajoute ce projet comme reference danns un autre projet. 

        - les Types class delegate struc enum ne peuvent etre que public ou internal

        - Un element Type sans access modifiers est par defaut publique 

        - un element type memebers sans acces modifiers est par defaut private 

         
    */ 
}

// using _51_Acces_Modifiers_Types;
// One.print();