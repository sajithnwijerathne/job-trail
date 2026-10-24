using JobTrail.App.ViewModels;

namespace JobTrail.Tests;

public class MainViewModelTests
{
    [Fact]
    public void Loads_sample_applications()
    {
        var vm = new MainViewModel();

        Assert.NotEmpty(vm.Applications);
    }

    [Fact]
    public void Selects_first_application_on_start()
    {
        var vm = new MainViewModel();

        Assert.Same(vm.Applications[0], vm.SelectedApplication);
    }

    [Fact]
    public void Raises_PropertyChanged_when_selection_changes()
    {
        var vm = new MainViewModel();
        string? changed = null;
        vm.PropertyChanged += (_, e) => changed = e.PropertyName;

        vm.SelectedApplication = vm.Applications[1];

        Assert.Equal(nameof(MainViewModel.SelectedApplication), changed);
    }
}