// using System.Reflection;
// using System.Net.Sockets;
// using System.Collections.Generic;
// namespace _53_Reflection
// {
//     /*
//         Reflection = recuperation des metadata du fichier assembly avec la classe Type
//         Type T = t.getType("nameSpace.emelement");
//         T.properties
//         T.getFunction()
//     */

//     class Client
//     {
//         public static void main()
//         {
//             Chat ch = new Chat();
//             ch.name = "Phenix";
//             ch.print();

//             Type? T = Type.GetType("_53_Reflection.Chat");

//             Console.WriteLine("Full name => {0}", T.FullName);
//             Console.WriteLine("Type name => {0}", T.Name);
//             Console.WriteLine("Type nameSpace => {0}", T.Namespace);
//             Console.WriteLine("Type Module => {0}", T.Module);
//             Console.WriteLine("Type IsVisible => {0}", T.IsVisible);
//             Console.WriteLine("Type IsPublic => {0}", T.IsPublic);

//             Console.WriteLine();
            
//             PropertyInfo[] TProper =  T.GetProperties();
//             foreach(PropertyInfo x in TProper)
//             {
//                 Console.WriteLine("Property de chat => {0}", x );
//             }
//             Console.WriteLine();

//             ConstructorInfo[] TM = T.GetConstructors();
//             foreach(ConstructorInfo x in TM)
//             {
//                 Console.WriteLine("Constructeur de chat => {0}", x );
//             } 
//             Console.WriteLine();

//             MemberInfo[] TMembers = T.GetMembers();
//             foreach(MemberInfo x in TMembers)
//             {
//                 Console.WriteLine("Members de Chat => {0}", x);
//             }
//             Console.WriteLine();

//             MethodInfo[] TMethodes = T.GetMethods();
//             foreach(MethodInfo x in TMethodes)
//             {
//                 Console.WriteLine("Methodes de Chat => {0}", x);
//             }
//             Console.WriteLine();

//         }
        
//     }

//     public class Chat 
//     {
//         private int _id;
//         private int _age;
//         private string? _name;

//         public Chat(){}
//         public Chat(int id, int age, int name){}
//         public Chat(string message){}

//         public int id
//         {
//             set{this._id = value;}
//             get{return this._id;}
//         }
//         public int age
//         {
//             set{this._age = value;}
//             get{return this._age;}
//         }
//         public string name
//         {
//             set{this._name = value;}
//             get{
//                 if(string.IsNullOrEmpty(this._name)){
//                     return "No name";
//                 }
//                 return this._name;
//                 }
//         }

//         public void print(){ Console.WriteLine("Name: {0}", name);}

//     }

// }

// // using _53_Reflection;
// // Client.main();