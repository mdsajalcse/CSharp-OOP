
using ClassAndObject;


Console.WriteLine("Object#01..");
object_person person = new object_person();
person.firstName = "Ifthekar";
person.lastName = "Sajal";
person.age = 25;
person.address = "Dhaka Uttara";
person.city = "Dhaka";
person.country = "Bangladesh";

string std_Profile = person.getInfo(" , ");
Console.WriteLine(std_Profile);

Console.WriteLine("Object#02..");

object_person person2 = new object_person();
person2.firstName = "Raju";
person2.lastName = "Hossain";
person2.age = 25;
person2.address = "Dhaka Uttara";
person2.city = "Dhaka";
person2.country = "Bangladesh";

string std_Profile2 = person2.getInfo(" , ");
Console.WriteLine(std_Profile2);
