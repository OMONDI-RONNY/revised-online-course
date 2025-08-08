using System.Globalization;

class Program
{
    static void Main()
    {
        Logic logicManager = new Logic();
        AddCourses(logicManager);
        AddUsers(logicManager);
        AddEnroll(logicManager);

        Console.WriteLine("Online course Enrollment System");
        System.Console.WriteLine("________________________");

        bool operationsLoop = true;
        do
        {
            System.Console.WriteLine("1.Registration");
            System.Console.WriteLine("2.Login");
            System.Console.WriteLine("3.Exit");

            Console.WriteLine("Enter your choice:  ");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    logicManager.Registration();
                    break;
                case 2:
                    Console.WriteLine("Login");
                    break;
                case 3:
                    Console.WriteLine("Exiting_________");
                    break;
                default:
                    Console.WriteLine("Invalid choice ");
                    break;
            }
        } while (operationsLoop);
    }

    static void AddCourses(Logic course)
    {
        course.AddCourses(new CourseDetails("C#", "Baskaran", 5, 0));
        course.AddCourses(new CourseDetails("HTML", "Ravi", 2, 5));
        course.AddCourses(new CourseDetails("CSS", "Priyadharshini", 2, 3));
        course.AddCourses(new CourseDetails("JS", "Baskaran", 3, 1));
        course.AddCourses(new CourseDetails("TS", "Ravi", 1, 2));
    }
    static void AddUsers(Logic user)
    {
        user.AddUsers(new UserDetails("Ravichandran", 30, Gender.Male, "ME", "87663456576", "ravi@gmail.com"));
        user.AddUsers(new UserDetails("Priyadharshini", 25, Gender.Female, "BE", "87663456576", "priya@gmail.com"));
    }

    static void AddEnroll(Logic enroll)
    {
        enroll.AddEnrollment(new EnrollmentDetails("CS2001", "SYNC1001", DateTime.ParseExact("28/01/2024", "dd/mm/yyyy", CultureInfo.InvariantCulture)));
        enroll.AddEnrollment(new EnrollmentDetails("CS2003", "SYNC1001", DateTime.ParseExact("15/02/2024", "dd/mm/yyyy", CultureInfo.InvariantCulture)));
        enroll.AddEnrollment(new EnrollmentDetails("CS2004", "SYNC1002", DateTime.ParseExact("18/02/2024", "dd/mm/yyyy", CultureInfo.InvariantCulture)));
        enroll.AddEnrollment(new EnrollmentDetails("CS2002", "SYNC1002", DateTime.ParseExact("20/02/2024", "dd/mm/yyyy", CultureInfo.InvariantCulture)));
    }
}