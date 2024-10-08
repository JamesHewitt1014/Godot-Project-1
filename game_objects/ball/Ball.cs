using Godot;
using System;

public partial class Ball : Node2D
{
	
	[Export] 
	public float speed { get; set; }

	[Export]
	public float x {get; set;} = 0;

	[Export]
	public float y {get; set;} = 0;
	
	private Vector2 _direction { get; set; }
	
	[ExportGroup("Paddles")]
	[Export]
	public Paddle PlayerPaddle {get; set;}
	[Export]
	public Paddle AIPaddle {get; set;}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Vector2 velocity = new Vector2(0, 0);
		_direction = new Vector2(x, y);
		
		GlobalPosition = GlobalPosition + _direction; 
		
		PlayerPaddle.PaddleHit += OnCollidePaddle;
		AIPaddle.PaddleHit += OnCollidePaddle;
	}
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GlobalPosition = GlobalPosition + _direction * speed; // * (float)delta;
	}

	public void OnCollideWall(Area2D body)
	{
		_direction = new Vector2(_direction.X, _direction.Y * -1);
		GD.Print(_direction.X, _direction.Y);	
	}

	public void OnCollidePaddle(Paddle paddle){
		//_direction = _paddle.GlobalPosition.DirectionTo(GlobalPosition);
		_direction = paddle.GlobalPosition.DirectionTo(this.GlobalPosition);
	}
}
