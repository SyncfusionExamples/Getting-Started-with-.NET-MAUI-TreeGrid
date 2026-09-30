using System.Collections.ObjectModel;

namespace GettingStarted
{
    public class EmployeeInfoViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeInfoViewModel"/> class.
        /// </summary>

        #region Constructor

        public EmployeeInfoViewModel()
        {
            this.PersonDetails = this.CreateEmployeeData();
        }

        #endregion


        #region Properties

        private ObservableCollection<EmployeeInfo> _personDetails = new ObservableCollection<EmployeeInfo>();

        /// <summary>
        /// Gets or sets the person details.
        /// </summary>
        /// <value>The person details.</value>
        public ObservableCollection<EmployeeInfo> PersonDetails
        {
            get { return _personDetails; }
            set { _personDetails = value; }
        }

        #endregion

        private ObservableCollection<EmployeeInfo> CreateEmployeeData()
        {
            //Management
            var childCollection1 = new ObservableCollection<EmployeeInfo>();
            childCollection1.Add(new EmployeeInfo() { FirstName = "Robert", LastName = "Fuller", EmpId = 1008, Salary = 120000, Title = "Design Engineer", Hike = 13 });
            childCollection1.Add(new EmployeeInfo() { FirstName = "Janet", LastName = "Leverling", EmpId = 1009, Salary = 100000, Title = "Engineering Manager", Hike = 10 });
            childCollection1.Add(new EmployeeInfo() { FirstName = "Steven", LastName = "Buchanan", EmpId = 1010, Salary = 35000, Title = "Business Manager", Hike = 7 });

            // Accounts
            var childCollection2 = new ObservableCollection<EmployeeInfo>();
            childCollection2.Add(new EmployeeInfo() { FirstName = "Nancy", LastName = "Davolio", EmpId = 1011, Salary = 85000, Title = "Accounts Supervisor", Hike = 12 });
            childCollection2.Add(new EmployeeInfo() { FirstName = "Margaret", LastName = "Peacock", EmpId = 1012, Salary = 32000, Title = "Accounts Representative", Hike = 5 });
            childCollection2.Add(new EmployeeInfo() { FirstName = "Michael", LastName = "Suyama", EmpId = 1013, Salary = 70000, Title = "Accounts Coordinator", Hike = 11 });
            childCollection2.Add(new EmployeeInfo() { FirstName = "Andrew", LastName = "King", EmpId = 1014, Salary = 45000, Title = "Accountant", Hike = 8 });

            // Sales
            var childCollection3 = new ObservableCollection<EmployeeInfo>();
            childCollection3.Add(new EmployeeInfo() { FirstName = "Simob", LastName = "Callahan", EmpId = 1015, Salary = 90000, Title = "Sales Representative", Hike = 14 });
            childCollection3.Add(new EmployeeInfo() { FirstName = "Anne", LastName = "Dodsworth", EmpId = 1016, Salary = 80000, Title = "Sales Coordinator", Hike = 10 });
            childCollection3.Add(new EmployeeInfo() { FirstName = "Albert", LastName = "Hellstern", EmpId = 1017, Salary = 75000, Title = "Sales Representative", Hike = 12 });
            childCollection3.Add(new EmployeeInfo() { FirstName = "Seves", LastName = "Smith", EmpId = 1018, Salary = 40000, Title = "Inside Sales Coordinator", Hike = 7 });

            childCollection3.Add(new EmployeeInfo() { FirstName = "Justin", LastName = "Brid", EmpId = 1019, Salary = 70000, Title = "Sales Supervisor", Hike = 11 });

            // Marketing
            var childCollection4 = new ObservableCollection<EmployeeInfo>();
            childCollection4.Add(new EmployeeInfo() { FirstName = "Caroline", LastName = "Patterson", EmpId = 1020, Salary = 80000, Title = "Marketing Director", Hike = 13 });
            childCollection4.Add(new EmployeeInfo() { FirstName = "Hill", LastName = "Martin", EmpId = 1021, Salary = 38000, Title = "Marketing Associate", Hike = 6 });

            // HR
            var childCollection5 = new ObservableCollection<EmployeeInfo>();
            childCollection5.Add(new EmployeeInfo() { FirstName = "Albert", LastName = "Pereira", EmpId = 1022, Salary = 90000, Title = "HR Coordinator", Hike = 14 });
            childCollection5.Add(new EmployeeInfo() { FirstName = "Hawkin", LastName = "Abbas", EmpId = 1023, Salary = 42000, Title = "HR Assistant", Hike = 9 });
            childCollection5.Add(new EmployeeInfo() { FirstName = "Amy", LastName = "Alberts", EmpId = 1024, Salary = 65000, Title = "HR Assistant", Hike = 11 });

            //Purchasing
            var childCollection6 = new ObservableCollection<EmployeeInfo>();
            childCollection6.Add(new EmployeeInfo() { FirstName = "Simon", LastName = "Ansman-Wolfe", EmpId = 1025, Salary = 60000, Title = "Advertising Director", Hike = 10 });
            childCollection6.Add(new EmployeeInfo() { FirstName = "Michael", LastName = "Blythe", EmpId = 1026, Salary = 35000, Title = "Advertising Coordinator", Hike = 5 });
            childCollection6.Add(new EmployeeInfo() { FirstName = "Seves", LastName = "Campbell", EmpId = 1027, Salary = 45000, Title = "Advertising Specialist", Hike = 8 });

            //Production
            var childCollection7 = new ObservableCollection<EmployeeInfo>();
            childCollection7.Add(new EmployeeInfo() { FirstName = "Janet", LastName = "Carson", EmpId = 1028, Salary = 60000, Title = "Production Supervisor", Hike = 12 });
            childCollection7.Add(new EmployeeInfo() { FirstName = "Caroline", LastName = "Ito", EmpId = 1029, Salary = 38000, Title = "Production Technician", Hike = 6 });
            childCollection7.Add(new EmployeeInfo() { FirstName = "Steven", LastName = "Jiang", EmpId = 1030, Salary = 45000, Title = "Production Control Manager", Hike = 9 });

            //Manager
            var employeeList = new ObservableCollection<EmployeeInfo>();
            employeeList.Add(new EmployeeInfo() { FirstName = "Sean", LastName = "Jacobson", EmpId = 1001, Salary = 200000, Title = "General Manager", Hike = 15, Children = childCollection1 });
            employeeList.Add(new EmployeeInfo() { FirstName = "Phyllis", LastName = "Allen", EmpId = 1002, Salary = 45000, Title = "Accounts Manager", Hike = 8, Children = childCollection2 });
            employeeList.Add(new EmployeeInfo() { FirstName = "Oscar", LastName = "Alpuerto", EmpId = 1003, Salary = 150000, Title = "Sales Manager", Hike = 12, Children = childCollection3 });
            employeeList.Add(new EmployeeInfo() { FirstName = "Maxwell", LastName = "Amland", EmpId = 1004, Salary = 40000, Title = "Marketing Manager", Hike = 6, Children = childCollection4 });
            employeeList.Add(new EmployeeInfo() { FirstName = "Emiliya", LastName = "Alvaro", EmpId = 1005, Salary = 135000, Title = "Human Resources Manager", Hike = 11, Children = childCollection5 });
            employeeList.Add(new EmployeeInfo() { FirstName = "Carla", LastName = "Adams", EmpId = 1006, Salary = 125000, Title = "Advertising Manager", Hike = 14, Children = childCollection6 });
            employeeList.Add(new EmployeeInfo() { FirstName = "John", LastName = "Ault", EmpId = 1007, Salary = 55000, Title = "Production Manager", Hike = 9, Children = childCollection7 });

            return employeeList;
        }
    }
}