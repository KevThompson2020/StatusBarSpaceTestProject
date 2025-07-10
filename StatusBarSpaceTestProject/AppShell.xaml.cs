using StatusBarSpaceTestProject.Pages;

namespace StatusBarSpaceTestProject;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(SubPageOne), typeof(SubPageOne));
        Routing.RegisterRoute(nameof(SubPageTwo), typeof(SubPageTwo));
        
    }
}