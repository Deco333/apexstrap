using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apexstrap.UI.ViewModels.Settings;

namespace Apexstrap.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for ApexstrapPage.xaml
    /// </summary>
    public partial class ApexstrapPage
    {
        public ApexstrapPage()
        {
            DataContext = new ApexstrapViewModel();
            InitializeComponent();
        }
    }
}
