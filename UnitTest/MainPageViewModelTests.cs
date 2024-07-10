using TechnicalAxos_MarcosCasor.ViewModels;

namespace UnitTest;

public class MainPageViewModelTests
{

    [Fact]
    public void Test_BundleId_IsSet()
    {
        var viewModel = new MainPageViewModel(true);
        Assert.Equal("TechnnicalAssesMent_MarcosCasor", viewModel.BundleId);
    }

    [Fact]
    public async Task Test_Countries_AreLoaded()
    {
        var viewModel = new MainPageViewModel(true);
        await Task.Delay(2000); 
        Assert.NotEmpty(viewModel.Countries);
    }

    
}