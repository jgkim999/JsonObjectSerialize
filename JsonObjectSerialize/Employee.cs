using System.Collections.Generic;

namespace JsonObjectSerialize
{
    public class Employee
    {
        public string firstName_;
        public string lastName_;
    }

    public class Boss
    {
        public int employeeId_;
        public string name_;
    }

    public class People
    {
        public List<object> object_;
    }
}
