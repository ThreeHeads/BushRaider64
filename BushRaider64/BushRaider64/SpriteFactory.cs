using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;

namespace BushRaider64
{
    class SpriteFactory
    {
        public Sprite createSprite(IntRect rectangle, string fileName)
        {
            Texture texture = new Texture(fileName);
            return new Sprite(texture, rectangle);
        }
    }
}
