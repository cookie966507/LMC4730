using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

	public GameObject sphere;
	
	Vector3 start;
	
	int index = 0;
		
	public Transform[] locs;
	
	void Start(){
		start = transform.position;
	}
	
	void Update () {
		if(transform.position.Equals(locs[index].position)){
			index++;
		}
		else{
			transform.position = Vector3.MoveTowards(transform.position, locs[index].position, 10f);
		}
		if(index == 7){
			Reset();
		}
	}
	
	void Reset(){
		transform.position = start;
		sphere.SetActive (true);
		sphere.GetComponent<SpinGlobe>().enabled = true;
		gameObject.transform.root.gameObject.SetActive(false);
	}
}
