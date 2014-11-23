using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Location : MonoBehaviour {
	
	[HideInInspector]
	public bool unlocked = false;
	[HideInInspector]
	public bool complete = false;
}
