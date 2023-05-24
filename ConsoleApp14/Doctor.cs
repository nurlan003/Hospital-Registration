using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Doctor
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int isTecrubesi { get; set; }
        public bool watch1 { get; set; }
        public bool watch2 { get; set; }
        public bool watch3 { get; set; }
        public string isSahesi { get; set; }

        public Doctor(string name, string surname, int istecrubesi , bool watch1, bool watch2, bool watch3, string issahesi)
        {
            Name=name;
            Surname=surname;
            isTecrubesi =istecrubesi;
            this.watch1=watch1;
            this.watch2=watch2;
            this.watch3=watch3;
            isSahesi = issahesi;
        }
    }
}
