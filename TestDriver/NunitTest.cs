using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestDriver
{
    [TestFixture]
    public class NunitTest
    {

        MyNunitSoln.Student student1;
        MyNunitSoln.Student student2;
        MyNunitSoln.Student student3;
        MyNunitSoln.Student student4;
        MyNunitSoln.Student student5;
        MyNunitSoln.Student student6;
        MyNunitSoln.Student student7;
        MyNunitSoln.Student student8;
        MyNunitSoln.Student student9;
        MyNunitSoln.Student student10;

        MyNunitSoln.Student[] students;

        [SetUp]
        public void Init()
        {
            student1 = new MyNunitSoln.Student("StudentName1",
                    "student1@example.com",
                    "123-456-7890",
                    new MyNunitSoln.Address(),
                    "Program1",
                    DateTime.Now,
                    1,
                    new MyNunitSoln.Enrollment());

            student2 = new MyNunitSoln.Student("StudentName2",
                    "student2@example.com",
                    "123-456-7891",
                    new MyNunitSoln.Address(),
                    "Program",
                    DateTime.Now,
                    2,
                    new MyNunitSoln.Enrollment());

            student3 = new MyNunitSoln.Student("StudentName3",
                    "student3@example.com",
                    "123-456-7892",
                    new MyNunitSoln.Address(),
                    "Program",
                    DateTime.Now,
                    3,
                    new MyNunitSoln.Enrollment());

            student4 = new MyNunitSoln.Student("StudentName4",
                    "student4@example.com",
                    "123-456-7893",
                    new MyNunitSoln.Address(),
                    "Program",
                    DateTime.Now,
                    4,
                    new MyNunitSoln.Enrollment());

            student5 = new MyNunitSoln.Student("StudentName5",
                    "student5@example.com",
                    "123-456-7894",
                    new MyNunitSoln.Address(),
                    "Program",
                    DateTime.Now,
                    5,
                    new MyNunitSoln.Enrollment());

            student6 = new MyNunitSoln.Student("StudentName6",
                    "student6@example.com",
                    "123-456-7895",
                    new MyNunitSoln.Address(),
                    "Program",
                    DateTime.Now,
                    6,
                    new MyNunitSoln.Enrollment());

            student7 = new MyNunitSoln.Student("StudentName7",
                    "student7@example.com",
                    "123-456-7896",
                    new MyNunitSoln.Address(),
                    "Program",
                    DateTime.Now,
                    7,
                    new MyNunitSoln.Enrollment());

            student8 = new MyNunitSoln.Student("StudentName8",
                    "student8@example.com",
                    "123-456-7897",
                    new MyNunitSoln.Address(),
                    "Program",
                    DateTime.Now,
                    8,
                    new MyNunitSoln.Enrollment());

            student9 = new MyNunitSoln.Student("StudentName9",
                    "student9@example.com",
                    "123-456-7898",
                    new MyNunitSoln.Address(),
                    "Program",
                    DateTime.Now,
                    9,
                    new MyNunitSoln.Enrollment());

            student10 = new MyNunitSoln.Student("StudentName10",
                    "student10@example.com",
                    "123-456-7899",
                    new MyNunitSoln.Address(),
                    "Program",
                    DateTime.Now,
                    10,
                    new MyNunitSoln.Enrollment());

            students = new MyNunitSoln.Student[10];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            students[3] = student4;
            students[4] = student5;
            students[5] = student6;
            students[6] = student7;
            students[7] = student8;
            students[8] = student9;
            students[9] = student10;
        }


        [Test]
        // 8.1.1
        public void testLinearSearch()
        {
            bool found = MyNunitSoln.Utility.LinearSeachOfObjectAsc(students, student3);
            Assert.IsTrue(found);
        }

        [Test]
        // 8.1.2
        public void testBinarySearch()
        {
            Array.Sort(students);
            int binarySearchResult = MyNunitSoln.Utility.BinarySearch(students, student3);
            Assert.AreEqual(binarySearchResult, 2);
            
        }

        [Test]
        // 8.1.3
        public void testBubbleSort() 
        {
            Array.Sort(students);
            int binarySearchResult = MyNunitSoln.Utility.BinarySearch(students, student3);
            Assert.AreEqual(binarySearchResult, 2);
        }


 

    }
}
