namespace UserControlViews.Views;

public partial class NavigationView : UserControl
{
    private readonly BaseForm _parentForm;

    public NavigationView(BaseForm parentForm)
    {
        InitializeComponent(); 
        _parentForm = parentForm;
    }

    private void StandaViewButton_Click(object? sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Standa);
    }

    private void ZdarskyViewButton_Click(object? sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Zdarsky);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Bohata);
    }

    private void next_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Standa);
    }

    private void back_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Bohata);
    }
}