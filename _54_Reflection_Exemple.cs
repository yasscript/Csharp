// namespace _54_Reflection_Exemple
// {
//     using System.Reflection;

//     class Client 
//     {
//         public static void main()
//         {
//             Console.WriteLine("## Reflection sur un element # \nEntrez le nom de l'element: ");
//             string? element = Console.ReadLine();

//             try
//             {
                
//                 Type? T = Type.GetType("_54_Reflection_Exemple." + element);
//                 int i = 1;
//                 // Properties 
//                 PropertyInfo[] TP = T.GetProperties();
//                 foreach(PropertyInfo x in TP){
//                     Console.WriteLine(" Ptoperty {0} : {1}",i, x);
//                     i++;
//                 }
//                 i=1;

//                 Console.WriteLine();
//                 // Constructeurs 
//                 ConstructorInfo[] TC = T.GetConstructors();
//                 foreach(ConstructorInfo x in TC){
//                     Console.WriteLine(" Construtor {0} : {1}",i, x);
//                     i++;
//                 }
//                 i=1;

//                 Console.WriteLine();
//                 // Methodes 
//                 MethodInfo[] TM = T.GetMethods();
//                 foreach(MethodInfo x in TM){
//                     Console.WriteLine(" Methodes {0} : {1}",i, x);
//                     i++;
//                 }
//             }
//             catch (System.NullReferenceException)
//             {
//                 Console.WriteLine("L'element n'existe pas ..");
//             } 
//             catch (System.Exception ex)
//             {
//                 Console.WriteLine(ex.GetType());
//             }  
//         }
//     }

//     class Chat
//     {
//         private int _id;
//         private string? _name;

//         public int id 
//         {
//             set{this._id = value;}
//             get{return this._id;}
//         } 
//         public string name
//         {
//             set{this._name = value;}
//             get{
//                 if (string.IsNullOrEmpty(this._name))  {
//                     return "No name";
//                 }
//                 return this._name;
//             }
//         } 
//         public Chat(){}
//         public Chat(int id, string name){}

//         public void print()
//         {
//             Console.WriteLine("Hello...");
//         }
//     }

// }
// // using _54_Reflection_Exemple;
// // Client.main();

