using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using Com.Calc;
using System.Diagnostics;
using Com;

namespace JavaDefaultInterfaceImpXam
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            ClassDemo.Main(new string[] { });

            Calculator calc = new Calculator();

            int result = calc.Sum(3, 4);

            int result2 = calc.Sum(3, 4, new NumberManagerDefaultImpl());

            int result3 = calc.Sum(3, 4, new NumberManagerCustomImpl());

            Debugger.Break();


            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
        }
    }
}