using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidAppGuit
{
    [Activity(Label = "AndroidAppGuit", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public int count = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);            

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

