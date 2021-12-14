using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Reading
    {
        private string _path;
        public Reading(string path)
        {
            _path = path;
        }
        public string[] Read()
        {
            string[] str = File.ReadAllLines(_path);
            return str;
        }

    }
}
