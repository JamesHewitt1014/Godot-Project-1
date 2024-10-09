using Godot;
using System;

public partial class AIController : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Entity = GetParent<Node2D>(); 
	}

	[Export]
	public float AISpeed { get; set; } = 2; 

	[Export]
	public Ball trackingEntity {get; set;}

	public Node2D Entity;

	public override void _PhysicsProcess(double delta)
	{	
			Vector2 direction = Entity.GlobalPosition.DirectionTo(trackingEntity.GlobalPosition);
			direction = new Vector2(0, direction.Y); 
			Entity.GlobalPosition = Entity.GlobalPosition + (direction * AISpeed);
	}	
}
