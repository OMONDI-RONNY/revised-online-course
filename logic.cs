class Logic
{
    List<UserDetails> users = new List<UserDetails>();
    List<CourseDetails> courses = new List<CourseDetails>();
    List<EnrollmentDetails> enrolledCourses = new List<EnrollmentDetails>();

    //add to list
    public void AddCourses(CourseDetails course)
    {
        courses.Add(course);
    }
    public void AddUsers(UserDetails user)
    {
        users.Add(user);

    }
    public void AddEnrollment(EnrollmentDetails enroll)
    {
        enrolledCourses.Add(enroll);
    }

    //registration
    public void Registration()
    {
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine()!.Trim();
        Console.WriteLine("Enter your age:  ");
        int age = int.Parse(Console.ReadLine()!.Trim());
        Console.WriteLine("Enter your gender: ");
        Gender userGender;
        if (Enum.TryParse(Console.ReadLine()!.Trim(), true, out userGender)) { Console.WriteLine(userGender); } else { userGender = Gender.Male; }
        Console.WriteLine("Enter your qualification: ");
        string qualification = Console.ReadLine()!;
        Console.WriteLine("Enter your mobile number");
        string mobile = Console.ReadLine()!.Trim();
        Console.WriteLine("Enter your email: ");
        string email = Console.ReadLine()!.Trim();

        UserDetails newUser = new UserDetails(username, age, userGender, qualification, mobile, email);
        AddUsers(newUser);
        Console.WriteLine("You have been succesfully registered your use ID: {0}", newUser.RegistrationID);

    }

    //login
    public void Login()
    {
        Console.WriteLine("Enter your Registration ID: ");
        string registrationID = Console.ReadLine()!.Trim();

        UserDetails? checkRegistrationID = users.Find(u => u.RegistrationID == registrationID);
        if (checkRegistrationID == null)
        {
            Console.WriteLine("Invalid user ID");
        }
        else
        {
            bool operationsLoop = true;
            do
            {
                Console.WriteLine("a.Enroll Course");
                Console.WriteLine("b.View Enrollment History");
                Console.WriteLine("c.Next enrollment");
                Console.WriteLine("d.Exit");

                Console.WriteLine("Enter your choice: ");
                char choice = char.Parse(Console.ReadLine()!.Trim().ToLower());

                switch (choice)
                {
                    case 'a':
                        EnrollCourse(checkRegistrationID);
                        break;
                    case 'b':
                        Console.WriteLine("view");
                        break;
                    case 'c':
                        System.Console.WriteLine("next");
                        break;
                    case 'd':
                        System.Console.WriteLine("Exit_____________");
                        operationsLoop = false;
                        break;
                    default:
                        System.Console.WriteLine("unknown choice");
                        break;
                }
            } while (operationsLoop);
        }
    }

    //enroll
    public void EnrollCourse(UserDetails user)
    {
        Console.WriteLine("{0,-10}{1,-15}{2,-20}{3,-25}{4,10}", "Course ID", "Course name", "Trainer name", "Duration", "SeatsAvailable");
        foreach (CourseDetails courses in courses)
        {
            Console.WriteLine("{0,-10}{1,-15}{2,-20}{3,-25}{4,10}", courses.CourseID, courses.CourseName, courses.TrainerName, courses.CourseDuration, courses.SeatsAvailable);
        }

        Console.WriteLine("Enter the course ID: ");
        string courseid = Console.ReadLine()!.Trim();

        CourseDetails? checkSelectedCourse = courses.Find(c => c.CourseID == courseid);

        if (checkSelectedCourse == null)
        {
            Console.WriteLine("No course found");
        }
        else
        {
            if (checkSelectedCourse.SeatsAvailable <= 0)
            {
                Console.WriteLine("Seats are not available for the current course");
            }
            else
            {
                var checkEnrolledUser = enrolledCourses.FindAll(e => e.RegistrationID == user.RegistrationID);
                if (checkEnrolledUser == null)
                {
                    Console.WriteLine("User not enrolled!");
                }
                else
                {
                    if (checkEnrolledUser.Count < 2)
                    {
                        EnrollmentDetails EnrollUser = new EnrollmentDetails(courseid, user.RegistrationID!, DateTime.Now);
                        AddEnrollment(EnrollUser);
                        Console.WriteLine("You have succesfully enrolled to {0} on {}", checkSelectedCourse.CourseName, EnrollUser.EnrollmentDate.ToShortDateString());
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}