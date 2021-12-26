﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration_CustomException
{
    public class UserRegistration
    {
       
        public string FirstNameMatch(string fname)
        {
            string Firstname = @"[A-Z]{1}[a-z]{2}$";

            Regex rg = new Regex(Firstname);

            try
            {
                if(fname.Equals(string.Empty))
                {
                    throw new RegexCustomException(RegexCustomException.Validation.EMPTY_NAME, "First Name Should noy be empty");
                }
                if (rg.IsMatch(fname))
                {
                    Console.Write("Name is Valid");
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Validation.INVALID_NAME, "Plase Enter First Letter Capital and Length of the name upto 3 only");
                }
            }
            catch (RegexCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return fname;
        }
        public string LastNameMatch(string lname)
        {
            string Lastname = @"[A-Z]{1}[a-z]{2}$";

            Regex rg = new Regex(Lastname);

            try
            {
                if (lname.Equals(string.Empty))
                {
                    throw new RegexCustomException(RegexCustomException.Validation.LAST_NAME, "Last Name Should not be empty");
                }
                if (rg.IsMatch(lname))
                {
                    Console.Write("Last Name is Valid");
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Validation.INVALID_LASTNAME, "Plase Enter First Letter Capital and Length of the last name upto 3 only");
                }
            }
            catch (RegexCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return lname;
        }
        public string EmailMatch(string email)
        {
            string EMAIL = @"^[a-zA-Z0-9]+.[a-zA-Z0-9]+@[A-Za-z0-9]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

            Regex rg = new Regex(EMAIL);

            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new RegexCustomException(RegexCustomException.Validation.EMAIL, "Email Should not be empty");
                }
                if (rg.IsMatch(email))
                {
                    Console.Write("Email is Valid");
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Validation.INVALID_EMAIL, "Plase Enter Valid Email Address");
                }
            }
            catch (RegexCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return email;
        }
    }
}
