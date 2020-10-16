using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class FinancialRequestController
    {
        private static List<FinancialRequest> financialRequests = Seed.FinancialRequests;

        public FinancialRequestController()
        {

        }

        public List<FinancialRequest> GetFinancialRequests()
        {
            return financialRequests;
        }

        public void AddFinancialRequest(RequestingDepartment department, Event reuqestedEvent, string ammountText, string reason)
        {
            double ammount = double.Parse(ammountText);
            FinancialRequest financialRequest = new FinancialRequest(department, reuqestedEvent, ammount, reason);
            financialRequests.Add(financialRequest);
        }

        public void SolveFinancialRequest(FinancialRequest financialRequest)
        {
            financialRequests.Remove(financialRequest);
        }
    }
}
