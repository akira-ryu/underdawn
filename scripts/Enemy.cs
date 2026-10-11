using Godot;
using System;

public abstract partial class Enemy : Node
{
    protected AnimatedSprite2D animatedSprite;

	/*using string to store last input of user*/
    protected string lastDirection = "down";

	/*speed key*/
    protected float speed = 125f;

    protected ElementType elementType { get; }
}
