using System.Windows;
using Wpf.Ui.Controls;

namespace Apexstrap.UI.Elements.Settings.Pages
{
    public partial class OptimizationPage : UiPage
    {
        public OptimizationPage()
        {
            InitializeComponent();
            DataContext = new ViewModels.Settings.OptimizationViewModel();
        }
    }
}
