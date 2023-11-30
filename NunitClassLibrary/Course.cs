using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentApendixClasses
{
    class Course : IComparable<Course>, IComparable
    {
        //private int courseCode;
        //private string courseName;
        //private int cost;

        const int DEF_COURSECODE = -1;
        const string DEF_COURSENAME = "No course name was provided";
        const int DEF_COST = 1;

        public int CourseCourseCode { get; set; }
        public string CourseCourseName { get; set; }
        public int CourseCost { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        public Course() : this(DEF_COURSECODE, DEF_COURSENAME, DEF_COST) { }

        public Course(int courseCode, string courseName, int cost) 
        {
            CourseCourseCode = courseCode;
            CourseCourseName = courseName;
            CourseCost = cost;
            Enrollments = new List<Enrollment>();
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (!(obj is Course))
                throw new ArgumentException("Expected Course instance", "obj");
            return CompareTo((Course)obj);
        }

        public int CompareTo(Course other)
        {
            return this.CourseCourseName.CompareTo(other.CourseCourseName);
        }
    }
}
