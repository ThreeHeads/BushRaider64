using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using SFML.Audio;

namespace BushRaider64
{
    static class TileEditor
    {

        private static int SelectTile(int Coord_x, int Coord_y, List<Tile> TileList)
        {
            int i = 0;
            foreach (var item in TileList)
            {
                i++;
                if (item.Coord_x == Coord_x && item.Coord_y == Coord_y)
                {
                    return i - 1;
                }
            }
            return -1;
        }

        // Wechselt den Content einer Tile über die Argumente X Koordinate, Y Koordiante
        public static int ChangeTexture(List<Tile> TileList, int Coord_x, int Coord_y, TileMap.SpriteTexture texture)
        {
            int i = SelectTile(Coord_x, Coord_y, TileList);
            if (i == -1)
            {
                Console.WriteLine("ChangeTexture(): Keine Tile auf der Koordinate {0} | {1}", Coord_x, Coord_y);
                return i;
            }

            switch (texture)
            {
                case TileMap.SpriteTexture.desert:
                    {
                        TileList[i].LoadContent("GameAssets/desert.png");
                        break;
                    }
                case TileMap.SpriteTexture.snow:
                    {
                        TileList[i].LoadContent("GameAssets/snow.png");
                        break;
                    }
                case TileMap.SpriteTexture.soil:
                    {
                        TileList[i].LoadContent("GameAssets/soil.jpg");
                        break;
                    }
            }
            return 0;

        }
        public static int ChangeLocation(List<Tile> TileList, int Coord_x, int Coord_y, int newCoord_x, int newCoord_y)
        {
            Vector2f temp_pos;

            // TileList Element für Ursprungs Tile
            int origin = SelectTile(Coord_x, Coord_y, TileList);
            if (origin == -1)
            {
                Console.WriteLine("ChangeLocation(): Keine Tile auf der Koordinate oder Außerhalb der Map Border {0} | {1}", Coord_x, Coord_y);
                return origin;
            }

            // TileList Element für Ziel Tile
            int target = SelectTile(newCoord_x, newCoord_y, TileList);
            if (target == -1)
            {
                Console.WriteLine("ChangeLocation(): Keine Tile auf der Koordinate oder Außerhalb der Map Border {0} | {1}", newCoord_x, newCoord_y);
                return target;
            }

           

            // Austausch von Vector2f Pos-Angaben und Grid Koordinaten
            //Known Bug: TileWidth und Length setzen sich auf GameAssets Ursprung zurück

            temp_pos = TileList[origin].position;
            Console.WriteLine("temp_pos wird {0} | {1}'s Vector Position: {2} zugewiesen.", Coord_x, Coord_y, TileList[origin].position);
            TileList[origin].LoadContent(TileList[target].position);
            Console.WriteLine("{0} | {1}'s Position: {2} wird mit {3} | {4}'s Vector Position: {5} ersetzt.", Coord_x, Coord_y, temp_pos, newCoord_x, newCoord_y, TileList[target].position);
            TileList[target].LoadContent(temp_pos);

            TileList[target].Coord_x = Coord_x;
            TileList[target].Coord_y = Coord_y;
            TileList[origin].Coord_x = newCoord_x;
            TileList[origin].Coord_y = newCoord_y;

            

            

            return 0;
        }
    }
}
