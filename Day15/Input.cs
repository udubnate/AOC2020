using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day15
{
    class Input
    {

        public string FilePath { get; set; }

        public Input(string filePath){
            this.FilePath = filePath;
        }

        public List<int> Parse(){
            //using statement to close out streamReader after use
            using (StreamReader sr = new StreamReader(this.FilePath))
            {
                var list = new List<int>();

                while (true)
                {
                    string line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line)) break;
                    
                    //custom processing
                    string[] strlist = line.Split(',');
                    int[] ints = Array.ConvertAll(strlist, s => int.Parse(s));
                    list = ints.ToList();
                    //end with EOF
                    
                }
                return list;
            }
        }
    }
}