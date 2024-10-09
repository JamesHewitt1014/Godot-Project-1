using Godot;
using System;

public partial class PlayerController : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Entity = GetParent<Node2D>(); 
	}

	[Export]
	public float PlayerSpeed { get; set; } = 2; 


	public Node2D Entity;

	public override void _PhysicsProcess(double delta)
	{
		
		if (Input.IsActionPressed("W"))
		{
			Entity.GlobalPosition = Entity.GlobalPosition + new Vector2(0, -1 * PlayerSpeed);
		}
		if (Input.IsActionPressed("S"))
		{
			Entity.GlobalPosition = Entity.GlobalPosition + new Vector2(0, PlayerSpeed);
		}
	}	
}
