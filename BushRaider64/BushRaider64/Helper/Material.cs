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
    static class Material
    {
        public static Sprite snow;
        public static Sprite desert;
        public static Sprite soil;
        public static Sprite cobble;

        public static void LoadMaterial()
        {
            snow = SpriteFactory.createSpriteNoScale(50, 50, "GameAssets/snow.png");
            desert = SpriteFactory.createSpriteNoScale(50, 50, "GameAssets/desert.png");
            soil = SpriteFactory.createSpriteNoScale(50, 50, "GameAssets/soil.jpg");
            cobble = SpriteFactory.createSpriteNoScale(50, 50, "GameAssets/stone_cobble.jpg");
        }

    }
}
