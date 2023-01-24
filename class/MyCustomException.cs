
using System;
using System.Runtime.Serialization; 

/*
    Pk j ai besoin du custon exception ?
        - Quand les exception natives ne decrient pas la problemme ..
    
*/

[Serializable]
// on herite de la class Exception
class MyCostumException : Exception
{


    // on a besoin de recreer le constructeur de base 
    public MyCostumException(){}



    // on creer un nouveau constructeur parametre: message 
    // on passe ce parametre a la classe parrent que elle se charge de lui donner format exception
    public MyCostumException(string message) : base(message)
    {

    }

    //Constructeur qui accept l inner exception
    public MyCostumException(string message, Exception InnerException) : base(message, InnerException)
    {

    }

    // pas vraiment compris ce lui
    // l idde est que je passe cette objet sérialisé a une autre application ..
    public MyCostumException(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}
