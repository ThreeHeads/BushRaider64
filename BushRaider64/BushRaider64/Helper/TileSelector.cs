using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushRaider64
{
    static class TileSelector
    {
        public static int SelectTile(int ID_x, int ID_y, List<Tile> TileList)
        {
            int i = 0;
            foreach (var item in TileList)
            {
                i++;
                if (item.ID_x == ID_x && item.ID_y == ID_y)
                {
                    return i - 1;
                }
            }
            return -1;
        }
    }
}
