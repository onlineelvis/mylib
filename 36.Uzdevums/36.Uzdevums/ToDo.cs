using System;
using System.Collections.Generic;
using System.Text;

namespace _36.Uzdevums
{
    class ToDo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Done  { get; set; }

        
        public bool MarkAsDone(bool isDone)
        {
            return !isDone;
        }
    }
}
