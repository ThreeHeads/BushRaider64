﻿using System;
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
        
        public PlayScreen(int screenWidth, int screenHeight, State state): base(screenWidth, screenHeight, state)
        {
            this.TileMap = new TileMap(50, 50, 10, 10);
        }

        public override void LoadContent()
        {
            Material.LoadMaterial();
            TileMap.LoadContent(TileMap.SpriteTexture.cobble);        
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
            //renderWindow.Clear(Color.Red);
        }
    }
}

