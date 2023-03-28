using XCalendar.Core.Models;

namespace CKC_App_4155;

public partial class Calendar : ContentPage
{
	public Calendar()
	{
		InitializeComponent();
	}
    public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>();
}