using System.Windows;
using Wpf.Ui.Controls;

namespace Apexstrap.UI.Elements.Settings.Pages
{
    public partial class DiscordRPCPage : UiPage
    {
        public DiscordRPCPage()
        {
            InitializeComponent();
            DataContext = new ViewModels.Settings.DiscordRPCViewModel();
        }
    }
}
