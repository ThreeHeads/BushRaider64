using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;
using SFML.Window;
using SFML.Graphics;


namespace BushRaider64
{
    class Tile
    {
        private Sprite tileSprite;
        private int tileWidth;
        private int tileHeight;

        private int position_x = 0;
        private int position_y = 0;

        public Tile(int tileWidth, int tileHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
        }

        public void LoadContent(Vector2f position, string path)
        {
            tileSprite = SpriteFactory.createSpriteNoScale(tileWidth, tileHeight, position, path);
        }

        public void Update(TimeSpan deltaTime)
        {
        }

        public void Draw(RenderWindow renderWindow)
        {
            renderWindow.Draw(tileSprite);
        }


        //Zeichnet eine komplette Map aus der Tile Instanz
        public void DrawMap(RenderWindow renderWindow, int mapWidth, int mapHeight)
        {


            for (position_y = 0; position_y < mapHeight; position_y += 50)
            {
                tileSprite.Position = new Vector2f(position_x, position_y);
                renderWindow.Draw(tileSprite);
                for(position_x = 0; position_x < mapWidth; position_x += 50)
                {
                    tileSprite.Position = new Vector2f(position_x, position_y);
                    renderWindow.Draw(tileSprite);
                }
            }

            //Console.WriteLine("Position_x:" + position_x);
            //Console.WriteLine("Position_y:" + position_y);
        }
    }
}
