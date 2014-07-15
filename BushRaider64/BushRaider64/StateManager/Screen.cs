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
    enum State { activ, inactive, paused}

    abstract class Screen
    {
        public Screen(int screenWidth, int screenHeight)
        {
            this.ScreenWidth = screenWidth;
            this.ScreenHeight = screenHeight;
        }

        public event ScreenHandler stateChangeHandler;

        private int ScreenWidth, ScreenHeight;

        abstract public void LoadContent();

        abstract public void Update(TimeSpan deltaTime);

        abstract public void Draw(RenderWindow renderWindow);
    }
}
