using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

	static Inventory instance = null;
	static HashSet<string> itens;

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

	static void Add(string item)
	{
		itens.Add(item);
	}

	static void Has(string item)
	{
		itens.Contains(item);
	}

}
