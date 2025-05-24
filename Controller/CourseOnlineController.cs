using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class CourseOnlineController 
    {
        public OnlineCourse InputCourse()
        {
            Console.Write("Nhập ID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập tiêu đề: ");
            string title = Console.ReadLine() ?? "";

            Console.Write("Nhập ngày bắt đầu (yyyy-MM-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString("yyyy-MM-dd"));

            Console.Write("Nhập URL khóa học: ");
            string url = Console.ReadLine() ?? "";

            return new OnlineCourse(id, title, startDate, url);
        }

        public List<OnlineCourse> InputCourseList()
        {
            Console.Write("Nhập số lượng khóa học: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            var courses = new List<OnlineCourse>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho khóa học thứ {i + 1}:");
                courses.Add(InputCourse());
            }
            return courses;
        }

        public void DisplayCourses(List<OnlineCourse> courses)
        {
            Console.WriteLine("\nDanh sách các khóa học:");
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }

        public List<OnlineCourse> FindCoursesByDateRange(List<OnlineCourse> courses)
        {
            Console.Write("Nhập ngày bắt đầu khoảng tìm kiếm (yyyy-MM-dd): ");
            DateTime fromDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString("yyyy-MM-dd"));

            Console.Write("Nhập ngày kết thúc khoảng tìm kiếm (yyyy-MM-dd): ");
            DateTime toDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString("yyyy-MM-dd"));

            var result = courses
                .Where(c => c.StartDate >= fromDate && c.StartDate <= toDate)
                .ToList();

            return result;
        }
        public List<OnlineCourse> SortCoursesByTitle(List<OnlineCourse> courses)
        {
            return courses.OrderBy(c => c.Title).ToList();

        }
    }

  

}
