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
    class InputManager
    {
        Keyboard lastKeyboardState;
        Keyboard currentKeyboardState;

        Mouse currentMouseState;
        Mouse lastMouseState;


        public void test()
        {
            lastKeyboardState = new Keyboard();
            currentKeyboardState = new Keyboard();

            currentMouseState = new Mouse();
            lastMouseState = new Mouse();
        }

        public void Update(TimeSpan deltaTime)
        {
            lastMouseState = currentMouseState;
        }

        public void getMousePos()
        {
        }
    }
}
