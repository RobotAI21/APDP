using System;
using System.Collections.Generic;
using SIMS_APP.Models;
using Xunit;

namespace SIMS_APP.Tests
{
    public class ModelsTests
    {
        // --- Course Tests ---
        [Fact]
        public void Course_DefaultCredits_ShouldBeZero()
        {
            var course = new Course();
            Assert.Equal(0, course.Credits); // Fail: default is 0, but [Range(1,10)]
        }

        [Fact]
        public void Course_Name_ShouldNotBeNull()
        {
            var course = new Course();
            Assert.NotNull(course.Name); // Pass
        }

        [Fact]
        public void Course_Code_ShouldBeEmptyByDefault()
        {
            var course = new Course();
            Assert.Equal(string.Empty, course.Code); // Pass
        }

        [Fact]
        public void Course_Description_CanBeNull()
        {
            var course = new Course();
            Assert.Null(course.Description); // Fail: default is null, but property is nullable
        }

        [Fact]
        public void Course_StudentCourses_EmptyOnInit()
        {
            var course = new Course();
            Assert.Empty(course.StudentCourses); // Pass
        }

        // --- Student Tests ---
        [Fact]
        public void Student_Email_ShouldBeEmptyByDefault()
        {
            var student = new Student();
            Assert.Equal(string.Empty, student.Email); // Pass
        }

        [Fact]
        public void Student_PhoneNumber_CanBeNull()
        {
            var student = new Student();
            Assert.Null(student.PhoneNumber); // Pass
        }

        [Fact]
        public void Student_User_ShouldNotBeNull()
        {
            var student = new Student();
            Assert.NotNull(student.User); // Pass
        }

        [Fact]
        public void Student_StudentId_ShouldBeEmptyByDefault()
        {
            var student = new Student();
            Assert.Equal(string.Empty, student.StudentId); // Pass
        }

        [Fact]
        public void Student_StudentCourses_EmptyOnInit()
        {
            var student = new Student();
            Assert.Empty(student.StudentCourses); // Pass
        }

        // --- Teacher Tests ---
        [Fact]
        public void Teacher_Email_ShouldBeEmptyByDefault()
        {
            var teacher = new Teacher();
            Assert.Equal(string.Empty, teacher.Email); // Pass
        }

        [Fact]
        public void Teacher_PhoneNumber_CanBeNull()
        {
            var teacher = new Teacher();
            Assert.Null(teacher.PhoneNumber); // Pass
        }

        [Fact]
        public void Teacher_User_ShouldNotBeNull()
        {
            var teacher = new Teacher();
            Assert.NotNull(teacher.User); // Pass
        }

        [Fact]
        public void Teacher_TeacherId_ShouldBeEmptyByDefault()
        {
            var teacher = new Teacher();
            Assert.Equal(string.Empty, teacher.TeacherId); // Pass
        }

        [Fact]
        public void Teacher_Courses_EmptyOnInit()
        {
            var teacher = new Teacher();
            Assert.Empty(teacher.Courses); // Pass
        }

        // --- User Tests ---
        [Fact]
        public void User_Username_ShouldBeEmptyByDefault()
        {
            var user = new User();
            Assert.Equal(string.Empty, user.Username); // Pass
        }

        [Fact]
        public void User_PasswordHash_ShouldBeEmptyByDefault()
        {
            var user = new User();
            Assert.Equal(string.Empty, user.PasswordHash); // Pass
        }

        [Fact]
        public void User_Role_ShouldBeEmptyByDefault()
        {
            var user = new User();
            Assert.Equal(string.Empty, user.Role); // Pass
        }

        [Fact]
        public void User_Student_ShouldBeNullByDefault()
        {
            var user = new User();
            Assert.Null(user.Student); // Pass
        }

        [Fact]
        public void User_Teacher_ShouldBeNullByDefault()
        {
            var user = new User();
            Assert.Null(user.Teacher); // Pass
        }
    }
}