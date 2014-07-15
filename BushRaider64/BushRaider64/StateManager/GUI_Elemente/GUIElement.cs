using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushRaider64.StateManager.GUI_Elemente
{
    abstract class GUIElement
    {
        public void loadContent();
        public void draw();
        public void update();
    }
}
