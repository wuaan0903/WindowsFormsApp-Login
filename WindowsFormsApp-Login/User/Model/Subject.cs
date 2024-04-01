using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Login.User.Model
{
    internal class Subject
    {
        private int id;
        private string nameExam;
        private int totalExam;
        public Subject()
        {

        }

        public Subject(string nameExam)
        {
            this.nameExam = nameExam;
        }

        public Subject(string nameExam, int totalExam)
        {
            this.nameExam = nameExam;
            this.totalExam = totalExam;
        }

        public Subject(int id, string nameExam, int totalExam)
        {
            this.id = id;
            this.nameExam = nameExam;
            this.totalExam = totalExam;
        }

        public int Id { get => id; set => id = value; }
        public string NameExam { get => nameExam; set => nameExam = value; }
        public int TotalExam { get => totalExam; set => totalExam = value; }
    }

}
