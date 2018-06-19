using DP1H.Exceptions;
using DP1H.Factory;
using DP1H.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DP1H.Reader
{
    public class FileReader
    {

        public string[] ReadFile(string path)
        {

            string[] lines = System.IO.File.ReadAllLines(path);
            return lines;

        }
    }
}