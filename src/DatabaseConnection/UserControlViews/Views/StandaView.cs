namespace UserControlViews.Views;

public partial class StandaView : UserControl
{
    private readonly BaseForm _parentForm;

    public StandaView(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Navigation);
    }

    private void next_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Zdarsky);
    }

    private void back_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Navigation);
    }
}