using DataTier;
using System.Collections.Generic;

namespace BusinessTier
{
    public class FinancialRequestController
    {
        public List<FinancialRequest> GetFinancialRequests()
        {
            return Seed.financialRequests;
        }

        public void AddFinancialRequest(RequestingDepartment department, Event reuqestedEvent, string ammountText, string reason, User user)
        {
            double ammount = double.Parse(ammountText);
            FinancialRequest financialRequest = new FinancialRequest(department, reuqestedEvent, ammount, reason, user);
            Seed.financialRequests.Add(financialRequest);
        }

        public void SolveFinancialRequest(FinancialRequest financialRequest, string choice)
        {
            financialRequest.Reviewed = true;
            switch (choice)
            {
                case "approve":
                    financialRequest.Result = true;
                    break;
                case "deny":
                    financialRequest.Result = false;
                    break;
                default:
                    financialRequest.Reviewed = false;
                    break;
            }
        }
    }
}
