using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;

namespace JavaDefaultInterfaceImpXam
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            ClassDemo.Main(new string[] { });

            Calculator calc = new Calculator();

            int result = calc.Sum(1, 2);

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
        }
    }
}