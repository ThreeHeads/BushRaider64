using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Graphics;
using SFML.Window;

namespace BushRaider64
{
    class Window : RenderWindow
    {
        private List<GUIElement> WindowGUIElements = new List<GUIElement>();

        public Window() : base(new VideoMode(800,600),"")
        {
            this.Closed += new EventHandler(isClosed);
            this.addGUIElement(new Button("ExitButton", new Vector2f(-50.0f, -12.5f)));
            //this.addGUIElement(new Label("TestLabel", new Vector2f(-100.0f,-100.0f)));
        }

        void isClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        public void start()
        {
            while (this.IsOpen())
            {
                this.DispatchEvents();

                this.Clear(Color.White);

                this.drawGUI();

                this.Display();
            }
        }

        private void drawGUI()
        {
            foreach (GUIElement Element in WindowGUIElements)
            {
                foreach (Drawable ElementDrawable in Element.getDrawables())
                {
                    this.Draw(ElementDrawable);
                }
            }
        }

        private void addGUIElement(GUIElement NewGUIElement)
        {
            this.WindowGUIElements.Add(NewGUIElement);
        }

    }
}

