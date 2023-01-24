namespace _61_Partial_Class_1
{
    public  partial class Client
    {
        //// Deusieme partie de ma class Client

        public string Lname
        {
            set{this._Lname = value;}
            get
            {
                if(string.IsNullOrEmpty(_Lname)){
                    return "No Fname";
                }
                return this._Lname;
            }
        }

        public string FullName()
        {
            return _Fname + " " + _Lname;
        }

    }
}