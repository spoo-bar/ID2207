using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class RecruitmentRequestController
    {
        public RecruitmentRequest Create(Contractype contractype, RequestingDepartment requestingDepartment, string yearsOfExperience, string jobTitle, string jobDescription)
        {
            if (string.IsNullOrEmpty(yearsOfExperience)) throw new ApplicationException("Years of experience for the job is not specified");
            if (string.IsNullOrEmpty(jobTitle)) throw new ApplicationException("Job Title is not specified");

            var recruitmentRequest = new RecruitmentRequest()
            {
                Contractype = contractype,
                RequestingDepartment = requestingDepartment,
                YearsOfExperience = yearsOfExperience,
                JobTitle = jobTitle,
                JobDescription = jobDescription
            };
            Seed.recruitmentRequests.Add(recruitmentRequest);
            return recruitmentRequest;
        }

        public List<RecruitmentRequest> GetRecruitmentRequests()
        {
            return Seed.recruitmentRequests;
        }
    }
}
