using Godot;
using System;

public partial class Ball : Node2D
{
	
	[Export] 
	public Vector2 speed { get; set; }
	
	public Vector2 _direction { get; set; }
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Vector2 velocity = new Vector2(0, 0);
		var random = new Random();
		_direction = new Vector2(random.Next(-1, 1), random.Next(-1, 1));
		
		GlobalPosition = GlobalPosition + _direction; 
	}
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GlobalPosition = GlobalPosition + _direction;
	}
}
