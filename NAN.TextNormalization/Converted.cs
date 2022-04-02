using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NAN.TextNormalization
{
    public class Converted
    {
        public string Source(string fileMane)
        {
            string str;
            StreamReader reader = new StreamReader(fileMane, Encoding.UTF8);
            str = reader.ReadToEnd();
            return str;
        }
        public string Convert(string fileMane)
        {
            string str;
            StreamReader reader = new StreamReader(fileMane, Encoding.UTF8);
            str = Regex.Replace(reader.ReadToEnd(), @"\W", " ").ToLower();
            str = string.Join(" ", str.Split(new char[] { ' ' }));
            return str;
        }
    }
}
