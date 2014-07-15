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
        private Sprite tile;

        public TileMap(int tile_width, int tile_height)
        {
            this.tile = SpriteFactory.createSprite(new IntRect(0, 0, 100, 100), "GameAssets/stone_cobble.jpg");
        }


        // komplette TileMap aus den Tiles zeichnen
        public void TileMapDraw(RenderWindow renderWindow)
        {
            //renderWindow.Size.X / Y

            

            tile.Position = new Vector2f(0, 0);
            renderWindow.Draw(tile);
            tile.Position = new Vector2f(renderWindow.Size.X-100, 0);
            renderWindow.Draw(tile);
        }

    }
}
