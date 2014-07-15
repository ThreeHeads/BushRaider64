﻿using System;
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
        private Sprite tileSprite;
        private int tileWidth;
        private int tileHeight;

        public Tile(int tileWidth, int tileHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
        }

        public void LoadContent(Vector2f position, string path)
        {
            tileSprite = SpriteFactory.createSpriteNoScale(tileWidth, tileHeight, position, path);
        }

        public void Update(TimeSpan deltaTime)
        {
        }

        public void Draw(RenderWindow renderWindow)
        {
            // TODO: Loop einbauen - vorher mapWith im Konstruktor TileMap !

            tileSprite.Position = new Vector2f(0, 0);
            renderWindow.Draw(tileSprite);
            tileSprite.Position = new Vector2f(tileWidth, 0);
            renderWindow.Draw(tileSprite);
            tileSprite.Position = new Vector2f(tileWidth*2, 0);
            renderWindow.Draw(tileSprite);
        }
    }
}
