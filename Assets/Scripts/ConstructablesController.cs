using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructablesController : MonoBehaviour
{

	Constructable[] constructables;

	void Start()
	{
		constructables = transform.GetComponentsInChildren<Constructable>();
		foreach (Constructable constructable in constructables)
		{
			constructable.TryEndGame = TryEndGame;
		}
	}

	void TryEndGame()
	{
		bool end = true;
		foreach (Constructable constructable in constructables)
		{
			if (!constructable.IsCompleted())
			{
				end = false;
				break;
			}
		}
		if (end)
		{
			Debug.Log("FIM DO JOGO");
		}
	}

}
