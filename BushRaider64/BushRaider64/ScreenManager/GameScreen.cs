using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushRaider64
{
    abstract class GameScreen
    {
        public event ScreenHandler screenChangeHandler;

        abstract public void LoadContent();

        abstract public void Update();//A

        abstract public void Draw();
    }
}
