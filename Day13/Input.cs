using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day13
{
    class Input
    {

        public string FilePath { get; set; }

        public Input(string filePath)
        {
            this.FilePath = filePath;
        }

        public List<List<string>> Parse()
        {
            //using statement to close out streamReader after use
            using (StreamReader sr = new StreamReader(this.FilePath))
            {
                var list = new List<List<string>>();
                var count = 0;
                while (true)
                {
                    string line = sr.ReadLine();
                    //end with EOF
                    if (string.IsNullOrEmpty(line)) break;

                    if (count == 0){
                        var sublist = new List<string>(); 
                        sublist.Add(line);
                        list.Add(sublist);
                    }
                    else if (count == 1){
                        var sublist = new List<string>();
                        sublist= line.Split(',').ToList();
                        list.Add(sublist);
                    }
                    count++;
                }
                return list;
            }
        }
    }
}
