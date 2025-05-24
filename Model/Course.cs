using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Course
    {
        //trang xinh 2
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Course(int iD, string title, DateTime startDate)
        {
            ID = iD;
            this.Title = title;
            StartDate = startDate;
        }

        public Course()
        {
        }

        public override string ToString()
        {
            return $"ID: {ID}, Title: {Title}, StartDate: {StartDate.ToShortDateString()}";
        }
        

    }
}
