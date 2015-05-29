using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTiles.ViewModels
{
    public class MainViewModel
    {
        public string MainText { get; private set; }

        public MainViewModel()
        {
            MainText = "Hello SmartTiles!";
        }
    }
}
