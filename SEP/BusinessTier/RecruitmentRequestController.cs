using DataTier;
using System;
using System.Collections.Generic;

namespace BusinessTier
{
    public class RecruitmentRequestController
    {
        public RecruitmentRequest Create(Contractype contractype, RequestingDepartment requestingDepartment, string yearsOfExperience, string jobTitle, string jobDescription, User user)
        {
            if (string.IsNullOrEmpty(yearsOfExperience)) throw new ApplicationException("Years of experience for the job is not specified");
            if (string.IsNullOrEmpty(jobTitle)) throw new ApplicationException("Job Title is not specified");

            var recruitmentRequest = new RecruitmentRequest(contractype,
                requestingDepartment,
                int.Parse(yearsOfExperience),
                jobTitle,
                jobDescription,
                user);
            Seed.recruitmentRequests.Add(recruitmentRequest);
            return recruitmentRequest;
        }

        public void SolveRecruitmentRequest(RecruitmentRequest recruitmentRequest, string choice)
        {
            recruitmentRequest.Reviewed = true;
            switch (choice)
            {
                case "approve":
                    recruitmentRequest.Result = true;
                    break;
                case "deny":
                    recruitmentRequest.Result = false;
                    break;
                default:
                    recruitmentRequest.Reviewed = false;
                    break;
            }
        }

        public List<RecruitmentRequest> GetRecruitmentRequests()
        {
            return Seed.recruitmentRequests;
        }
    }
}
