using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelBasic
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public StudentViewModel()
        {
            Student = new Student() { Navn = "Jeppe" };
        }
        

    }
}
