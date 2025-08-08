class EnrollmentDetails
{
    public string? EnrollmentID { get; }
    public string? CourseID { get; }
    public string? RegistrationID { get; }
    public DateTime EnrollmentDate { get; set; }
    private static int enrollmentIncrementor = 3001;

    public EnrollmentDetails(string courseid, string registrationId, DateTime enrollmentdate)
    {
        CourseID = courseid;
        RegistrationID = registrationId;
        EnrollmentDate = enrollmentdate;
        EnrollmentID = "EMT" + enrollmentIncrementor;
        enrollmentIncrementor++;
    }

}