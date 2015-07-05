using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTiles.ViewModels
{
    public class MainViewModel
    {
        public IEnumerable<int> Tiles { get; private set; }

        public MainViewModel()
        {
            Tiles = Enumerable.Range(1, 8).ToList();
        }
    }
}
