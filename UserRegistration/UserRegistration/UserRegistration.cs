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

        string Firstname = @"[A-Z]{1}[a-z]{2}$";
        string Lastname = @"[A-Z]{1}[a-z]{2}$";
        string EMAIL = @"^[a-zA-Z0-9]+.[a-zA-Z0-9]+@[A-Za-z0-9]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        string PHONE = @"^[0-9]{2,4}[ ]{1}[6-9]{1}[0-9]{9}$";
        string PASSWORD = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8}$";
        public string FirstnameCheckusingLambda(string firstName) => Regex.IsMatch(firstName, Firstname) ? "FirstName is Valid" : "FirstName is not Valid";
        public string LastnameCheckusingLambda(string lastName) => Regex.IsMatch(lastName, Lastname) ? "LastName is Valid" : "LastName is not Valid";
        public string EmailCheckusingLambda(string email) => Regex.IsMatch(email, EMAIL) ? "Email is Valid" : "Email is not Valid";
        public string PhoneCheckusingLambda(string phone) => Regex.IsMatch(phone, PHONE) ? "Phone is Valid" : "Phone is not Valid";
        public string PasswordCheckusingLambda(string password) => Regex.IsMatch(password, PASSWORD) ? "Password is Valid" : "Password is not Valid";
    }
}
