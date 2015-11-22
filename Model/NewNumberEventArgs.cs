using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NewNumberEventArgs: EventArgs
    {
        public NewNumberEventArgs(int number)
        {
            Number = number;
        }
        public int Number { get; }
    }

    public delegate void NewNumberEventHandler(object sender, NewNumberEventArgs args);
}
