using System;
using System.Collections.Generic;
using System.IO;

namespace Day10
{
    class Input
    {

        public string FilePath { get; set; }

        public Input(string filePath){
            this.FilePath = filePath;
        }

        public List<long> Parse(){
            //using statement to close out streamReader after use
            using (StreamReader sr = new StreamReader(this.FilePath))
            {
                var list = new List<long>();

                while (true)
                {
                    string line = sr.ReadLine();
                    //end with EOF
                    if (string.IsNullOrEmpty(line)) break;

                    long val = Convert.ToInt64(line);

                    list.Add(val);
                }
                return list;
            }
        }
    }
}