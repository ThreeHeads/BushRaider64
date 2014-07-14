using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML.Window;
using SFML.Graphics;

namespace SCS
{
    class Button : GUIElement
    {
        private RectangleShape ButtonBody;

        public Button(String ID, Vector2f Origin) : base(ID, GUIElementTypes.Button, Origin)
        {
            ButtonBody = new RectangleShape();

            ButtonBody.Size = new Vector2f(100.0f, 25.0f);
            Vector2f ButtonBodyOrigin = new Vector2f(this.Origin.X + (this.ButtonBody.Size.X / 2),
                                                     this.Origin.Y + (this.ButtonBody.Size.Y / 2));
            ButtonBody.Origin = ButtonBodyOrigin;
            ButtonBody.FillColor = Color.Blue;
            ButtonBody.OutlineThickness = 2.0f;

            this.Drawables = new Drawable[1];
            Drawables[0] = ButtonBody;
        }
    }
}



//public class Button extends GUIElement
//{
//    private RectangleShape ButtonBody;
//    private ButtonState State;
//    private Color[] ButtonColors = new Color[3];
//    private Vector2f ButtonSize = new Vector2f(100.0f, 25.0f);
//    private Label ButtonLabel;
	
//    public enum ButtonState {Over, Normal, Down};
	
	
//    public Button(String ID, Vector2f Origin)
//    {
//        super(ID, "Button", Origin);
		
//        ButtonLabel = new Label(this.ID + "Label", this.Origin);
		
//        this.ButtonLabel.setText(this.ID);
		
//        ButtonBody = new RectangleShape();
//        Vector2f ButtonBodyOrigin = new Vector2f(this.Origin.x + (ButtonSize.x / 2),
//                                                 this.Origin.y + (ButtonSize.y / 2));
		
//        ButtonBody.setOrigin(ButtonBodyOrigin);
//        ButtonBody.setSize(this.ButtonSize);
//        ButtonColors[0] = Color.WHITE;
//        ButtonColors[1] = new Color(220, 220, 220);
//        ButtonColors[2] = new Color(156, 156, 156);
		
//        ButtonBody.setOutlineThickness(2.0f);
//        ButtonBody.setOutlineColor(new Color(100, 100 ,100));
		
//        Drawables = new Drawable[2];
//        Drawables[0] = ButtonBody;
//        Drawables[1] = ButtonLabel.getDrawables()[0];
		
//        this.State = ButtonState.Normal;
//        changeState(this.State);
//    }
	
	
//    public boolean isOver(Vector2i Point)
//    {	
//        boolean isOver = false;

//        int x = ((int)(-Origin.x - (this.ButtonSize.x / 2)));
//        int y = ((int)(-Origin.y - (this.ButtonSize.y / 2)));
//        for(int X = 0; X <= (int)ButtonBody.getSize().x; X++)
//        {
//            for(int Y = 0; Y <= (int)ButtonBody.getSize().y; Y++)
//            {
//                if(((x + X) == Point.x) && ((y + Y) == Point.y))
//                {
//                    isOver = true;
//                }
//            }
//        }
//        return isOver;
//    }
	
	
//    public ButtonState getState()
//    {
//        return this.State;
//    }
	
//    public void changeState(ButtonState State)
//    {
//        this.State = State;
		
//        switch(State)
//        {
//        case Over:
//                    this.ButtonBody.setFillColor(this.ButtonColors[0]);
//                    break;
//        case Normal:
//                    this.ButtonBody.setFillColor(this.ButtonColors[1]);
//                    break;
//        case Down:
//                    this.ButtonBody.setFillColor(this.ButtonColors[2]);
//                    break;
//        }
//    }


//    public void setOrigin(Vector2f newOrigin) 
//    {
//        this.Origin = newOrigin;
//        this.update();
//    }
	
	
//    private void update()
//    {
//        Vector2f ButtonBodyOrigin = new Vector2f(this.Origin.x + (ButtonSize.x / 2), this.Origin.y + (ButtonSize.y / 2));
//        ButtonBody.setOrigin(ButtonBodyOrigin);
		
//        Drawables = new Drawable[2];
//        Drawables[0] = ButtonBody;
//        Drawables[1] = ButtonLabel.getDrawables()[0];
//    }
	
//}