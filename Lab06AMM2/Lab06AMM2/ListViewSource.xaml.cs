﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06AMM2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }

        public ListViewSource()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Rob finnerty" });
            employees.Add(new Employee { DisplayName = "Bill Wrestler" });
            employees.Add(new Employee { DisplayName = "Dr. geri-Beth Hopper" });
            employees.Add(new Employee { DisplayName = "Dr. Keith Joyce.Purdy" });
            employees.Add(new Employee { DisplayName = "Sheri Spruce" });
            employees.Add(new Employee { DisplayName = "Burt Indybrick" });


        }

        public class Employee
        {
            public string DisplayName { get; set; }
        }


    }
}