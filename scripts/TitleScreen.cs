using Godot;
using System;

public partial class TitleScreen : CanvasLayer
{
	private bool fullscreen = true;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("exit_game"))
		{
			GetTree().Quit(0);
		}

		if (Input.IsActionJustPressed("toggle_screen"))
		{
			if (fullscreen)
			{
				DisplayServer.WindowSetMode(DisplayServer.WindowMode.Windowed);
				DisplayServer.WindowSetSize(new Vector2I(1280, 720));
				fullscreen = false;
			}
			else
			{
				DisplayServer.WindowSetMode(DisplayServer.WindowMode.ExclusiveFullscreen);
				fullscreen = true;
			}
		}
	}
	
	private void OnStartButtonPressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/main.tscn");
	}
}
