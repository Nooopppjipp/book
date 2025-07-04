﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookrent
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        public string Description { get; set; }
        public int QueueCount { get; set; } = 0;
        public List<string> QueueUsers { get; set; } = new List<string>();

    }
}
