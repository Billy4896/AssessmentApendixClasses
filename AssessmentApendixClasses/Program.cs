using System;

namespace AssessmentApendixClasses
{
    class Program
    {   
        static void Main(string[] args)
        {
            // Part 3
            // Generate 10 Student objects.
            Console.WriteLine("Generating student objects...");

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

            Console.WriteLine(studentToFind.ToString());

            Console.WriteLine("\n Linear Search Algorithm commencing...");

            bool found = Utility.LinearSeachOfObjectAsc(students, studentToFind);

            if (found)
            {
                Console.WriteLine("Student found in the array.");
            }
            else
            {
                Console.WriteLine("Student not found in the array.");
            }

            Console.WriteLine("\n Bubble Sort Algorithm commencing...");

            Utility.BubbleSort(students);

            foreach (Student student in students)
            {
                Console.WriteLine(student + " ");
            }



            Console.WriteLine("\n Bubble Sort Algorithm Desc commencing...");

            Utility.BubbleSortDescending(students);

            foreach (Student student in students)
            {
                Console.WriteLine(student + " ");
            }




            // Part 4
            // Students
            Console.WriteLine("\n BinarySearch commencing...");

            Array.Sort(students);

            int binarySearchResult = Utility.BinarySearch(students, studentToFind);
            

            if (binarySearchResult != -1)
            {
                Console.WriteLine($"Student found at index {binarySearchResult} using binary search.");
            }
            else
            {
                Console.WriteLine("Student not found using binary search.");
            }

            Console.WriteLine("\n sequentialSearch commencing...");

            int sequentialSearchResult = Utility.SequentialSearch(students, studentToFind);
            if (sequentialSearchResult != -1)
            {
                Console.WriteLine($"Student found at index {sequentialSearchResult} using sequential search.");
            }
            else
            {
                Console.WriteLine("Student not found using sequential search.");
            }

            // Courses
            Console.WriteLine("\n Generating Course objects...");

            Course[] courses = new Course[10];

            for (int i = 0; i < 10; i++)
            {
                courses[i] = new Course(i, "Course" + i, i);
                Console.WriteLine(courses[i].ToString());
            }

            Course courseToFind = new Course(4, "Course" + 4, 4);

            Console.WriteLine(studentToFind.ToString());

            Console.WriteLine("\n BinarySearch commencing...");

            int binarySearchResult2 = Utility.BinarySearch(courses, courseToFind);


            if (binarySearchResult2 != -1)
            {
                Console.WriteLine($"Course found at index {binarySearchResult2} using binary search.");
            }
            else
            {
                Console.WriteLine("Course not found using binary search.");
            }

            Console.WriteLine("\n sequentialSearch commencing...");

            int sequentialSearchResult2 = Utility.SequentialSearch(courses, courseToFind);
            if (sequentialSearchResult2 != -1)
            {
                Console.WriteLine($"Course found at index {sequentialSearchResult2} using sequential search.");
            }
            else
            {
                Console.WriteLine("Course not found using sequential search.");
            }

            // PART 1
            Student student1 = new Student("StudentName" + 1, "student1@example.com", "123-456-7890", new Address(), "Program", DateTime.Now, 1, new Enrollment());
            Student student2 = new Student("StudentName" + 2, "student2@example.com", "123-456-7890", new Address(), "Program", DateTime.Now, 2, new Enrollment());
            Student student3 = new Student("StudentName" + 3, "student3@example.com", "123-456-7890", new Address(), "Program", DateTime.Now, 3, new Enrollment());
            Student student4 = new Student("StudentName" + 4, "student4@example.com", "123-456-7890", new Address(), "Program", DateTime.Now, 4, new Enrollment());
            Student student5 = new Student("StudentName" + 5, "student5@example.com", "123-456-7890", new Address(), "Program", DateTime.Now, 5, new Enrollment());
            Student student6 = new Student("StudentName" + 6, "student6@example.com", "123-456-7890", new Address(), "Program", DateTime.Now, 6, new Enrollment());
            Student student7 = new Student("StudentName" + 7, "student7@example.com", "123-456-7890", new Address(), "Program", DateTime.Now, 7, new Enrollment());

            DoublyLinkedList<Student> studentList = new DoublyLinkedList<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);

            Console.WriteLine("\n Inital studentList");

            foreach (Student student in studentList)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n Addlast four more students to the end of the studentList");

            studentList.AddLast(student4);
            studentList.AddLast(student5);
            studentList.AddLast(student6);
            studentList.AddLast(student7);

            foreach (Student student in studentList)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n Double linked list contains check");

            bool studentFound = studentList.Contains(student6);

            if (studentFound) 
            {
                Console.WriteLine("\n" + student6.StudentStudentID + " " + "was found in the studentList");
            }
            else 
            {
                Console.WriteLine("\n" + student6.StudentStudentID + " " + "wasn't found in the studentList");
            }

            Console.WriteLine("\n Remove a student from the start of the list");

            studentList.RemoveFirst();
            Console.WriteLine("\nAfter removing the first item:");
            foreach (Student student in studentList)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n Remove a student from the end of the list");
            studentList.RemoveLast();
            Console.WriteLine("\nAfter removing the last item:");
            foreach (Student student in studentList)
            {
                Console.WriteLine(student);
            }

            // 1.2
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(student1.StudentStudentID);
            binaryTree.Add(student2.StudentStudentID);
            binaryTree.Add(student7.StudentStudentID);
            binaryTree.Add(student6.StudentStudentID);
            binaryTree.Add(student5.StudentStudentID);
            binaryTree.Add(student4.StudentStudentID);
            binaryTree.Add(student3.StudentStudentID);

            Node node = binaryTree.Find(student7.StudentStudentID);
            //int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("\nPreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);

            Console.WriteLine("\nInOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);

            Console.WriteLine("\nPostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);

            binaryTree.Remove(student6.StudentStudentID);
            binaryTree.Remove(student5.StudentStudentID);

            Console.WriteLine("\nPreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
