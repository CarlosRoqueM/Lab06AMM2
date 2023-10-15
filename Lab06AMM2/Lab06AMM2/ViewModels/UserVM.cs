using Lab06AMM2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lab06AMM2.ViewModels
{
    public class UserVM
    {
        public ObservableCollection<UserGroupM> UserList { get; set; }

        public UserVM() 
        { 
            this.UserList = new ObservableCollection<UserGroupM>();

            var group1 = new List<UserM>
            {
                new UserM("Carlos", "Roque", 20),
                new UserM("Manuel", "Roque", 22)
            };
            UserList.Add(new UserGroupM("Seccion A", group1));

            var group2 = new List<UserM>
            {
                new UserM("Mauro", "Tapia", 23),
                new UserM("Jesus", "Ibarra", 21)
            };
            UserList.Add(new UserGroupM("Seccion B", group2));

            var group3 = new List<UserM>
            {
                new UserM("Julio", "Peña", 21),
                new UserM("Abel", "Garcia", 25)
            };
            UserList.Add(new UserGroupM("Seccion C", group3));
        }
    }
}
