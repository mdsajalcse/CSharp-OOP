using Class_Object_01;

person1 personinfo = new person1();
personinfo.firstName = "Rahat";
personinfo.middleName = "islam";
personinfo.lastName = "Rasul";
personinfo.profession = "Engineering";
personinfo.address = "Uttara";
personinfo.city = "Dhaka";
personinfo.country = "Bangladesh";
personinfo.postalCode = 1230;

string personData = personinfo.getInfo(" , ");
Console.WriteLine(personData);

