namespace UserControlViews.Views;

public partial class BohataView : UserControl
{
    private readonly BaseForm _parentForm;
    public BohataView(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Navigation);
    }

    private void back_Click(object sender, EventArgs e)
    {
       _parentForm.SwitchView(BaseForm.ViewType.Zdarsky);
    }

    private void Next_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchView(BaseForm.ViewType.Navigation);
    }
}