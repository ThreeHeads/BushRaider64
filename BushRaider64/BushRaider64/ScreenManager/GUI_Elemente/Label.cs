using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using SFML.Window;
using SFML.Graphics;

namespace BushRaider64
{
    class Label : GUIElement
    {
        private Font LabelFont;
        private Text LabelText;

        public Label(String ID, Vector2f Origin) : base(ID, GUIElementTypes.Label, Origin)
        {
            this.LabelFont = new Font(@"Pfad");
            this.LabelText.Font = this.LabelFont;
            this.LabelText.DisplayedString = "DefaultText";

            this.Drawables = new Drawable[1];
            this.Drawables[1] = LabelText;
        }
    }
}






//public class Label extends GUIElement 
//{
//    private Font LabelFont = new Font();
//    private Text LabelText;
	
	
//    public Label(String ID, Vector2f Origin) 
//    {
//        super(ID, "Label", Origin);
	 
//        try 
//        {
//            LabelFont.loadFromFile(Paths.get("Resources\\9SYSTEMA.ttf"));
//        } 
//        catch (IOException e) 
//        {
//            e.printStackTrace();
//        }
		
//        LabelText = new Text("Default", LabelFont, 16);
//        LabelText.setColor(Color.BLACK);
//        LabelText.setOrigin(new Vector2f(Origin.x + (LabelText.getGlobalBounds().width/2), Origin.y + (LabelText.getGlobalBounds().height)));
		
//        this.Drawables = new Drawable[1];
//        this.Drawables[0] = LabelText;
//    }
	

//    public boolean isOver(Vector2i Point) 
//    {
//        boolean isOver = false;
		
//        int x = ((int)-Origin.x);
//        int y = ((int)-Origin.y);
//        for(int X = 0; X <= (int)this.LabelText.getGlobalBounds().width; X++)
//        {
//            for(int Y = 0; Y <= (int)this.LabelText.getGlobalBounds().height; Y++)
//            {
//                if(((x + X) == Point.x) && ((y + Y) == Point.y))
//                {
//                    isOver = true;
//                }
//            }
//        }
//        return isOver;
//    }


//    public void setText(String newText)
//    {
//        this.LabelText.setString(newText);
//    }
	
//    public void setOrigin(Vector2f newOrigin) 
//    {
//        this.Origin = newOrigin;
//        this.update();
//    }
	
	
//    private void update()
//    {
//        LabelText.setOrigin(new Vector2f(Origin.x + (LabelText.getGlobalBounds().width/2), Origin.y + (LabelText.getGlobalBounds().height)));
//        this.Drawables[0] = LabelText;
//    }
	
//}