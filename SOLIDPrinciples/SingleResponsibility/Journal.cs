using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibility
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}:{text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        //Violates Single Responsibility principle as Journal class is adding entries and saving entries
        //public void Save(string filename,bool overwrite = false)
        //{
        //    File.WriteAllText(filename,ToString());
        //}
    }

    public class Persistence
    {
        public void SavetoFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite)
            {
                File.WriteAllText(filename, journal.ToString()); 
            }
        }
    }
}
