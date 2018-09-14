using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IWeaponObj 
{
	public float secondsToExplosion;

	public APlayer holder;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// TODO Flash
		
	}

	public void Explode()
	{
		// Check for non player snakes in area - kill if head in radius, minus some tail if tail in radius.

	}
}
