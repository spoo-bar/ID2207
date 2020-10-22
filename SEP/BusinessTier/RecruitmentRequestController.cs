using DataTier;
using System;
using System.Collections.Generic;

namespace BusinessTier
{
    public class RecruitmentRequestController
    {
        public RecruitmentRequest Create(Contractype contractype, RequestingDepartment requestingDepartment, string yearsOfExperience, string jobTitle, string jobDescription)
        {
            if (string.IsNullOrEmpty(yearsOfExperience)) throw new ApplicationException("Years of experience for the job is not specified");
            if (string.IsNullOrEmpty(jobTitle)) throw new ApplicationException("Job Title is not specified");

            var recruitmentRequest = new RecruitmentRequest(contractype,
                requestingDepartment,
                int.Parse(yearsOfExperience),
                jobTitle,
                jobDescription);
            Seed.recruitmentRequests.Add(recruitmentRequest);
            return recruitmentRequest;
        }

        public List<RecruitmentRequest> GetRecruitmentRequests()
        {
            return Seed.recruitmentRequests;
        }
    }
}
