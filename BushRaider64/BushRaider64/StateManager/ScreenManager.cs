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
    public delegate void ScreenHandler(string input);

    class ScreenManager
    {
        RenderWindow renderWindow;
        List<Screen> stateList;

        double testSwitch;

        public ScreenManager(RenderWindow renderWindow)
        {
            this.renderWindow = renderWindow;

            stateList = new List<Screen>();
            stateList.Add(new IntroScreen((int)renderWindow.Size.X, (int)renderWindow.Size.Y,State.activ));
            stateList.Add(new PlayScreen((int)renderWindow.Size.X, (int)renderWindow.Size.Y,State.inactive));
        }

        public void Update(TimeSpan deltaTime)
        {
            foreach (Screen screen in stateList)
            {
                if(screen.state == State.activ)
                screen.Update(deltaTime);
            }
            testSwitch += deltaTime.TotalSeconds;
            if (testSwitch >= 3f)
                stateList[0].state = State.inactive;

        }

        public void Draw(RenderWindow renderWindow)
        {
            foreach (Screen screen in stateList)
            {
                if (screen.state == State.activ)
                screen.Draw(renderWindow);
            }
        }
    }
}
