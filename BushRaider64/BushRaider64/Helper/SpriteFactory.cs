﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;

namespace BushRaider64
{
    static class SpriteFactory
    {
        public static Sprite createSpriteCentered(IntRect rectangle, string fileName)
        {
            //Sprite estellen

            Texture texture = new Texture(fileName);
            Sprite sprite = new Sprite(texture);

            //Größe zur Auflösung anpassen

            sprite.Scale = SpriteFactory.getScaleVector(texture.Size.X, texture.Size.Y, rectangle.Width, rectangle.Height);

            //Sprite Zeichnen Origin auf die Mitte Legen

            sprite.Transform.TransformPoint(new Vector2f(rectangle.Width / 2, rectangle.Height / 2));

            sprite.Texture.Smooth = true;

            return sprite;
        }

        public static Sprite createSprite(IntRect rectangle, string fileName)
        {
            //Sprite estellen

            Texture texture = new Texture(fileName);
            Sprite sprite = new Sprite(texture, new IntRect(rectangle.Left,rectangle.Top,(int)texture.Size.X, (int)texture.Size.Y));

            //Größe zur Auflösung anpassen

            sprite.Scale = getScaleVector(texture.Size.X, texture.Size.Y, rectangle.Width, rectangle.Height);

            sprite.Texture.Smooth = true;

            return sprite;
        }

        public static Sprite createSpriteNoScale(int width, int height, Vector2f position, string path)
        {

            //Sprite sprite = new Sprite(new Texture(path), new IntRect((int)position.X, (int)position.Y, width, height));
            Sprite sprite = new Sprite(new Texture(path));
            sprite.Position = position;
            sprite.Scale = getScaleVector(50, 50, 64, 64);
            sprite.Texture.Smooth = true;
            return sprite;
        }

        // Überladung ohne PositionsParameter & width/height (immerhin heisst die Methode ja NoScale) ~ Charlie
        public static Sprite createSpriteNoScale(string path, int pos_x, int pos_y, int width, int height)
        {
            Sprite sprite = new Sprite(new Texture(path), new IntRect(pos_x, pos_y, width, height));
            //Sprite sprite = new Sprite(new Texture(path));
            sprite.Texture.Smooth = true;
            return sprite;
        }


        private static Vector2f getScaleVector(float baseWidth, float baseHeight, int newWidth, int newHeight)
        {
            return new Vector2f(newWidth / baseWidth , newHeight / baseHeight);
        }
    }
}
