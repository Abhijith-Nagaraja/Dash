using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour {

	CharacterController controller;
	bool isGrounded= true;
	public float jump = 0f;
	public float factor = 0.01f;
	private bool maxHeightReached = false;
	private Vector2 fp; // first finger position
	private Vector2 lp; // last finger position
	private float currentPos = 0f;
	public AudioClip otherClip;
	// Update is called once per frame
	void Update () {

		if (Time.timeSinceLevelLoad % 5 == 0)
			factor += 0.01f;

		foreach(Touch touch in Input.touches)
		{
			if (touch.phase == TouchPhase.Began)
			{
				fp = touch.position;
				lp = touch.position;
			}
			if (touch.phase == TouchPhase.Moved )
			{
				lp = touch.position;
			}
			if(touch.phase == TouchPhase.Ended)
			{
				if((fp.x - lp.x) > 80 && currentPos != 2.5f && isGrounded) // right swipe
				{
					currentPos += 2.5f;
					transform.Translate(2.5f, 0, 0);
				}
				else if((fp.x - lp.x) < -80 && currentPos != -2.5f && isGrounded) // left swipe
				{
					currentPos -= 2.5f;
					transform.Translate(currentPos, 0, 0);
				}
				else if((fp.y - lp.y) < -80 ) // up swipe
				{
					if (isGrounded) {
							isGrounded = false;
					}
				}
			}
		}
	
		if (isGrounded) 
		{
			if( Input.GetKeyDown(KeyCode.RightArrow) && currentPos != -2.5f )
			{
				currentPos -= 2.5f;
				transform.Translate(-2.5f, 0, 0);
			}
			
			else if( Input.GetKeyDown(KeyCode.LeftArrow) && currentPos != 2.5f )
			{
				currentPos += 2.5f;
				transform.Translate(2.5f, 0, 0);
			}

			else if (Input.GetKeyDown (KeyCode.UpArrow)) 
			{ 
				isGrounded = false;
			}
		}
	
		if (!isGrounded) 
		{
			if(jump < 0.4f && !maxHeightReached )
			{
				jump += factor;
				transform.Translate(0, jump, 0);
				return;
			}
			else if(!maxHeightReached)
			{
				maxHeightReached = true;
				jump = 0f;
			}
			if(maxHeightReached && jump < 0.4f)
			{
				jump += factor;
				transform.Translate(0, -jump, 0);
				return;
			}
			else
			{
				maxHeightReached = false;
				jump = 0f;
				isGrounded = true;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "FrenchClassicCar(Clone)")
		{
			Destroy(other.gameObject);
			audio.clip = otherClip;
			audio.Play();
			GameControllerScript.isGameOver = true;
		}

		
	}
}
