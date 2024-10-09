using Godot;

namespace First_Project ;

public partial class ScoreLabel : Godot.Label
{

	public int CurrentScore;

	[Export]
	public Color color { get; set; } = Colors.White;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.Text = "PONG";
		this.Modulate = color;
		CurrentScore = 0;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
