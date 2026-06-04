using System.ComponentModel;

namespace SchoolApp.ViewModels;

public class Person : INotifyPropertyChanged
{
    private string _name = "Aida";
    private string _city = "Almaty";

    public string Name
    {
        get => _name;
        set
        {
            if (_name == value) return;

            _name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }

    public string City
    {
        get => _city;
        set
        {
            if (_city == value) return;

            _city = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(City)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}