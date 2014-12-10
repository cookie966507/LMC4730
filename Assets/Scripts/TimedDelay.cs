using UnityEngine;
using System.Collections;

public class TimedDelay : MonoBehaviour {
	
	public GameObject sphere;
	public float delay = 5.0f;
	private float time = 0;
	
	void Update () {
		time += Time.deltaTime;
		if(time > delay){
			time = 0;
			sphere.SetActive (true);
			sphere.GetComponent<SpinGlobe>().enabled = true;
			gameObject.transform.root.gameObject.SetActive(false);
		}
	}
}
