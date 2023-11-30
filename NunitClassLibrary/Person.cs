using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentApendixClasses
{
    class Person
    {
        //private string name;
        //private string email;
        //private string telNum;

        public const string DEF_NAME = "No name was provided";
        public const string DEF_EMAIL = "No email was provided";
        public const string DEF_TELNUM = "No telephone number was provided";

        public string PersonName { get; set; }
        public string PersonEmail { get; set; }
        public string PersonTelNum { get; set; }

        public Address Address { get; set; }

        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_TELNUM, null) 
        {
            
        }

        public Person(string name, string email, string telNum, Address address) 
        {
            PersonName = name;
            PersonEmail = email;
            PersonTelNum = telNum;
            Address = address;
        }

        public static bool operator == (Person x, Person y){
            return object.Equals(x, y);
        }
        public static bool operator !=(Person x, Person y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Person rhs = obj as Person;
            return this.PersonName == rhs.PersonName && this.PersonEmail == rhs.PersonEmail && this.PersonTelNum == rhs.PersonTelNum;
        }

        public override string ToString()
        {
            return PersonName + PersonEmail + PersonTelNum + Address;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
