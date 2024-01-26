using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{

	public float speed;

	void Update()
	{

		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector2.right * speed);
		}

		else if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.left * speed);
		}

		else if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector2.down * speed);
		}

		else if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector2.up * speed);
		}

		if (Input.GetKey(KeyCode.LeftShift))
        {
			speed = 0.8f;
        } else
        {
			speed = 0.4f;
        }
	}
}
