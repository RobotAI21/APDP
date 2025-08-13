using SIMS_APP.Models;
using Xunit;

public class StudentTests
{
    [Fact] // Pass: Tạo student hợp lệ
    public void Create_ValidStudent_ShouldSucceed()
    {
        var s = new Student { FirstName = "A", LastName = "B", Email = "a@b.com", StudentId = "S001", UserId = 1 };
        Assert.Equal("A", s.FirstName);
        Assert.Equal("B", s.LastName);
        Assert.Equal("a@b.com", s.Email);
    }

    [Fact] // Pass: Thiếu số điện thoại vẫn hợp lệ
    public void Create_StudentWithoutPhone_ShouldSucceed()
    {
        var s = new Student { FirstName = "A", LastName = "B", Email = "a@b.com", StudentId = "S002", UserId = 1 };
        Assert.Null(s.PhoneNumber);
    }

    [Fact] // Pass: Email không hợp lệ (test logic)
    public void Create_StudentWithInvalidEmail_ShouldBeInvalid()
    {
        var s = new Student { FirstName = "A", LastName = "B", Email = "abc", StudentId = "S003", UserId = 1 };
        Assert.DoesNotMatch(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", s.Email); // Pass: "abc" không hợp lệ
    }

    [Fact] // Fail: Thiếu FirstName => Fail
    public void Create_StudentWithoutFirstName_ShouldFail()
    {
        var s = new Student { LastName = "B", Email = "a@b.com", StudentId = "S004", UserId = 1 };
        Assert.False(string.IsNullOrEmpty(s.FirstName)); // Fail: mặc định ""
    }

    [Fact] // Fail: Thiếu Email => Fail
    public void Create_StudentWithoutEmail_ShouldFail()
    {
        var s = new Student { FirstName = "A", LastName = "B", StudentId = "S005", UserId = 1 };
        Assert.False(string.IsNullOrEmpty(s.Email)); // Fail: mặc định ""
    }
}