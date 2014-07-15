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
    class MenuScreen : Screen
    {
        double elapsed;

        public MenuScreen(int screenWidth, int screenHeight, State state): base(screenWidth, screenHeight, state)
        {
        }

        public override void LoadContent()
        {

        }

        public override void Update(TimeSpan deltaTime)
        {
            elapsed += deltaTime.TotalSeconds;

            if(elapsed >= 2f)
            NotifyScreenChangeEvent(input.MenuToPlay);
        }

        public override void Draw(RenderWindow renderWindow)
        {
            renderWindow.Clear(Color.Blue);
        }
    }
}
