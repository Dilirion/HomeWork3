using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        private static void Main(string[] args)
        {
            var menu = 1;
            while (menu != 0)
            {
                Console.WriteLine("Уважаемые спорщики, введите количество чисел для спора\n (целое число больше нуля):");
                var str = Console.ReadLine();
                var amount = 0;
                try
                {
                     amount = Convert.ToInt32(str);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Видимо, вы ввели не целое число. Сообщение: "+e.Message);
                }
                
                while (amount <= 0)
                {
                    Console.WriteLine("Вы ввели не положительное число. Попробуйте еще раз:");
                    str = Console.ReadLine();
                    amount = Convert.ToInt32(str);
                }

                var count = 0;
                var numbertron = new Numbertron();
                var silentBob = new SilentBob();
                var jay = new Jay();
                numbertron.NewNumber += jay.FetchNewNumber;
                numbertron.NewNumber += silentBob.FetchNewNumber;
                while (count < amount)
                {
                    numbertron.Generate();
                    count++;
                }
                if (silentBob.Score == jay.Score) Console.WriteLine("DRAW");
                else
                {
                    Console.WriteLine("Выиграл {0}", jay.Score > silentBob.Score ? jay.Name : silentBob.Name);
                }
                Console.WriteLine("Вы хотите еще раз поспорить?\n 0 - нет, 1 - да");
                str = Console.ReadLine();
                menu = Convert.ToInt32(str);
            }
        }
    }
}
