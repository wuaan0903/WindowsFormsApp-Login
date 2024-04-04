using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms;
using WindowsFormsApp_Login.User.Model;
using WindowsFormsApp_Login.User.Controller; //the WinForm wrappers

namespace WindowsFormsApp_Login.Admin.View
{
    public partial class FormThongKe : UserControl
    {
        List<Subject> subjects = new List<Subject>();
        List<Exam> exams = new List<Exam>();
        List<History> history = new List<History>();
        List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
        public FormThongKe()
        {
            InitializeComponent();

            ExamModify examModify = new ExamModify();
            Modify modify = new Modify();
            string querry = "SELECT * FROM list_subject";
            subjects = examModify.Subjects(querry);

            querry = "SELECT * FROM list_exam";
            exams = examModify.Exams(querry);

            querry = "SELECT * FROM history_test";
            history = examModify.histories(querry);

            List<string> monHocList = new List<string>();
            for (int i = 0; i < subjects.Count; i++)
            {
                monHocList.Add(subjects[i].NameExam);
            }

            List<int> soDeThi = new List<int>();
            for (int i = 0; i < monHocList.Count; i++)
            {
                int d = 0;
                for (int j = 0; j < exams.Count; j++)
                {
                    if (exams[j].Name_exam == monHocList[i])
                    {
                        d++;
                    }
                }
                soDeThi.Add(d);
            }
            int tongSoDeThi = 0;
            for (int i = 0; i < soDeThi.Count; i++)
            {
                tongSoDeThi = tongSoDeThi + soDeThi[i];
            }
            soDeThiTxt.Text = tongSoDeThi.ToString();

            List<int> soLuotThi = new List<int>();
            for (int i = 0; i < monHocList.Count; i++)
            {
                int d = 0;
                for (int j = 0; j < history.Count; j++)
                {
                    if (history[j].NameExam == monHocList[i])
                    {
                        d++;
                    }
                }
                soLuotThi.Add(d);
            }

            int tongSoLuotThi = 0;
            for (int i = 0; i < soLuotThi.Count; i++)
            {
                tongSoLuotThi = tongSoLuotThi + soLuotThi[i];
            }
            soLuotThiTxt.Text = tongSoLuotThi.ToString();


            querry = "SELECT * FROM Users";
            taiKhoans = modify.TaiKhoans(querry);
            int tongSoNguoiDung = 0;
            for (int i = 0; i < taiKhoans.Count; i++)
            {
                tongSoDeThi++;
            }
            soNguoiDungTxt.Text = tongSoDeThi.ToString();


            ChartValues<int> soDeThiValues = new ChartValues<int>(soDeThi);
            cartesianChart1.Series = new SeriesCollection
            {

                new ColumnSeries
                    {
                        Title = "Số đề thi",
                        Values = soDeThiValues
                    }
            };

            //adding series will update and animate the chart automatically
            ChartValues<int> soLuotThiValues = new ChartValues<int>(soLuotThi);
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "Số lượt thi",
                Values = soLuotThiValues
            });


            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Môn học",
                Labels = monHocList.ToArray()
            });
        }
    }
}
