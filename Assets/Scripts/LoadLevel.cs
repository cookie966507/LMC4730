using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public string level;
	
	void Update () {
		if(Input.touchCount > 0){
			Application.LoadLevel(level);
		}
	}
}
