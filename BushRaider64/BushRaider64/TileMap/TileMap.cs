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

        private int ID_x;
        private int ID_y;

        // TODO: Enum erstellen für Texturarten

        public enum SpriteTexture { desert, snow, soil };
             
        public TileMap(int tileWidth, int tileHeight, int mapWidth, int mapHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.mapWidth = mapWidth*tileWidth;
            this.mapHeight = mapHeight*tileHeight;

            TileList = new List<Tile>();
           
           //Loop: Add einer Tile mit Positionsdaten
            

            for (ID_y = 0, position_y = 0; position_y < this.mapHeight; position_y += tileHeight, ID_y++)
            {  
                for (ID_x = 0, position_x = 0; position_x < this.mapWidth; position_x += tileWidth, ID_x++)
                {
                    TileList.Add(new Tile(new Vector2f(position_x , position_y), tileWidth, tileHeight, ID_x, ID_y));
                }
            }    

        }

        public void LoadContent(SpriteTexture texture)
        {
            for(int i = 0; i < TileList.Count; i++)
            {
                switch (texture)
                {
                    case SpriteTexture.desert:
                        {
                            TileList[i].LoadContent("GameAssets/desert.png");
                            break;
                        }
                    case SpriteTexture.snow:
                        {
                            TileList[i].LoadContent("GameAssets/snow.png");
                            break;
                        }
                    case SpriteTexture.soil:
                        {
                            TileList[i].LoadContent("GameAssets/soil.jpg");
                            break;
                        }
                }
            }
        }

        // Methode ändert Content bei angebener Koordinate
        public int ChangeContent(int ID_x, int ID_y, SpriteTexture texture)
        {
            int i = TileSelector.SelectTile(ID_x, ID_y, TileList);
            if (i == -1)
            {
                Console.WriteLine("ChangeContent(): Keine Tile auf der Koordinate {0} | {1}", ID_x, ID_y);
                return i;
            }
               


            switch (texture)
            {
                case SpriteTexture.desert:
                    {
                        TileList[i].LoadContent("GameAssets/desert.png");
                        break;
                    }
                case SpriteTexture.snow:
                    {
                        TileList[i].LoadContent("GameAssets/snow.png");
                        break;
                    }
                case SpriteTexture.soil:
                    {
                        TileList[i].LoadContent("GameAssets/soil.jpg");
                        break;
                    }
            }
            return 0;
               
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

