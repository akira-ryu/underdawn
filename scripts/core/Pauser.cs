//Name:			Pauser.cs
//Description:	Allows player to pause the game

using Godot;

public partial class Pauser : Node
{
	private bool isPaused = false;

	public override void _Ready()
	{
        //ensures this node will keep running when
        //using gettree().paused
		ProcessMode = ProcessModeEnum.Always;
	}

	public override void _Input(InputEvent @event)
	{
		if (@event.IsActionPressed("ui_cancel"))
			PauseGame();
	}

	public void PauseGame()
	{
		if (isPaused)
		{
			isPaused = false;
			GetTree().Paused = false;
		}
		else
		{
			isPaused = true;
			GetTree().Paused = true;
		}
	}
}
