# Getting Started with .NET MAUI TreeGrid

This section provides a quick overview for working with the .NET MAUI TreeGrid. Walk through the entire process of creating a real world of this control.

## Creating an application using the .NET MAUI TreeGrid
 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfTreeGrid to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.TreeGrid and then install it.
 3. Import the control namespace `Syncfusion.Maui.TreeGrid` in XAML or C# code.
 4. Initialize the [SfTreeGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html) control.

 

```xml
<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid">

    <syncfusion:SfTreeGrid />
</ContentPage>
```

```C#
using Syncfusion.Maui.TreeGrid;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeGrid treeGrid = new SfTreeGrid();
        this.Content = treeGrid;
    }
}
```

## Register the handler

To use this control inside an application, you must initialize the `SfTreeGrid` handler.

```C#

using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace GettingStarted
{
    public class MauiProgram 
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

           builder.ConfigureSyncfusionCore();
           return builder.Build();
        }
    }
}
```


## Create DataModel for the SfTreeGrid

The SfTreeGrid is a data-bound control. Hence, a data model should be created to bind it to the control. 

Create a simple data source as shown in the following code example in a new class file, and save it as EmployeeInfo.cs file:

```C#
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
```

> **_NOTE:_** If you want your data model to respond to property changes, implement the `INotifyPropertyChanged` interface in your model class.

Create a model repository class with EmployeeInfo collection property initialized with the required number of data objects in a new class file as shown in the following code example and save it as EmployeeInfoViewModel.cs file:

```C#
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
```

## Binding data to the SfTreeGrid

To bind the data source to the SfTreeGrid, set the [SfTreeGrid.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSource) property as follows. You can bind the data source of the SfTreeGrid either from XAML or in code. 

The following code example binds the collection created in the previous step to the `SfTreeGrid.ItemsSource` property:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid"
              xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
        <local:EmployeeInfoViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfTreeGrid x:Name = "treeGrid"
                               ItemsSource = "{Binding PersonDetails}"
                               ChildPropertyName = "Children"> 
        </syncfusion:SfTreeGrid>
    </ContentPage.Content>
</ContentPage>
```
```C#
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
this.Content = treeGrid;
```

Run the application to render the following output:
<img src="net-maui-treegrid-getting-started.png" alt="Getting started with .NET MAUI Tree Grid" width="567">