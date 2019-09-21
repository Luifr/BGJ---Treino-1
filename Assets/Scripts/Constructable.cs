using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Constructable : MonoBehaviour
{
	[SerializeField]
	private string displayName;
	[SerializeField]
	private Hashtable itens;

	// Start is called before the first frame update
	void Start()
	{
		itens = new Hashtable();
		itens.Add("iron", false);
		itens.Add("cloth", false);
		itens.Add("feathers", false);
	}

	// Update is called once per frame
	void ReceiveItem(string itemName)
	{
		bool? value = (bool)itens[itemName];
		Debug.Log(value);
		if (value != null)
		{
			if (value == false)
			{
				itens[itemName] = true;
				Debug.Log("item adicionado");
			}
			else
			{
				Debug.Log("item ja tava adicionado, isso nao devia acontecer");
			}
		}
		else
		{
			Debug.Log("item nao pertence a maquina");
            Inventory.RespawnItem();
		}
		Debug.Log(itens[itemName]);
	}

	// when the GameObjects collider arrange for this GameObject to travel to the left of the screen
	void OnTriggerEnter2D(Collider2D col)
	{
		if (Inventory.Has())
			ReceiveItem(Inventory.Use());
	}

}