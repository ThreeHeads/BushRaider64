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
        public int tileWidth;
        public int tileHeight;
        public int Coord_x;
        public int Coord_y;
        string path;
        

        public Tile(Vector2f position, int tileWidth, int tileHeight, int Coord_x, int Coord_y)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.position = position;
            this.Coord_x = Coord_x;
            this.Coord_y = Coord_y;
        }

        public void LoadContent(string path)
        {
            this.path = path;
            tileSprite = SpriteFactory.createSpriteNoScale(tileWidth, tileHeight, position, path);
        }

        public void LoadContent(Vector2f position)
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
