using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentApendixClasses
{
    sealed class Student : Person, IComparable<Student>, IComparable
    {
        //private string program;
        //private DateTime dateRegistered;
        //private int studentID;

        const string DEF_PROGRAM = "No program was registered";
        DateTime DEF_DATE_REGISTERED;
        const int DEF_STUDENTID = -1;

        public string StudentProgram { get; set; }
        public DateTime StudentDateRegistered { get; set; }
        public int StudentStudentID { get; set; }

        public Enrollment StudentEnrollment { get; set; }

        public Student() : base(DEF_NAME, DEF_EMAIL, DEF_TELNUM, null)
        {
            StudentProgram = DEF_PROGRAM;
            StudentDateRegistered = DEF_DATE_REGISTERED;
            StudentStudentID = DEF_STUDENTID;
            StudentEnrollment = new Enrollment();
        }

        public Student(string name, string email, string telNum, Address address, string program, DateTime dateRegistered, int studentID, Enrollment enrollment)
            : base(name, email, telNum, address)
        {
            StudentProgram = program;
            StudentDateRegistered = dateRegistered;
            StudentStudentID = studentID;
            StudentEnrollment = enrollment;
        }

        public static bool operator ==(Student x, Student y)
        {
            return object.Equals(x, y);
        }
        public static bool operator !=(Student x, Student y)
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
            Student rhs = obj as Student;
            return this.StudentStudentID == rhs.StudentStudentID;
        }

        public override int GetHashCode()
        {
            return StudentStudentID.GetHashCode();
        }


        public override string ToString()
        {
            return $"Name: {base.PersonName}, Email: {base.PersonEmail}, Telephone Number: {base.PersonTelNum}, Program: {StudentProgram}, Date Registered: {StudentDateRegistered}, Student ID: {StudentStudentID}, Address: {Address}, Enrollment: {StudentEnrollment}";
        }


        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (!(obj is Student))
                throw new ArgumentException("Expected Student instance", "obj");
            return CompareTo((Student)obj);
        }

        public int CompareTo(Student other)
        {
            return this.PersonName.CompareTo(other.PersonName);
        }
    }
}
