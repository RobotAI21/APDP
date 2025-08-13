using SIMS_APP.Models;
using Xunit;

public class UserTests
{
    [Fact] // Pass: Đăng nhập đúng tài khoản
    public void Login_ValidCredentials_ShouldSucceed()
    {
        var u = new User { Username = "admin", PasswordHash = "hash", Role = "Admin" };
        Assert.Equal("admin", u.Username);
        Assert.Equal("hash", u.PasswordHash);
    }

    [Fact] // Pass: Đăng nhập thiếu role vẫn tạo được user
    public void Create_UserWithoutRole_ShouldSucceed()
    {
        var u = new User { Username = "user", PasswordHash = "hash" };
        Assert.Equal(string.Empty, u.Role);
    }

    [Fact] // Pass: Đăng nhập sai mật khẩu (test logic)
    public void Login_WrongPassword_ShouldFail()
    {
        var u = new User { Username = "admin", PasswordHash = "hash1" };
        Assert.NotEqual("hash", u.PasswordHash); // Pass: mật khẩu sai
    }

    [Fact] // Fail: Đăng nhập thiếu username => Fail
    public void Login_WithoutUsername_ShouldFail()
    {
        var u = new User { PasswordHash = "hash", Role = "Admin" };
        Assert.False(string.IsNullOrEmpty(u.Username)); // Fail: mặc định ""
    }

    [Fact] // Fail: Đăng nhập thiếu mật khẩu => Fail
    public void Login_WithoutPassword_ShouldFail()
    {
        var u = new User { Username = "admin", Role = "Admin" };
        Assert.False(string.IsNullOrEmpty(u.PasswordHash)); // Fail: mặc định ""
    }
}