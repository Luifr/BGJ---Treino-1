using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

	static Inventory instance = null;
	static HashSet<string> itens;
	static string currentItem = "iron";

	// Start is called before the first frame update
	void Start()
	{
		if (instance == null)
		{
			itens = new HashSet<string>();
			instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			Destroy(this);
		}
	}

	public static void Add(string item)
	{
		itens.Add(item);
		currentItem = item;
	}

	public static bool Has(string item)
	{
		return itens.Contains(item);
	}

	public static bool Has()
	{
		return currentItem != "";
	}

	public static string Use()
	{
		string item = currentItem;
		currentItem = "";
		return item;
	}

	public static void ClearItem()
	{
		currentItem = "";
	}

}
