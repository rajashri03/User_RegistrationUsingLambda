using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration_CustomException
{
    public class UserRegistration
    {
       /// <summary>
       /// Method to Check name is valid or not
       /// </summary>
       /// <param name="fname"></param>
       /// <returns></returns>
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
                    return "Name is Valid";
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
        /// <summary>
        /// Method to check last name is valid or not
        /// </summary>
        /// <param name="lname"></param>
        /// <returns></returns>
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
                    return "Last Name is valid";
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
        /// <summary>
        /// Method to check email address is valid or not
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
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
                    return "Email is Valid";
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
        /// <summary>
        /// Method to check Phoner Number is valid or not
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public string PhoneMatch(string phone)
        {
            string PHONE = @"^[0-9]{2,4}[ ]{1}[6-9]{1}[0-9]{9}$";

            Regex rg = new Regex(PHONE);

            try
            {
                if (phone.Equals(string.Empty))
                {
                    throw new RegexCustomException(RegexCustomException.Validation.EMPTY_PHONE, "Phone Should not be empty");
                }
                if (rg.IsMatch(phone))
                {
                   return "Valid";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Validation.INVALID_PHONE, "Plase Enter Valid Phone Number (eg 91 9876543210)");
                }
            }
            catch (RegexCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return phone;
        }
        /// <summary>
        /// Method -Password Rule 1-Enter Minimum 8 characters
        /// </summary>
        /// <param name="Password1"></param>
        /// <returns></returns>
        public string PasswordRule1Match(string Password1)
        {
            string PASSWORD1 = @"^[0-9a-z]{8}$";

            Regex rg = new Regex(PASSWORD1);

            try
            {
                if (Password1.Equals(string.Empty))
                {
                    throw new RegexCustomException(RegexCustomException.Validation.EMPTY_PASSWORD, "Password Should not be empty");
                }
                if (rg.IsMatch(Password1))
                {
                    return "Password Validate";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Validation.INVALID_PASSWORD1, "Plase Enter valid password(minimum 8 character)");
                }
            }
            catch (RegexCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return Password1;
        }
        /// <summary>
        /// Method -Password Rule 2-Enter Minimum 8 characters and should have at least one upper case
        /// </summary>
        /// <param name="Password2"></param>
        /// <returns></returns>
        public string PasswordRule2Match(string Password2)
        {
            string PASSWORD2 = @"^(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-z]{8}$";

            Regex rg = new Regex(PASSWORD2);

            try
            {
                if (Password2.Equals(string.Empty))
                {
                    throw new RegexCustomException(RegexCustomException.Validation.EMPTY_PASSWORD, "Password Should not be empty");
                }
                if (rg.IsMatch(Password2))
                {
                    return "Password Validate";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Validation.INVALID_PASSWORD2, "Plase Enter valid password(minimum 8 character and should have at least one upper case)");
                }
            }
            catch (RegexCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return Password2;
        }
         /// <summary>
        /// Method -Password Rule 2-Enter Minimum 8 characters and should have at least one special Character
        /// </summary>
        /// <param name="Password2"></param>
        /// <returns></returns>
        public string PasswordRule3Match(string Password3)
        {
            string PASSWORD3 = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8}$";

            Regex rg = new Regex(PASSWORD3);

            try
            {
                if (Password3.Equals(string.Empty))
                {
                    throw new RegexCustomException(RegexCustomException.Validation.EMPTY_PASSWORD, "Password Should not be empty");
                }
                if (rg.IsMatch(Password3))
                {
                    return "Password Validate";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Validation.INVALID_PASSWORD3, "Plase Enter valid password(Should have at least one special Character)");
                }
            }
            catch (RegexCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return Password3;
        }
    }
}
