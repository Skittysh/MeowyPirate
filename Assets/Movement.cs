using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public float moveSpeed;
	public Rigidbody2D rb;


	private Vector2 moveDirection;


	// Start is called before the first frame update
	void Start()
    {
        
    }

	void Move()
	{
		rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

	}

	void FixedUpdate()
	{
		Move();


	}

	void ProcessInputs()
	{
		float moveX = Input.GetAxisRaw("Horizontal");
		float moveY = Input.GetAxisRaw("Vertical");

		if (moveX < 0)
		{
			transform.localScale = new Vector2(-1, 1);
		}

		else if (moveX > 0)
		{
			transform.localScale = new Vector2(1, 1);
		}

		moveDirection = new Vector2(moveX, moveY).normalized;

	}

	void Update()
	{
		ProcessInputs();

	}
}
