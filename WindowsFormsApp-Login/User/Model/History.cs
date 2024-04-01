﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Login.User.Model
{
    internal class History
    {
        private int id;
        private int id_user;
        private string nameExam;
        private int numberExam;
        private int time_completed;
        private int totalPoint;
        public History()
        {

        }
        public History(int id_user, string nameExam, int numberExam, int time_completed, int totalPoint)
        {
            this.id_user = id_user;
            this.nameExam = nameExam;
            this.numberExam = numberExam;
            this.time_completed = time_completed;
            this.totalPoint = totalPoint;
        }

        public History(int id, int id_user, string nameExam, int numberExam, int time_completed, int totalPoint)
        {
            this.id = id;
            this.id_user = id_user;
            this.nameExam = nameExam;
            this.numberExam = numberExam;
            this.time_completed = time_completed;
            this.totalPoint = totalPoint;
        }

        public int Id { get => id; set => id = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public string NameExam { get => nameExam; set => nameExam = value; }
        public int NumberExam { get => numberExam; set => numberExam = value; }
        public int Time_completed { get => time_completed; set => time_completed = value; }
        public int TotalPoint { get => totalPoint; set => totalPoint = value; }
    }
}
