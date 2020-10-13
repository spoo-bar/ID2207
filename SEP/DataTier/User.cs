using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class User
    {
        private List<User> _subordinates = new List<User>();
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public void AddSubordinate(User subordinate)
        {
            _subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(User subordinate)
        {
            _subordinates.Remove(subordinate);
        }

        public List<User> Subordinates { get => _subordinates; }

        public override string ToString()
        {
            return Email;
        }
    }

    public enum Role
    {
        AdministrationDepartmentManager,
        SeniorCustomerServiceOfficer,
        CustomerService,
        FinancialManager,
        ProductionManager,
        Photographer,
        GraphicDesigner,
        ServicesDepartmentManager,
        TopChef,
        SeniorWaitress
    }
}
