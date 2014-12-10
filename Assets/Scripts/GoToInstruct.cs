using UnityEngine;
using System.Collections;

public class GoToInstruct : MonoBehaviour {

	public GameObject next;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount > 0){
			next.SetActive(true);
			this.gameObject.SetActive(false);
		}
	}
}
