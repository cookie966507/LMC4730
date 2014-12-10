using UnityEngine;
using System.Collections;

public class ForceOverTime : MonoBehaviour {

	public float force;
	float time = 3;
	public float delay;
	public GameObject sphere;
	
	Vector3 start;
	
	void Start(){
		start = transform.position;
	}
	
	void Update () {
		time += Time.deltaTime;
		if(time > delay){
			time = 0;
			rigidbody2D.AddForce(new Vector2(force, 0), ForceMode2D.Impulse);
		}
	}
	
	void OnTriggerEnter2D(Collider2D col){
		time = 3;
		rigidbody2D.velocity = Vector2.zero;
		transform.position = start;
		sphere.SetActive (true);
		sphere.GetComponent<SpinGlobe>().enabled = true;
		gameObject.transform.root.gameObject.SetActive(false);
	}
}
