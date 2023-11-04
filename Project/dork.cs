using Godot;
using System;
using System.Diagnostics;

public partial class dork : CharacterBody2D
{
	Sprite2D sprite;
	RayCast2D bottomLeft;
	RayCast2D bottomRight;
	private Vector2 velocity = new Vector2();
	private int gravity = 200;
	private int speed = 30;
	private bool one_hit = false;

	public override void _Ready() {
		sprite = GetNode<Sprite2D>("Sprite");
		bottomLeft = GetNode<RayCast2D>("LeftRaycast");
		bottomRight = GetNode<RayCast2D>("RightRaycast");
		velocity.X = speed;
		
	}

	public override void _PhysicsProcess(double delta){
		velocity.Y += gravity * (float)delta;
		if (velocity.Y > gravity) {
			velocity.Y = gravity;
		}
		velocity.X = speed;
		MoveAndSlide();
		for (int i = 0; i < GetSlideCollisionCount(); i++)
		{
			var collision = GetSlideCollision(i);
			if (((Node)collision.GetCollider()).Name == "CharacterBody2D" && !one_hit) {
					one_hit = true;
					GD.Print("I collided with ", ((Node)collision.GetCollider()).Name);
					ProcessStartInfo startInfo = new ProcessStartInfo();
					startInfo.FileName = "python"; // or the full path to Python executable
					startInfo.Arguments = "start_terminal.py"; // Replace with the name of your Python script
					Process.Start(startInfo);
			}
		}
		
		
	}

}
