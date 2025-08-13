using SIMS_APP.Models;
using Xunit;

public class ErrorViewModelTests
{
    [Fact] // Pass: RequestId null thì ShowRequestId false
    public void ShowRequestId_ShouldBeFalse_WhenRequestIdIsNull()
    {
        var e = new ErrorViewModel();
        Assert.False(e.ShowRequestId);
    }

    [Fact] // Pass: RequestId rỗng thì ShowRequestId false
    public void ShowRequestId_ShouldBeFalse_WhenRequestIdIsEmpty()
    {
        var e = new ErrorViewModel { RequestId = "" };
        Assert.False(e.ShowRequestId);
    }

    [Fact] // Pass: RequestId có giá trị thì ShowRequestId true
    public void ShowRequestId_ShouldBeTrue_WhenRequestIdIsNotEmpty()
    {
        var e = new ErrorViewModel { RequestId = "abc" };
        Assert.True(e.ShowRequestId);
    }

    [Fact] // Fail: RequestId null mà ShowRequestId true => Fail
    public void ShowRequestId_ShouldBeTrue_WhenRequestIdIsNull()
    {
        var e = new ErrorViewModel();
        Assert.True(e.ShowRequestId); // Fail: thực tế là False
    }

    [Fact] // Fail: RequestId có giá trị mà ShowRequestId false => Fail
    public void ShowRequestId_ShouldBeFalse_WhenRequestIdIsNotEmpty()
    {
        var e = new ErrorViewModel { RequestId = "abc" };
        Assert.False(e.ShowRequestId); // Fail: thực tế là True
    }
}