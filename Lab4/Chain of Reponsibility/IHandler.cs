﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Reponsibility
{
    public interface IHandler
    {
        public void Handle(int num);
    }
}
