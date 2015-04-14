using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float movementSpeed = 5f;
	Rigidbody2D playerRigidbody;
	float moveSpeed = 0;

	void Start () 
	{
		moveSpeed = movementSpeed;
		playerRigidbody = GetComponent<Rigidbody2D>();
	}

	void Update () 
	{
		HandleInput();
	}

	void MovePlayer()
	{
		//Vector2 player
	}

	void HandleInput()
	{
		Vector2 movementDirection = Vector2.zero;
		if(Input.GetKey(KeyCode.W))
		{
			movementDirection += new Vector2(0,1);
		}
		if(Input.GetKey(KeyCode.A))
		{
			movementDirection += new Vector2(-1,0);
		}
		if(Input.GetKey(KeyCode.S))
		{
			movementDirection += new Vector2(0,-1);
		}
		if(Input.GetKey(KeyCode.D))
		{
			movementDirection += new Vector2(1,0);
		}
		movementDirection.Normalize();
		if(Input.GetKey(KeyCode.LeftShift))
		{
			movementSpeed = moveSpeed * 2;
		}
		else
		{
			movementSpeed = moveSpeed;
		}
	
		playerRigidbody.velocity = movementDirection * moveSpeed;
	}

	//Take Input
	//Determine movement direction
	//Multiply direction by movement Speed
	//Apply Vector to player
}
