﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Core.Interfaces
{
    public interface IRenderer
    {
        void Write(string line);
        void WriteLine(string line);
    }
}
