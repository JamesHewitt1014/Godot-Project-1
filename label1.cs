using Godot;

namespace First_Project ;

public partial class label1 : Godot.Label
{

	private Label _label1;

	[Export]
	public Color color { get; set; } = Colors.White;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_label1 = this; 
		_label1.Text = "Howdy";
		_label1.Modulate = color;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public override void _Input(InputEvent @event)
	{
		if (@event.IsActionPressed("SPACE"))
		{
			_label1.Modulate = color; 
		}

		if (@event.IsActionReleased("SPACE"))
		{
			_label1.Modulate = Colors.Green;
		}
	}
}