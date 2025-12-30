using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AetherStrap.UI.ViewModels.Settings;

namespace AetherStrap.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for AetherStrapPage.xaml
    /// </summary>
    public partial class AetherStrapPage
    {
        public AetherStrapPage()
        {
            DataContext = new AetherStrapViewModel();
            InitializeComponent();
        }
    }
}
