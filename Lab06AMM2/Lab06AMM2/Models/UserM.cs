using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06AMM2.Models
{
    public class UserM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public UserM(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }

    public class UserGroupM : List<UserM>
    {
        public string GroupName { get; private set; }

        public UserGroupM(string groupName, List<UserM> source) : base(source)
        {
            GroupName = groupName;
        }
    }
}
