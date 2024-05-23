using Godot;
using System;

public partial class ParallaxForeGround : ParallaxLayer
{
	private Texture2D Background{ get; set; }
	private Vector2 ParaScale { get; set; }
	private float TextureX { get; set; }
	private float TextureY { get; set; }
	private Sprite2D Sprite { get; set; }

	public override void _Ready()
	{
		Background = (Texture2D)GD.Load("res://Resources/ParalaxForegoundOne.png");
		ParaScale = new Vector2((float)0.6, 0);
		TextureX = 1600;
		TextureY = 900;
		Sprite = GetNode<Sprite2D>("ParaFore");
		
		var viewportScale = GetViewportRect().Size.Y/TextureY;
		Sprite.Texture = Background;
		Sprite.Scale = new Vector2(viewportScale, viewportScale);
		MotionScale = ParaScale;
		MotionMirroring = new Vector2(viewportScale * TextureX,0);
	}
	
	public override void _Process(double delta)
	{
	}
}
