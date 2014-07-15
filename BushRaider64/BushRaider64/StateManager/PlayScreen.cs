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
    class PlayScreen : Screen
    {
        TileMap tilemap;

        public PlayScreen(int screenWidth, int screenHeight, State state): base(screenWidth, screenHeight, state)
        {
            this.tilemap = new TileMap(100, 100);
        }

        public override void LoadContent()
        {
            
        }

        public override void Update(TimeSpan deltaTime)
        {
        }

        public override void Draw(RenderWindow renderWindow)
        {
            tilemap.TileMapDraw(renderWindow);
            //renderWindow.Clear(Color.Red);
        }
    }
}
