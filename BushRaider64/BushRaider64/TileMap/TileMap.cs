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

        // TODO: List -> Array (warum auch immer :P )

        private List<Tile> TileList;
        private int tileWidth;
        private int tileHeight;
        private int mapWidth;
        private int mapHeight;


        // TODO: mapWidth, mapHeight - Dynamische Größe

        public TileMap(int tileWidth, int tileHeight, int mapWidth, int mapHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;

            TileList = new List<Tile>();
            TileList.Add(new Tile(tileWidth, tileHeight));
        }

        public void LoadContent()
        {
            TileList[0].LoadContent(new Vector2f(0f, 0f), "GameAssets/desert.png");
            
        }

        public void Update(TimeSpan deltaTime)
        {
        }

        public void Draw(RenderWindow renderWindow)
        {
            
            //renderWindow.Size.X / Y
            
            TileList[0].DrawMap(renderWindow, mapWidth, mapHeight);
            
            //tile.Position = new Vector2f(renderWindow.Size.X-100, 0);
        }

    }
}
