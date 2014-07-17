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

        // TODO: Enum erstellen für Texturarten

        public enum Texture { desert, snow, stone };
        

        public TileMap(int tileWidth, int tileHeight, int mapWidth, int mapHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;

            TileList = new List<Tile>();

            TileList.Add(new Tile(tileWidth, tileHeight));
            TileList.Add(new Tile(tileWidth, tileHeight));
        }

        public void LoadContent()
        {
            TileList[0].LoadContent(new Vector2f(0f, 0f), "GameAssets/desert.png");
            TileList[1].LoadContent(new Vector2f(0f, 0f), "GameAssets/snow.png");
        }

        public void Update(TimeSpan deltaTime)
        {
        }

        public void Draw(RenderWindow renderWindow, Texture texture)
        {
            //int index = (int)texture;
            TileList[(int)texture].DrawMap(renderWindow, mapWidth, mapHeight);
        }

    }
}
