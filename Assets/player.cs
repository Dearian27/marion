using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public Rigidbody2D rb; 
	// bool isGrounded = false;

	void Start()
	{
			
	}

	void FixedUpdate()
	{
		float dirX = Input.GetAxisRaw("Horizontal");
		rb.velocity = new Vector2(dirX * 15, rb.velocity.y);
			
		if(Input.GetButtonDown("Jump") || Input.GetKey("space")) {
			rb.velocity = new Vector2(rb.velocity.x, 5);
			// isGrounded = false;
		}
	}
}
