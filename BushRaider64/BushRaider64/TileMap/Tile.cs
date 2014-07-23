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
        public Sprite tileSprite;
        public Vector2f position;
        public int Coord_x;
        public int Coord_y;
        public string texture;

        public Tile(Vector2f position, int Coord_x, int Coord_y)
        {
            this.position = position;
            this.Coord_x = Coord_x;
            this.Coord_y = Coord_y;
        }

        public void LoadContent(string texture)
        {
            this.texture = texture;
        }

        public void Update(TimeSpan deltaTime)
        {
        }

        public void Draw(RenderWindow renderWindow)
        {

            Material.cobble.Position = position;
            renderWindow.Draw(Material.cobble);
            switch (texture)
            {
                case "soil":
                        Material.soil.Position = position;
                        renderWindow.Draw(Material.soil);
                        break;
                case "desert":
                        Material.desert.Position = position;
                        renderWindow.Draw(Material.desert);
                        break;
                case "snow":
                        Material.snow.Position = position;
                        renderWindow.Draw(Material.snow);
                        break;
                case "cobble":
                        Material.cobble.Position = position;
                        renderWindow.Draw(Material.cobble);
                        break;
                default:
                    Console.WriteLine(texture);
                    break;
            }        
        }
    }
}
