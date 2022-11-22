using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myInputException;

namespace WorkWithDelegates
{
    public class NumberReader
    {
        public delegate void NotifyDelegate(int type);
        public event NotifyDelegate NumberEntered;

        public void Read()
        {
            Console.WriteLine("Введите число 1 или 2");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number != 1 && number != 2) 
                throw new WrongInputException();
            OnNumberEntered(number);
        }

        protected virtual void OnNumberEntered(int type)
        {
            NumberEntered?.Invoke(type);
        }
    }
}
