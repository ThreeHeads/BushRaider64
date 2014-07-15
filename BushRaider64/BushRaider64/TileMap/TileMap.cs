﻿using System;
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
            tile.Position = new Vector2f(100f, 100f);
        }

        public void TileMapDraw(RenderWindow renderWindow)
        {
            renderWindow.Draw(tile);

        }

    }
}