﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBrowserGame.Shared
{
    public class Unit
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int HitPoints { get; set; } = 100;

        public int BananaCost { get; set; }
    }
}
