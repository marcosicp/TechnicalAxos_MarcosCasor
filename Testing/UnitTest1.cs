using TechnicalAxos_MarcosCasor.ViewModels;

namespace Testing;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var viewModel = new MainPageViewModel();
        Assert.AreEqual(AppInfo.PackageName, viewModel.BundleId);
    }
}
