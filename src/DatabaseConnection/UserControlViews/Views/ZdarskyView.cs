namespace UserControlViews.Views;

public partial class ZdarskyView : UserControl
{
    private readonly BaseForm _parentForm;

    public ZdarskyView(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Navigation);
    }
}