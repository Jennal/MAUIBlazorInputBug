using Microsoft.AspNetCore.Components.WebView;

namespace RepoMAUIBlazorInputBug;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        
        blazorWebView.UrlLoading -= BlazorWebView_UrlLoading;
        blazorWebView.UrlLoading += BlazorWebView_UrlLoading;
    }

    private void BlazorWebView_UrlLoading(object sender, UrlLoadingEventArgs e)
    {
        e.UrlLoadingStrategy = UrlLoadingStrategy.OpenInWebView;
    }
}