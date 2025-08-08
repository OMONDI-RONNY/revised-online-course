enum Gender
{
    Male,
    Female,
    Transgender
}
class UserDetails
{
    public string? RegistrationID { get; }
    public string? Username { get; }
    public int Age { get; }
    public Gender Gender { get; }
    public string? Qualification { get; }
    public string? MobileNumber { get; }
    public string? EmailID { get; }
    private static int courseIncrementor = 1001;

    public UserDetails(string username, int age, Gender gender, string qualification, string mobile, string mail)
    {
        RegistrationID = "SYNC" + courseIncrementor;
        courseIncrementor++;
        Username = username;
        Age = age;
        Gender = gender;
        Qualification = qualification;
        MobileNumber = mobile;
        EmailID = mail;
    }
}