using System.Collections.Generic;
using VanLanschot.Foundation.Kernel.Models;

namespace VanLanschot.Feature.Navigation.ViewModels
{
    public class HeaderNavigationViewModel : ViewModelBase<I_MenuItemGroup>
    {
        public IEnumerable<I_LinkMenuItem> MenuItems { get; set; }
        
    }
}