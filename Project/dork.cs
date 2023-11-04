using Godot;
using System;

public partial class dork : CharacterBody2D
{
	Sprite2D sprite;
	RayCast2D bottomLeft;
	RayCast2D bottomRight;
	private Vector2 velocity = new Vector2();
	private int gravity = 200;
	private int speed = 30;

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
	}

}
