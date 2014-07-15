using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML.Window;
using SFML.Graphics;

namespace BushRaider64
{
    abstract class GUIElement
    {
        public enum GUIElementTypes { Button, Label }

        public String ID;
        public GUIElementTypes Type;
        protected Vector2f Origin;
        protected Drawable[] Drawables;

        public GUIElement(String ID, GUIElementTypes Type, Vector2f Origin)
        {
            this.ID = ID;
            this.Type = Type;
            this.Origin = Origin;
        }

        public Drawable[] getDrawables()
        {
            return Drawables;
        }

    }
}


    //public final String ID, Type;
    //protected Vector2f Origin;
    //protected Drawable[] Drawables;
	
	
    //public GUIElement(String ID, String Type, Vector2f Origin)
    //{
    //    this.ID = ID;
    //    this.Type = Type;
    //    this.Origin = Origin;
    //}
	
	
    //public Drawable[] getDrawables()
    //{
    //    return Drawables;
    //}
	
	
    //public abstract boolean isOver(Vector2i Point);
	
    //public abstract void setOrigin(Vector2f newOrigin);