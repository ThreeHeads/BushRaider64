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
    class IntroScreen : Screen
    {
        private Sprite IntroLogo;

        public IntroScreen(int screenWidth, int screenHeight,State state) : base(screenWidth, screenHeight, state)
        {
            IntroLogo = SpriteFactory.createSprite(new IntRect(0 ,0 ,screenWidth ,screenHeight), "GameAssets/logo.png");
        }

        public override void LoadContent()
        {
           
        }

        public override void Update(TimeSpan deltaTime)
        {
        }

        public override void Draw(RenderWindow renderWindow)
        {
            renderWindow.Draw(IntroLogo);
        }
    }
}
