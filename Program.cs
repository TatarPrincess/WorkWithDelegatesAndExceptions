using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CommonFuncs;
using myException;
using myInputException;
using WorkWithDelegates;
using WorkWithSurname;

namespace WorkWithDelegatesAndExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Exception[] exceptions = new Exception[5];

            exceptions[0] = new WrongLanguageException();
            exceptions[1] = new FileNotFoundException("File not found");
            exceptions[2] = new ArgumentNullException("Null exception");
            exceptions[3] = new FormatException("Format exception");
            exceptions[4] = new TimeoutException("time out");


            foreach (var ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (WrongLanguageException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (TimeoutException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

            //задание 2
            try 
            {
                NumberReader numberReader = new NumberReader();
                Surname surname = new Surname();
                numberReader.NumberEntered += surname.Sort;
                numberReader.Read();                
            }

            catch (FormatException e)
            {
                throw new WrongInputException();
            }
        }
    }
}
