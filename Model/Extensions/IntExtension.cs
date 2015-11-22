using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Extensions
{
    public static class IntExtension
    {
        public static bool IsEven(this int number)
        {
            return (number % 2 == 0);
        }
    }
}
