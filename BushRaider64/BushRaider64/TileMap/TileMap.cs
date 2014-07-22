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
    class TileMap
    {
        // TODO: List -> Array 

        public List<Tile> TileList;
        private int tileWidth;
        private int tileHeight;
        private int mapWidth;
        private int mapHeight;

        private int position_x = 0;
        private int position_y = 0;

        private int Coord_x;
        private int Coord_y;

        public enum SpriteTexture { desert, snow, soil, cobble };
             
        public TileMap(int tileWidth, int tileHeight, int mapWidth, int mapHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.mapWidth = mapWidth*tileWidth;
            this.mapHeight = mapHeight*tileHeight;

            TileList = new List<Tile>();
           
           //Loop: Add einer Tile mit Positionsdaten
            

            for (Coord_y = 0, position_y = 0; position_y < this.mapHeight; position_y += tileHeight, Coord_y++)
            {  
                for (Coord_x = 0, position_x = 0; position_x < this.mapWidth; position_x += tileWidth, Coord_x++)
                {
                    TileList.Add(new Tile(new Vector2f(position_x , position_y), tileWidth, tileHeight, Coord_x, Coord_y));
                }
            }    

        }

        public void LoadContent(SpriteTexture texture)
        {
            for (int i = 0; i < TileList.Count; i++)
            {
                switch (texture)
                {
                    case SpriteTexture.desert:
                            TileList[i].LoadContent("desert");
                            break;
                    case SpriteTexture.snow:
                            TileList[i].LoadContent("snow");
                            break;
                    case SpriteTexture.soil:
                            TileList[i].LoadContent("soil");
                            break;
                    case SpriteTexture.cobble:
                            TileList[i].LoadContent("cobble");
                            break;
                }
            }
        }

        // Methode ändert Textur bei angebener Koordinate
        public void ChangeTexture(int Coord_x, int Coord_y, SpriteTexture texture)
        {
            TileEditor.ChangeTexture(TileList, Coord_x, Coord_y, texture);
        }
        
        // Methode ändert momentane Position der Tile
        public void ChangeLocation(int Coord_x, int Coord_y, int newCoord_x, int newCoord_y)
        {
            TileEditor.ChangeLocation(TileList, Coord_x, Coord_y, newCoord_x, newCoord_y);
        }

        public void Update(TimeSpan deltaTime)
        {
            
        }

        //Zeichnet eine komplette Map aus der Tile
        public void DrawMap(RenderWindow renderWindow)
        {
            foreach (var item in TileList)
            {
                item.Draw(renderWindow);
            }
        }
    }
}

