using System.Diagnostics;

namespace MauiAppWebview;

public partial class NewPage : ContentPage
{
	public NewPage()
	{
        InitializeComponent();
        Debug.WriteLine("Constructor for NewPage()");
    }

    ~NewPage()
	{
        Debug.WriteLine("Finalizer for ~NewPage()");
    }
}