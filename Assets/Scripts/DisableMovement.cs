using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMovement : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("enter");
		other.GetComponent<PlayerPlatformerController>().canMove = false;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log("exit");
		other.GetComponent<PlayerPlatformerController>().canMove = true;
	}

}
