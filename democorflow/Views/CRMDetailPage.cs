using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;

namespace democorflow
{
	public class CRMDetailPage : ContentPage
	{

		public CRMDetailPage (Contactpersoon data)
		{
			Padding = new Thickness(0,Device.OnPlatform(20,0,0),0,0);

			var voornaam = new Label {
				Text = "Voornaam"
			};

			var voornaamtxt = new Label {
				Text = data.voornaam,
				TextColor = Color.Red
			};
			var familienaam = new Label {
				Text = "familienaam"
			};

			var familienaamtxt = new Label {
				Text = data.familienaam,
				TextColor = Color.Red
			};
			var email = new Label {
				Text = "email"
			};

			var emailtxt = new Label {
				Text = data.email,
				TextColor = Color.Red
			};
			var gsm = new Label {
				Text = "gsm"
			};

			var gsmtxt = new Label {
				Text = data.gsm,
				TextColor = Color.Red
			};
			var fax = new Label {
				Text = "fax"
			};

			var faxtxt = new Label {
				Text = data.fax,
				TextColor = Color.Red
			};
			var telefoonwerk = new Label {
				Text = "telefoonwerk"
			};

			var telefoonwerktxt = new Label {
				Text = data.telefoonwerk,
				TextColor = Color.Red
			};
			var telefoonprive = new Label {
				Text = "telefoonprive"
			};

			var telefoonprivetxt = new Label {
				Text = data.telefoonprive,
				TextColor = Color.Red
			};
			var actieflbl = new Label {
				Text = "actief"
			};
			var actief = new Switch {
				IsToggled = data.actief
			};

			Content = new StackLayout {
				Children = {voornaam,voornaamtxt,familienaam,familienaamtxt,email,emailtxt,gsm,gsmtxt,fax,faxtxt,telefoonwerk,telefoonwerktxt,telefoonprive,telefoonprivetxt,actieflbl,actief }
			};

			Title = data.voornaam +" "+data.familienaam;


		}


	}
}


