using Dicgo.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dicgo.Domain.CacheModels
{
    public class NavigationModel
    {
        /// <summary>
        /// UI
        /// </summary>
        public FrameworkElement? View { get; set; }
        /// <summary>
        /// ViewModel
        /// </summary>
        public BaseViewModel? ViewModel { get; set; }
    }
}
