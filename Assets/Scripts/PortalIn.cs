using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalIn : MonoBehaviour
{
	GameObject outPortal;

	// Start is called before the first frame update
	void Start()
	{
		outPortal = GameObject.Find("Out" + gameObject.name.Substring(2));
	}

	// when the GameObjects collider arrange for this GameObject to travel to the left of the screen
	void OnTriggerEnter2D(Collider2D col)
	{
		col.gameObject.transform.position = outPortal.transform.position;
	}

}
