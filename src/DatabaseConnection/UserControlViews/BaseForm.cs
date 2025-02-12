using UserControlViews.Views;

namespace UserControlViews;

public partial class BaseForm : Form
{
    private NavigationView _navigationView;
    private StandaView _standaView;
    private ZdarskyView _zdarskyView;
    private UserControl _currentView;
    public enum ViewType
    {
        Navigation,
        Standa,
        Zdarsky,
    }
    public BaseForm()
    {
        InitializeComponent();
        _navigationView = new NavigationView(this);
        _standaView = new StandaView(this);
        _zdarskyView = new ZdarskyView(this);
        SwitchView(ViewType.Navigation);
        
    }

    public void SwitchView(ViewType viewType)
    {
        Controls.Remove(_currentView);
        _currentView = viewType switch
        {
            ViewType.Navigation => _navigationView,
            ViewType.Standa => _standaView,
            ViewType.Zdarsky => _zdarskyView,
        };
        Controls.Add(_currentView);
    }
}