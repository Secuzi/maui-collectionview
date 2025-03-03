using CollectionViewDemo.Models;

namespace CollectionViewDemo.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}