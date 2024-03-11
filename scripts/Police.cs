using Godot;
using System;

public partial class Police : Node2D
{
	[Signal]
	public delegate void ReadingFinishEventHandler();
	
	private AnimatedSprite2D animatedSprite2D;
	private Timer readingTimer;

	public string[] FirstDialog = new string[]
	{
		"Good work, inspector.",
		"I'll check your report now."
	};
	public string[] GoodDialog = new string[]
	{
		"Great job! You learn fast, inspector.",
		"Keep up the good work for the sake of all of us."
	};
	public string[] BadDialog = new string[]
	{
		"I hoped for more, inspector.",
		"We can't allow one of us to be exposed."
	};

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		animatedSprite2D.Play("police");

		readingTimer = GetNode<Timer>("ReadingTimer");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void PlayAnimation(string animationName)
	{
		animatedSprite2D.Play(animationName);

		if(animationName == "policeReading")
		{
			readingTimer.Start();
		}
	}
	private void OnReadingTimeout()
	{
		PlayAnimation("police");
		EmitSignal(SignalName.ReadingFinish);
	}
}

