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
            EMPTY_NAME, INVALID_NAME

        }
        public readonly Validation type;
        public RegexCustomException(Validation type,string message):base(message)
        {
            this.type = type;
        }
    }
}
