namespace Layouts
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute("Grid", typeof(GridPage));
        }
    }
}
