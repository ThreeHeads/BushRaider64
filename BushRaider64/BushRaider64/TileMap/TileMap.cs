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
        // TODO: ID für Tiles
        // TODO: Methode für Zugriff auf Tile
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

        public void LoadContent()
        {
            for(int i = 0; i < TileList.Count; i++)
            {
                TileList[i].LoadContent("GameAssets/soil.jpg");
            }
            
            //TileList[1].LoadContent(new Vector2f(0f, 0f), "GameAssets/snow.png");
            //TileList[2].LoadContent(new Vector2f(0f, 0f), "GameAssets/soil.jpg");
        }

        // Methode ändert Content bei angebener Koordinate
        public void ChangeContent(int ID_x, int ID_y, SpriteTexture texture)
        {
            int i = SelectTile(ID_x, ID_y);

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

        #region Klasseinterne Methoden

        private int SelectTile(int ID_x, int ID_y)
        {
            int i = 0;
            foreach (var item in TileList)
            {
               i++;
               if(item.ID_x == ID_x && item.ID_y == ID_y)
               {
                   return i-1;
               }
            }
            return -1;
        }
        #endregion   

    }
}

