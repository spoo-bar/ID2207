using System.ComponentModel;

namespace DataTier
{
    public class RecruitmentRequest
    {
        public RecruitmentRequest(Contractype type, RequestingDepartment department, int yearsOfExperience, string jobTitle, string jobDescription, User user)
        {
            Contractype = type;
            RequestingDepartment = department;
            YearsOfExperience = yearsOfExperience;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            User = user;
        }

        public Contractype Contractype { get; set; }

        public RequestingDepartment RequestingDepartment { get; set; }

        public int YearsOfExperience { get; set; }

        public string JobTitle { get; set; }

        public string JobDescription { get; set; }

        public User User { get; }

        [Browsable(false)]
        public bool Reviewed { get; set; }

        public bool Result { get; set; }
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
