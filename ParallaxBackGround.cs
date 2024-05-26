using Godot;
using System;
using System.Net.Mime;

public partial class ParallaxBackGround : ParallaxLayer
{
	//Default Background for the Flash Card Menu and Game
	private Texture2D Background{ get; set; }
	private Vector2 ParaScale { get; set; }
	private float TextureX { get; set; }
	private float TextureY { get; set; }
	private Sprite2D Sprite { get; set; }

	public override void _Ready()
	{
		//Uses GD.Load to load the image from file into a locally stored variable. (Texture2D) casts it specifically as a 2D texture.
		Background = (Texture2D)GD.Load("res://Resources/ParalaxBackGroundOne.png");
		//Sets the X movement scale (0.2 is the slowest out of all 3) 
		ParaScale = new Vector2((float)0.2, 0);
		//TextureX & TextureY are the image scales,
		//TODO: replace with Vector & automatically detect at later stage
		TextureX = 1600;
		TextureY = 900;
		//Loads child node into local variable <> is used to specify which type of node is loaded
		Sprite = GetNode<Sprite2D>("ParaBack");
		
		//Gets the Y resolution of the vieport
		var viewportScale = GetViewportRect().Size.Y/TextureY;
		//Uses the Texture2D loaded from file and sets it to the Texture of the child node (Sprite2D) we previously loaded 
		Sprite.Texture = Background;
		//Sets the scale of the sprite to match the height of the viewport, scales the length the same amount to avoid stretching or squishing the image.
		Sprite.Scale = new Vector2(viewportScale, viewportScale);
		//Motion scale is a property of Parallax Background that dictates the rate in which the x and y axi will change in accordance to the movement of the camera or the parent node.
		//Sets the scale to the value we previously set.
		MotionScale = ParaScale;
		//motion mirroring dictates the way the computer repeats images, this calulation means the images are joined at the edged and there is no overlap.
		MotionMirroring = new Vector2(viewportScale * TextureX,0);
	}

	public override void _Process(double delta)
	{
		
	}
}
