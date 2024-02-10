using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Workraund
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "emrah";
            person1.LastName = "cengiz";
            person1.DateOfBirthYear = 1982;
            person1.NationalIdentity = 123;

                    
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

    }

}
