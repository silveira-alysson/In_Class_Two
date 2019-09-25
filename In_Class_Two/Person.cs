using System;

namespace In_Class_Two
{

        class Person
        {
            public static string salutationMr = "Mr";
            public static string salutationMs = "Ms";
            public static string defaultsalutationkid = "";

            public string firstName;
            public string lastName;
            public string salutation;
            public Person()
            {
                firstName = "Joss";
                lastName = "Doe";
                salutation = salutationMs;
            }

            static void Main(string[] args)
            {
                Person pr = new Person();

            }
        }
    }

