using Godot;
using System;


public partial class Parallax : Node2D
{
	private ParallaxBackground Background { get; set; }
	public override void _Ready()
	{
		Background = GetNode<ParallaxBackground>("ParallaxBackground");
		GD.Print("INITIAL STATE: "+Background.ScrollOffset);
	}
	
	public override void _Process(double delta)
	{
		//var camera = new Camera2D();
		// camera.Position = camera.Position with { X = Camera.Position.X + 40 * (float)delta };
		// Camera.Position = camera.Position;
		
		Vector2 vector = Background.ScrollOffset;
		vector.X = vector.X - (float)delta * 50;
		Background.ScrollOffset = vector;
		GD.Print(Background.ScrollOffset+"\n"+delta);
	}
}
