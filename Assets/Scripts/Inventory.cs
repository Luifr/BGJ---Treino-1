using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

	static Inventory instance = null;
	static string currentItem = "iron";
	private static GameObject currentItemReference;

	// Start is called before the first frame update
	void Start()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			Destroy(this);
		}
	}

	public static void Set(string item, GameObject reference)
	{
		currentItem = item;
		currentItemReference = reference;
	}

	public static bool Has()
	{
		return currentItem != "";
	}

	public static string Use()
	{
		string item = currentItem;
		ClearItem();
		return item;
	}

	public static void ClearItem()
	{
		currentItem = "";
		currentItemReference = null;
	}

	public static void RespawnItem()
	{
		currentItemReference.SetActive(true);
		ClearItem();
	}
}
