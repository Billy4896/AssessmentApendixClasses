using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNunitSoln
{
    public class Enrollment
    {
        //private string dateEnrolled;
        //private string grade;
        //private int semester;

        const string DEF_DATEENROLLED = "No enrollment date was recorded";
        const string DEF_GRADE = "No grade was provided";
        const int DEF_SEMESTER = -1;

        public string EnrollmentDateEnrolled { get; set; }
        public string EnrollmentGrade { get; set; }
        public int EnrollmentSemester { get; set; }

        public Enrollment() : this(DEF_DATEENROLLED, DEF_GRADE, DEF_SEMESTER) { }
        
        public Enrollment(string dateEnrolled, string grade, int semester) 
        {
            EnrollmentDateEnrolled = dateEnrolled;
            EnrollmentGrade = grade;
            EnrollmentSemester = semester;
        }

        public static bool operator ==(Enrollment x, Enrollment y)
        {
            return object.Equals(x, y);
        }
        public static bool operator !=(Enrollment x, Enrollment y)
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
            Enrollment rhs = obj as Enrollment;
            return this.EnrollmentDateEnrolled == rhs.EnrollmentDateEnrolled && this.EnrollmentGrade == rhs.EnrollmentGrade && this.EnrollmentSemester == rhs.EnrollmentSemester;
        }

        public override string ToString()
        {
            return EnrollmentDateEnrolled + EnrollmentGrade + EnrollmentSemester;
        }
    }
}
