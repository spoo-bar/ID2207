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

        public void AddFinancialRequest(RequestingDepartment department, Event reuqestedEvent, string ammountText, string reason)
        {
            double ammount = double.Parse(ammountText);
            FinancialRequest financialRequest = new FinancialRequest(department, reuqestedEvent, ammount, reason);
            Seed.financialRequests.Add(financialRequest);
        }

        public void SolveFinancialRequest(FinancialRequest financialRequest)
        {
            Seed.financialRequests.Remove(financialRequest);
        }
    }
}
