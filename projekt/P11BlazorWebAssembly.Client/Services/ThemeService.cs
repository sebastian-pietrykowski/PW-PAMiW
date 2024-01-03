using System.ComponentModel;
using System.Runtime.CompilerServices;


public class ThemeService : INotifyPropertyChanged
{
    public bool IsDarkMode { get; private set; } = false;

    private string _cssClass;
    public string CssClass
    {
        get => _cssClass;
        private set
        {
            if (_cssClass != value)
            {
                _cssClass = value;
                OnPropertyChanged();
            }
        }
    }

    public void SetThemeIsDark(bool isDarkMode)
    {
        IsDarkMode = isDarkMode;
        CssClass = IsDarkMode ? "dark-mode" : string.Empty;
    }

    public void SwitchTheme()
    {
        IsDarkMode = !IsDarkMode;
        CssClass = IsDarkMode ? "dark-mode" : string.Empty;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "IsDarkMode")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}