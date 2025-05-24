using Controller;
// lô con cặc
using Model;

internal class Program
// TAO LOP CHUAN
{
    private static void Main(string[] args)
    {
        var courseController = new CourseController();
        var onlineController = new CourseOnlineController();

        List<Course> courses = new List<Course>
        {
            new Course(1, "Khóa học C#", DateTime.Parse("2023-01-01")),
            new Course(2, "Khóa học Java", DateTime.Parse("2023-02-01")),
            new Course(3, "Khóa học Python", DateTime.Parse("2023-03-01"))
        };

        List<OnlineCourse> onlineCourses = new List<OnlineCourse>
        {
            new OnlineCourse(1, "Khóa học C# Online", DateTime.Parse("2023-01-01"), "http://example.com/csharp"),
            new OnlineCourse(2, "Khóa học Java Online", DateTime.Parse("2023-02-01"), "http://example.com/java"),
            new OnlineCourse(3, "Khóa học Python Online", DateTime.Parse("2023-03-01"), "http://example.com/python")
        };

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Nhập danh sách khóa học");
            Console.WriteLine("2. Hiển thị danh sách khóa học");
            Console.WriteLine("3. Tìm kiếm khóa học theo khoảng ngày");
            Console.WriteLine("4. Sắp xếp khóa học theo tiêu đề");
            Console.WriteLine("5. Nhập danh sách khóa học online");
            Console.WriteLine("6. Hiển thị danh sách khóa học online");
            Console.WriteLine("7. Tìm kiếm khóa học online theo khoảng ngày");
            Console.WriteLine("8. Sắp xếp khóa học online theo tiêu đề");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    courses = courseController.InputCourseList();
                    break;
                case "2":
                    courseController.DisplayCourses(courses);
                    break;
                case "3":
                    var foundCourses = courseController.FindCoursesByDateRange(courses);
                    courseController.DisplayCourses(foundCourses);
                    break;
                case "4":
                    courses = courseController.SortCoursesByTitle(courses);
                    Console.WriteLine("Đã sắp xếp danh sách khóa học.");
                    break;
                case "5":
                    onlineCourses = onlineController.InputCourseList();
                    break;
                case "6":
                    onlineController.DisplayCourses(onlineCourses);
                    break;
                case "7":
                    var foundOnline = onlineController.FindCoursesByDateRange(onlineCourses);
                    onlineController.DisplayCourses(foundOnline);
                    break;
                case "8":
                    onlineCourses = onlineController.SortCoursesByTitle(onlineCourses);
                    Console.WriteLine("Đã sắp xếp danh sách khóa học online.");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }
    }
}
