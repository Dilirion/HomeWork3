using Model.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jay: Gambler
    {
        public Jay() : base("Jay")
        {
            Score = 0;
        }

        public override void FetchNewNumber(Object sender, NewNumberEventArgs e)
        {
            if(e.Number.IsEven()) Score++;
        }

    }
}
