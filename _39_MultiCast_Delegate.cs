namespace _39_MultiCast_Delegate
{
    /*
        Le MultiCast Delegarte est un pointeur sur plusieur functions
        une fois appeler il lance toutes ces functions 

        Ou est ce que je peut utilser le multicast Delegate ?
            Observer design pattern (qu on va voir)
    */

    class Client
    {
        public delegate void MulticastDelegate();

        public static void methode_1()
        {
            Console.WriteLine( "==> Method_1");
        }
        public static void methode_2()
        {
            Console.WriteLine( "==> Method_2");
        }
        public static void methode_3()
        {
            Console.WriteLine( "==> Method_3");
        }


        //======================================

        public delegate int DelReturn();

        public static int Mreturn1(){return 1;} 
        public static int Mreturn2(){return 2;} 
        public static int Mreturn3(){return 3;} 

        //======================================

        public delegate void DelegOutPut(out int a);

        public static void Mout1(out int a){a = 2;}
        public static void Mout2(out int a){a = 4;}
        public static void Mout3(out int a){a = 6;}

    }

}

// using _39_MultiCast_Delegate;

// Client.MulticastDelegate mltdel1, mltdel2, mltdel3, mltdel4; 
// mltdel1 = new Client.MulticastDelegate(Client.methode_1);
// mltdel2 = new Client.MulticastDelegate(Client.methode_2);
// mltdel3 = new Client.MulticastDelegate(Client.methode_3);

// mltdel1();
// mltdel2();
// mltdel3();

// Console.WriteLine("\n===========\n");
// mltdel4 = mltdel1 + mltdel2 + mltdel3;
// // mltdel4 = mltdel1 + mltdel2 - mltdel3;
// mltdel4();


// Console.WriteLine("\n===========\n");
// Client.MulticastDelegate mltdel_ = new Client.MulticastDelegate(Client.methode_1);
// mltdel_ += Client.methode_2;
// mltdel_ += Client.methode_3;
// mltdel_();

// Console.WriteLine("\n##########################################\n");

// Client.DelReturn delReturn = new Client.DelReturn(Client.Mreturn1);
// delReturn += Client.Mreturn2;
// delReturn += Client.Mreturn3;
// Console.WriteLine("Affiche le retour (derniere methode) => " + delReturn());

// int a = 0;
// Client.DelegOutPut delOut = new Client.DelegOutPut(Client.Mout1);
// delOut += Client.Mout2;
// delOut += Client.Mout3;

// delOut(out a);
// Console.WriteLine("valeur de l\'output (derniere methode) => " + a);
