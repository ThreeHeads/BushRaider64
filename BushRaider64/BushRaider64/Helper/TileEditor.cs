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

        // Auswahlloop für eine Tile bei der ID Coord_x | Coord_y
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
            Console.WriteLine("Tile nicht gefunden!");
            return -1;
        }
         
        // Wechselt den Content einer Tile über die Argumente X Koordinate, Y Koordiante
        public static int ChangeTexture(List<Tile> TileList, int Coord_x, int Coord_y, TileMap.SpriteTexture texture)
        {
            int index = SelectTile(Coord_x, Coord_y, TileList);
            if (index == -1)
            {
                Console.WriteLine("ChangeTexture(): Keine Tile auf der Koordinate {0} | {1}", Coord_x, Coord_y);
                return index;
            }

            switch (texture)
            {
                case TileMap.SpriteTexture.desert:
                    {
                        TileList[index].LoadContent("GameAssets/desert.png");
                        break;
                    }
                case TileMap.SpriteTexture.snow:
                    {
                        TileList[index].LoadContent("GameAssets/snow.png");
                        break;
                    }
                case TileMap.SpriteTexture.soil:
                    {
                        TileList[index].LoadContent("GameAssets/soil.jpg");
                        break;
                    }
            }
            return 0;

        }
        // Wechselt den Ort der Tile Vom Koordinate 1 zu 2
        public static int ChangeLocation(List<Tile> TileList, int Coord_x, int Coord_y, int newCoord_x, int newCoord_y)
        {
            Vector2f temp_pos;
            int temp_coordx;
            int temp_coordy;

            // TileList Element für Ursprungs Tile
            int origin = SelectTile(Coord_x, Coord_y, TileList);
            if (origin == -1)
            {
                Console.WriteLine("ChangeLocation({0},{1},good,good): Keine Tile auf der Koordinate \noder Außerhalb der Map Border.", Coord_x, Coord_y);
                return origin;
            }

            // TileList Element für Ziel Tile
            int target = SelectTile(newCoord_x, newCoord_y, TileList);
            if (target == -1)
            {
                Console.WriteLine("ChangeLocation(good,good,{0},{1}): Keine Tile auf der Koordinate \noder Außerhalb der Map Border.", newCoord_x, newCoord_y);
                return target;
            }

            temp_pos = TileList[origin].position; //origin pos speichern
            temp_coordx = TileList[origin].Coord_x;
            temp_coordy = TileList[origin].Coord_y;

            TileList[origin].position = TileList[target].position; // Vector Positionen austauschen
            TileList[origin].Coord_x = newCoord_x; // Coord IDs austauschen
            TileList[origin].Coord_y = newCoord_y; // Coord IDs austauschen
            //TileList[origin].RefreshContent(); // komplette Instanze mit neuen Werte refreshen (Sprite Erzeugung refreshen)

            TileList[target].position = temp_pos;
            TileList[target].Coord_x = temp_coordx;
            TileList[target].Coord_y = temp_coordy;
            //TileList[target].RefreshContent();

            return 0;
        }


        // Gibt komplette Infos über eine Tile wieder
        public static void TileInfo(int Coord_x, int Coord_y, List<Tile> TileList)
        {
            int index = SelectTile(Coord_x,Coord_y, TileList);

            Console.WriteLine("TileList[{0}]: MapPosition: {1}\nCoord ID: ({2} | {3})\nTileWidth: {4}\nTileHeight: {5}\nSprite: {6}\nSprite Width: {7} - Height: {8}\n",
                index, TileList[index].position, TileList[index].Coord_x, TileList[index].Coord_y, TileList[index].tileWidth, TileList[index].tileHeight, TileList[index].path, TileList[index].tileWidth, TileList[index].tileHeight);
        }
    }
}
