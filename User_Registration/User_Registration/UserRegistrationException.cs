using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration
{
    public class UserRegistrationException : Exception
    {/// <summary>
     /// Enum for exception type
     /// </summary>
        public enum ExceptionType
        {
            ENTERD_NULL, ENTERD_EMPTY, NO_A_VALID_INPUT, INVALID_FIRST_NAME,
            INVALID_LAST_NAME, INVALID_EMAIL, INVALID_PASSWORD, INVALID_MOBILE_NUMBER
        }

        /// <summary>
        /// Creating 'type' variable of type ExceptionType
        /// </summary>
        ExceptionType type;
        readonly string message;

        /// <summary>
        /// Parameterized constructor sets the exception type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public UserRegistrationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
            this.message = message;
        }
    }
}
