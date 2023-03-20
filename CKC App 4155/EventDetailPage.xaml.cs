using CKC_App_4155.ViewModel;

namespace CKC_App_4155;

public partial class EventDetailPage : ContentPage
{
	public EventDetailPage(EventDetailViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}