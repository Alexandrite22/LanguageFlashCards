using Godot;
using System;


public partial class Parallax : Node2D
{
	private ParallaxBackground Background { get; set; }
	public override void _Ready()
	{
		Background = GetNode<ParallaxBackground>("ParallaxBackground");
	}
	
	public override void _Process(double delta)
	{
		Vector2 vector = Background.ScrollOffset;
		vector.X = vector.X - (float)delta * 50;
		Background.ScrollOffset = vector;
		GD.Print(Background.ScrollOffset+"\n"+delta);
	}
}
