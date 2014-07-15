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

        private ScreenManager screenManager;
        public RenderWindow renderWindow;

        //Camera

        View view;

        //GameTime

        private const double frames = 60;
        private const double timeStep = 1 / frames;
        private double timeBank;
        private Stopwatch timer;
        private TimeSpan deltaTime;

        public BushRaider()
        {
            //Window Initialisieren

            VideoMode video = new VideoMode();
            video = VideoMode.DesktopMode;

            renderWindow = new RenderWindow(video, "BushRaider", Styles.Default);
            renderWindow.SetVisible(true);
            renderWindow.SetVerticalSyncEnabled(true);
            renderWindow.Closed += new EventHandler(OnClosed);

            //Debug Code

            foreach(VideoMode item in VideoMode.FullscreenModes)
            {
                Console.WriteLine(item.Width + " + " + item.Height + " + " + item.BitsPerPixel);
            }
            Console.WriteLine(VideoMode.DesktopMode.Width + " + " + VideoMode.DesktopMode.Height);

            //GameTime Initialisieren

            timer = new Stopwatch();
            deltaTime = new TimeSpan();
            timer.Start();

            //Camera

            view = new View(new FloatRect(0, 0, VideoMode.DesktopMode.Width, VideoMode.DesktopMode.Height));
            renderWindow.SetView(view);

            screenManager = new ScreenManager(renderWindow);
            this.Update();

        }

        public void Update()
        {
            while (renderWindow.IsOpen())
            {
                timeBank += deltaTime.TotalSeconds;

                if (timeBank >= timeStep)
                {
                    screenManager.Update(deltaTime);
                    timeBank -= timeStep;
                    Console.WriteLine("Logic");
                }

                renderWindow.DispatchEvents();
                this.Draw();

                deltaTime = timer.Elapsed;
                timer.Restart();
            }
        }

        //public void Update()
        //{
        //    while (renderWindow.IsOpen())
        //    {
        //        timeBank += deltaTime.TotalSeconds;

        //        while (timeBank >= timeStep)
        //        {
        //            screenManager.Update(deltaTime);
        //            timeBank -= timeStep;
        //        }

        //        renderWindow.DispatchEvents();
        //        this.Draw();

        //        deltaTime = timer.Elapsed;
        //        timer.Restart();
        //    }
        //}

        void OnClosed(object sender, EventArgs e)
        {
            renderWindow.Close();
        }

        public void Draw()
        {
            Console.WriteLine("Draw");
            renderWindow.Clear(new Color(24,116,205));
            screenManager.Draw(renderWindow);
            renderWindow.Display();
        }
    }
}
