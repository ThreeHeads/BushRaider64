using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;
using SFML.Window;
using SFML.Graphics;


namespace BushRaider64
{
    class Tile
    {
        public Sprite tileSprite;
        public Vector2f position;
        private int tileWidth;
        private int tileHeight;
        

        public Tile(Vector2f position, int tileWidth, int tileHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.position = position;
        }

        public void LoadContent(string path)
        {
            tileSprite = SpriteFactory.createSpriteNoScale(tileWidth, tileHeight, position, path);
        }

        public void Update(TimeSpan deltaTime)
        {
        }

        public void Draw(RenderWindow renderWindow)
        {
            renderWindow.Draw(tileSprite);
        }
    }
}
