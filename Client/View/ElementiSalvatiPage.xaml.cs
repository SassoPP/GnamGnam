using Microsoft.Maui.Controls;
using Client.Controller;

namespace Client.View;

public partial class ElementiSalvatiPage : ContentPage
{
	public ElementiSalvatiPage()
	{
        BindingContext = new ElementiSalvatiController();
        InitializeComponent();
	}
}