namespace _7_Conversions
{
    /**
    Implicit conversions
    Explicit conversions
    Difference entre Parse et Parsetry
    **/
    class A 
    {
        public void conversion()
        {
            //True
            /**
                Implicit convesrion => Quand? : 
                    -> fait par le compilator
                    - Quand il y a pas probabilité d une exception
                    - small in big dataType
            **/
            int i = 100;
            float f = i;
            Console.WriteLine("int to float implicit => " + f);

            // //False
            /**
                difference entre le cast et le convert :
                = exception au cas ou il arrive pas souvent la taille 
            **/
            // float ff = 123.45F;
            // int ii = ff;
            // Console.WriteLine(ii);
            
            //True
            float ff = 123.45F;
            int ii = (int)ff;

            float fff = 22.55F;
            int iii = Convert.ToInt32(fff);

            string strNum = "123";
            int Num = int.Parse(strNum);

            //TryPas return bool succes 2 param in && out
            string TNum2 = "123ABC";
            int ret = 0;
            bool succes = int.TryParse(TNum2, out ret);

            Console.WriteLine("cast => " + ii);
            Console.WriteLine("Convert => " + iii);
            Console.WriteLine("Parse str => " + Num);
            Console.WriteLine("TryParse str => {0} succes: {1}",ret, succes);  
        }
    }
}
// using _7_Conversions;
// _7_Conversions.A A = new _7_Conversions.A();

// A.conversion();
