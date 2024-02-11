// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "Enes";
person1.LastName = "Kartancı";
person1.DateOfBirthYear = 2002;
person1.NationalIdentity = 12345678910;

PttManager pttmanager = new PttManager(new PersonManager());
pttmanager.GiveMask(person1);
