using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;

namespace BushRaider64
{
    class BushRaider
    {
        //ScreenManager und Render Window

        private ScreenManager screenManger;
        public RenderWindow renderWindow;

        //GameTime

        private const double frames = 60;
        private const double timeStep = 1 / frames;
        private double timeBank;
        private Stopwatch timer;
        private TimeSpan deltaTime;

        public BushRaider()
        {
            renderWindow = new RenderWindow(new VideoMode(1280, 760), "Bush Raider", Styles.Default);
            renderWindow.SetVisible(true);
            renderWindow.SetVerticalSyncEnabled(true);
            renderWindow.Closed += new EventHandler(onClosed);

            //GameTime Initialisieren

            timer = new Stopwatch();
            deltaTime = new TimeSpan();
            timer.Start();

            this.Update();

        }

        public void Update()
        {
            while(renderWindow.IsOpen())
            {
                timeBank += deltaTime.TotalSeconds;


                if (timeBank >= timeStep)
                {
                    timeBank -= timeStep;
                }

                renderWindow.DispatchEvents();
                this.Draw();

                deltaTime = timer.Elapsed;
                timer.Restart();
            }
        }

        public void Draw()
        {
            renderWindow.Clear(Color.Blue);
        }

        public void onClosed(Object sender, EventArgs e)
        {
            renderWindow.Close();
        }
    }
}
