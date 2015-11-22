using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public event NewNumberEventHandler NewNumber;

        Random rand = new Random();

        public void Generate()
        {
            NewNumber?.Invoke(this, new NewNumberEventArgs(rand.Next()));
        }
    }

    
}
