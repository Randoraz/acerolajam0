using Godot;
using System;

public partial class GameOverScreen : CanvasLayer
{
	[Signal]
	public delegate void GameOverTimeOutEventHandler();
	[Signal]
	public delegate void RestartButtonPressedEventHandler();

	private AnimatedSprite2D slashSprite;
	private Label gameOverLabel;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		slashSprite = GetNode<AnimatedSprite2D>("SlashScreen");
		gameOverLabel = GetNode<Label>("Label");

		gameOverLabel.Text = "You were knocked out!\r\nTry again!";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void ShowGameOverScreen(bool showSlash = false)
	{
		Show();

		if(showSlash)
		{
			slashSprite.Show();
			slashSprite.Frame = 0;
			slashSprite.Play();
		}
		else
		{
			gameOverLabel.Text = "You won!";
			slashSprite.Hide();
		}
	}
	
	private void OnRestartButtonPressed()
	{
		EmitSignal(SignalName.RestartButtonPressed);
	}
	
	private void OnGameOverTimeOut()
	{
		EmitSignal(SignalName.GameOverTimeOut);
	}
	
	private void OnAnimationFinished()
	{
		slashSprite.Hide();
	}
}
