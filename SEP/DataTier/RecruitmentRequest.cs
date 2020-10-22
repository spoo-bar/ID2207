namespace DataTier
{
    public class RecruitmentRequest
    {
        public RecruitmentRequest(Contractype type, RequestingDepartment department, int yearsOfExperience, string jobTitle, string jobDescription)
        {
            Contractype = type;
            RequestingDepartment = department;
            YearsOfExperience = yearsOfExperience;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
        }

        public Contractype Contractype { get; set; }

        public RequestingDepartment RequestingDepartment { get; set; }

        public int YearsOfExperience { get; set; }

        public string JobTitle { get; set; }

        public string JobDescription { get; set; }
    }

    public enum Contractype
    {
        FullTime,
        PartTime
    }

    public enum RequestingDepartment
    {
        Administration,
        Service,
        Production,
        Financial
    }
}
