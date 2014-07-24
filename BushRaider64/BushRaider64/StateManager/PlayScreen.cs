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
        TileMap TileMap;
        TileMap TileMap2;
        TileMap TileMap3;
        
        public PlayScreen(int screenWidth, int screenHeight, State state): base(screenWidth, screenHeight, state)
        {
            this.TileMap = new TileMap(50, 50, 10, 10);
            this.TileMap2 = new TileMap(50, 50, 5, 5);
            this.TileMap3 = new TileMap(50, 50, 2, 2);
        }

        public override void LoadContent()
        {
            Material.LoadMaterial();
            TileMap.LoadContent(TileMap.SpriteTexture.cobble);
            TileMap2.LoadContent(TileMap.SpriteTexture.soil);
            TileMap3.LoadContent(TileMap.SpriteTexture.desert);
        }

        public void ChangeContent() // Bitte noch bei screenhandler usw einfügen!
        {
            
        }

        public override void Update(TimeSpan deltaTime)
        {
        }

        public override void Draw(RenderWindow renderWindow)
        {
            TileMap.DrawMap(renderWindow);
            TileMap2.DrawMap(renderWindow);
            TileMap3.DrawMap(renderWindow);
            //renderWindow.Clear(Color.Red);
        }
    }
}

