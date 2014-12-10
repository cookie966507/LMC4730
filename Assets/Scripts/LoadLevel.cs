using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public string level;
	
	void Update () {
		if(Input.touchCount > 0){
			if(Input.touches[0].phase.Equals(TouchPhase.Began)){
				Application.LoadLevel(level);
			}
		}
	}
}
