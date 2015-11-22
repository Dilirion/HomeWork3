using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Extensions;

namespace Model
{
    public class SilentBob: Gambler
    {
        public SilentBob() : base("SilentBob")
        {
            Score = 0;
        }
        public override void FetchNewNumber(Object sender, NewNumberEventArgs e)
        {
            if (!(e.Number.IsEven())) Score++;
        }
    }
}
