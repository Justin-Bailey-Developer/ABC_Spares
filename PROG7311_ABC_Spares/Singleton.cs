using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7311_ABC_Spares
{
    public sealed class Singleton
    {

        private static readonly Singleton instance = new Singleton();

        private static string path = "changesLog.txt";

        public  List<Log> Log { get; set; }
        public List<Part> Parts { get; set; }

        static Singleton()
        {
        }

        //private constructor restricted to this class itself
        private Singleton()
        {
        }

        public static Singleton getInstance
        {            
            get
            {                
                return instance;
            }
        }
        
        public static void UpdateLog(string log)
        {
            using (StreamWriter sw = File.AppendText(@"changesLog.txt"))
            {
                sw.WriteLine(log);
            }
        }
                
        public List<Log> getLog()
        {

            Log = new List<Log>();

            StreamReader readFile = new StreamReader(@"changesLog.txt");

            string line;            

            string date;
            string description;

            while ((line = readFile.ReadLine()) != null)
            {                
                string[] split = line.Split(',');

                date = split[0].Trim();
                description = split[1].Trim();

                Log.Add(new Log(date, description));
            }

            readFile.Close();

            return Log;
        }

        public void AddPart(string part)
        {          
            using (StreamWriter sw = File.AppendText(@"parts.txt"))
            {
                sw.WriteLine(part);
            }
        }

        public List<Part> getParts()
        {

            Parts = new List<Part>();

            StreamReader readFile = new StreamReader(@"parts.txt");

            string line;

            string partId;
            string partName;
            double partPrice;

            while ((line = readFile.ReadLine()) != null)
            {
                string[] split = line.Split('-');

                partId = split[0].Trim();
                partName = split[1].Trim();
                partPrice = Convert.ToDouble(split[2].Trim());

                Parts.Add(new Part(partId, partName, partPrice));
            }

            readFile.Close();

            return Parts;
        }


    }
}
