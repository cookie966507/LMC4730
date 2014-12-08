using UnityEngine;
using System.Collections;

public class SpinGlobe : MonoBehaviour {
	
	private float rotationSpeed = 2.0F;
	private float lerpSpeed = 1.0F;
	
	private Vector3 theSpeed;
	private Vector3 avgSpeed;
	private bool isDragging = false;
	private Vector3 targetSpeedX;
	
	void Update() {
		if(Input.touchCount > 0){
			isDragging = true;
			if (!Input.GetTouch(0).phase.Equals(TouchPhase.Ended) && !Input.GetTouch(0).phase.Equals(TouchPhase.Began) && isDragging) {
				theSpeed = new Vector3(-Input.GetAxis("Mouse X"), 0, 0.0F);
				avgSpeed = Vector3.Lerp(avgSpeed, theSpeed, Time.deltaTime * 5);
			}
			if(Input.GetTouch(0).phase.Equals(TouchPhase.Ended)){
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
				RaycastHit hit;
				if(Physics.Raycast(ray, out hit) && hit.transform.tag == "Location"){
					if(GlobeManager.instance.isUnlocked(hit.transform.GetComponent<Location>())){
						//hit.transform.renderer.material.color = Color.yellow;
						//hit.transform.GetComponent<Activity>().updateLevel();
						hit.transform.GetComponent<Activity>().instructions.SetActive(true);
						this.enabled = false;
					}
				}
			}
		}
		else {
			if (isDragging) {
				theSpeed = avgSpeed;
				isDragging = false;
			}
			float i = Time.deltaTime * lerpSpeed;
			theSpeed = Vector3.Lerp(theSpeed, Vector3.zero, i);
		}
		
		transform.Rotate(Camera.main.transform.up * theSpeed.x * rotationSpeed, Space.World);
		transform.Rotate(Camera.main.transform.right * theSpeed.y * rotationSpeed, Space.World);
	}
}