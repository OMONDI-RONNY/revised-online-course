class CourseDetails
{
    public string? CourseID { get; }
    public string? CourseName { get; }
    public string? TrainerName { get; }
    public int CourseDuration { get; set; }
    public int SeatsAvailable { get; set; }
    private static int courseIncrementor = 2001;

    public CourseDetails(string custname, string trainerName, int courseduration, int seats)
    {
        CourseName = custname;
        TrainerName = trainerName;
        CourseDuration = courseduration;
        SeatsAvailable = seats;
        CourseID = "CS" + courseIncrementor;
        courseIncrementor++;
    }
}