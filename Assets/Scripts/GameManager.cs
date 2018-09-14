using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public List<int> playerIds = new List<int>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Place apple.

		// Place bomb.
		
	}

	public void ImAlive(int id)
	{
		if (playerIds.Contains(id))
		{
			Debug.Log("Yo! I'm already here - " + id);
		}
		else
		{
			playerIds.Add(id);
		}
	}

	public void ImDead(int id)
	{
		if (!playerIds.Contains(id))
		{
			Debug.Log("Yo! I'm already dead - " + id);
		}
		else
		{
			playerIds.Remove(id);
		}
	}
}
