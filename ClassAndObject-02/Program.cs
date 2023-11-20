using ClassAndObject_02;


    public class Program
    {
        static void Main(string[] args)
        {
            objectClass_02 workObj = new objectClass_02();
            string fullName= workObj.name = "Iftheka Sajal";
            string myWork=workObj.getWork("  ");
            Console.WriteLine("My Full Name: {0}",fullName);
            Console.WriteLine("MyWork is::{0}",myWork);
        }
    }
