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
    public enum State { activ, inactive, paused}

    abstract class Screen
    {
        public event ScreenHandler screenChange;

        public Screen(int screenWidth, int screenHeight, State state)
        {
            this.ScreenWidth = screenWidth;
            this.ScreenHeight = screenHeight;
            this.state = state;
        }

        public void NotifyScreenChangeEvent(input input)
        {
            var handler = screenChange;
            if (handler != null)
                handler(input);
        }

        public event ScreenHandler stateChangeHandler;

        private int ScreenWidth, ScreenHeight;

        public State state;

        abstract public void LoadContent();

        abstract public void Update(TimeSpan deltaTime);

        abstract public void Draw(RenderWindow renderWindow);
    }
}
