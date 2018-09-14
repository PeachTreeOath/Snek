using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : APlayer 
{
	public Vector3 headPosition;

	public IPlayerMovement movement;

	public List<GameObject> tailObjects = new List<GameObject>();
	
	public Queue<IWeaponObj> inventory = new Queue<IWeaponObj>();

	// Use this for initialization
	public void Start ()
	{
		
	}
	
	// Update is called once per frame.
	public void Update ()
	{
		// Check for input.
		if (Input.GetKeyDown(KeyCode.Space) && inventory.Count != 0)
		{
			// Drop inventory.
		}
		else if(Input.GetKeyDown(KeyCode.W))
		{

			// movement.move(DiscreteMovement.DiscreteDirection.UP, );
		}

		// Check collison for reward.
		// Check collison for weapon.

	}

	/// <summary>
	/// This function is called when the MonoBehaviour will be destroyed.
	/// </summary>
	void OnDestroy()
	{
		
	}

	public void PickUpReward(IRewardObj reward)
	{
		pointCount += reward.GetPoints();

		// TODO Create tail object.
//		tailObjects.Add()
	}

	public void PickUpWeapon(IWeaponObj weapon)
	{
		if (weapon is Bomb)
		{
			Bomb bomb = (Bomb) weapon;
			// bomb.secondsToExplosion = // TODO
		}
		inventory.Enqueue(weapon);
	}
}
