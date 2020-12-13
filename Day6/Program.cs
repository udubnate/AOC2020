using System;
using System.Collections.Generic;
using System.IO;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = "Day6input.txt";

            List<Group> GroupList = new List<Group>();
            List<string> buffer = new List<string>();

            //using statement to close out streamReader after use
            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (true)
                {
                    string line = sr.ReadLine();

                    if (string.IsNullOrEmpty(line))
                    {

                        if (buffer.Count > 0)
                        {
                            Group g = new Group(buffer);
                            GroupList.Add(g);
                            buffer.Clear();
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        buffer.Add(line);
                    }
                }
            }

            int outputCount = 0;
            int part2Count = 0;

            foreach (Group g in GroupList){
                outputCount += g.CountUniqueQuestions();
                part2Count += g.CountAllAnsweredYes();
            }
            Console.WriteLine(outputCount);
            Console.WriteLine(part2Count);
        }
    }


    public class Group
    {
        public List<Person> PersonList { get; set; }

        public Group(List<string> sl)
        {
            PersonList = new List<Person>();

            foreach (string line in sl)
            {
                Person p = new Person(line);
                PersonList.Add(p);
            }
        }

        public int CountUniqueQuestions(){
            HashSet<char> uniqueItems = new HashSet<char>();

            foreach (Person p in PersonList){
                foreach (Question q in p.QuestionList){
                    uniqueItems.Add(q.name);
                }
            }
            return uniqueItems.Count;
        }

        //part2
        public int CountAllAnsweredYes(){
            
            Dictionary<char, int> qcount = new Dictionary<char, int>();
            int count = 0;
            foreach (Person p in PersonList){
                foreach (Question q in p.QuestionList){
                    if (!qcount.ContainsKey(q.name)){
                        qcount.Add(q.name, 1);
                    } else {
                        qcount[q.name] += 1;
                    }
                }
            }
            foreach (KeyValuePair<char, int>kvp in qcount){
                if (kvp.Value == PersonList.Count){
                    count++;
                }
            }
            return count;
        }
    }


    public class Person
    {
        public List<Question> QuestionList { get; set; }

        public Person(string p)
        {

            QuestionList = new List<Question>();

            foreach (char c in p)
            {
                Question q = new Question(c);
                QuestionList.Add(q);

            }
        }
    }

    public class Question
    {
        public char name { get; set; }

        public Question(char name)
        {
            this.name = name;
        }
    }

}
