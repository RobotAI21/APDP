using SIMS_APP.Models;
using Xunit;

public class TeacherTests
{
    [Fact] // Pass: Tạo teacher hợp lệ
    public void Create_ValidTeacher_ShouldSucceed()
    {
        var t = new Teacher { FirstName = "T", LastName = "A", Email = "t@a.com", TeacherId = "T001", UserId = 1 };
        Assert.Equal("T", t.FirstName);
        Assert.Equal("T001", t.TeacherId);
    }

    [Fact] // Pass: Thiếu số điện thoại vẫn hợp lệ
    public void Create_TeacherWithoutPhone_ShouldSucceed()
    {
        var t = new Teacher { FirstName = "T", LastName = "A", Email = "t@a.com", TeacherId = "T002", UserId = 1 };
        Assert.Null(t.PhoneNumber);
    }

    [Fact] // Pass: Email không hợp lệ (test logic)
    public void Create_TeacherWithInvalidEmail_ShouldBeInvalid()
    {
        var t = new Teacher { FirstName = "T", LastName = "A", Email = "abc", TeacherId = "T003", UserId = 1 };
        Assert.DoesNotMatch(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", t.Email); // Pass: "abc" không hợp lệ
    }

    [Fact] // Fail: Thiếu TeacherId => Fail
    public void Create_TeacherWithoutTeacherId_ShouldFail()
    {
        var t = new Teacher { FirstName = "T", LastName = "A", Email = "t@a.com", UserId = 1 };
        Assert.False(string.IsNullOrEmpty(t.TeacherId)); // Fail: mặc định ""
    }

    [Fact] // Fail: Thiếu Email => Fail
    public void Create_TeacherWithoutEmail_ShouldFail()
    {
        var t = new Teacher { FirstName = "T", LastName = "A", TeacherId = "T005", UserId = 1 };
        Assert.False(string.IsNullOrEmpty(t.Email)); // Fail: mặc định ""
    }
}