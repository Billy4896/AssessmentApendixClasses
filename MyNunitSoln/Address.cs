using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNunitSoln
{
    public class Address
    {
        //private int number;
        //private string street;
        //private string suburb;
        //private int postCode;
        //private string state;

        const int DEF_NUMBER = -1;
        const string DEF_STREET = "No street was provided";
        const string DEF_SUBURB = "No suburb was provided";
        const int DEF_POSTCODE = -1;
        const string DEF_STATE = "No state was provided";

        public int AddressNumber { get; set; }
        public string AddressStreet { get; set; }
        public string AddressSuburb { get; set; }
        public int AddresspostCode { get; set; }
        public string AddressState { get; set; }

        public Address() : this(DEF_NUMBER, DEF_STREET, DEF_SUBURB, DEF_POSTCODE, DEF_STATE) 
        {
            
        }

        public Address(int number, string street, string suburb, int postCode, string state) 
        {
            AddressNumber = number;
            AddressStreet = street;
            AddressSuburb = suburb;
            AddresspostCode = postCode;
            AddressState = state;
        }

        public static bool operator ==(Address x, Address y)
        {
            return object.Equals(x, y);
        }
        public static bool operator !=(Address x, Address y)
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
            Address rhs = obj as Address;
            return this.AddressNumber == rhs.AddressNumber && this.AddressStreet == rhs.AddressStreet && this.AddressSuburb == rhs.AddressSuburb && this.AddresspostCode == rhs.AddresspostCode && this.AddressState == rhs.AddressState;
        }

        public override string ToString()
        {
            return AddressNumber + AddressStreet + AddressSuburb + AddresspostCode + AddressState;
        }

    }


}
