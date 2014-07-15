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
    public enum input { play, quit, options, highscore, pause, menu}

    public delegate void ScreenHandler(input input);

    class ScreenManager
    {
        RenderWindow renderWindow;
        List<Screen> screenList;

        public ScreenManager(RenderWindow renderWindow)
        {
            this.renderWindow = renderWindow;

            screenList = new List<Screen>();
            screenList.Add(new IntroScreen((int)renderWindow.Size.X, (int)renderWindow.Size.Y,State.activ));
            screenList.Add(new PlayScreen((int)renderWindow.Size.X, (int)renderWindow.Size.Y,State.inactive));

            //Events anmelden

            screenList[0].screenChange += ScreenChangeHandler;
        }


        public void Update(TimeSpan deltaTime)
        {
            foreach (Screen screen in screenList)
            {
                if(screen.state == State.activ)
                screen.Update(deltaTime);
            }
        }

        public void ScreenChangeHandler(input input)
        {
            switch(input)
            {
                case input.menu:
                {
                    screenList[0].state = State.inactive; break;
                }
            }
        }

        public void Draw(RenderWindow renderWindow)
        {
            foreach (Screen screen in screenList)
            {
                if (screen.state == State.activ)
                screen.Draw(renderWindow);
            }
        }
    }
}
