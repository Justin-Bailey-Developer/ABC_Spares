using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7311_ABC_Spares
{
    public class Part
    {

        public string PartId { get; set; }
        public string PartName { get; set; }
        public double PartPrice { get; set; }

        public Part(string partId, string partName, double price)
        {
            PartId = partId;
            PartName = partName;
            PartPrice = price;
        }

        public string toString()
        {
            return (PartId + " - " + PartName + " - " + PartPrice);
        }
    }
}
