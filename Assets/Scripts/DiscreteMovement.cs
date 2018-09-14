using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreteMovement
{

public enum DiscreteDirection
{
	UP,
	DOWN,
	LEFT,
	RIGHT
}

public Vector3 Move(DiscreteDirection direction, Vector3 originalPosition)
{
	return originalPosition;
}

}