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
            snow = SpriteFactory.createSpriteNoScale("GameAssets/texture_sheet.png", 0,50,50,50);
            desert = SpriteFactory.createSpriteNoScale("GameAssets/texture_sheet.png", 50, 50, 50, 50);
            soil = SpriteFactory.createSpriteNoScale("GameAssets/texture_sheet.png", 0, 0, 50, 50);
            cobble = SpriteFactory.createSpriteNoScale("GameAssets/texture_sheet.png", 50, 0, 50, 50);
        }

    }
}
