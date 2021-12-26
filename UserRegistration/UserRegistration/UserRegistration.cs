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
    }
}
