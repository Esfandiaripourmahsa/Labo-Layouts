using System.Threading.Tasks;

namespace Layouts
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void  OnGotoGrid_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Grid");
        }
    }

}
