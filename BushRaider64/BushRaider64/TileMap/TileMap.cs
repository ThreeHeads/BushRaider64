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
        private List<Tile> TileList;
        private int tileWidth;
        private int tileHeight;

        public TileMap(int tileWidth, int tileHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;

            TileList = new List<Tile>();

            for (int i = 1; i < 10; i++)
            {
                TileList.Add(new Tile(tileWidth, tileHeight));
            }
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
                TileList[0].Draw(renderWindow);
        }

    }
}
