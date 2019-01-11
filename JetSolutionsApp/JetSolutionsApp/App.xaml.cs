using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace JetSolutionsApp
{
    public partial class Application : Xamarin.Forms.Application
    {
        public static MasterDetailPage Navegacao { get; set; }

        public Application()
        {
            
            MainPage = new MainPage();
        }  

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
