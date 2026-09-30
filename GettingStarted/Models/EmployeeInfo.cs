using System.Collections.ObjectModel;

namespace GettingStarted
{
    public class EmployeeInfo
    {
        private string? _firstName;
        private string? _lastName;
        private int? _empId;
        private double? _salary;
        private string? _title;
        internal double _hike = 5;
        private ObservableCollection<EmployeeInfo> _children = new ObservableCollection<EmployeeInfo>();

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string? FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string? LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// Gets or sets the emp ID.
        /// </summary>
        public int? EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        public double? Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string? Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Gets or sets the hike.
        /// </summary>
        public double Hike
        {
            get { return _hike; }
            set { _hike = value; }
        }

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        public ObservableCollection<EmployeeInfo> Children
        {
            get { return _children; }
            set { _children = value; }
        }
    }
}
