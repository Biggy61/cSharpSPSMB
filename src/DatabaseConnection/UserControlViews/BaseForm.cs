using UserControlViews.Views;

namespace UserControlViews;

public partial class BaseForm : Form
{
    public List<UserControl> ViewList = new List<UserControl>();
    private NavigationView _navigationView;
    private StandaView _standaView;
    private ZdarskyView _zdarskyView;
    private BohataView _bohataView;
    private UserControl _currentView;
    private NameViews _nameViews;
    public enum ViewType
    {
        Navigation,
        Standa,
        Zdarsky,
        Bohata,
        Pepa,
        Lukas,
    }
    public BaseForm()
    {
        InitializeComponent();
        _navigationView = new NavigationView(this);
        _standaView = new StandaView(this);
        _zdarskyView = new ZdarskyView(this);
        _bohataView = new BohataView(this);
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
            ViewType.Bohata => _bohataView,
        };
        Controls.Add(_currentView);
    }
}