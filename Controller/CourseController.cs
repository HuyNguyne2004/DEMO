using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class CourseController
    {
        public Course InputCourse()
        {
            Console.Write("Nhập ID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập tiêu đề: ");
            string title = Console.ReadLine() ?? "";

            Console.Write("Nhập ngày bắt đầu (yyyy-MM-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString("yyyy-MM-dd"));

            return new Course(id, title, startDate);
        }

        public List<Course> InputCourseList()
        {
            Console.Write("Nhập số lượng khóa học: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            var courses = new List<Course>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho khóa học thứ {i + 1}:");
                courses.Add(InputCourse());
            }
            return courses;
        }

        public void DisplayCourses(List<Course> courses)
        {
            Console.WriteLine("\nDanh sách các khóa học:");
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }

        public List<Course> FindCoursesByDateRange(List<Course> courses)
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
        public List<Course> SortCoursesByTitle(List<Course> courses)
        {
            return courses.OrderBy(c => c.Title).ToList();
        }

        


    }
}
