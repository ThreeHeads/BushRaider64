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
            TileList.Add(new Tile(tileWidth, tileHeight));
        }

        public void LoadContent()
        {
            TileList[0].LoadContent(new Vector2f(0f, 0f), "GameAssets/desert.png");
            //this.tile = SpriteFactory.createSprite(new IntRect(0, 0, 100, 100), "GameAssets/stone_cobble.jpg");
        }

        public void Update(TimeSpan deltaTime)
        {
        }

        public void Draw(RenderWindow renderWindow)
        {

            //renderWindow.Size.X / Y

            TileList[0].Draw(renderWindow);
            
            //tile.Position = new Vector2f(renderWindow.Size.X-100, 0);
        }

    }
}
