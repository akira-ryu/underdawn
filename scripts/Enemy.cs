//Name:			Enemy.cs
//Description:	Abstract class of what a basic enemy should have

using Godot;

public abstract partial class Enemy : CharacterBody2D
{
    protected AnimatedSprite2D animatedSprite;

	/*using string to store last input of user*/
    protected string lastDirection = "down";

	/*speed key*/
    protected float speed = 125f;

    protected int attackDamage = 10;

    protected ElementType elementType { get; }
}