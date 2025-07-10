using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusBarSpaceTestProject.Pages;

public partial class SubPageOne : ContentPage
{
    public SubPageOne()
    {
        InitializeComponent();
    }
    
    private async void OnClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SubPageTwo));   
    }
}