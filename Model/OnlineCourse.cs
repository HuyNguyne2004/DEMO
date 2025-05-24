using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OnlineCourse :Course
    {
        //trang xinh vãi l 
        // trang đang ở feature ...
        // trang đang ở feature 2

        public string LinkMat { get; set; }

        public OnlineCourse(string linkMat)
        {
            LinkMat = linkMat;
        }

        public OnlineCourse(int iD, string title, DateTime startDate, string linkMat) : base(iD, title, startDate)
        {
            LinkMat = linkMat;
        }
        public OnlineCourse()
        {
        }
        public override string ToString()
        {
            return base.ToString() + $", LinkMat: {LinkMat}";
        }

       
    }
}
