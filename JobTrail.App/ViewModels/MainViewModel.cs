using System.Collections.ObjectModel;
using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;
using JobTrail.App.Models;

namespace JobTrail.App.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        Applications = new ObservableCollection<JobApplication>(SampleData.Applications);
        SelectedApplication = Applications.Count > 0 ? Applications[0] : null;
    }

    public ObservableCollection<JobApplication> Applications { get; set; }

    [ObservableProperty]
    public partial JobApplication? SelectedApplication { get; set; }
}
