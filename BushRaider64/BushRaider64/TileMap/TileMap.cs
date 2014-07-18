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
        private int draw_counter;

        private int position_x = 0;
        private int position_y = 0;

        // TODO: Enum erstellen für Texturarten

        public enum Texture { desert, snow, soil };
        
        public TileMap(int tileWidth, int tileHeight, int mapWidth, int mapHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.mapWidth = mapWidth*tileWidth;
            this.mapHeight = mapHeight*tileHeight;

            TileList = new List<Tile>();
           
           //Loop: Add einer Tile mit Positionsdaten
            
            for (position_y = 0; position_y < this.mapHeight; position_y += tileHeight)
            {  
                for (position_x = 0; position_x < this.mapWidth; position_x += tileWidth)
                {
                    TileList.Add(new Tile(new Vector2f(position_x, position_y), tileWidth, tileHeight));
                    draw_counter++;
                    
                }
            }    
        }

        public void LoadContent()
        {
            for(int i = 0; i < draw_counter; i++)
            {
                TileList[i].LoadContent("GameAssets/soil.jpg");
            }
            
            //TileList[1].LoadContent(new Vector2f(0f, 0f), "GameAssets/snow.png");
            //TileList[2].LoadContent(new Vector2f(0f, 0f), "GameAssets/soil.jpg");
        }

        public void Update(TimeSpan deltaTime)
        {
            
        }

        //Zeichnet eine komplette Map aus der Tile

        public void DrawMap(RenderWindow renderWindow)
        {
            for(int i = 0; i < draw_counter; i++)
            {
                TileList[i].Draw(renderWindow);
            }
        }
    }
}
