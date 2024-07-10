using TechnicalAxos_MarcosCasor.ViewModels;

namespace UnitTesting;

public class UnitTest1
{
    [Fact]
    public void Test_BundleId_IsSet()
    {
        var viewModel = new MainPageViewModel();
        Assert.Equal(AppInfo.PackageName, viewModel.BundleId);
    }

    [Fact]
    public async Task Test_Countries_AreLoaded()
    {
        var viewModel = new MainPageViewModel();
        await Task.Delay(2000); 
        Assert.NotEmpty(viewModel.Countries);
    }
}
