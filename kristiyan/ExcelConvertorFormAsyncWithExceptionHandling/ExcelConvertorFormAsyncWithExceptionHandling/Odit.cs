﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Odit
    {
        public string? DateTimeString { get; set; }
        public string? UserType { get; set; }
        public string? ActionType { get; set; }
        public string? Object { get; set; }
        public string? Identificator { get; set; }
        public List<Tuple>? Tuples { get; set; }
    }
}
