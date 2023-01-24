namespace _48_Types_Vs_TypeMembers
{
    /*
        En gros Les types c est tt les class structx enmus interface 
        et les Type memebers c esr ce qui dedons 

        Les acces modifiers pour les Type members:
            - Private
            - Protected
            - Internal
            - Protected Internal
            - Public
        
        Les acces modifiers pour les Type :
            - Public 
            - Internal

        =======

        On peut ségumenter le code avec des paragraphes avec #region
            une flech apparait pour collapser le paragraph et le show
    */


    class Client
    {
        #region Attributs
        public int _id;
        public string? _name;
        public int _age;
        #endregion

        #region encapsulation
        public int id
        {
            set{this._id = value;}
            get{return this._id;}
        }
        public string name
        {
            set{this._name = value;}
            get{
                if(string.IsNullOrEmpty(this._name)){
                    return "No name";
                }
                return this._name;}
        }
        public int age
        {
            set{this._age = value;}
            get{return this._age;}
        }
        #endregion

        #region Methodes
        public void displayClient()
        {
            Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", id, name, age);
        }
        #endregion

    }
}

// using _48_Types_Vs_TypeMembers;
// Client c = new Client {
//     id = 1,
//     name = "yass",
//     age = 38
// };
// c.displayClient();