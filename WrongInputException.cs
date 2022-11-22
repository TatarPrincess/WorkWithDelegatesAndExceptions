using System;

namespace myInputException
{
    public class WrongInputException : Exception
    {
        public WrongInputException(string errText) : base(errText)
        {

        }

        public WrongInputException() : this("Введено неверное значение. Введите число 1 или 2.")
        {

        }
    }
}