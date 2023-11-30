using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;



namespace NunitTestingFrameWork
{
    [TestFixture]
    public class NunitTesting
    {
        [Test]
        public void testLinearSearchOfObjectAsc() 
        {
            Student[] students = new Student[10];

            for (int i = 0; i < 10; i++)
            {
                students[i] = new Student(
                    "StudentName" + i,
                    "student@example.com",
                    "123-456-7890",
                    new Address(),
                    "Program",
                    DateTime.Now,
                    i,
                    new Enrollment()

                );
                Console.WriteLine(students[i].ToString());
            }

            Student studentToFind = new Student(
                    "StudentName3",
                    "student@example.com",
                    "123-456-7890",
                    new Address(),
                    "Program",
                    DateTime.Now,
                    3,
                    new Enrollment()
                );
        }
    }
}
