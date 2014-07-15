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
        private Sprite background;

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

            //Debug Code

            foreach(VideoMode item in VideoMode.FullscreenModes)
            {
                Console.WriteLine(item.Width + " + " + item.Height + " + " + item.BitsPerPixel);
            }
            Console.WriteLine(VideoMode.DesktopMode.Width + " + " + VideoMode.DesktopMode.Height);


            renderWindow = new RenderWindow(video, "BushRaider",Styles.Default);
            renderWindow.SetVisible(true);
            renderWindow.SetVerticalSyncEnabled(true);
            renderWindow.Closed += new EventHandler(OnClosed);

            //Test Sprite

            background = SpriteFactory.createSpriteCentered(new IntRect((int)video.Width / 2, (int)video.Height / 2, (int)video.Width, (int)video.Height), "GameAssets/logo.png");

            //GameTime Initialisieren

            timer = new Stopwatch();
            deltaTime = new TimeSpan();
            timer.Start();

            //Camera

            view = new View(new FloatRect(0, 0, VideoMode.DesktopMode.Width, VideoMode.DesktopMode.Height));
            renderWindow.SetView(view);

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
                renderWindow.Display();

                deltaTime = timer.Elapsed;
                timer.Restart();
            }
        }

        void OnClosed(object sender, EventArgs e)
        {
            renderWindow.Close();
        }

        public void Draw()
        {
            renderWindow.Clear(Color.Blue);
            renderWindow.Draw(background);
        }
    }
}
