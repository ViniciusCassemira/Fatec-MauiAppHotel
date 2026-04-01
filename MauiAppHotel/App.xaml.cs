using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public static List<Usuario> lista_usuarios = new();

        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window w = new Window(new AppShell());
            w.Height = 600;
            w.Width = 300;

            return w;
        }
    }
}