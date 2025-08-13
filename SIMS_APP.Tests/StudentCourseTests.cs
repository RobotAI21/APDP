using SIMS_APP.Models;
using Xunit;

public class StudentCourseTests
{
    [Fact] // Pass: Tạo StudentCourse hợp lệ
    public void Create_ValidStudentCourse_ShouldSucceed()
    {
        var sc = new StudentCourse { StudentId = 1, CourseId = 1 };
        Assert.Equal(1, sc.StudentId);
        Assert.Equal(1, sc.CourseId);
    }

    [Fact] // Pass: Grade có thể null
    public void Create_StudentCourseWithoutGrade_ShouldSucceed()
    {
        var sc = new StudentCourse { StudentId = 1, CourseId = 1 };
        Assert.Null(sc.Grade);
    }

    [Fact] // Pass: LetterGrade có thể null
    public void Create_StudentCourseWithoutLetterGrade_ShouldSucceed()
    {
        var sc = new StudentCourse { StudentId = 1, CourseId = 1 };
        Assert.Null(sc.LetterGrade);
    }

    [Fact] // Fail: Thiếu StudentId => Fail
    public void Create_StudentCourseWithoutStudentId_ShouldFail()
    {
        var sc = new StudentCourse { CourseId = 1 };
        Assert.True(sc.StudentId > 0); // Fail: mặc định 0
    }

    [Fact] // Fail: Thiếu CourseId => Fail
    public void Create_StudentCourseWithoutCourseId_ShouldFail()
    {
        var sc = new StudentCourse { StudentId = 1 };
        Assert.True(sc.CourseId > 0); // Fail: mặc định 0
    }
}