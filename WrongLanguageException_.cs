using System;

namespace myException
{
    public class WrongLanguageException : Exception
    {
        public WrongLanguageException(string errText) : base(errText)
        {

        }

        public WrongLanguageException() : this("Необходимо использовать буквы латинского алфавита") 
        {
                       
        }
    }
}