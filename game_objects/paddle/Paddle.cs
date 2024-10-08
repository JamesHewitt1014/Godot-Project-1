using Godot;
using System;

public partial class Paddle : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	[Signal] 
	public delegate void PaddleHitEventHandler(Paddle paddle);
	
	public void OnCollidePaddle(Area2D area)
	{
		EmitSignal(SignalName.PaddleHit, this);
		GD.Print("Paddle Collided");
	}
}
