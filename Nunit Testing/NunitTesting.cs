﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Student;

namespace Nunit_Testing
{
    [TestFixture]
    public class NunitTesting
    {
        test.Student

        [Test]
        public void linearSearchTesting() 
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
