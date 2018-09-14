using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : IRewardObj
{
	public int points;

    public int GetPoints()
    {
        return points;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// This function is called when the MonoBehaviour will be destroyed.
	/// </summary>
	void OnDestroy()
	{
		
	}
}
