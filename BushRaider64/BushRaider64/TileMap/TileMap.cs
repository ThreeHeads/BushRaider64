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

        // TODO: Enum erstellen für Texturarten

        public enum Texture { desert, snow, soil };
        

        public TileMap(int tileWidth, int tileHeight, int mapWidth, int mapHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;

            TileList = new List<Tile>();
            
            //TODO: Add++ für jede Textur
            TileList.Add(new Tile(tileWidth, tileHeight));
            TileList.Add(new Tile(tileWidth, tileHeight));
            TileList.Add(new Tile(tileWidth, tileHeight));
        }

        public void LoadContent()
        {
            //TODO: Index++ für jede Textur + Pfad
            TileList[0].LoadContent(new Vector2f(0f, 0f), "GameAssets/desert.png");
            TileList[1].LoadContent(new Vector2f(0f, 0f), "GameAssets/snow.png");
            TileList[2].LoadContent(new Vector2f(0f, 0f), "GameAssets/soil.jpg");
        }

        public void Update(TimeSpan deltaTime)
        {
            
        }

        //Zeichnet eine komplette Map aus der Tile
        public void DrawMap(RenderWindow renderWindow, Texture texture)
        {
            for (position_y = 0; position_y < mapHeight; position_y += 50)
            {
                TileList[(int)texture].tileSprite.Position = new Vector2f(position_x, position_y);
                renderWindow.Draw(TileList[(int)texture].tileSprite);
                for (position_x = 0; position_x < mapWidth; position_x += 50)
                {
                    TileList[(int)texture].tileSprite.Position = new Vector2f(position_x, position_y);
                    renderWindow.Draw(TileList[(int)texture].tileSprite);
                }
            }
        }

       

    }
}
