using System;
using Xamarin.Forms;

namespace democorflow
{
	public class ContactpersoonCell : ViewCell
	{
		public ContactpersoonCell ()
		{
			
			var voornaamlabel = new Label {
				Font = Font.SystemFontOfSize(NamedSize.Large)
			};
			voornaamlabel.SetBinding (Label.TextProperty, new Binding ("voornaam"));
			var familienaamlabel = new Label {
				Font = Font.SystemFontOfSize(NamedSize.Large)
			};
			familienaamlabel.SetBinding (Label.TextProperty, new Binding ("familienaam"));

			View = new StackLayout {
				Children = { familienaamlabel, voornaamlabel },
				Orientation = StackOrientation.Horizontal,
				Padding = new Thickness(5,5,0,5)
			};
		}
	}
}

