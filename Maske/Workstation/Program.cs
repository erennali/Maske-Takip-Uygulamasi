using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;


namespace Workstation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Test";
            person1.LastName = "test";
            person1.DateOfBirthYear = 2004;
            person1.NationalIdentity = 1234;



            PttManager pttManager= new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadKey();
        }
    }
}