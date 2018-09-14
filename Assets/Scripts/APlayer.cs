using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APlayer : MonoBehaviour 
{
	public int id;
	public Color color;
	public int pointCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Die()
	{
		GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		gameManager.ImDead(id);
	}
}
