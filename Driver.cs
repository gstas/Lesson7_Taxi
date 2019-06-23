using System;

namespace Lesson7_Taxi
{
    class Driver
    {
        string name;
        string address;
        string phone;
        DateTime birthday;

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }

        public Driver(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public Driver(string name, string phone, string address, DateTime birthday) : this(name, phone)
        {
            Address = address;
            Birthday = birthday;
        }

        public Driver(Driver oldDriver)
        {
            this.Name = oldDriver.Name;
            this.Address = oldDriver.Address;
            this.Phone = oldDriver.Phone;
            this.Birthday = oldDriver.Birthday;
        }

        public override string ToString()
        {
            return $"{Name}" + (Birthday != DateTime.MinValue ? " (" + Birthday.ToShortDateString() + ")" : "") +
                $", tel: {Phone}" + (Address != null && Address != "" ? "\n"+Address : "");
        }

        public bool FindByName(string name)
        {
            return (Name.ToUpper().Contains(name.ToUpper()));
        }
    }
}
