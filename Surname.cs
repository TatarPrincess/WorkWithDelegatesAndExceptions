using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myInputException;
using CommonFuncs;
using WorkWithDelegates;

namespace WorkWithSurname
{
    public class Surname
    {
        public string[] surnames;
        public Surname()
        {
            surnames = new string[] { "Иванов", "Санфельд", "Фромм", "Манн", "Фербер" };            
        }
        
        public void Sort(int sortType)
        {
            if (sortType == 1 || sortType == 2)
            {
                new Sorter(surnames).SortStrings(sortType);
            } 
            else throw new WrongInputException("Введено некорректное значение (долно быть либо 1, либо 2)");
        }
    }
}
