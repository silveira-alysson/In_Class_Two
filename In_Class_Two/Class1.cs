using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Two
{
    class Physician : Person
    {
        public static string salutationDr = "Dr";
        public static string specialty = "Surgeon";

        public Physician(string salutationMs, string salutationDr, string specialty, string fName, string lName)
        {
            Console.Write(salutationMs + salutationDr + specialty + fName + lName);

        }


    }
}
