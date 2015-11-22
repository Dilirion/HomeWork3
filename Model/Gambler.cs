﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Gambler
    {
        protected Gambler(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public int Score { get; protected set; }

        public abstract void FetchNewNumber(Object sender, NewNumberEventArgs e);
    }
}
