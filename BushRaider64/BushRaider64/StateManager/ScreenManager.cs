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

        public ScreenManager(RenderWindow renderWindow)
        {
            this.renderWindow = renderWindow;

            stateList = new List<Screen>();
            stateList.Add(new IntroScreen((int)renderWindow.Size.X, (int)renderWindow.Size.Y));
        }

        public void Update(TimeSpan deltaTime)
        {
            foreach (Screen state in stateList)
            {
                state.Update(deltaTime);
            }
        }

        public void Draw(RenderWindow renderWindow)
        {
            foreach (Screen state in stateList)
            {
                state.Draw(renderWindow);
            }
        }
    }
}
