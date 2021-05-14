using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7311_ABC_Spares
{
    public class Log
    {
        public string Date { get; set; }
        public string Description { get; set; }

        public Log(string date, string description)
        {
            Date = date;
            Description = description;
        }
    }
}
