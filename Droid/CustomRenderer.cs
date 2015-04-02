using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.App;

[assembly: ExportRenderer(typeof(democorflow.CRMPage), typeof(democorflow.Droid.CustomRenderer))]
namespace democorflow.Droid
{
	//This customer renderer exists only to make certain that we cache the activity
	//hosting the syncPage.  That activity is then used to start the background
	//service.
	public class CustomRenderer : PageRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged(e);
		}

		protected override void OnAttachedToWindow()
		{
			base.OnAttachedToWindow();
			AndroidSyncService.SyncActivity = this.Context as Activity;
		}

		protected override void OnDetachedFromWindow()
		{
			base.OnDetachedFromWindow();
			AndroidSyncService.SyncActivity = null;
		}
	}
}

