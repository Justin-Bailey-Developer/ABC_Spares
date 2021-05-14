using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7311_ABC_Spares
{
    public static class PartsDataManager
    {

        private static StreamReader readFile = new StreamReader(@"parts.txt");
        private static StreamWriter writeFile = new StreamWriter(@"parts.txt");

        public static List<Part> Parts;

        public static List<Part> ReadFile()
        {

            Parts = new List<Part>();

            string line = "";
            string id, name; 
            double price;

            //System.IO.StreamReader file = new System.IO.StreamReader(@"students.txt");

            while ((line = readFile.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                string[] split = line.Split(',');

                id = split[0].Trim();
                name = split[1].Trim();
                price = Convert.ToDouble(split[2].Trim());
                              
                    
                Parts.Add(new Part(id, name,price));
                
            }

            readFile.Close();

            return Parts;
        }

        public static void WriteFile(List<Part> parts)
        {
            using (TextWriter tw = new StreamWriter("SavedList.txt"))
            {
                foreach (Part part in parts)
                    tw.WriteLine(part);
            }
        }
    }
}
