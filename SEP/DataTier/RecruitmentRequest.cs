using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class RecruitmentRequest
    {
        public Contractype Contractype { get; set; }

        public RequestingDepartment RequestingDepartment { get; set; }

        public string YearsOfExperience { get; set; }

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
