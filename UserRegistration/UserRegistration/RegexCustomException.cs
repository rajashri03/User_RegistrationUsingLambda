using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_CustomException
{
    public class RegexCustomException:Exception
    {
        public enum Validation
        {
            EMPTY_NAME, INVALID_NAME,
            LAST_NAME,INVALID_LASTNAME,
            EMAIL,INVALID_EMAIL,
            EMPTY_PHONE,INVALID_PHONE,
            EMPTY_PASSWORD1,INVALID_PASSWORD1,
            EMPTY_PASSWORD2,INVALID_PASSWORD2,


        }
        public readonly Validation type;
        public RegexCustomException(Validation type,string message):base(message)
        {
            this.type = type;
        }
    }
}
