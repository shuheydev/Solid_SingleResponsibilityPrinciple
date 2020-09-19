﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_SingleResponsibilityPrinciple
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            //Create a username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
